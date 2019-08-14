Feature: Conversion Roman Number to Integer Numbers
Based on Roman number value
I would like to know the arabic numbers

Scenario: Basic number
	Given I'm using the ConvertToArabic method
	And I have entered 'X' into the program
	When I process the program
	Then the result should be 10 on the screen

Scenario: Basic number 2
	Given I'm using the ConvertToArabic method
	And I have entered 'V' into the program
	When I process the program
	Then the result should be 5 on the screen

Scenario: Two arabic digits number
	Given I'm using the ConvertToArabic method
	And I have entered 'XV' into the program
	When I process the program
	Then the result should be 15 on the screen

Scenario: Two arabic digits number with three roman digits
	Given I'm using the ConvertToArabic method
	And I have entered 'XVI' into the program
	When I process the program
	Then the result should be 16 on the screen

Scenario: Two arabic digits number with less roman value in the left
	Given I'm using the ConvertToArabic method
	And I have entered 'XIV' into the program
	When I process the program
	Then the result should be 14 on the screen

