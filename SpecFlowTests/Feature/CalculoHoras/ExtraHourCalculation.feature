Feature: Extra Hour Calculation
For how many extra hours I will get
While employee
I would like to calculate the extra hour addition

Scenario: Add 5 normal extra hours
	Given I'm using the CalculaHoraExtraNormal method
	And I have entered 5 in the field quantidade
	When I execute the application
	Then the result should be '102.27' on the screen