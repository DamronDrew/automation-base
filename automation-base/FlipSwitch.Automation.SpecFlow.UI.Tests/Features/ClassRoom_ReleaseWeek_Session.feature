Feature: ClassRoom_ReleaseWeek_Session
	As a student
	I want to be able to launch the ClassRoom
	from the LMS

@classRoom
Scenario: Launch Classroom
	Given I have logged in as "a student with classroom access"
	And I have clicked on the "classroom" navigation item
	When I launch the session
	Then the Classroom should be displayed
