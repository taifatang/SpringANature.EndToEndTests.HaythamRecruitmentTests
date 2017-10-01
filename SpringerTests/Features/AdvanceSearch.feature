@advancedSearch
Feature: AdvanceSearch
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@happyPath
Scenario: Inputting valid texts in the Advanced Search fields
	Given I am on Advance Search Page
	When I Enter Maths in all search field
	And I submit advance advance search
	Then I receive search results with the 'Maths' in a title

	#And I Enter <text> in exact search field
	#And I Enter <text> in oneOfTheWords search field
	#And I Enter <text> in withOut search field
	#And I Enter <text> in title search field
	#And I Enter <text> in author search field

#
#Examples: 
#	| all   | exactPhrase | oneOfTheWords | without | title    | authorEditor | outputWord |
#	| Maths |             |               |         |          |              | Maths      |
#	|       | English     |               |         |          |              | English    |
#	|       |             | Physics       |         |          |              | Physics    |
#	|       |             |               | Science |          |              | N/A        |
#	|       |             |               |         | Palgrave |              | Palgrave   |
#	|       |             |               |         |          | Christian    | Christian  |

@negativePath
Scenario: Negative test - Inputting valid texts in the Advanced Search fields
	Given I am on Advance Search Page
	When I Enter $%£%$£% in all search field
	And I submit advance advance search
	Then I receive not found message

#And I Enter <text> in exact search field
#And I Enter <text> in oneOfTheWords search field
#And I Enter <text> in withOut search field
#And I Enter <text> in title search field
#And I Enter <text> in author search field

#
#Examples: 
#	| all   | exactPhrase | oneOfTheWords | without | title    | authorEditor | outputWord |
#	| Maths |             |               |         |          |              | Maths      |
#	|       | English     |               |         |          |              | English    |
#	|       |             | Physics       |         |          |              | Physics    |
#	|       |             |               | Science |          |              | N/A        |
#	|       |             |               |         | Palgrave |              | Palgrave   |
#	|       |             |               |         |          | Christian    | Christian  |

@happyPath
Scenario Outline: Inputting valid date in the Published date field
	Given I am on Advance Search Page
	When I input a date in the <publishDateBefore> and <publishDateAfter>
	And I submit advance advance search
	Then I receive search results inbetween <publishDateBefore> and <publishDateAfter>

Examples: 
	| publishDateBefore | publishDateAfter |
	| 2017              | 2017             |

@negativePath
Scenario Outline: Inputting invalid date in the Published date field
	Given I am on Advance Search Page
	When I input a date in the <publishDateBefore> and <publishDateAfter>
	And I submit advance advance search
	Then I receive not found message

Examples: 
	| publishDateBefore | publishDateAfter |
	| 3000              | 3001             |
