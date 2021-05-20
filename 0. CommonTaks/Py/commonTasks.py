"""
1. Not able to debug python as the conds environment is corrupted.
"""

import json
import os
print(os.path.dirname(__file__))

try:
    with open("input.txt") as file_in:
        lines = []
        lineNo = 1;
        for line in file_in:
            print("Line ", lineNo, ": ", line)
            if(line.isnumeric()):
                lines.append(line)
            lineNo = lineNo + 1

    with open('output.txt', 'w') as file_out:
        # for item in lines:
        #     file_out.write('%s\n' % item)
        file_out.write(json.dumps(lines))
except Exception as e:
    print(e)