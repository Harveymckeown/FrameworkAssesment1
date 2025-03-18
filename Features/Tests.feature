Feature: Tests

       
A short summary of the feature
@HappyPathTest
Scenario: HappyPath
	Given Im on the Webpage 
	When I log in with standard_user and secret_sauce
	And I add an item to my cart
	And I add my name,lastname and postcode
	And I purchice item
	Then I have Bought the Item

	@FailPath
Scenario: FailPath
	Given Im on the Webpage 
	When I log in with problem_user and secret_sauce
	And I add an item to my cart
	And I add my name,lastname and postcode
	And I purchice item
	Then I have Bought the Item

	@ExpectedFailPath
Scenario: ExpectedFailPath
	Given Im on the Webpage 
	When I log in with locked_out_user and secret_sauce
	Then An error message will be displyed

	@PriceChecker
Scenario: PriceChecker
	Given Im on the Webpage
	When I log in with standard_user and secret_sauce
	Then Compare prices 
	

