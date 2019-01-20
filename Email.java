/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package com.vvp.java;

import java.io.*;
import java.net.*;

import javax.servlet.*;
import javax.servlet.http.*;

/**
 *
 * @author Dell
 */
public class Email extends HttpServlet {
   
    /** 
    * Processes requests for both HTTP <code>GET</code> and <code>POST</code> methods.
    * @param request servlet request
    * @param response servlet response
    */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
    throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        PrintWriter out = response.getWriter();
        try {
          
             String name=request.getParameter("name");
           String password=request.getParameter("password");
             String cpassword=request.getParameter("cpassword");
               String email=request.getParameter("email");
                 String number=request.getParameter("number");
                  String college=request.getParameter("college");
                 
             if(password.equals(cpassword))
             {
                 //out.print("divya dori inside password checking");
                 // out.print("divya dori inside password checking");// This gives the character 'a'
                 /*char character = email.charAt(0);
                 out.print("divya dori inside password checking");// This gives the character 'a'
int  firstcharunicode= (int) character; // a
		if(firstcharunicode<97 || firstcharunicode > 122)
		{
                    out.print("1 condition");
		out.println("invlaid");
		out.println("enter character\n\n");
		System.exit(0);
		}
		if(email.indexOf('@')<1)
		{
                     out.print("2 condition");
		System.out.println("invlaid");
		System.out.println("enter character before @");
		
		System.exit(0);
		}
		String emailcomponent[]=email.split("@");
		int ename=emailcomponent[1].length();
		if(ename<3 )
		{
                     out.print("3 condition");
			System.out.println("invlaid");
			System.out.println("should have  atleast more than 2 characters after @");
		
			System.exit(0);
			
		}
		int len  =emailcomponent.length;
		
		//System.out.println("\n\nlen\n\n");
		if(len>2)
		{
                     out.print("4 condition");
			System.out.println("invalid");
			System.out.println("enter one @ symbol");
		
			System.exit(0);
			
		}
	
		
		for(int i=0;i<email.length();i++)
		{	
			int temp=email.codePointAt(i);
			if(temp>33 && temp<46 || temp==47 )
			{
                             out.print("5 condition");
				System.out.println("invalid");
				System.out.println("should not have any special symbol");
				
			}
				
			
			
		}
		
		
		String [] s1= email.split("@");
		 String[] s2=s1[1].split("\\.");
		int l1=s2[0].length();
		if(l1<3)
		{
			out.println("invalid");
			System.exit(0);
			
			
		}
		int turn=0;
		int i=0;
		while( i<email.length())
		{
		if(email.charAt(i)=='.')
		{
			turn++;
			
			
			
		}
		i++;
		}
		if(turn!=0)
		{
			System.out.println("valid");
			System.exit(0);
		}
		else
		{
			System.out.println("invalid");
			System.exit(0);
		}
		
	System.out.println("\n\nvalid\n\n");
        
        for(int j=0;j<number.length();j++)
		{	
			int temp=number.codePointAt(i);
			if(temp>47 && temp<58 && temp==43 )
			{
				for(int k=0;k<email.length();k++)
		{	
			int temp1=college.codePointAt(i);
			if(temp1>33 && temp1<46  )
			{
				System.out.println("invalid");
				System.out.println("should not have any special symbol");
				
			}
                        else
                        {
                            out.print("do not enter special symbol in college name");
                        }
				
			
			
			}
                        }
                        else
                        {
                            out.print("enter valid number");
                        }
				
                        }
			
		
	
           */
          
           out.print("submitted successfully!!");
             }
        else
        {
          out.print("error"); 
        } } finally {
         
           // out.print("error!!"); 
            out.close();
        }
     
    }
    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /** 
    * Handles the HTTP <code>GET</code> method.
    * @param request servlet request
    * @param response servlet response
    */
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
    throws ServletException, IOException {
        processRequest(request, response);
    } 

    /** 
    * Handles the HTTP <code>POST</code> method.
    * @param request servlet request
    * @param response servlet response
    */
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
    throws ServletException, IOException {
        processRequest(request, response);
    }

    /** 
    * Returns a short description of the servlet.
    */
    public String getServletInfo() {
        return "Short description";
    }
    // </editor-fold>

    }