Feature: SortByPostCode
	Sort postcode records in descending order

@smoke
Scenario: Perform sort of postcode  in descending order
	Given I launch the application
	And I click on the Bank Manager Login link
	And I click on the Customers menu item
	When I click on the Post Code header
	Then I should see postcode records sorted in descending order
