from userService import userService


print("System Login Kelompok 41!\n")
email = input("Email: ")
password = input("Password: ")
get_class = userService(email,password)
get_class.login()
