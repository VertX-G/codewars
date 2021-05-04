'''
Bob is preparing to pass IQ test.
The most frequent task in this test is to find out which one
of the given numbers differs from the others.
Bob observed that one number usually differs from the others in evenness.
Help Bob — to check his answers, he needs a program that among
the given numbers finds one that is different in evenness, and return a position of this number.

! Keep in mind that your task is to help Bob solve a real IQ test,
which means indexes of the elements start from 1 (not 0)

Examples:
IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even

IQ.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd

'''

# -------------------- My first solution --------------------
# O(2n)
# Ω(1n+3)
def iq_test(n):
    # split the string into a list
    numList = n.split()
    odd = even = 0
    
    # test each number and return as soon as the different number is found
    for x in range(1, (len(numList))+1):
        if int(numList[x-1])%2 == 0:
            if even != 0 and odd != 0:
                return odd
            elif even == 0:
                even = x
        else:
            if odd != 0 and even != 0:
                return even
            elif odd == 0:
                odd = x  
    return x
  
  
# -------------------- Voted best solution --------------------
'''
# O(3n)
# Ω(3n)
# this solution will iterate through the list three times (split, int/mod, and count)
def iq_test(n):
    n = [int(i)%2 for i in n.split()]
    if n.count(0)>1:
        return n.index(1)+1
    else:
        return n.index(0)+1
'''



