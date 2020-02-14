#!/usr/bin/env python3

from tkinter import *

import tkinter.messagebox as tm

import datetime



"""CONSTANTS"""

ADMIN_NAME = 'ADMIN'

ADMIN_PASSWORD = 'password'



"""ADMIN LOGS IN AND CAN VIEW ALL SQL ENTRIES - SQL DATABASE DETAILS ARE JUST LOADED RIGHT IN DYNAMICALLY INTO A (BOX?)"""

"""USERS DETAILS ARE CHECKED AGAINST A DATABASE, (SEE IF THEY ARE IN THE SAME ROW? OR CREATE A DICTIONARY AND LOOP THROUGHT IT

TO SEE IF KEY == VALUE?)"""



"""SQL VARIABLES"""

# 0, 1 == False, 2 == True

QuestionsDict = {"1. What number should come next in this series: 12, 11, 13, 12, 14, 13… ": [["16", 0], ["15", 2], ["13", 1]],

                 "2. What number should come next: 80, 10, 70, 15, 60": [["25", 0], ["50", 1], ["20", 2]],

                 "3. Melt : Liquid :: Freeze : ?" :[["Ice", 0], ["Solid", 2], ["Condense", 1]],

                 "4. Parts : Strap :: Wolf : ?" : [["Wood", 0], ["Fox", 1], ["Flow", 2]],

                 "5. Paw : Cat :: Hoof : ?" : [["Horse", 2], ["Lamb", 0], ["Tiger", 1]]}



def destoryWidgets(lst):

    for l in lst:

        l.destroy()



# Admin access can view test score results

class AdminForm(Frame):

    def __init__(self, master):

        self.master.geometry("440x200")



class LoginForm(Frame):

    def __init__(self, master):

        super().__init__(master)

        self.master.geometry('200x100')



        self.label_username = Label(self, text="Name")

        self.label_password = Label(self, text="ID")



        self.entry_username = Entry(self)

        self.entry_password = Entry(self, show="*")

        #Grid or place? Test on different Form classes

        self.label_username.grid(row=0, sticky=E)

        self.label_password.grid(row=1, sticky=E)

        self.entry_username.grid(row=0, column=1)

        self.entry_password.grid(row=1, column=1)



        self.logbtn = Button(self, text="Login", command=self._login_btn_clicked)

        self.logbtn.grid(columnspan=2)

        self.pack()



    def _login_btn_clicked(self):

        #Get text from login fields

        username = self.entry_username.get()

        password = self.entry_password.get()



        # generic name for testing, will be tested against SQL db in next phase

        if username == "john" and password == "012345678":

            tm.showinfo("Login info", "Welcome " + username)

            self.destroy()

            qs = QSecurityForm(root,username, password) #Pass user login details between class contexts to associate score with user details

        elif username == ADMIN_NAME and password == ADMIN_PASSWORD:

            tm.showinfo("Login Info", "Welcom Admin")

            self.destroy()

            af = AdminForm(root)

        else:

            tm.showerror("Login error", "Incorrect username")





class QSecurityForm(Frame):

    def __init__(self, master, USER_ID, USER_NAME):

        super().__init__(master)

        self.u_i = USER_ID

        self.u_n = USER_NAME

        self.turns = 3

        self.master.geometry('240x100')

        self.label_SQprompt = Label(master, text="Name of your first car? ")

        self.label_SQprompt.place(x=20, y=10)

        self.label_turns = Label(master, text="Attempts remaing: " + str(self.turns))

        self.label_turns.place(x=20, y=65)



        self.entry_SA = Entry(master)

        self.entry_SA.place(x=20, y=40)



        self.btn_confirmSQ = Button(master, text="Confirm", command=self.sq_button_clicked)

        self.btn_confirmSQ.place(x=165, y=40)



        self.pack()



        # self.logbtn = Button(self, text="Confirm", command=self._login_btn_clicked)

        # self.logbtn.grid(columnspan=2)



    def sq_button_clicked(self):



        if self.turns < 1:

            tm.showerror("","No more attempts remaining!")

            destoryWidgets([self.label_turns, self.label_SQprompt, self.entry_SA, self.btn_confirmSQ])

            self.destroy()

            lf = LoginForm(root)

            return

        answer = self.entry_SA.get()

        if answer != "answer": # test term

            self.turns -= 1

            self.label_turns.config(text="Incorrect term. Attempts remaing: " + str(self.turns))

        else:

            destoryWidgets([self.label_turns, self.label_SQprompt, self.entry_SA, self.btn_confirmSQ])

            self.destroy()

            qf = questionform(root,self.u_i, self.u_n)



