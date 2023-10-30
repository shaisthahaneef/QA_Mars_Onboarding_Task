Feature: SkillsFeature

AAs a user 
I would like to show what skills I know.
So that the people seeking for skills can look at what details I hold.

@tag1
Scenario: Add skkills to my profile
	Given  I logged into website successfully
	When I navigate to skills tab to add new skills
	Then the new skills should be added successfully
