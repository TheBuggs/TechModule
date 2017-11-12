#########################################
# Problem 3. Restaurant Discount
########################################

hallPrice = dict()
hallPrice["Small Hall"] = 2500
hallPrice["Terrace"] = 5000
hallPrice["Great Hall"] = 7500

capacity = dict()
capacity[50] = "Small Hall"
capacity[100] = "Terrace"
capacity[120] = "Great Hall"

discount = dict()
discount["Normal"] = 5
discount["Gold"] = 10
discount["Platinum"] = 15

packPrice = dict()
packPrice["Normal"] = 500
packPrice["Gold"] = 750
packPrice["Platinum"] = 1000

size = input()
pack = input()

keys = list(capacity.keys())

check = False;
for key in keys:
    if key > int(size):
        if discount[pack] != 0 and size != 0:
            total = (int(hallPrice[capacity[key]] + packPrice[pack]) -
                     (int(hallPrice[capacity[key]] + packPrice[pack]) / int(discount[pack]))) / float(size)
        check = True
        print("We can offer you the " + capacity[key] + " The price per person is {0:.2f}$".format(total))
        break

if not check:
    print("We do not have an appropriate hall.")