class questionform(Frame):

    def __init__(self, master, i, n):

        super().__init__(master)

        self.USERID = i

        self.USERNAME = n

        self.master.geometry('440x130')

        self.solution = IntVar()

        self.solution.set(None)

        self.score = 0

        self.Question_counter = 1

        self.lbl_question = Label(master)

        self.lbl_question.place(x=20, y=20)

        self.rbtn1 = Radiobutton(master)

        self.rbtn1.place(x = 30, y = 50)

        self.rbtn2 = Radiobutton(master)

        self.rbtn2.place(x = 150, y = 50)

        self.rbtn3 = Radiobutton(master)

        self.rbtn3.place(x = 270, y = 50)

        self.confirm_btn = Button(root, text = "Confirm", command = self.Confirm_Answer )

        self.confirm_btn.place(x=200, y=100)

        self.exit_btn = Button(root, text='Exit', command=self.exitQuestions)

        self.exit_btn.place(x=150, y=100)

        self.pack()

        self.change_question()



    def change_question(self):

        for question, answer in QuestionsDict.items():

            if question[0] == str(self.Question_counter):  # avoiding duplicate questions by matching the sliced first index of the string key

                self.lbl_question.config(text=question)

                for i in range(3):

                    if answer[i][1] == True:

                        if i == 0:

                            self.rbtn1.config(text = answer[0][0], value = answer[0][1], variable = self.solution)

                            self.rbtn2.config(text = answer[1][0], value = answer[1][1], variable = self.solution)

                            self.rbtn3.config(text=answer[2][0], value = answer[2][1], variable = self.solution)

                        elif i == 1:

                            self.rbtn2.config(text=answer[1][0], value = answer[1][1], variable = self.solution)

                            self.rbtn1.config(text=answer[0][0], value = answer[0][1], variable = self.solution)

                            self.rbtn3.config(text=answer[2][0], value = answer[2][1], variable = self.solution)

                        elif i == 2:

                            self.rbtn3.config(text=answer[2][0], value = answer[2][1], variable = self.solution)

                            self.rbtn1.config(text=answer[0][0], value = answer[0][1], variable = self.solution)

                            self.rbtn2.config(text=answer[1][0], value = answer[1][1], variable = self.solution)

        self.Question_counter += 1



    def Confirm_Answer(self):

        if self.solution.get() == None:

            tm.showerror("Select an option")

            return

        result = self.solution.get()

        if result > 1:

            self.score += 1

        if self.Question_counter > len(QuestionsDict):

            tm.showinfo("Results", "Thank-you. Your score: " + str(self.score) + "/" + str(len(QuestionsDict)))

            SCORE = self.score

            writeFile(self.USERID, self.USERNAME, self.score)

            destoryWidgets([self.lbl_question,self.rbtn1,self.rbtn2,self.rbtn3, self.confirm_btn, self.exit_btn])

            self.destroy()

            lf = LoginForm(root)

        self.change_question()





    def exitQuestions(self):

        result = tm.askyesno("", "Test unfinished, are you want to exit?")

        if result == True:

            root.destroy()

        else:

            return



"""Security measure that backs up a copy of the test results by creating a text file"""

def writeFile(APP_ID, APP_NAME, SCORE):



    with open(str(APP_ID) + "_test.txt", 'a', encoding='utf-8') as f: # 'a' appends consecutive tests with a timestamp, text file created if no such file exits

        f.write(datetime.datetime.now().strftime("%A, %d %b %Y") + "\n")

        f.write("ID: " + APP_ID+"\n")

        f.write("NAME: " + APP_NAME+"\n")

        f.write("SCORE: "+ str(SCORE)+ "\n\n")

        f.close()

root = Tk()

lf = LoginForm(root)

#qf = questionform(root)

root.mainloop()