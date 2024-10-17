Feature: ProfileFeature

This is a platform where users can add and show skills and languages ​​known by users.
People looking for skills and languages ​​can see what details other users have.
User can perform actions add, Update, delete etc.


Background:
	Given I logged into profile page successfully
	
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

Scenario Outline: User Cancel the Update Language
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

Scenario Outline: User input duplicate language
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
	| FirstLanguage | FirstLanguageLevel | SecondLanguage | SecondLanguageLevel | ActionAdd | ActionAddExist      |
	| English       | Fluent             | English        | Basic               | Add       | AddExistingLanguage |

Scenario Outline: User input duplicate language level
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
	Then I remove added language details

Examples:
	| FirstLanguage | FirstLanguageLevel | SecondLanguage | SecondLanguageLevel | ActionAdd | ActionAddExist           |
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

Scenario Outline: User add skills
	When I click on the Add New Skill button
	When I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<Skill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Skill>' and '<SkillLevel>' on Skills section
	When I open the '<User>' profile to view added skills
	Then the people seeking for skills can see what '<Skill>' and '<SkillLevel>' I hold
	Then I remove added skill details

Examples:
	| Skill              | SkillLevel   | ActionAdd | User                |
	| Manual Testing     | Beginner     | Add       | Kalpana Dissanayake |
	| Automation Testing | Intermediate | Add       | Kalpana Dissanayake |
	| API Testing        | Expert       | Add       | Kalpana Dissanayake |

Scenario Outline: User update skills
	When I click on the Add New Skill button
	When I add new '<NewSkill>' and '<NewSkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<NewSkill>' on the skill related toast message with the '<ActionAdd>'
	Given I update existing '<Skill>' and '<SkillLevel>' on Skills section
	Then I click on the skill update button
	Then I can see the updated '<Skill>' on the skill related toast message with the '<ActionUpdate>'
	Then I should be able to view the updated '<Skill>' and '<SkillLevel>' on Skills section
	When I open the '<User>' profile to view added skills
	Then the people seeking for skills can see what '<Skill>' and '<SkillLevel>' I hold
	Then I remove added skill details

Examples:
	| NewSkill           | NewSkillLevel | ActionAdd | Skill | SkillLevel   | ActionUpdate | User                |
	| Manual Testing     | Beginner      | Add       | C#    | Intermediate | Update       | Kalpana Dissanayake |
	| Automation Testing | Intermediate  | Add       | C++   | Expert       | Update       | Kalpana Dissanayake |
	| API Testing        | Expert        | Add       | Java  | Beginner     | Update       | Kalpana Dissanayake |

Scenario Outline: User Delete skills
	When I click on the Add New Skill button
	When I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<Skill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Skill>' and '<SkillLevel>' on Skills section
	When I delete the added skill
	Then I can see the deleted '<Skill>' on the skill related toast message with the '<ActionDelete>'

Examples:
	| Skill        | SkillLevel | ActionAdd | ActionDelete |
	| Load Testing | Beginner   | Add       | Delete       |

Scenario Outline: User cancel the Add Skill
	When I click on the Add New Skill button
	When I add new '<NewSkill>' and '<NewSkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<NewSkill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<NewSkill>' and '<NewSkillLevel>' on Skills section
	When I click on the Add New Skill button
	When I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the skill add cancel button
	Then I can see the existing last added '<Skill>' on the Skill section

Examples:
	| NewSkill       | NewSkillLevel | ActionAdd | Skill | SkillLevel   |
	| Manual Testing | Beginner      | Add       | C#    | Intermediate |

Scenario Outline: User Cancel the Update Skill
	When I click on the Add New Skill button
	When I add new '<NewSkill>' and '<NewSkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<NewSkill>' on the skill related toast message with the '<ActionAdd>'
	Given I update existing '<Skill>' and '<SkillLevel>' on Skills section
	And I click on the update skill cancellation button
	Then I can see the relevent '<Skill>' and '<SkillLevel>' not updated on Skills section
	Then I remove added skill details

Examples:
	| NewSkill       | NewSkillLevel | ActionAdd | Skill | SkillLevel   |
	| Manual Testing | Beginner      | Add       | C#    | Intermediate |

Scenario Outline: User can add skill with a huge payload
	When I click on the Add New Skill button
	When I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<Skill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<Skill>' and '<SkillLevel>' on Skills section
	When I open the '<User>' profile to view added skills
	Then the people seeking for skills can see what '<Skill>' and '<SkillLevel>' I hold
	Then I remove added skill details

Examples:
	| Skill     | SkillLevel | ActionAdd | User                |
	| HugeSkill | Beginner   | Add       | Kalpana Dissanayake |

Scenario Outline: User input duplicate skill
	When I click on the Add New Skill button
	When I add new '<FirstSkill>' and '<FirstSkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<FirstSkill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<FirstSkill>' and '<FirstSkillLevel>' on Skills section
	When I click on the Add New Skill button
	When I add new '<SecondSkill>' and '<SecondSkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<SecondSkill>' on the skill related toast message with the '<ActionAdd>'
	Then I remove added skill details

Examples:
	| FirstSkill         | FirstSkillLevel | SecondSkill        | SecondSkillLevel | ActionAdd | ActionAddExist   |
	| Automation Testing | Beginner        | Automation Testing | Expert           | Add       | AddExistingSkill |
	
Scenario Outline: User input duplicate skill level
	When I click on the Add New Skill button
	When I add new '<FirstSkill>' and '<FirstSkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<FirstSkill>' on the skill related toast message with the '<ActionAdd>'
	Then I should be able to view the added '<FirstSkill>' and '<FirstSkillLevel>' on Skills section
	When I click on the Add New Skill button
	When I add new '<SecondSkill>' and '<SecondSkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<SecondSkill>' on the skill related toast message with the '<ActionAdd>'
	Then I remove added skill details
	Then I remove added skill details

Examples:
	| FirstSkill       | FirstSkillLevel | SecondSkill        | SecondSkillLevel | ActionAdd | ActionAddExist        |
	| Security Testing | Expert          | Regression Testing | Expert           | Add       | AddExistingSkillLevel |


Scenario Outline: User input invalid inputs as skill and skill level
	When I click on the Add New Skill button
	When I add new '<Skill>' and '<SkillLevel>' to Skills section
	Then I click on the Add Skill button
	Then I can see the added '<Skill>' on the skill related toast message with the '<ActionAdd>'

Examples:
	| Skill          | SkillLevel   | ActionAdd |
	| Sanity Testing |              | AddNull   |
	|                | Intermediate | AddNull   |








#Scenario Outline: User create profile
	#And I provide '<Title>', '<Description>', '<Tags>', '<ServiceType>', '<LocationType>', '<EndDate>', '<SkillTrade>', '<SkillExchange>' and '<ActiveStatus>' on Service Listning page

#Examples:
	#| Title           | Description           | Tags     | ServiceTypes | LocationType | EndDate    | SkillTrade     | SkillExchange    | ActiveStatus |
	#| Test Automation | This is a Description | Software | Hourly Basis | On site      | 2025-02-23 | Skill Exchange | QualityAssurance | Active       |
	