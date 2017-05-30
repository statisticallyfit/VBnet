Feature: AvgTestScores
	When the user inputs scores 
	Then find the average
	And return score-specific feedback to the user

@AvgTestScoresReturnAverage
Scenario: ReturnAverage
	Given the user has inputted a score
	Then show user the average 

@AvgTestScoresReturnLetterGrade
Scenario: ReturnLetterGrade
	Given the user has inputted a score
	Then return letter-grade feedback to user
	
@AvgTestScoresFeedbackErrors
Scenario: FeedbackErrors
	Given the user has given input
	And the input is not a score
	Then throw exception 
