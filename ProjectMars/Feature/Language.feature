Feature: LanguageFeature

This is a platform where users can add and show languages ​​known by users.
People looking for languages ​​can see what details other users have.
User can perform actions add, Update, delete etc.

Background:
	Given I logged into profile page successfully
	Then I remove existing language details
	
@regression
Scenario Outline: User add languages
	When I click on the Add New button
	When I add new '<Language>' and '<LanguageLevel>' to Languages section
	Then I click on the Add button
	Then I can see the added '<Language>' on the toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Language>' and '<LanguageLevel>' on Languages section
	When I open the '<User>' profile to view added languages
	Then the people seeking for languages can see what '<Language>' and '<LanguageLevel>' I hold
	Then I remove added language details

Examples:
	| Language | LanguageLevel    | ActionAdd | User                |
	| English  | Fluent           | Add       | Kalpana Dissanayake |
	| German   | Conversational   | Add       | Kalpana Dissanayake |
	| Mandarin | Native/Bilingual | Add       | Kalpana Dissanayake |
	| Spanish  | Basic            | Add       | Kalpana Dissanayake |
	

Scenario Outline: User update languages
	When I click on the Add New button
	When I add new '<NewLanguage>' and '<NewLanguageLevel>' to Languages section
	Then I click on the Add button
	Then I can see the added '<NewLanguage>' on the toast message with the '<ActionAdd>'
	Given I update existing '<Language>' and '<LanguageLevel>' on Languages section
	Then I click on the Update button
	Then I can see the updated '<Language>' on the toast message with the '<ActionUpdate>'
	Then I should be able to view the updated '<Language>' and '<LanguageLevel>' on Languages section
	When I open the '<User>' profile to view added languages
	Then the people seeking for languages can see what '<Language>' and '<LanguageLevel>' I hold
	Then I remove added language details

Examples:
	| NewLanguage | NewLanguageLevel | ActionAdd | Language | LanguageLevel  | ActionUpdate | User                |
	| English     | Native/Bilingual | Add       | Spanish  | Fluent         | Update       | Kalpana Dissanayake |
	| German      | Basic            | Add       | French   | Conversational | Update       | Kalpana Dissanayake |

Scenario Outline: User Delete language
	When I click on the Add New button
	When I add new '<Language>' and '<LanguageLevel>' to Languages section
	Then I click on the Add button
	Then I can see the added '<Language>' on the toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Language>' and '<LanguageLevel>' on Languages section
	When I delete the added language
	Then I can see the deleted '<Language>' on the toast message with the '<ActionDelete>'

Examples:
	| Language | LanguageLevel | ActionAdd | ActionDelete |
	| Tamil    | Fluent        | Add       | Delete       |

Scenario Outline: User Cancel the Add language
	When I click on the Add New button
	When I add new '<NewLanguage>' and '<NewLanguageLevel>' to Languages section
	Then I click on the Add button
	Then I can see the added '<NewLanguage>' on the toast message with the '<ActionAdd>'
	Then I should be able to view the added '<NewLanguage>' and '<NewLanguageLevel>' on Languages section
	When I click on the Add New button
	When I add new '<Language>' and '<LanguageLevel>' to Languages section
	Then I click on the cancel button
	Then I can see the existing last added '<Language>' on Languages section
	Then I remove added language details

Examples:
	| NewLanguage | NewLanguageLevel | ActionAdd | Language | LanguageLevel |
	| English     | Fluent           | Add       | Chinese  | Basic         |

Scenario Outline: User Cancel the Update language
	When I click on the Add New button
	When I add new '<NewLanguage>' and '<NewLanguageLevel>' to Languages section
	Then I click on the Add button
	Then I can see the added '<NewLanguage>' on the toast message with the '<ActionAdd>'
	Given I update existing '<Language>' and '<LanguageLevel>' on Languages section
	And I click on the update cancellation buttion
	Then I can see the relevent '<Language>' and '<LanguageLevel>' not updated on Languages section
	Then I remove added language details

Examples:
	| NewLanguage | NewLanguageLevel | ActionAdd | Language | LanguageLevel |
	| English     | Native/Bilingual | Add       | Chinese  | Fluent        |

Scenario Outline: User can add language with a huge payload
	When I click on the Add New button
	When I add new '<Language>' and '<LanguageLevel>' to Languages section
	Then I click on the Add button
	Then I can see the added '<Language>' on the toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Language>' and '<LanguageLevel>' on Languages section
	When I open the '<User>' profile to view added languages
	Then the people seeking for languages can see what '<Language>' and '<LanguageLevel>' I hold
	Then I remove added language details

Examples:
	| Language     | LanguageLevel | ActionAdd | User                |
	| HugeLanguage | Basic         | Add       | Kalpana Dissanayake |

Scenario Outline: User input duplicate language and language level
	When I click on the Add New button
	When I add new '<FirstLanguage>' and '<FirstLanguageLevel>' to Languages section
	Then I click on the Add button
	Then I can see the added '<FirstLanguage>' on the toast message with the '<ActionAdd>'
	Then I should be able to view the added '<FirstLanguage>' and '<FirstLanguageLevel>' on Languages section
	When I click on the Add New button
	When I add new '<SecondLanguage>' and '<SecondLanguageLevel>' to Languages section
	Then I click on the Add button
	Then I can see the added '<SecondLanguage>' on the toast message with the '<ActionAddExist>'
	Then I remove added language details

Examples:
	| FirstLanguage | FirstLanguageLevel | SecondLanguage | SecondLanguageLevel | ActionAdd | ActionAddExist           |
	| English       | Fluent             | English        | Basic               | Add       | AddExistingLanguage      |
	| Spanish       | Fluent             | Korean         | Fluent              | Add       | AddExistingLanguageLevel |


Scenario Outline: User input invalid inputs as language and language level
	When I click on the Add New button
	When I add new '<Language>' and '<LanguageLevel>' to Languages section
	Then I click on the Add button
	Then I can see the added '<Language>' on the toast message with the '<ActionAdd>'

Examples:
	| Language | LanguageLevel  | ActionAdd |
	| Turkish  |                | AddNull   |
	|          | Conversational | AddNull   |



