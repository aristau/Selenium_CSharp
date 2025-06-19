Feature: Login


Scenario: User Logins with Valid Credentials
	Given User navigates to the login page
	When User enters "tomsmith" and "SuperSecretPassword!"
	Then User is directed to the dashboard page

# Scenario Outline: User Attempts Login with Invalid Username
#     Given User navigates to the login page
#     When User enters invalid <username> and valid <password>
#     |username | password            |
#     |tommy    | SuperSecretPassword!|
#     |         |                     |
#     Then An invalid username error message appears

# Scenario Outline: User Attempts Login with Invalid Password
#     Given User navigates to the login page
#     When User enters valid <username> and invalid <password>
#     |username    | password  |
#     |tomsmith    | wrongPass!|
#     |tomsmith    |           |
#     Then An invalid password error message appears