Feature: DeleteSkillFeaturetoProfile
	In order to Delete my particular Skill from my Profile
	As a Seller
	I want to Delete Particular skill from my Profile

@mytag
Scenario: Check if user could able to Delete skill from Profile
	Given I have Clicked on the Skill Tab under Profile page
	When  I can Delete Skill under Profile page
	Then that deleted skill should be removed from my profile Listing 
