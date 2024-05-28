import os
import pandas as pd

new_directory = r"C:\Users\aliyu\Desktop\SHRA"
# File name of the organisation that you want filter data from main data of Bauchi Schedule
source_file_path = os.path.join(new_directory, "NHF SHIRA LGA schedule.xlsx")
# Bauchi Shedule data
destination_file_path = os.path.join(new_directory, "BAUCHI.xlsx")

# Ensure the directory exists before changing to it
if not os.path.isdir(new_directory):
    raise FileNotFoundError(f"The directory {new_directory} does not exist.")
os.chdir(new_directory)

# Ensure the source and destination files exist
if not os.path.isfile(source_file_path):
    raise FileNotFoundError(f"The source file {source_file_path} does not exist.")
if not os.path.isfile(destination_file_path):
    raise FileNotFoundError(f"The destination file {destination_file_path} does not exist.")

# Read Excel files
source_df = pd.read_excel(source_file_path, skiprows=1, sheet_name='2023 - DATE')
destination_df = pd.read_excel(destination_file_path)

# Columns to work with
column_to_copy = 'Employee NHF Number'
column_to_compare = 'Staff ID'

# Check if the specified columns exist in both DataFrames
if 'PSN' not in source_df.columns:
    raise KeyError(f"'PSN' not found in source DataFrame")
if column_to_compare not in destination_df.columns:
    raise KeyError(f"'{column_to_compare}' not found in destination DataFrame")
if column_to_copy not in destination_df.columns:
    raise KeyError(f"'{column_to_copy}' not found in destination DataFrame")

# Create a mask for rows where the values in column_to_compare match
mask = destination_df[column_to_compare].isin(source_df['PSN'])

# Update source_df with values from destination_df based on the mask
source_df['Employee NHF Number'] = source_df['PSN'].map(destination_df.set_index(column_to_compare)[column_to_copy])

# Save the updated DataFrame to the source Excel file
source_df.to_excel(source_file_path, index=False)
