Feature: AccountMgmt
	Allow users to deposit, withdraw, or request balance from a list of given choices
	Return a running balance upon user request
	Do not allow overdrafts

@mytag
Scenario: Deposit
	Given choices are shown
	And the balance is 0 
	When user has entered 200 to deposit
	Then add them so balance is 200
	
Scenario: Withdraw
	Given choices are shown
	And the balance is 200
	When user has entered 100 to withdraw
	Then subtract amount from balance so balance is 100

Scenario: Show balance upon user request
	Given choices are shown
	And user requests the balance 
	Then show balance is 100

Scenario: Forbid overdrafts
	Given choices are shown and balance is 100
	And user requests to withdraw 500
	Then do not withdraw 500
	And tell user the amount is not withdrawn


	