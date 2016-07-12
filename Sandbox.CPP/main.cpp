#include <string>
#include <iostream>

class ListNode
{
public:
	explicit ListNode(int value) : Next(nullptr), Value(value)
	{
	}

	ListNode* Next;
	int Value;
};

ListNode* ReverseLinkedList(ListNode* root)
{
	ListNode* new_root = nullptr;
	while (root)
	{
		auto next = root->Next;
		root->Next = new_root;
		new_root = root;
		root = next;
	}
	return new_root;
}

void PrintList(ListNode* root, std::ostream& out = std::cout)
{
	auto node = root;
	while (node)
	{
		out << node->Value << " ";
		node = node->Next;
	}
	out << "\n";
}

void ReverseStringInPlace(std::string& text)
{
	if (text.size() == 0)
	{
		return;
	}

	auto right = text.size() - 1;
	decltype(right) left = 0;

	while (left < right)
	{
		auto current = text[left];
		text[left] = text[right];
		text[right] = current;
		left++;
		right--;
	}
}

void ReverseStringInPlaceTest()
{
	std::string input = "Hakuna Matata";

	std::cout << input << "\n";
	ReverseStringInPlace(input);
	std::cout << input << "\n";
}

int main()
{
	auto root = ListNode(0);
	auto n1 = ListNode(1);
	auto n2 = ListNode(2);
	auto n3 = ListNode(3);

	root.Next = &n1;
	n1.Next = &n2;
	n2.Next = &n3;

	PrintList(&root);

	auto reversed = ReverseLinkedList(&root);

	PrintList(reversed);

	return 0;
}
