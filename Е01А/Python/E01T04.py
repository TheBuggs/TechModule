#######################################################
# Problem 4.	Resurrection
#######################################################

from decimal import *

i = input()
result = list()
string = list()

for x in range(0, int(i), 1):
    length = input()
    width = input()
    wing = input()
    total = Decimal(length) * Decimal(length) * Decimal(((2 * int(wing)) + float(width)))
    if '.' in str(total):
        temp = str(total).split('.')
        if len(temp[1]) > 0:
            string.append(temp[0])
            result.append(temp[1])

m = int(0)

if len(result) > 0:
    for r in result:
        if len(result) > m:
            m = len(result)

    for x in range(0, len(string), 1):
        print(str(string[x]) + "." + str(result[x]))
else:
    for x in range(0, len(string[x]), 1):
        print(string[x])

