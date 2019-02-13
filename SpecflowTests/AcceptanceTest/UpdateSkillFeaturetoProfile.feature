Feature: UpdateSkillFeaturetoProfile
	In order to update my profile
	As a Seller
	I want to Update the skill that I know into my Profile

@mytag
Scenario: Check if user could able to update a Skill into Profile
	Given I have Clicked on the Skill Tab under Profile Page
	When I can Update Skill under Profle Page
	Then that Updated skill should be displayed on my Profile Listings

	
