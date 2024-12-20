PGDMP     #    6    
        	    |            postgres    12.18    12.18     &           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            '           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            (           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            )           1262    13318    postgres    DATABASE     �   CREATE DATABASE postgres WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_Indonesia.1252' LC_CTYPE = 'English_Indonesia.1252';
    DROP DATABASE postgres;
                postgres    false                        3079    16384 	   adminpack 	   EXTENSION     A   CREATE EXTENSION IF NOT EXISTS adminpack WITH SCHEMA pg_catalog;
    DROP EXTENSION adminpack;
                   false            �            1259    49162    hasil    TABLE     �  CREATE TABLE public.hasil (
    id_res integer NOT NULL,
    kecamatan character varying(30),
    res_date date,
    l_hijau_3 double precision,
    l_hijauseb_3 double precision,
    l_impervious_3 double precision,
    l_hijau_none double precision,
    l_hijauseb_none double precision,
    l_impervious_none double precision,
    img_3pre character varying,
    img_classic character varying
);
    DROP TABLE public.hasil;
       public         heap    postgres    false            �            1259    49170    hasil_id_res_seq    SEQUENCE     �   ALTER TABLE public.hasil ALTER COLUMN id_res ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.hasil_id_res_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    209            �            1259    40972    metadata_file    TABLE     �  CREATE TABLE public.metadata_file (
    id_meta integer NOT NULL,
    img_date date,
    m2 double precision,
    m3 double precision,
    m4 double precision,
    m5 double precision,
    m6 double precision,
    m7 double precision,
    a2 double precision,
    a3 double precision,
    a4 double precision,
    a5 double precision,
    a6 double precision,
    a7 double precision,
    sun_elevation double precision
);
 !   DROP TABLE public.metadata_file;
       public         heap    postgres    false            �            1259    40970    metadata_file_id_meta_seq    SEQUENCE     �   ALTER TABLE public.metadata_file ALTER COLUMN id_meta ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.metadata_file_id_meta_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    206            �            1259    32768 	   pelatihan    TABLE       CREATE TABLE public.pelatihan (
    id_train integer NOT NULL,
    jenis character varying(30),
    img_date date,
    b2 character varying,
    b3 character varying,
    b4 character varying,
    b5 character varying,
    b6 character varying,
    b7 character varying
);
    DROP TABLE public.pelatihan;
       public         heap    postgres    false            �            1259    32776    pelatihan_id_train_seq    SEQUENCE     �   ALTER TABLE public.pelatihan ALTER COLUMN id_train ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.pelatihan_id_train_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    203            �            1259    49154 	   pengujian    TABLE       CREATE TABLE public.pengujian (
    id_test integer NOT NULL,
    kecamatan character varying(30),
    test_date date,
    b2 character varying,
    b3 character varying,
    b4 character varying,
    b5 character varying,
    b6 character varying,
    b7 character varying
);
    DROP TABLE public.pengujian;
       public         heap    postgres    false            �            1259    49152    pengujian_id_test_seq    SEQUENCE     �   ALTER TABLE public.pengujian ALTER COLUMN id_test ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.pengujian_id_test_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    208            �            1259    49174    perubahan_lahan    TABLE     �  CREATE TABLE public.perubahan_lahan (
    id_change integer NOT NULL,
    kecamatan character varying(30),
    start_date date,
    end_date date,
    hij_hijseb double precision,
    hij_imper double precision,
    hijseb_hij double precision,
    hijseb_imper double precision,
    imper_hij double precision,
    imper_hijseb double precision,
    no_change double precision,
    img_change character varying
);
 #   DROP TABLE public.perubahan_lahan;
       public         heap    postgres    false            �            1259    49172    perubahan_lahan_id_change_seq    SEQUENCE     �   ALTER TABLE public.perubahan_lahan ALTER COLUMN id_change ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.perubahan_lahan_id_change_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    212            �
           2606    32775    pelatihan Pelatihan_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.pelatihan
    ADD CONSTRAINT "Pelatihan_pkey" PRIMARY KEY (id_train);
 D   ALTER TABLE ONLY public.pelatihan DROP CONSTRAINT "Pelatihan_pkey";
       public            postgres    false    203            �
           2606    49169    hasil hasil_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.hasil
    ADD CONSTRAINT hasil_pkey PRIMARY KEY (id_res);
 :   ALTER TABLE ONLY public.hasil DROP CONSTRAINT hasil_pkey;
       public            postgres    false    209            �
           2606    40976    metadata_file metadata_id 
   CONSTRAINT     \   ALTER TABLE ONLY public.metadata_file
    ADD CONSTRAINT metadata_id PRIMARY KEY (id_meta);
 C   ALTER TABLE ONLY public.metadata_file DROP CONSTRAINT metadata_id;
       public            postgres    false    206            �
           2606    49161    pengujian pengujian_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.pengujian
    ADD CONSTRAINT pengujian_pkey PRIMARY KEY (id_test);
 B   ALTER TABLE ONLY public.pengujian DROP CONSTRAINT pengujian_pkey;
       public            postgres    false    208            �
           2606    49181 $   perubahan_lahan perubahan_lahan_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.perubahan_lahan
    ADD CONSTRAINT perubahan_lahan_pkey PRIMARY KEY (id_change);
 N   ALTER TABLE ONLY public.perubahan_lahan DROP CONSTRAINT perubahan_lahan_pkey;
       public            postgres    false    212           