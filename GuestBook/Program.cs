using GuestBook;

GuestLogic.WelcomeMessages();

var (guests, totalGuests) = GuestLogic.GetAllGuests();

GuestLogic.DisplayGuests(guests);
GuestLogic.DisplayTotalGuests(totalGuests);

