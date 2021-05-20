def fizzBuzz(num):
    for item in range(num):
        if (item % 15 == 0):
            print("FizzBuzz")
        elif(item % 3 == 0):
            print("Fizz")
        elif(item % 5 == 0):
            print("Buzz")
        else:
            print(item)


fizzBuzz(20)