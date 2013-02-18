using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Schedule.Model;

namespace ONote
{
    public partial class Calendarfrm : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public Calendarfrm()
        {
            InitializeComponent();
        }
        //protected override void OnClosed(EventArgs e)
        //{
        //    base.OnClosed(e);
        //    instance = null;//关闭时确保注销实例 
        //}

        //private static volatile Calendarfrm instance = null;

        //public static Calendarfrm Instance
        //{
        //    get
        //    {
        //        if (null == instance)
        //        {
        //            lock (typeof (Calendarfrm))
        //            {
        //                if (null == instance)
        //                {
        //                    instance = new Calendarfrm();
        //                }
        //            }
        //        }
        //        return instance;
        //    }
        //}

        //public  static  void CreateInstance(Form mdiParent)
        //{

        //    Instance.MdiParent = mdiParent;
        //    Instance.WindowState = FormWindowState.Maximized;
        //    Instance.Show();
        //}
        public   void SetDate(DateTime dt)
        {
            calendarView1.DayViewDate = dt;
           
        }
        /// <summary>
        /// Adds the specified appointment to the model
        /// </summary>
        /// <param name="subject">Appointment subject</param>
        /// <param name="startTime">Appointment start time</param>
        /// <param name="endTime">Appointment end time</param>
        /// <param name="color">Appointment color</param>
        /// <param name="marker">Appointment marker</param>
        public Appointment AddAppointment(string subject, string description, string address, DateTime startTime, DateTime endTime, string color, string marker, string tag, string RemindTime)
        {
            Appointment appointment = new Appointment();
            appointment.StartTime = startTime;
            appointment.EndTime = endTime;
            appointment.Subject = subject;
            appointment.Description = description;
            appointment.OwnerKey = address;
            appointment.CategoryColor = color;
            appointment.TimeMarkedAs = marker;
            appointment.Tooltip = description;
            appointment.Tag = tag;
            
            appointment.Recurrence = new AppointmentRecurrence();
            if (RemindTime.Trim() != "")
            {
                appointment.Reminders.Add(new Reminder(Convert.ToDateTime(RemindTime)));
            }
            appointment.StartTimeAction = eStartTimeAction.StartTimeReachedEvent;
            appointment.StartTimeReached += new EventHandler(appointment_StartTimeReached);
            // Set recurrence type to weekly

            appointment.Recurrence.RecurrenceType = eRecurrencePatternType.Daily;
            appointment.Recurrence.Daily.RepeatOnDaysOfWeek = eDailyRecurrenceRepeat.All;
            appointment.Recurrence.Daily.RepeatInterval = 10;
            appointment.Recurrence.RangeLimitType = eRecurrenceRangeLimitType.RangeEndDate;
            //--------------------
            calendarView1.CalendarModel.Appointments.Add(appointment);
            return (appointment);
        }
        void appointment_StartTimeReached(object sender, EventArgs e)
        {
            MessageBox.Show("");
            //TipForm tf = new TipForm();
            //tf.Show();
        }

        private void calendarView1_ItemClick(object sender, EventArgs e)
        {
            
        }

        private void calendarView1_AppointmentReminder(object sender, ReminderEventArgs e)
        {
            if (e.Reminder.Appointment != null)
            {
                DateTime dt = e.Reminder.Appointment.Reminders[0].ReminderTime;
                if (dt.Year == System.DateTime.Now.Year && dt.Month == System.DateTime.Now.Month && dt.Day == System.DateTime.Now.Day && dt.Hour == System.DateTime.Now.Hour && dt.Minute == System.DateTime.Now.Minute)
                {
                    MessageBox.Show("");
                }
            }

        }
    }
}