#!/usr/bin/env python3
import datetime
import sqlite3
import tkinter.messagebox as tm
import tkinter.ttk as ttk
from tkinter import *
import os
cwd = os.getcwd()

"""ADMIN LOGIN DETAILS"""
ADMIN_NAME = 'ADMIN'
ADMIN_PASSWORD = 'password'

"""USERS DETAILS ARE CHECKED AGAINST A DATABASE, (SEE IF THEY ARE IN THE SAME ROW & LOOP THROUGHT IT
TO SEE IF KEY == VALUE?)""""""SQL VARIABLES"""
# 0, 1 == False, 2 == True
QuestionsDict = {"1. What number should come next in this series: 12, 11, 13, 12, 14, 13… ": [["16", 0], ["15", 2], ["13", 1]],
                 "2. What number should come next: 80, 10, 70, 15, 60": [["25", 0], ["50", 1], ["20", 2]],
                 "3. Melt : Liquid :: Freeze : ?" :[["Ice", 0], ["Solid", 2], ["Condense", 1]],
                 "4. Parts : Strap :: Wolf : ?" : [["Wood", 0], ["Fox", 1], ["Flow", 2]],
                 "5. Paw : Cat :: Hoof : ?" : [["Horse", 2], ["Lamb", 0], ["Tiger", 1]],
                 "6. Find out the wrong term: 8, 13, 21, 32, 47, 63, 83" : [["13", 0], ["32", 1], ["47",2]],
                 "7. Which word does NOT belong with the others?" : [["Book", 2], ["Index", 1], ["Glossary", 0]],
                 "8. Which word is the odd man out?" :[["Fondness", 0], ["Hate", 2], ["Appreciation", 1]],
                 "9. Floors are cleaned on consecutive days. All other policies are untampered.\n What days are windows washed and floors cleaned?" :
                 [["Six", 2], ["Three", 1], ["Five", 0]],
                 "10. New roads are open for tender, what follows?.\nI. Work is slow over construction. II. The roads will be better made" :
                 [["I or II", 1], ["Not I or II", 2], ["I and II", 0]]}
# Grabs the Database
def DataBase():
    conn = sqlite3.connect('Applicants.db')
    cursor = conn.execute("SELECT * from APPLICANTS")
    return [conn, cursor]
# Bulk disposal of widgets; allows transition between forms
def destoryWidgets(lst):
    for l in lst:
        l.destroy()# Admin access can view test score results


class AddForm(Frame):
    def __init__(self, master):
        super().__init__(master)
        self.master.tkraise(self)
        self.master.geometry("300x150")
        self.frame = Frame(self.master, width=200, height=150)

        self.frame.pack()

        self.L1 = Label(self.frame, text="Name")

        self.L1.place(x=0, y=30)

        self.E1 = Entry(self.frame, width=50)

        self.E1.place(x=55, y=30)

        self.L2 = Label(self.frame, text="Position")

        self.L2.place(x=0, y=60)

        self.E2 = Entry(self.frame, width=50)

        self.E2.place(x=55, y=60)

        self.L3 = Label(self.frame, text="First Car")

        self.L3.place(x=0, y=90)

        self.E3 = Entry(self.frame, width=50)

        self.E3.place(x=55, y=90)

        self.addBtn = Button(self.frame, text="Add", command=self.on_buttonAdd)
        self.addBtn.place(x=0,y=120)
        self.extBtn = Button(self.frame, text="Return", command=self.btn_return_click)
        self.extBtn.place(x=60, y=120)


    def on_buttonAdd(self):
        n = str(self.E1.get())
        pos = str(self.E2.get())
        sq = str(self.E3.get())
        res = [(lambda x: False if x.isdigit() or x == None or x == "" else True)(x) for x in [n, pos, sq]]
        if False in res:
            tm.showerror("Validation error", "Incorrect values, please supply text only")
            return
        myDB = DataBase()
        cursor = myDB[1]
        l = int(len(cursor.fetchall()) + 1)
        cursor.execute("""INSERT INTO main.Applicants(ID,Name,Position,Score,Security_Question)
                          VALUES(:ID,:Name,:Position,:Score,:Security_Question)""",
                       {'ID':l,'Name':n,'Position':pos,'Score':0,'Security_Question':sq})
        myDB[0].commit()
        cursor.close()

    def btn_return_click(self):
        destoryWidgets(([self.addBtn, self.extBtn, self.E3, self.E2, self.E1, self.L1, self.L2, self.L3, self.frame]))
        self.destroy()
        AdminForm(root)



