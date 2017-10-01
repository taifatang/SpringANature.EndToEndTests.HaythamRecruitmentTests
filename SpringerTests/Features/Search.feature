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
	| !"£!"£!"£"!  |

