Feature: Feature4455

Test User Story
i would like to create profile details so i can manage
profile details successfully.


Scenario: Add Language details in profile with valid data
	Given Logged into Mars Logo home
	When Navigate to Mars logo profile
	And User filled the language details and saved
	Then The language details should be added successfully

Scenario: Add Skills details in profile with valid data
	Given Logged into Mars Logo home
	When Navigate to Mars logo profile
	And User filled the skills details and saved
	Then The skills details should be added successfully

Scenario: Add Description details in profile with valid data
	Given Logged into Mars Logo home
	When Navigate to Mars logo profile
	And User filled the Description details and saved
	Then The Description details should be added successfully

