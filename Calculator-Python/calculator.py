
def get_first_num():
    return input("Enter first number: ")

def get_operator():
    return input("Enter operator (+,-,*,/): ")

def get_sec_num():
    return input("Enter second number: ")

def is_valid_input(first, op, sec):
    if first =="":
        print("First number must be entered")
        return False
    if op =="":
        print("Operator must be entered")
        return False
    if sec =="":
        print("Second number must be entered")
        return False
    if op not in ["+","-","*","/"] :
        print("invalid operator")
        return False
    if not first.isnumeric():
        print("First number must be numerical")
        return False
    if not sec.isnumeric():
        print("Second number must be numerical")
        return False
    if op == "/" and sec == "0":
        print("Second number cannot be divisible by 0")
        return False 
    return True

    

def calc_result(first,op,sec):

    result = 0
    if op =="+":
        result = int(first) + int(sec)
    elif op=="-":
        result = int(first) - int(sec)
    elif op=="*":
        result = int(first) * int(sec)
    elif op=="/":
        result = round(int(first) / int(sec),1)
    return result

def display_result():
    first = get_first_num()
    op = get_operator()
    sec = get_sec_num()

    while is_valid_input(first,op,sec) == False:
        first = get_first_num()
        op = get_operator()
        sec = get_sec_num()
    
    result = calc_result(first,op,sec)
    print("{} {} {} = {}".format(first,op,sec, result))

if __name__=="__main__":
    display_result()