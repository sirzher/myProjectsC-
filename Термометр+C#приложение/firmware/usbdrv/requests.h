/* ���: requests.h
 * ������: custom-class, ������� ������ ���������� USB
 * �����: Christian Starkjohann
 * �������: microsin.ru 
 * ���� ��������: 2008-04-09
 * ���������: 4
 * Copyright: (c) 2008 by OBJECTIVE DEVELOPMENT Software GmbH
 * ��������: GNU GPL v2 (��. License.txt) ��� ������������� (CommercialLicense.txt)
 * �������: $Id: requests.h 602 2008-05-13 15:15:13Z cs $
 */

/* ���� ������������ ���� �������� ����� ����� firmware � �� �����. �� ������
 *  ������ �������� USB numbers (� ����������� ���� ������), ������������ ���
 *  ������������ ����� ������ � ����������� USB.
 */

#ifndef __REQUESTS_H_INCLUDED__
#define __REQUESTS_H_INCLUDED__

#define CUSTOM_RQ_ECHO          0
/* ������, ����� ���������� ������� ������� wValue � wIndex. ��� ������������ 
 *  �� ���������� ������� ��� ������������ ��������� ����������.
 */
#define CUSTOM_RQ_SET_STATUS    1
/* ��������� ��������� LED (���������). Control-OUT.
 * ������������� ������ ���������� � ���� "wValue" ����������� (control)
 *  ��������. ������� ������ OUT �� ����������. ��� 0 �������� ����� wValue 
 *  ��������� LED.
 */

#define CUSTOM_RQ_GET_STATUS    2
/* ��������� ��������� LED. Control-IN.
 * ��� ����������� �������� (control transfer) ��������� 1 ���� ������, ��� 
 *  ���������� ���������� ������� ��������� �����. ��������� ���������� � 
 *  ���� 0 �����.
 */

#endif /* __REQUESTS_H_INCLUDED__ */
