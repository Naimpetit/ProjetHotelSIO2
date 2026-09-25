ALTER TABLE photo
ADD CONSTRAINT fk_photo_hotel
FOREIGN KEY (hotel_id) REFERENCES hotel(id);

ALTER TABLE chambre
ADD CONSTRAINT fk_chambre_hotel
FOREIGN KEY (hotel_id) REFERENCES hotel(id);

ALTER TABLE reservation
ADD CONSTRAINT fk_reservation_hotel
FOREIGN KEY (hotel_id) REFERENCES hotel(id);

ALTER TABLE reservation
ADD CONSTRAINT fk_reservation_client
FOREIGN KEY (client_id) REFERENCES client(id);

ALTER TABLE equipement_hotel
ADD CONSTRAINT fk_equipement_hotel_equipement
FOREIGN KEY (equipement_id) REFERENCES equipement(id);

ALTER TABLE equipement_hotel
ADD CONSTRAINT fk_equipement_hotel_hotel
FOREIGN KEY (hotel_id) REFERENCES hotel(id);

ALTER TABLE chambre_reservation
ADD CONSTRAINT fk_chambre_reservation_reservation
FOREIGN KEY (reservation_id) REFERENCES reservation(id);

ALTER TABLE chambre_reservation
ADD CONSTRAINT fk_chambre_reservation_chambre
FOREIGN KEY (chambre_id) REFERENCES chambre(id);