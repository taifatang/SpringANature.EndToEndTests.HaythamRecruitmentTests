Feature: SearchTest
	In order to check the Search is working
	As a user
	I want to be given Search results correctly

@searchBar
@happyPath
Scenario Outline: Inputting valid text in the Search bar
	Given I am a user
	And I navigate to the 'http://link.springer.com'
	When I search for the <inputWord>
	Then I receive search results with the <outputWord> in a title

Examples: 
	| inputWord | outputWord |
	| Maths     | Maths      |

@searchBar
@negativePath
Scenario Outline: Negative test - Inputting special characters in the Search bar
	Given I am a user
	And I navigate to the 'http://link.springer.com'
	When I search for the <invalidWords>
	Then I receive search results with the sorry message <outputWord>

Examples: 
	| invalidWords | outputWord |
	| !£$%^&       | Sorry      |

@advancedSearch
@happyPath
Scenario Outline: Inputting valid texts in the Advanced Search fields
	Given I am a user
	And I navigate to the 'https://link.springer.com/advanced-search'
	When I search each field individually: <all>, <exactPhrase>, <oneOfTheWords>, <without>, <title>, <authorEditor>
	Then I receive search results with the <outputWord> in a title

Examples: 
	| all   | exactPhrase | oneOfTheWords | without | title    | authorEditor | outputWord |
	| Maths |             |               |         |          |              | Maths      |
	|       | English     |               |         |          |              | English    |
	|       |             | Physics       |         |          |              | Physics    |
	|       |             |               | Science |          |              | N/A        |
	|       |             |               |         | Palgrave |              | Palgrave   |
	|       |             |               |         |          | Christian    | Christian  |

@advancedSearch
@negativePath
Scenario Outline: Negative test - Inputting special characters in the Advanced Search fields
	Given I am a user
	And I navigate to the 'https://link.springer.com/advanced-search'
	When I search each field individually with an invalid text: <all>, <exactPhrase>, <oneOfTheWords>, <without>, <title>, <authorEditor>
	Then I receive search results with the sorry message <outputWord>

Examples: 
	| all    | exactPhrase | oneOfTheWords | without | title  | authorEditor | outputWord |
	| !£$%^& |             |               |         |        |              | Sorry      |
	|        | !£$%^&      |               |         |        |              | Sorry      |
	|        |             | !£$%^&        |         |        |              | Sorry      |
	|        |             |               | !£$%^&  |        |              | Sorry      |
	|        |             |               |         | !£$%^& |              | Sorry      |
	|        |             |               |         |        | !£$%^&       | Sorry      |

@advancedSearch
@happyPath
Scenario Outline: Inputting valid date in the Published date field
	Given I am a user
	And I navigate to the 'https://link.springer.com/advanced-search'
	When I input a valid date in the <publishDate>
	Then I receive search results with books of the pulished date <outputWord>

Examples: 
	| publishDate | outputWord |
	| 2017        | 2017       |

@advancedSearch
@negativePath
Scenario Outline: Inputting invalid date in the Published date field
	Given I am a user
	And I navigate to the 'https://link.springer.com/advanced-search'
	When I input an invalid date in the <publishDate>
	Then I receive search results with the sorry message <outputWord>

Examples: 
	| publishDate | outputWord |
	| 2018        | sorry      |


	
