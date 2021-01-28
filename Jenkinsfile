pipeline {
	agent none 
    		stages {
			stage ('Run test in parallel') {
        			parallel {
        				stage('Project test 1') {
            				agent any
            					steps {
                					echo "Hello World 1"
            					}
        				}
            				stage('Projest test 2'){
                 			agent {
						node { lable 'Test' }
					}
                				steps {
            	        				echo "Hello World 2"
                				}
            				}
        			}
			}
    		}
}
