Feature: AddSkillFeaturetoProfile
	In order to update my profile
	As a Seller
	I want to add the skill that I know into my Profile

@mytag
Scenario: Check if user could able to add a Skill into Profile
	Given I have Clicked on the skill Tab under Profile Page
	When  I add a new Skill
	Then  that skill should be displayed on my Profile Listings
