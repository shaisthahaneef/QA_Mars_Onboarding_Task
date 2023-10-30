Feature: LanguageFeature

As a user 
I would like to show what languages I know.
So that the people seeking for languages can look at what details I hold.


@tag1
Scenario: Add new language to my profile
	Given I logged into website successfully
	When I navigate language tab to add new language
	Then the new language should be added successfully
