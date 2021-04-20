# Given an array containing hashes of names
# Return a string formatted as a list of names separated by commas except for the last two names, which should be separated by an ampersand.

def namelist(names):       
    number_of_names = len(names)
    list_of_names = ''
    i = 0
    if number_of_names != 0:
        for name_dict in names:
            name = name_dict['name']
            i += 1
            list_of_names += name
            if i < (number_of_names -1):
                list_of_names += ', '
            elif i == (number_of_names -1):
                list_of_names += ' & '
    return(list_of_names)
