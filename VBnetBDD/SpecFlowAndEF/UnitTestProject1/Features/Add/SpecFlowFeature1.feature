Feature: Add Customer
Allow users to create and store new customers
As long as the new customers have a first and last name

@AddCustomerHappyPathSteps
Scenario: Happy Path
Given a user has entered information about a customer
And she has provided a first name and a last name as required
When she completes entering more information
Then that customer should be stored in the system


@AddCustomerMissingFirstorLastNameSteps
Scenario: Missing First or Last Name
Given a user has entered information about a customer
And she has not provided both the firstname and lastname
When she completes entering more information
Then that user will get a message
And the customer will not be stored into the system
