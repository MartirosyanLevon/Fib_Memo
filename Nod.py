a,b = map(int,input("Enter 2 numbre's: ").split())

while b > 0:
   a,b = b,a % b
print(a)    