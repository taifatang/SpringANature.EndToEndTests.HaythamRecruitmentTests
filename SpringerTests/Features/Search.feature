Feature: Search

@searchBar
@happyPath
Scenario Outline: Inputting valid text in the Search bar
	Given I am on Search Page
	When I search for the <inputWord>
	Then I receive search results with the <outputWord> in a title

Examples:
	| inputWord | outputWord |
	| Maths		| Maths		 |
	| Science	| Science	 |
	| Soup		| Soup		 |

@searchBar
@negativePath
Scenario Outline: Negative test - Inputting special characters in the Search bar
	Given I am on Search Page
	When I search for the <invalidWords>
	Then I receive not found message

Examples:
	| invalidWords |
	| Maths	   	   |

@advancedSearch
@happyPath
Scenario Outline: Inputting valid texts in the Advanced Search fields
	Given I am on Advance Search Page
	When I search each field individually: <all>, <exactPhrase>, <oneOfTheWords>, <without>, <title>, <authorEditor>
	Then I receive search results with the <outputWord> in a title