class AdminForm(Frame):
    SortDir = True  # descending

    def __init__(self, isapp=True, name='mclistdemo'):
        ttk.Frame.__init__(self, name=name)
        self.pack(expand=N)
        self.master.geometry('500x250')
        self.master.title('Admin Screen')
        self.isapp = isapp
        self.tree = None
        self._create_widgets()

    def _create_widgets(self):
        myFrame = Frame(self, width=200)
        scrollbarx = Scrollbar(myFrame, orient=HORIZONTAL)
        scrollbary = Scrollbar(myFrame, orient=VERTICAL)
        self.tree = ttk.Treeview(columns=("ID", "Name", "Position", "Score"),
        selectmode="extended", height=100, yscrollcommand=scrollbary.set, xscrollcommand=scrollbarx.set)
        scrollbary.config(command=self.tree.yview)
        scrollbary.pack(side=RIGHT, fill=Y)
        scrollbarx.config(command=self.tree.xview)
        scrollbarx.pack(side=BOTTOM, fill=X)
        self.tree.heading('ID', text="ID", anchor=W)
        self.tree.heading('Name', text="Candidate Name", anchor=W)
        self.tree.heading('Position', text="Position", anchor=W)
        self.tree.heading('Score', text="Score", anchor=W)
        self.tree.column('#0', stretch=NO, minwidth=0, width=0)
        self.tree.column('#1', stretch=NO, minwidth=0, width=0)
        self.tree.column('#2', stretch=NO, minwidth=0, width=200)
        self.tree.column('#3', stretch=NO, minwidth=0, width=120)
        self.tree.column('#4', stretch=NO, minwidth=0, width=120)
        self.btn_return = Button(self.master, text="Return", command=self.btn_return_click)
        self.btn_return.pack(anchor= W, side=TOP)
        self.btn_add = Button(self.master, text="Add Candidate", command=self.btn_add_candidate_click)
        self.btn_add.pack(anchor= E, side=TOP)
        self.DisplayData()
        self.tree.pack()

    def btn_return_click(self):
        destoryWidgets([self.tree, self.btn_return, self.btn_add])
        self.destroy()
        LoginForm(root)

    def btn_add_candidate_click(self):
        destoryWidgets([self.tree, self.btn_return, self.btn_add])
        self.destroy()
        AddForm(root)

    def DisplayData(self):
        cursor = DataBase()[1]
        fetch = cursor.fetchall()
        for data in fetch:
            self.tree.insert('', 'end', values=(data))
        cursor.close()

class LoginForm(Frame):
    def __init__(self, master):
        super().__init__(master)
        self.master.title("T5 Recruitment & Training")
        self.master.geometry('300x150')
        info_frame = LabelFrame(self, padx = 20, pady = 20)
        label_title = Label(info_frame, text = "T5 Recruitment & Trainging\nCandidate Test")

        entry_frame = LabelFrame(self, text = "Enter Details", padx =50, pady = 20)
        self.label_username = Label(entry_frame, text="Name")
        self.label_password = Label(entry_frame, text="ID")
        self.entry_username = Entry(entry_frame)
        self.entry_password = Entry(entry_frame, show="*")
        entry_frame.pack()
        info_frame.pack()
        #Grid or place? Test on different Form classes
        self.label_username.grid(row=0, sticky=E)
        self.label_password.grid(row=1, sticky=E)
        self.entry_username.grid(row=0, column=1)
        self.entry_password.grid(row=1, column=1)
        self.logbtn = Button(self, text="Login", command=self._login_btn_clicked, width = 10)
        self.logbtn.pack()
        self.pack()

    def _login_btn_clicked(self):
        #Get text from login fields
        username = self.entry_username.get()
        password = self.entry_password.get()        # generic name for testing, will be tested against SQL db in next phase
        found_user = False
        cursor = DataBase()[1]
        if username == "ADMIN" and password == "password":
            tm.showinfo("Login Info", "Welcome Admin")
            found_user = True
            self.destroy()
            af = AdminForm(root)

        for row in cursor:
            if str(row[0]) == password and row[1] == username:
                sq = str(row[4])
                found_user = True
                tm.showinfo("Login info", "Welcome " + username)
                self.destroy()
                qs = QSecurityForm(root,username, password, sq) #Pass user login details between class contexts to associate score with user details
        if not found_user:
           tm.showerror("Login error", "Incorrect username/password")

class QSecurityForm(Frame):
    def __init__(self, master, USER_ID, USER_NAME, SEQ):
        super().__init__(master)
        self.u_i = USER_ID
        self.u_n = USER_NAME
        self.sq = SEQ
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
        if answer != self.sq: # test term
            self.turns -= 1
            self.label_turns.config(text="Incorrect term. Attempts remaing: " + str(self.turns))
        else:
            destoryWidgets([self.label_turns, self.label_SQprompt, self.entry_SA, self.btn_confirmSQ])
            self.destroy()
            qf = questionform(root,self.u_i, self.u_n)

class questionform(Frame):
    def __init__(self, master, i, n):
        super().__init__(master)
        self.USERID = n
        self.USERNAME = i
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
        check_q = lambda x, y: True if x[0] + x[1]  == y and x[1].isdigit() else (True if x[0] == y and not x[1].isdigit() else False)
        for question, answer in QuestionsDict.items():

            if check_q(question,str(self.Question_counter)):  # avoiding duplicate questions by matching the sliced first index of the string key
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
        self.rbtn1.select() #Resets the selected radio button
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
            myDB = DataBase()
            myDB[1].execute('''UPDATE main.Applicants SET Score = ? WHERE ID = ?''', (int(self.score), int(self.USERID)))
            myDB[0].commit()
            writeFile(self.USERID, self.USERNAME, self.score)
            destoryWidgets([self.lbl_question,self.rbtn1,self.rbtn2,self.rbtn3, self.confirm_btn, self.exit_btn])
            self.destroy()
            lf = LoginForm(root)
            return
        self.change_question()
    def exitQuestions(self):
        result = tm.askyesno("", "Test unfinished, are you want to exit?")
        if result == True:
            root.destroy()
        else:
            return"""Security measure that backs up a copy of the test results by creating a text file"""
def writeFile( APP_NAME, APP_ID, SCORE):
    f = open(cwd + "\Scores.txt","w")
    f.write(datetime.datetime.now().strftime("%A, %d %b %Y") + "\n")
    f.write("ID: " + APP_ID+"\n")
    f.write("NAME: " + APP_NAME+"\n")
    f.write("SCORE: "+ str(SCORE)+ "\n\n")
    f.close()
root = Tk()
lf = LoginForm(root)

root.mainloop()