Feature: Tests

A short summary of the feature
#TODO: given 1, when 1, then 1, and anywhere
@HappyPathTest
Scenario: HappyPath
	Given Im on the Webpage using chrome
	When I log in with standard_user and secret_sauce
	And I add an item to my cart
	Then I add my name,lastname and postcode
	Then i purchice item
	Then i have Bought the Item

	@FailPath
Scenario: FailPath
	Given Im on the Webpage using chrome
	When I log in with problem_user and secret_sauce
	And I add an item to my cart
	Then I add my name,lastname and postcode
	Then i purchice item
	Then i have Bought the Item

	@ExpectedFailPath
Scenario: ExpectedFailPath
	Given Im on the Webpage using chrome
	When I log in with locked_out_user and secret_sauce
	Then An error message will be displyed

	@PriceChecker
Scenario: PriceChecker
	Given Im on the Webpage using chrome
	When I log in with standard_user and secret_sauce
	Then Compare prices 
	

