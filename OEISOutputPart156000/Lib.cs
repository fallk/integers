using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199105
{
public static readonly long[] Value={ 24L,48L,56L,72L,80L,88L,96L,112L,144L,152L,160L,168L,176L,184L,192L,208L,216L,224L,240L,248L,264L,288L,304L,320L,336L,344L,352L,368L,376L,384L,392L,400L,416L,432L,448L,456L,464L,472L,480L,496L,504L,528L,536L,552L,560L,568L,576L,592L,608L,616L,624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199105Inst : IEnumerable<long>
{
public static readonly long[] Value=A199105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199105.Bytes);
public long this[int i]=>Value[i];

public static A199105Inst Instance=new A199105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199106
{
public static readonly long[] Value={ 3L,47L,575L,6911L,82943L,995327L,11943935L,143327231L,1719926783L,20639121407L,247669456895L,2972033482751L,35664401793023L,427972821516287L,5135673858195455L,61628086298345471L,739537035580145663L,8874444426961747967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199106Inst : IEnumerable<long>
{
public static readonly long[] Value=A199106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199106.Bytes);
public long this[int i]=>Value[i];

public static A199106Inst Instance=new A199106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199107
{
public static readonly ulong[] Value={ 4L,59L,719L,8639L,103679L,1244159L,14929919L,179159039L,2149908479L,25798901759L,309586821119L,3715041853439L,44580502241279L,534966026895359L,6419592322744319L,77035107872931839L,924421294475182079L,11093055533702184959UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199107Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A199107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199107.Bytes);
public ulong this[int i]=>Value[i];

public static A199107Inst Instance=new A199107Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199108
{
public static readonly long[] Value={ 5L,13L,37L,109L,325L,973L,2917L,8749L,26245L,78733L,236197L,708589L,2125765L,6377293L,19131877L,57395629L,172186885L,516560653L,1549681957L,4649045869L,13947137605L,41841412813L,125524238437L,376572715309L,1129718145925L,3389154437773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199108Inst : IEnumerable<long>
{
public static readonly long[] Value=A199108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199108.Bytes);
public long this[int i]=>Value[i];

public static A199108Inst Instance=new A199108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199109
{
public static readonly long[] Value={ 4L,11L,32L,95L,284L,851L,2552L,7655L,22964L,68891L,206672L,620015L,1860044L,5580131L,16740392L,50221175L,150663524L,451990571L,1355971712L,4067915135L,12203745404L,36611236211L,109833708632L,329501125895L,988503377684L,2965510133051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199109Inst : IEnumerable<long>
{
public static readonly long[] Value=A199109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199109.Bytes);
public long this[int i]=>Value[i];

public static A199109Inst Instance=new A199109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199110
{
public static readonly long[] Value={ 8L,22L,64L,190L,568L,1702L,5104L,15310L,45928L,137782L,413344L,1240030L,3720088L,11160262L,33480784L,100442350L,301327048L,903981142L,2711943424L,8135830270L,24407490808L,73222472422L,219667417264L,659002251790L,1977006755368L,5931020266102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199110Inst : IEnumerable<long>
{
public static readonly long[] Value=A199110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199110.Bytes);
public long this[int i]=>Value[i];

public static A199110Inst Instance=new A199110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199111
{
public static readonly long[] Value={ 9L,25L,73L,217L,649L,1945L,5833L,17497L,52489L,157465L,472393L,1417177L,4251529L,12754585L,38263753L,114791257L,344373769L,1033121305L,3099363913L,9298091737L,27894275209L,83682825625L,251048476873L,753145430617L,2259436291849L,6778308875545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199111Inst : IEnumerable<long>
{
public static readonly long[] Value=A199111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199111.Bytes);
public long this[int i]=>Value[i];

public static A199111Inst Instance=new A199111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199112
{
public static readonly long[] Value={ 11L,31L,91L,271L,811L,2431L,7291L,21871L,65611L,196831L,590491L,1771471L,5314411L,15943231L,47829691L,143489071L,430467211L,1291401631L,3874204891L,11622614671L,34867844011L,104603532031L,313810596091L,941431788271L,2824295364811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199112Inst : IEnumerable<long>
{
public static readonly long[] Value=A199112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199112.Bytes);
public long this[int i]=>Value[i];

public static A199112Inst Instance=new A199112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199113
{
public static readonly long[] Value={ 6L,17L,50L,149L,446L,1337L,4010L,12029L,36086L,108257L,324770L,974309L,2922926L,8768777L,26306330L,78918989L,236756966L,710270897L,2130812690L,6392438069L,19177314206L,57531942617L,172595827850L,517787483549L,1553362450646L,4660087351937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199113Inst : IEnumerable<long>
{
public static readonly long[] Value=A199113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199113.Bytes);
public long this[int i]=>Value[i];

public static A199113Inst Instance=new A199113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199114
{
public static readonly long[] Value={ 12L,34L,100L,298L,892L,2674L,8020L,24058L,72172L,216514L,649540L,1948618L,5845852L,17537554L,52612660L,157837978L,473513932L,1420541794L,4261625380L,12784876138L,38354628412L,115063885234L,345191655700L,1035574967098L,3106724901292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199114Inst : IEnumerable<long>
{
public static readonly long[] Value=A199114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199114.Bytes);
public long this[int i]=>Value[i];

public static A199114Inst Instance=new A199114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199115
{
public static readonly long[] Value={ 6L,21L,81L,321L,1281L,5121L,20481L,81921L,327681L,1310721L,5242881L,20971521L,83886081L,335544321L,1342177281L,5368709121L,21474836481L,85899345921L,343597383681L,1374389534721L,5497558138881L,21990232555521L,87960930222081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199115Inst : IEnumerable<long>
{
public static readonly long[] Value=A199115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199115.Bytes);
public long this[int i]=>Value[i];

public static A199115Inst Instance=new A199115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199116
{
public static readonly long[] Value={ 7L,25L,97L,385L,1537L,6145L,24577L,98305L,393217L,1572865L,6291457L,25165825L,100663297L,402653185L,1610612737L,6442450945L,25769803777L,103079215105L,412316860417L,1649267441665L,6597069766657L,26388279066625L,105553116266497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199116Inst : IEnumerable<long>
{
public static readonly long[] Value=A199116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199116.Bytes);
public long this[int i]=>Value[i];

public static A199116Inst Instance=new A199116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199117
{
public static readonly long[] Value={ 0L,2L,2L,4L,6L,8L,8L,8L,10L,14L,12L,14L,18L,20L,20L,18L,20L,26L,22L,26L,30L,32L,32L,28L,36L,36L,34L,38L,42L,44L,42L,38L,48L,50L,46L,50L,54L,56L,52L,48L,54L,60L,58L,60L,64L,68L,66L,60L,72L,74L,68L,70L,78L,76L,80L,72L,78L,86L,76L,84L,90L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199117Inst : IEnumerable<long>
{
public static readonly long[] Value=A199117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199117.Bytes);
public long this[int i]=>Value[i];

public static A199117Inst Instance=new A199117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199118
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,7L,10L,13L,17L,21L,28L,34L,42L,52L,65L,78L,96L,113L,138L,165L,196L,231L,276L,322L,379L,442L,518L,600L,698L,803L,931L,1071L,1231L,1407L,1615L,1839L,2099L,2384L,2712L,3069L,3478L,3923L,4434L,4991L,5618L,6303L,7083L,7928L,8878L,9916L,11081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199118Inst : IEnumerable<long>
{
public static readonly long[] Value=A199118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199118.Bytes);
public long this[int i]=>Value[i];

public static A199118Inst Instance=new A199118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199119
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,2L,2L,2L,3L,4L,4L,4L,5L,6L,6L,7L,7L,8L,10L,9L,9L,12L,13L,13L,13L,14L,17L,18L,18L,19L,21L,23L,25L,26L,27L,30L,33L,33L,36L,40L,42L,43L,45L,51L,55L,55L,57L,62L,67L,71L,72L,76L,82L,87L,91L,95L,100L,107L,112L,116L,124L,132L,137L,143L,151L,159L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199119Inst : IEnumerable<long>
{
public static readonly long[] Value=A199119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199119.Bytes);
public long this[int i]=>Value[i];

public static A199119Inst Instance=new A199119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199120
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,7L,8L,11L,13L,17L,20L,25L,30L,38L,44L,54L,63L,77L,90L,107L,124L,148L,171L,202L,231L,271L,310L,360L,412L,477L,542L,622L,705L,809L,915L,1042L,1175L,1335L,1501L,1699L,1905L,2148L,2403L,2702L,3018L,3383L,3768L,4212L,4682L,5223L,5794L,6445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199120Inst : IEnumerable<long>
{
public static readonly long[] Value=A199120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199120.Bytes);
public long this[int i]=>Value[i];

public static A199120Inst Instance=new A199120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199121
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,2L,2L,2L,2L,2L,3L,4L,4L,4L,4L,5L,6L,6L,7L,8L,7L,8L,10L,11L,11L,12L,14L,14L,15L,17L,18L,20L,21L,22L,24L,25L,27L,30L,31L,32L,35L,37L,39L,41L,44L,45L,48L,52L,53L,56L,60L,62L,66L,69L,72L,76L,81L,86L,89L,92L,96L,103L,109L,113L,117L,123L,127L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199121Inst : IEnumerable<long>
{
public static readonly long[] Value=A199121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199121.Bytes);
public long this[int i]=>Value[i];

public static A199121Inst Instance=new A199121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199122
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,2L,3L,4L,5L,6L,7L,9L,11L,14L,16L,20L,23L,29L,33L,39L,47L,54L,64L,75L,86L,101L,117L,135L,155L,179L,204L,236L,268L,306L,349L,397L,450L,511L,577L,653L,736L,831L,934L,1050L,1179L,1322L,1478L,1657L,1848L,2065L,2302L,2562L,2852L,3172L,3518L,3909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199122Inst : IEnumerable<long>
{
public static readonly long[] Value=A199122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199122.Bytes);
public long this[int i]=>Value[i];

public static A199122Inst Instance=new A199122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199123
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,2L,2L,2L,3L,2L,3L,3L,4L,4L,5L,5L,6L,6L,6L,8L,8L,9L,11L,10L,12L,14L,12L,17L,16L,17L,22L,19L,24L,25L,25L,30L,30L,33L,37L,37L,42L,45L,46L,52L,54L,57L,64L,66L,69L,79L,76L,87L,93L,91L,109L,105L,115L,126L,123L,140L,144L,151L,166L,169L,180L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199123Inst : IEnumerable<long>
{
public static readonly long[] Value=A199123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199123.Bytes);
public long this[int i]=>Value[i];

public static A199123Inst Instance=new A199123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199124
{
public static readonly BigInteger[] Value={ 2L,13L,107L,1009L,10037L,100049L,1000099L,10000379L,100000399L,1000000787L,10000000799L,100000001989L,1000000001999L,10000000003999L,100000000006997L,1000000000017899L,10000000000018999L,100000000000038989L,1000000000000067999L,10000000000000079899UL,BigInteger.Parse("100000000000000079999") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199124Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199124.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199124Inst Instance=new A199124Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199125
{
public static readonly long[] Value={ 1L,2L,6L,258L,11475L,438502L,358599045L,247746055048L,141388449764548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199125Inst : IEnumerable<long>
{
public static readonly long[] Value=A199125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199125.Bytes);
public long this[int i]=>Value[i];

public static A199125Inst Instance=new A199125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199126
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,5L,19L,37L,29L,124L,240L,182L,834L,1614L,1198L,5746L,11137L,8142L,40336L,78332L,56620L,287358L,559134L,400598L,2071558L,4038130L,2872754L,15079270L,29443040L,20824778L,110653854L,216379650L,152303410L,817542980L,1600817660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199126Inst : IEnumerable<long>
{
public static readonly long[] Value=A199126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199126.Bytes);
public long this[int i]=>Value[i];

public static A199126Inst Instance=new A199126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199127
{
public static readonly long[] Value={ 1L,2L,2L,12L,30L,30L,210L,560L,560L,4200L,11550L,11550L,90090L,252252L,252252L,2018016L,5717712L,5717712L,46558512L,133024320L,133024320L,1097450640L,3155170590L,3155170590L,26293088250L,75957810500L,75957810500L,638045608200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199127Inst : IEnumerable<long>
{
public static readonly long[] Value=A199127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199127.Bytes);
public long this[int i]=>Value[i];

public static A199127Inst Instance=new A199127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199128
{
public static readonly long[] Value={ 1L,2L,6L,19L,70L,264L,1038L,4155L,16896L,69584L,289146L,1211873L,5111178L,21686612L,92453594L,395888507L,1701506820L,7337867736L,31739124866L,137656095241L,598476364166L,2607710997676L,11385288787534L,49800060551081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199128Inst : IEnumerable<long>
{
public static readonly long[] Value=A199128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199128.Bytes);
public long this[int i]=>Value[i];

public static A199128Inst Instance=new A199128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199129
{
public static readonly long[] Value={ 3L,12L,19L,258L,1409L,2836L,48320L,295092L,629776L,11499816L,73045294L,159683856L,3012721252L,19537447260L,43276955012L,832789320948L,5471578311520L,12222775051564L,238366172778672L,1580313985819656L,3551105861275344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199129Inst : IEnumerable<long>
{
public static readonly long[] Value=A199129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199129.Bytes);
public long this[int i]=>Value[i];

public static A199129Inst Instance=new A199129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199130
{
public static readonly long[] Value={ 6L,30L,70L,1409L,11475L,33970L,887966L,8181546L,26354800L,739462036L,7166709232L,23742940530L,690068431668L,6837489856538L,23031293598718L,682253330136338L,6857414650447522L,23326710623207736L,700022706564351432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199130Inst : IEnumerable<long>
{
public static readonly long[] Value=A199130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199130.Bytes);
public long this[int i]=>Value[i];

public static A199130Inst Instance=new A199130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199131
{
public static readonly long[] Value={ 5L,30L,264L,2836L,33970L,438502L,5926852L,82908094L,1187201812L,17307138986L,255687902462L,3817658150424L,57485010058768L,871667490461400L,13295046323445896L,203799010704532580L,3137556683409570358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199131Inst : IEnumerable<long>
{
public static readonly long[] Value=A199131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199131.Bytes);
public long this[int i]=>Value[i];

public static A199131Inst Instance=new A199131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199132
{
public static readonly BigInteger[] Value={ 19L,210L,1038L,48320L,887966L,5926852L,358599045L,7633754680L,56435001338L,3718131446504L,84113596169937L,647071266317908L,44371190146396476L,1031280656608709860L,8107333731404729122L,BigInteger.Parse("567373010032314560752") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199132Inst Instance=new A199132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199133
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,2L,2L,3L,6L,12L,6L,12L,6L,5L,30L,19L,19L,30L,5L,19L,30L,70L,258L,70L,30L,19L,37L,210L,264L,1409L,1409L,264L,210L,37L,29L,560L,1038L,2836L,11475L,2836L,1038L,560L,29L,124L,560L,4155L,48320L,33970L,33970L,48320L,4155L,560L,124L,240L,4200L,16896L,295092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199133Inst : IEnumerable<long>
{
public static readonly long[] Value=A199133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199133.Bytes);
public long this[int i]=>Value[i];

public static A199133Inst Instance=new A199133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199134
{
public static readonly long[] Value={ 4L,5L,10L,11L,13L,15L,20L,21L,26L,27L,29L,31L,34L,38L,40L,42L,43L,49L,50L,54L,56L,58L,59L,64L,67L,69L,71L,75L,77L,78L,80L,85L,86L,90L,91L,95L,99L,101L,102L,104L,108L,111L,113L,116L,117L,120L,123L,128L,129L,132L,133L,136L,141L,143L,144L,146L,151L,152L,154L,156L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199134Inst : IEnumerable<long>
{
public static readonly long[] Value=A199134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199134.Bytes);
public long this[int i]=>Value[i];

public static A199134Inst Instance=new A199134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199135
{
public static readonly long[] Value={ 1L,3L,11L,64L,504L,5241L,66515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199135Inst : IEnumerable<long>
{
public static readonly long[] Value=A199135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199135.Bytes);
public long this[int i]=>Value[i];

public static A199135Inst Instance=new A199135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199136
{
public static readonly long[] Value={ 1L,2L,8L,47L,389L,4226L,54888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199136Inst : IEnumerable<long>
{
public static readonly long[] Value=A199136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199136.Bytes);
public long this[int i]=>Value[i];

public static A199136Inst Instance=new A199136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199137
{
public static readonly long[] Value={ 1L,1L,3L,9L,30L,97L,336L,1153L,4081L,14552L,52609L,191657L,704385L,2604476L,9687433L,36207241L,135920489L,512182805L,1936656361L,7345211322L,27935373368L,106509551719L,407015199144L,1558603221623L,5979839952471L,22983021033071L,88477003979994L,341120527468590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199137Inst : IEnumerable<long>
{
public static readonly long[] Value=A199137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199137.Bytes);
public long this[int i]=>Value[i];

public static A199137Inst Instance=new A199137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199138
{
public static readonly long[] Value={ 1L,1L,3L,17L,135L,1463L,19306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199138Inst : IEnumerable<long>
{
public static readonly long[] Value=A199138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199138.Bytes);
public long this[int i]=>Value[i];

public static A199138Inst Instance=new A199138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199139
{
public static readonly long[] Value={ 0L,0L,1L,9L,122L,1701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199139Inst : IEnumerable<long>
{
public static readonly long[] Value=A199139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199139.Bytes);
public long this[int i]=>Value[i];

public static A199139Inst Instance=new A199139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199140
{
public static readonly long[] Value={ 3L,9L,43L,217L,1328L,19700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199140Inst : IEnumerable<long>
{
public static readonly long[] Value=A199140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199140.Bytes);
public long this[int i]=>Value[i];

public static A199140Inst Instance=new A199140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199141
{
public static readonly long[] Value={ 0L,3L,132L,125468L,839006010L,44832664800117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199141Inst : IEnumerable<long>
{
public static readonly long[] Value=A199141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199141.Bytes);
public long this[int i]=>Value[i];

public static A199141Inst Instance=new A199141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199142
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,6L,11L,23L,47L,102L,221L,492L,1099L,2485L,5637L,12858L,29391L,67354L,154539L,355003L,816035L,1876862L,4318201L,9937840L,22874731L,52659593L,121237417L,279141170L,642732027L,1479959118L,3407837387L,7847200511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199142Inst : IEnumerable<long>
{
public static readonly long[] Value=A199142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199142.Bytes);
public long this[int i]=>Value[i];

public static A199142Inst Instance=new A199142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199143
{
public static readonly long[] Value={ 1L,3L,13L,65L,393L,2539L,16866L,113432L,766473L,5188597L,35148945L,238173743L,1614066774L,10938730576L,74134306725L,502428413393L,3405102418833L,23077383280435L,156402287318610L,1059984943413152L,7183834447992225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199143Inst : IEnumerable<long>
{
public static readonly long[] Value=A199143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199143.Bytes);
public long this[int i]=>Value[i];

public static A199143Inst Instance=new A199143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199144
{
public static readonly BigInteger[] Value={ 1L,13L,132L,2453L,42420L,794416L,14511531L,268456338L,4940928443L,91146218920L,1679743067872L,30969409565822L,570877041856787L,10524153072061784L,194006638767664141L,3576453618832667684L,BigInteger.Parse("65930406443303698229") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199144Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199144.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199144Inst Instance=new A199144Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199145
{
public static readonly BigInteger[] Value={ 2L,65L,2453L,125468L,6235011L,316561994L,15958823113L,806680624447L,40736752748774L,2057896226081573L,103945296750116087L,5250572116269762125L,BigInteger.Parse("265216743260845702081"),BigInteger.Parse("13396704712673136390007"),BigInteger.Parse("676696655003807234547723") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199145Inst Instance=new A199145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199146
{
public static readonly BigInteger[] Value={ 3L,393L,42420L,6235011L,839006010L,117380324984L,16158623337745L,2239304268913257L,309471298054332806L,BigInteger.Parse("42818034223579225138"),BigInteger.Parse("5921413251810033475103"),BigInteger.Parse("819050117505774849777870") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199146Inst Instance=new A199146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199147
{
public static readonly long[] Value={ 6L,2539L,794416L,316561994L,117380324984L,44832664800117L,16925667317073175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199147Inst : IEnumerable<long>
{
public static readonly long[] Value=A199147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199147.Bytes);
public long this[int i]=>Value[i];

public static A199147Inst Instance=new A199147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199148
{
public static readonly long[] Value={ 11L,16866L,14511531L,15958823113L,16158623337745L,16925667317073175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199148Inst : IEnumerable<long>
{
public static readonly long[] Value=A199148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199148.Bytes);
public long this[int i]=>Value[i];

public static A199148Inst Instance=new A199148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199149
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,2L,13L,13L,2L,3L,65L,132L,65L,3L,6L,393L,2453L,2453L,393L,6L,11L,2539L,42420L,125468L,42420L,2539L,11L,23L,16866L,794416L,6235011L,6235011L,794416L,16866L,23L,47L,113432L,14511531L,316561994L,839006010L,316561994L,14511531L,113432L,47L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199149Inst : IEnumerable<long>
{
public static readonly long[] Value=A199149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199149.Bytes);
public long this[int i]=>Value[i];

public static A199149Inst Instance=new A199149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199150
{
public static readonly long[] Value={ 1L,1L,4L,1L,5L,2L,9L,8L,6L,4L,6L,4L,2L,3L,9L,2L,5L,6L,2L,7L,0L,7L,5L,0L,6L,6L,0L,5L,6L,2L,9L,4L,8L,6L,7L,7L,8L,4L,6L,7L,2L,7L,2L,6L,6L,3L,6L,4L,1L,5L,7L,9L,5L,5L,0L,7L,5L,8L,6L,1L,6L,9L,7L,2L,5L,6L,0L,8L,6L,3L,1L,1L,9L,6L,7L,3L,5L,7L,4L,4L,7L,8L,8L,7L,7L,9L,0L,4L,6L,9L,5L,4L,3L,7L,2L,5L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199150Inst : IEnumerable<long>
{
public static readonly long[] Value=A199150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199150.Bytes);
public long this[int i]=>Value[i];

public static A199150Inst Instance=new A199150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199151
{
public static readonly long[] Value={ 8L,6L,4L,0L,1L,1L,2L,7L,2L,4L,2L,7L,9L,0L,3L,4L,5L,7L,3L,2L,9L,5L,5L,0L,3L,1L,5L,0L,3L,5L,9L,0L,0L,2L,9L,4L,7L,0L,4L,8L,8L,0L,1L,7L,2L,7L,8L,9L,4L,2L,0L,3L,8L,5L,2L,7L,5L,0L,0L,7L,7L,8L,3L,4L,3L,8L,2L,4L,2L,2L,0L,4L,0L,1L,2L,5L,9L,8L,3L,2L,0L,0L,5L,6L,4L,3L,1L,1L,8L,0L,0L,8L,8L,7L,4L,2L,1L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199151Inst : IEnumerable<long>
{
public static readonly long[] Value=A199151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199151.Bytes);
public long this[int i]=>Value[i];

public static A199151Inst Instance=new A199151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199152
{
public static readonly long[] Value={ 9L,3L,1L,9L,4L,4L,5L,3L,9L,1L,9L,6L,5L,7L,4L,8L,0L,8L,7L,5L,7L,9L,9L,4L,8L,2L,2L,2L,1L,9L,0L,3L,5L,7L,7L,7L,4L,3L,2L,4L,1L,6L,3L,2L,3L,9L,2L,4L,2L,2L,3L,1L,3L,6L,1L,2L,1L,0L,2L,9L,6L,0L,5L,1L,6L,3L,7L,4L,3L,3L,6L,3L,4L,4L,7L,8L,0L,9L,1L,8L,6L,6L,5L,1L,4L,5L,5L,7L,1L,6L,5L,7L,7L,3L,9L,3L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199152Inst : IEnumerable<long>
{
public static readonly long[] Value=A199152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199152.Bytes);
public long this[int i]=>Value[i];

public static A199152Inst Instance=new A199152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199153
{
public static readonly long[] Value={ 3L,3L,6L,4L,8L,2L,7L,0L,1L,9L,2L,3L,3L,5L,2L,8L,1L,5L,7L,7L,0L,3L,9L,4L,9L,3L,7L,6L,1L,1L,0L,6L,7L,7L,8L,1L,4L,4L,3L,6L,5L,3L,0L,1L,1L,7L,8L,4L,0L,0L,3L,6L,7L,9L,4L,6L,8L,5L,6L,3L,5L,3L,2L,4L,2L,5L,3L,4L,9L,3L,1L,1L,2L,9L,0L,3L,6L,8L,3L,7L,2L,5L,6L,4L,9L,3L,2L,1L,7L,3L,9L,8L,2L,0L,0L,1L,7L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199153Inst : IEnumerable<long>
{
public static readonly long[] Value=A199153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199153.Bytes);
public long this[int i]=>Value[i];

public static A199153Inst Instance=new A199153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199154
{
public static readonly long[] Value={ 1L,1L,2L,6L,2L,9L,9L,9L,4L,0L,9L,9L,3L,8L,7L,7L,5L,2L,3L,9L,9L,2L,8L,6L,7L,7L,3L,3L,6L,4L,1L,8L,6L,8L,5L,0L,7L,2L,2L,2L,7L,0L,7L,8L,8L,7L,1L,8L,7L,3L,6L,9L,6L,8L,2L,1L,0L,1L,2L,4L,1L,9L,8L,1L,3L,2L,7L,5L,3L,6L,9L,3L,2L,2L,5L,1L,7L,5L,0L,6L,8L,2L,5L,0L,4L,4L,0L,7L,7L,5L,3L,0L,0L,7L,7L,6L,0L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199154Inst : IEnumerable<long>
{
public static readonly long[] Value=A199154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199154.Bytes);
public long this[int i]=>Value[i];

public static A199154Inst Instance=new A199154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199155
{
public static readonly long[] Value={ 5L,5L,9L,3L,7L,2L,1L,7L,0L,8L,1L,3L,1L,2L,7L,0L,4L,7L,7L,6L,5L,6L,2L,9L,6L,4L,7L,3L,2L,6L,5L,4L,8L,9L,2L,0L,7L,0L,8L,1L,5L,6L,2L,5L,3L,5L,4L,4L,2L,3L,2L,2L,2L,9L,8L,4L,0L,6L,5L,6L,7L,2L,9L,4L,5L,4L,1L,6L,4L,0L,8L,0L,2L,8L,3L,7L,1L,8L,3L,6L,5L,6L,4L,6L,9L,0L,6L,8L,6L,3L,4L,4L,1L,5L,1L,6L,0L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199155Inst : IEnumerable<long>
{
public static readonly long[] Value=A199155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199155.Bytes);
public long this[int i]=>Value[i];

public static A199155Inst Instance=new A199155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199156
{
public static readonly long[] Value={ 1L,2L,8L,0L,1L,1L,7L,0L,2L,7L,8L,2L,3L,5L,9L,2L,9L,0L,0L,0L,4L,5L,6L,8L,9L,8L,4L,5L,5L,5L,8L,5L,5L,4L,9L,7L,9L,6L,5L,5L,2L,8L,2L,3L,5L,3L,6L,5L,3L,4L,8L,6L,3L,0L,8L,5L,6L,7L,7L,8L,2L,6L,9L,0L,0L,8L,4L,7L,4L,8L,3L,3L,1L,9L,7L,1L,7L,6L,9L,0L,6L,9L,7L,1L,8L,5L,9L,5L,0L,8L,4L,8L,1L,0L,8L,4L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199156Inst : IEnumerable<long>
{
public static readonly long[] Value=A199156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199156.Bytes);
public long this[int i]=>Value[i];

public static A199156Inst Instance=new A199156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199157
{
public static readonly long[] Value={ 7L,4L,1L,4L,5L,6L,7L,0L,6L,7L,6L,9L,8L,5L,8L,9L,2L,0L,1L,5L,9L,4L,6L,0L,9L,5L,6L,3L,4L,9L,1L,0L,8L,9L,4L,9L,9L,8L,7L,5L,4L,6L,6L,1L,4L,9L,6L,5L,7L,8L,0L,9L,0L,1L,8L,9L,5L,5L,5L,0L,1L,0L,3L,5L,1L,0L,4L,9L,6L,6L,0L,9L,9L,0L,4L,8L,0L,8L,3L,1L,6L,2L,7L,9L,1L,9L,8L,9L,1L,1L,9L,4L,5L,2L,6L,4L,8L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199157Inst : IEnumerable<long>
{
public static readonly long[] Value=A199157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199157.Bytes);
public long this[int i]=>Value[i];

public static A199157Inst Instance=new A199157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199158
{
public static readonly long[] Value={ 1L,1L,0L,8L,2L,6L,9L,4L,4L,7L,3L,9L,3L,7L,1L,0L,5L,4L,6L,7L,2L,8L,0L,0L,8L,2L,1L,5L,8L,6L,1L,4L,9L,9L,7L,4L,2L,3L,3L,7L,9L,6L,7L,1L,6L,5L,5L,7L,5L,2L,2L,3L,7L,1L,4L,8L,4L,2L,1L,2L,8L,1L,3L,3L,5L,5L,5L,8L,5L,9L,1L,4L,9L,1L,9L,2L,6L,4L,1L,9L,0L,2L,5L,9L,8L,9L,1L,9L,8L,5L,7L,8L,0L,4L,4L,0L,9L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199158Inst : IEnumerable<long>
{
public static readonly long[] Value=A199158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199158.Bytes);
public long this[int i]=>Value[i];

public static A199158Inst Instance=new A199158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199159
{
public static readonly long[] Value={ 2L,6L,5L,8L,0L,1L,6L,2L,7L,1L,9L,8L,3L,4L,7L,9L,8L,1L,5L,8L,3L,1L,2L,9L,6L,9L,2L,0L,3L,4L,2L,7L,7L,3L,3L,1L,0L,9L,4L,2L,5L,9L,8L,1L,8L,9L,2L,7L,7L,1L,4L,0L,5L,3L,9L,9L,3L,5L,9L,4L,6L,6L,6L,3L,9L,9L,3L,0L,9L,7L,9L,2L,6L,1L,6L,1L,5L,6L,7L,4L,6L,9L,5L,6L,1L,5L,3L,8L,1L,3L,7L,4L,8L,7L,3L,7L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199159Inst : IEnumerable<long>
{
public static readonly long[] Value=A199159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199159.Bytes);
public long this[int i]=>Value[i];

public static A199159Inst Instance=new A199159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199160
{
public static readonly long[] Value={ 1L,2L,7L,3L,9L,4L,1L,9L,1L,9L,4L,1L,1L,5L,8L,3L,3L,2L,7L,0L,3L,4L,0L,8L,4L,7L,4L,3L,4L,2L,0L,5L,5L,6L,4L,3L,5L,0L,6L,1L,2L,3L,1L,9L,6L,7L,6L,0L,7L,9L,9L,5L,6L,6L,7L,9L,1L,1L,7L,0L,7L,2L,4L,3L,0L,1L,8L,8L,8L,5L,2L,0L,2L,7L,1L,7L,7L,1L,6L,1L,8L,8L,7L,3L,5L,7L,7L,5L,9L,0L,0L,0L,6L,9L,7L,4L,9L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199160Inst : IEnumerable<long>
{
public static readonly long[] Value=A199160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199160.Bytes);
public long this[int i]=>Value[i];

public static A199160Inst Instance=new A199160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199161
{
public static readonly long[] Value={ 4L,6L,6L,1L,0L,6L,4L,2L,1L,6L,8L,3L,1L,9L,6L,4L,1L,1L,1L,4L,8L,0L,8L,1L,0L,3L,5L,3L,0L,4L,5L,0L,0L,6L,3L,0L,4L,3L,7L,4L,6L,2L,4L,0L,5L,9L,0L,5L,2L,3L,5L,0L,2L,3L,9L,4L,7L,8L,6L,9L,3L,0L,0L,0L,7L,7L,2L,4L,5L,3L,3L,9L,0L,1L,8L,8L,8L,6L,5L,0L,9L,3L,8L,1L,4L,8L,0L,4L,1L,9L,7L,7L,2L,4L,3L,4L,1L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199161Inst : IEnumerable<long>
{
public static readonly long[] Value=A199161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199161.Bytes);
public long this[int i]=>Value[i];

public static A199161Inst Instance=new A199161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199162
{
public static readonly long[] Value={ 1L,6L,7L,8L,9L,10L,11L,12L,14L,24L,26L,27L,28L,29L,31L,45L,46L,47L,48L,49L,62L,68L,82L,83L,84L,85L,98L,104L,117L,122L,135L,142L,154L,155L,159L,172L,191L,192L,193L,194L,195L,209L,234L,245L,248L,249L,250L,265L,266L,267L,268L,270L,283L,302L,303L,304L,305L,306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199162Inst : IEnumerable<long>
{
public static readonly long[] Value=A199162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199162.Bytes);
public long this[int i]=>Value[i];

public static A199162Inst Instance=new A199162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199163
{
public static readonly BigInteger[] Value={ 1L,2L,10L,56L,404L,3272L,30688L,316304L,3609656L,44624624L,597131600L,8555752064L,130941724064L,2127005759296L,36577172243776L,663151898857856L,12646212723268576L,252922802230850496L,5294480128736395456L,BigInteger.Parse("115747660924409952512"),BigInteger.Parse("2638244919080808844544") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199163Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199163.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199163Inst Instance=new A199163Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199164
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,17L,77L,448L,3274L,29326L,313768L,3929226L,56701093L,930803798L,17196523994L,354410799300L,8087797118417L,203054496653329L,5577055299461291L,166745207015271392L,5403112484148713170L,BigInteger.Parse("188998781647795395932"),BigInteger.Parse("7111266811914520345796") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199164Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199164.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199164Inst Instance=new A199164Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199165
{
public static readonly long[] Value={ 2L,3L,4L,5L,14L,19L,21L,50L,53L,136L,146L,1255L,1448L,1839L,2053L,2496L,4060L,5041L,8410L,14090L,14940L,19759L,29871L,44836L,78175L,114398L,120946L,137845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199165Inst : IEnumerable<long>
{
public static readonly long[] Value=A199165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199165.Bytes);
public long this[int i]=>Value[i];

public static A199165Inst Instance=new A199165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199166
{
public static readonly BigInteger[] Value={ 2L,4L,8L,88L,888L,222222L,444444L,888888L,444444444444L,888888888888L,444444444444444444L,888888888888888888L,BigInteger.Parse("888888888888888888888888"),BigInteger.Parse("222222222222222222222222222222"),BigInteger.Parse("444444444444444444444444444444"),BigInteger.Parse("888888888888888888888888888888") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199166Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199166.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199166Inst Instance=new A199166Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199167
{
public static readonly long[] Value={ 1L,3L,2L,15L,8L,12L,4L,105L,2L,3L,43L,60L,9L,12L,8L,945L,67L,300L,37L,240L,5L,48L,137L,420L,8L,5L,2L,60L,173L,12L,16L,10395L,86L,13L,76L,2100L,73L,147L,8L,1680L,163L,4800L,257L,240L,8L,3072L,281L,3780L,4L,3L,101L,60L,211L,14700L,8L,420L,32L,17L,353L,8400L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199167Inst : IEnumerable<long>
{
public static readonly long[] Value=A199167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199167.Bytes);
public long this[int i]=>Value[i];

public static A199167Inst Instance=new A199167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199168
{
public static readonly long[] Value={ 0L,10L,102L,120L,201L,210L,1023L,1032L,1203L,1230L,1302L,1320L,2013L,2031L,2103L,2130L,2301L,2310L,3012L,3021L,3102L,3120L,3201L,3210L,10234L,10243L,10324L,10342L,10423L,10432L,12034L,12043L,12304L,12340L,12403L,12430L,13024L,13042L,13204L,13240L,13402L,13420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199168Inst : IEnumerable<long>
{
public static readonly long[] Value=A199168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199168.Bytes);
public long this[int i]=>Value[i];

public static A199168Inst Instance=new A199168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199169
{
public static readonly long[] Value={ 11L,102001L,1000121L,1000211L,1002101L,1010201L,1020011L,1020101L,1021001L,1102001L,1120001L,1201001L,2001101L,2100011L,2110001L,100012111L,100101121L,100110121L,100112101L,100121011L,100211101L,101020111L,101100211L,101102101L,101110201L,101210101L,102100111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199169Inst : IEnumerable<long>
{
public static readonly long[] Value=A199169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199169.Bytes);
public long this[int i]=>Value[i];

public static A199169Inst Instance=new A199169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199170
{
public static readonly long[] Value={ 1L,1L,9L,8L,3L,5L,9L,8L,4L,4L,5L,1L,8L,6L,6L,0L,2L,6L,8L,2L,6L,5L,0L,2L,1L,6L,0L,3L,4L,3L,0L,3L,0L,8L,9L,8L,9L,2L,7L,2L,6L,8L,0L,9L,3L,5L,8L,7L,4L,8L,2L,5L,6L,9L,0L,1L,4L,4L,4L,9L,2L,3L,8L,6L,8L,6L,4L,2L,7L,1L,7L,6L,1L,4L,9L,7L,1L,9L,1L,2L,5L,5L,9L,1L,7L,1L,4L,2L,8L,9L,1L,6L,9L,7L,2L,0L,9L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199170Inst : IEnumerable<long>
{
public static readonly long[] Value=A199170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199170.Bytes);
public long this[int i]=>Value[i];

public static A199170Inst Instance=new A199170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199171
{
public static readonly long[] Value={ 6L,8L,5L,1L,7L,4L,1L,3L,3L,8L,5L,4L,5L,0L,3L,1L,8L,7L,8L,9L,5L,2L,1L,1L,5L,3L,0L,6L,3L,8L,4L,5L,8L,7L,0L,9L,5L,9L,1L,7L,8L,5L,9L,1L,8L,9L,1L,9L,8L,8L,6L,0L,5L,2L,8L,0L,6L,6L,8L,3L,2L,7L,1L,3L,1L,9L,7L,0L,8L,5L,1L,2L,4L,4L,7L,2L,1L,1L,5L,1L,1L,4L,8L,5L,0L,0L,8L,6L,8L,4L,1L,0L,2L,7L,8L,8L,4L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199171Inst : IEnumerable<long>
{
public static readonly long[] Value=A199171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199171.Bytes);
public long this[int i]=>Value[i];

public static A199171Inst Instance=new A199171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199172
{
public static readonly long[] Value={ 1L,4L,6L,6L,9L,7L,8L,3L,0L,5L,3L,9L,7L,1L,2L,3L,5L,6L,8L,4L,1L,9L,8L,1L,4L,1L,8L,4L,7L,8L,0L,4L,4L,4L,3L,1L,8L,9L,1L,2L,0L,2L,2L,5L,9L,1L,2L,6L,4L,3L,2L,3L,3L,8L,6L,6L,0L,8L,0L,5L,7L,9L,9L,8L,2L,4L,7L,9L,0L,7L,3L,7L,0L,7L,2L,7L,4L,7L,7L,3L,6L,9L,5L,1L,1L,2L,1L,2L,2L,2L,7L,9L,9L,9L,9L,4L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199172Inst : IEnumerable<long>
{
public static readonly long[] Value=A199172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199172.Bytes);
public long this[int i]=>Value[i];

public static A199172Inst Instance=new A199172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199173
{
public static readonly long[] Value={ 1L,2L,7L,6L,6L,7L,1L,3L,6L,7L,9L,4L,0L,7L,6L,0L,5L,5L,4L,0L,9L,1L,5L,0L,7L,4L,9L,0L,4L,4L,1L,2L,1L,0L,2L,7L,8L,3L,4L,0L,0L,2L,4L,6L,4L,7L,3L,4L,5L,6L,7L,6L,0L,6L,1L,5L,6L,6L,2L,8L,7L,6L,7L,4L,1L,2L,5L,9L,6L,3L,2L,8L,0L,1L,0L,9L,7L,6L,3L,1L,1L,9L,2L,3L,4L,4L,1L,8L,2L,9L,4L,3L,2L,4L,2L,4L,5L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199173Inst : IEnumerable<long>
{
public static readonly long[] Value=A199173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199173.Bytes);
public long this[int i]=>Value[i];

public static A199173Inst Instance=new A199173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199174
{
public static readonly long[] Value={ 1L,6L,7L,8L,9L,2L,9L,7L,6L,3L,4L,9L,1L,0L,9L,4L,5L,1L,9L,5L,9L,3L,3L,8L,3L,2L,0L,1L,1L,6L,3L,4L,3L,2L,9L,9L,8L,5L,9L,3L,3L,0L,5L,0L,1L,6L,7L,2L,8L,7L,8L,3L,6L,4L,3L,7L,0L,8L,7L,6L,3L,6L,2L,7L,1L,0L,4L,2L,4L,6L,7L,1L,9L,7L,2L,8L,5L,9L,8L,6L,2L,7L,2L,2L,7L,8L,3L,4L,6L,5L,3L,5L,9L,3L,6L,9L,9L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199174Inst : IEnumerable<long>
{
public static readonly long[] Value=A199174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199174.Bytes);
public long this[int i]=>Value[i];

public static A199174Inst Instance=new A199174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199175
{
public static readonly long[] Value={ 1L,9L,0L,2L,5L,3L,0L,3L,8L,5L,0L,3L,8L,2L,3L,5L,7L,0L,3L,4L,5L,7L,7L,9L,5L,8L,2L,7L,7L,3L,9L,7L,2L,6L,7L,6L,1L,2L,7L,8L,9L,4L,2L,9L,0L,5L,3L,3L,4L,2L,2L,1L,0L,6L,0L,4L,5L,0L,4L,0L,1L,9L,1L,2L,0L,5L,8L,8L,0L,3L,8L,0L,5L,8L,5L,3L,8L,0L,4L,9L,5L,5L,8L,4L,2L,9L,9L,7L,5L,1L,4L,1L,6L,2L,8L,9L,5L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199175Inst : IEnumerable<long>
{
public static readonly long[] Value=A199175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199175.Bytes);
public long this[int i]=>Value[i];

public static A199175Inst Instance=new A199175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199176
{
public static readonly long[] Value={ 1L,3L,0L,1L,2L,0L,1L,7L,3L,3L,1L,4L,1L,9L,1L,1L,4L,0L,0L,7L,9L,8L,3L,9L,7L,3L,6L,4L,4L,4L,0L,2L,6L,4L,5L,2L,2L,1L,9L,1L,3L,0L,0L,6L,5L,7L,4L,3L,0L,3L,0L,4L,8L,9L,2L,6L,9L,4L,6L,0L,5L,7L,9L,4L,6L,6L,0L,3L,7L,1L,9L,0L,5L,4L,5L,5L,9L,6L,8L,1L,3L,3L,2L,4L,3L,2L,9L,6L,9L,4L,8L,2L,3L,0L,7L,2L,9L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199176Inst : IEnumerable<long>
{
public static readonly long[] Value=A199176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199176.Bytes);
public long this[int i]=>Value[i];

public static A199176Inst Instance=new A199176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199177
{
public static readonly long[] Value={ 4L,4L,4L,4L,1L,6L,8L,0L,9L,3L,9L,1L,7L,9L,1L,6L,3L,3L,2L,1L,3L,0L,8L,3L,6L,0L,1L,8L,2L,3L,1L,0L,7L,0L,7L,8L,8L,3L,9L,6L,2L,6L,4L,4L,0L,4L,8L,5L,6L,5L,0L,9L,3L,4L,6L,9L,5L,6L,5L,6L,5L,0L,8L,2L,7L,2L,9L,0L,9L,1L,3L,0L,3L,8L,3L,9L,2L,8L,1L,8L,7L,7L,7L,0L,7L,1L,9L,3L,0L,4L,6L,0L,2L,6L,2L,5L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199177Inst : IEnumerable<long>
{
public static readonly long[] Value=A199177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199177.Bytes);
public long this[int i]=>Value[i];

public static A199177Inst Instance=new A199177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199178
{
public static readonly long[] Value={ 1L,4L,9L,3L,5L,1L,9L,2L,8L,0L,8L,6L,8L,8L,9L,1L,0L,5L,6L,5L,5L,6L,3L,3L,9L,5L,0L,9L,9L,3L,4L,7L,8L,1L,8L,2L,5L,3L,5L,5L,3L,8L,1L,3L,0L,7L,4L,1L,8L,8L,4L,7L,6L,4L,8L,1L,6L,4L,1L,8L,0L,2L,9L,9L,2L,7L,6L,3L,4L,0L,0L,6L,0L,8L,5L,8L,4L,0L,4L,0L,8L,6L,5L,1L,5L,6L,3L,5L,2L,0L,2L,4L,0L,3L,0L,7L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199178Inst : IEnumerable<long>
{
public static readonly long[] Value=A199178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199178.Bytes);
public long this[int i]=>Value[i];

public static A199178Inst Instance=new A199178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199179
{
public static readonly long[] Value={ 9L,4L,4L,9L,4L,8L,3L,2L,9L,1L,0L,3L,5L,4L,6L,9L,6L,4L,9L,4L,5L,9L,2L,7L,6L,4L,0L,3L,7L,8L,3L,4L,5L,5L,5L,1L,6L,8L,6L,9L,7L,2L,5L,6L,5L,9L,9L,0L,0L,8L,1L,1L,2L,3L,4L,6L,4L,8L,9L,1L,2L,1L,6L,0L,6L,7L,5L,6L,5L,8L,7L,8L,0L,9L,6L,7L,9L,2L,3L,2L,9L,0L,3L,1L,2L,8L,2L,8L,4L,2L,8L,9L,8L,9L,7L,5L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199179Inst : IEnumerable<long>
{
public static readonly long[] Value=A199179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199179.Bytes);
public long this[int i]=>Value[i];

public static A199179Inst Instance=new A199179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199180
{
public static readonly long[] Value={ 1L,6L,5L,2L,4L,2L,8L,0L,4L,5L,0L,4L,1L,7L,4L,2L,1L,4L,2L,4L,0L,5L,8L,9L,1L,8L,6L,6L,2L,5L,8L,0L,1L,2L,3L,8L,7L,8L,2L,1L,3L,4L,1L,5L,4L,3L,5L,2L,8L,5L,3L,3L,1L,3L,1L,8L,0L,7L,4L,8L,0L,2L,3L,8L,2L,3L,3L,3L,8L,1L,1L,9L,6L,5L,0L,3L,5L,9L,8L,9L,3L,6L,1L,4L,7L,6L,6L,4L,0L,0L,7L,2L,1L,6L,5L,5L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199180Inst : IEnumerable<long>
{
public static readonly long[] Value=A199180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199180.Bytes);
public long this[int i]=>Value[i];

public static A199180Inst Instance=new A199180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199181
{
public static readonly long[] Value={ 2L,9L,8L,0L,6L,4L,5L,2L,7L,9L,4L,3L,8L,5L,3L,6L,8L,3L,4L,5L,9L,4L,9L,0L,8L,9L,0L,5L,5L,7L,9L,0L,3L,2L,1L,7L,5L,7L,0L,7L,3L,8L,5L,6L,3L,2L,0L,5L,6L,7L,4L,0L,2L,2L,7L,7L,6L,0L,0L,5L,6L,0L,8L,5L,2L,5L,1L,9L,6L,2L,1L,5L,4L,1L,5L,0L,3L,8L,3L,1L,1L,6L,7L,2L,8L,4L,7L,7L,0L,9L,3L,6L,3L,4L,6L,0L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199181Inst : IEnumerable<long>
{
public static readonly long[] Value=A199181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199181.Bytes);
public long this[int i]=>Value[i];

public static A199181Inst Instance=new A199181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199182
{
public static readonly long[] Value={ 1L,3L,6L,0L,6L,7L,2L,7L,7L,2L,5L,1L,3L,7L,9L,7L,2L,1L,5L,2L,2L,8L,6L,0L,2L,7L,4L,8L,7L,3L,7L,9L,9L,2L,5L,8L,8L,0L,9L,6L,8L,6L,2L,8L,0L,8L,5L,7L,6L,1L,8L,0L,9L,4L,7L,4L,5L,8L,1L,9L,1L,7L,7L,1L,9L,7L,1L,2L,0L,7L,6L,2L,0L,8L,6L,5L,3L,3L,7L,9L,2L,3L,5L,3L,1L,4L,1L,9L,0L,8L,0L,8L,3L,3L,8L,2L,9L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199182Inst : IEnumerable<long>
{
public static readonly long[] Value=A199182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199182.Bytes);
public long this[int i]=>Value[i];

public static A199182Inst Instance=new A199182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199183
{
public static readonly long[] Value={ 3L,2L,7L,7L,4L,6L,4L,6L,6L,3L,4L,1L,3L,7L,3L,0L,5L,8L,7L,3L,4L,5L,8L,7L,7L,2L,7L,7L,9L,1L,0L,8L,3L,5L,7L,1L,7L,7L,4L,7L,8L,5L,8L,8L,5L,4L,4L,7L,9L,5L,3L,1L,4L,9L,0L,1L,3L,4L,2L,1L,2L,3L,2L,8L,6L,6L,2L,2L,6L,8L,2L,3L,3L,2L,8L,8L,5L,6L,8L,8L,0L,4L,7L,6L,8L,9L,7L,7L,7L,9L,5L,5L,9L,1L,3L,5L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199183Inst : IEnumerable<long>
{
public static readonly long[] Value=A199183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199183.Bytes);
public long this[int i]=>Value[i];

public static A199183Inst Instance=new A199183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199184
{
public static readonly long[] Value={ 1L,5L,0L,9L,3L,3L,9L,0L,6L,2L,4L,6L,6L,6L,8L,8L,1L,2L,3L,4L,5L,1L,2L,5L,2L,6L,4L,1L,7L,9L,2L,1L,9L,0L,2L,9L,3L,1L,3L,5L,1L,6L,4L,6L,6L,5L,1L,7L,1L,9L,2L,6L,5L,2L,8L,1L,2L,4L,9L,8L,7L,7L,9L,1L,9L,8L,7L,3L,9L,5L,1L,1L,6L,8L,3L,1L,7L,7L,2L,1L,7L,8L,5L,5L,1L,2L,9L,3L,6L,1L,0L,0L,6L,4L,5L,1L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199184Inst : IEnumerable<long>
{
public static readonly long[] Value=A199184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199184.Bytes);
public long this[int i]=>Value[i];

public static A199184Inst Instance=new A199184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199185
{
public static readonly long[] Value={ 3L,4L,4L,4L,2L,8L,4L,6L,0L,9L,9L,0L,4L,9L,5L,5L,4L,1L,0L,7L,9L,1L,9L,5L,5L,5L,2L,7L,8L,5L,3L,8L,1L,2L,5L,1L,9L,5L,6L,9L,2L,4L,4L,7L,6L,3L,4L,8L,1L,1L,3L,7L,2L,2L,0L,4L,9L,8L,8L,0L,7L,0L,1L,6L,7L,1L,8L,7L,9L,4L,8L,9L,4L,7L,8L,9L,7L,2L,9L,4L,4L,5L,4L,9L,0L,6L,7L,2L,1L,2L,5L,6L,2L,3L,9L,6L,1L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199185Inst : IEnumerable<long>
{
public static readonly long[] Value=A199185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199185.Bytes);
public long this[int i]=>Value[i];

public static A199185Inst Instance=new A199185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199186
{
public static readonly long[] Value={ 1L,6L,3L,6L,4L,4L,3L,5L,5L,1L,9L,5L,5L,0L,4L,1L,4L,2L,2L,0L,6L,7L,5L,9L,3L,0L,3L,1L,1L,8L,7L,1L,2L,8L,2L,4L,5L,5L,9L,3L,6L,5L,4L,1L,7L,1L,8L,5L,9L,0L,2L,6L,8L,4L,2L,5L,3L,3L,4L,8L,5L,5L,7L,2L,4L,9L,6L,0L,1L,4L,7L,7L,1L,1L,7L,8L,8L,6L,4L,9L,0L,3L,3L,9L,7L,9L,7L,6L,2L,3L,7L,9L,1L,6L,2L,1L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199186Inst : IEnumerable<long>
{
public static readonly long[] Value=A199186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199186.Bytes);
public long this[int i]=>Value[i];

public static A199186Inst Instance=new A199186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199187
{
public static readonly long[] Value={ 3L,5L,6L,9L,6L,8L,6L,3L,3L,3L,9L,6L,2L,3L,0L,3L,9L,3L,0L,4L,9L,7L,9L,2L,8L,9L,6L,6L,8L,7L,8L,0L,0L,1L,4L,3L,3L,4L,3L,4L,9L,3L,8L,9L,9L,7L,2L,0L,6L,3L,2L,6L,5L,0L,2L,4L,3L,9L,7L,8L,8L,8L,1L,5L,6L,3L,8L,6L,8L,7L,2L,9L,5L,7L,1L,1L,8L,8L,7L,9L,7L,1L,7L,0L,4L,1L,6L,8L,2L,2L,9L,6L,8L,4L,3L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199187Inst : IEnumerable<long>
{
public static readonly long[] Value=A199187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199187.Bytes);
public long this[int i]=>Value[i];

public static A199187Inst Instance=new A199187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199188
{
public static readonly long[] Value={ 8L,8L,3L,3L,3L,0L,1L,9L,7L,1L,9L,5L,8L,9L,1L,9L,3L,8L,9L,2L,5L,8L,9L,6L,4L,5L,0L,8L,8L,5L,6L,7L,7L,1L,0L,7L,2L,3L,5L,0L,5L,9L,0L,0L,8L,8L,4L,2L,3L,1L,8L,8L,2L,3L,1L,6L,6L,7L,6L,3L,6L,6L,7L,3L,1L,6L,3L,4L,3L,1L,9L,5L,8L,7L,3L,3L,2L,2L,6L,1L,2L,9L,9L,8L,7L,3L,3L,1L,6L,8L,8L,3L,1L,9L,8L,3L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199188Inst : IEnumerable<long>
{
public static readonly long[] Value=A199188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199188.Bytes);
public long this[int i]=>Value[i];

public static A199188Inst Instance=new A199188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199189
{
public static readonly long[] Value={ 5L,2L,2L,9L,4L,5L,9L,4L,6L,1L,1L,3L,1L,1L,1L,7L,3L,7L,2L,4L,7L,6L,2L,3L,8L,3L,6L,3L,5L,9L,8L,1L,1L,2L,3L,7L,1L,3L,9L,7L,3L,4L,5L,2L,5L,8L,0L,0L,2L,6L,0L,5L,9L,9L,0L,2L,3L,1L,1L,5L,7L,6L,4L,5L,8L,7L,4L,4L,7L,0L,8L,0L,0L,7L,9L,9L,6L,3L,1L,5L,6L,5L,3L,7L,1L,0L,3L,2L,7L,5L,4L,8L,5L,0L,6L,5L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199189Inst : IEnumerable<long>
{
public static readonly long[] Value=A199189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199189.Bytes);
public long this[int i]=>Value[i];

public static A199189Inst Instance=new A199189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199190
{
public static readonly long[] Value={ 1L,3L,7L,9L,37L,49L,99L,379L,399L,787L,799L,1989L,1999L,3999L,6997L,17899L,18999L,38989L,67999L,79899L,79999L,389899L,499989L,798979L,897999L,989899L,2999997L,2899999L,4998999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199190Inst : IEnumerable<long>
{
public static readonly long[] Value=A199190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199190.Bytes);
public long this[int i]=>Value[i];

public static A199190Inst Instance=new A199190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199191
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,10L,11L,41L,83L,160L,178L,526L,881L,2578L,3772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199191Inst : IEnumerable<long>
{
public static readonly long[] Value=A199191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199191.Bytes);
public long this[int i]=>Value[i];

public static A199191Inst Instance=new A199191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199192
{
public static readonly BigInteger[] Value={ 7L,37L,271L,2269L,19927L,129159847L,1162320517L,BigInteger.Parse("49269609804781974450852068861184694669"),BigInteger.Parse("589881151426658740854227725580736348850640632297373414091790995505756623268837") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199192Inst Instance=new A199192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199193
{
public static readonly long[] Value={ 1L,1L,114L,11734L,86954982L,329877369234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199193Inst : IEnumerable<long>
{
public static readonly long[] Value=A199193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199193.Bytes);
public long this[int i]=>Value[i];

public static A199193Inst Instance=new A199193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199194
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,21L,41L,36L,281L,1051L,2056L,1721L,15131L,58951L,115631L,94376L,887643L,3551235L,6981925L,5609649L,55101276L,224543335L,442311619L,351574834L,3559509379L,14702228029L,29006278734L,22875971289L,236833911819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199194Inst : IEnumerable<long>
{
public static readonly long[] Value=A199194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199194.Bytes);
public long this[int i]=>Value[i];

public static A199194Inst Instance=new A199194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199195
{
public static readonly long[] Value={ 1L,1L,14L,21L,424L,571L,14479L,18551L,541753L,677755L,21602174L,26710635L,900441480L,1106584141L,38750819148L,47454881357L,1708021796194L,2086972918493L,76696731839316L,93565751359627L,3495631904879766L,4259451181263175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199195Inst : IEnumerable<long>
{
public static readonly long[] Value=A199195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199195.Bytes);
public long this[int i]=>Value[i];

public static A199195Inst Instance=new A199195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199196
{
public static readonly long[] Value={ 1L,14L,114L,447L,17598L,342958L,3366282L,13445925L,707828355L,15468414047L,160870584083L,660014693614L,37999381354839L,871398222241220L,9306441021808721L,38698706989763825L,2328196816238106071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199196Inst : IEnumerable<long>
{
public static readonly long[] Value=A199196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199196.Bytes);
public long this[int i]=>Value[i];

public static A199196Inst Instance=new A199196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199197
{
public static readonly long[] Value={ 1L,21L,447L,11734L,341015L,10692835L,351517665L,11945622271L,415824209261L,14744482818827L,530560208277339L,19323001059102859L,710881996757208605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199197Inst : IEnumerable<long>
{
public static readonly long[] Value=A199197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199197.Bytes);
public long this[int i]=>Value[i];

public static A199197Inst Instance=new A199197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199198
{
public static readonly long[] Value={ 6L,424L,17598L,341015L,86954982L,9746409872L,533423159945L,11692182169225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199198Inst : IEnumerable<long>
{
public static readonly long[] Value=A199198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199198.Bytes);
public long this[int i]=>Value[i];

public static A199198Inst Instance=new A199198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199199
{
public static readonly long[] Value={ 21L,571L,342958L,10692835L,9746409872L,329877369234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199199Inst : IEnumerable<long>
{
public static readonly long[] Value=A199199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199199.Bytes);
public long this[int i]=>Value[i];

public static A199199Inst Instance=new A199199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199200
{
public static readonly long[] Value={ 41L,14479L,3366282L,351517665L,533423159945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199200Inst : IEnumerable<long>
{
public static readonly long[] Value=A199200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199200.Bytes);
public long this[int i]=>Value[i];

public static A199200Inst Instance=new A199200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199201
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,14L,14L,1L,6L,21L,114L,21L,6L,21L,424L,447L,447L,424L,21L,41L,571L,17598L,11734L,17598L,571L,41L,36L,14479L,342958L,341015L,341015L,342958L,14479L,36L,281L,18551L,3366282L,10692835L,86954982L,10692835L,3366282L,18551L,281L,1051L,541753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199201Inst : IEnumerable<long>
{
public static readonly long[] Value=A199201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199201.Bytes);
public long this[int i]=>Value[i];

public static A199201Inst Instance=new A199201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199202
{
public static readonly BigInteger[] Value={ 1L,1L,3L,10L,53L,376L,3607L,38032L,498409L,7122304L,121691051L,2182921984L,45592175389L,987527547904L,24479592884671L,620921169012736L,17795726532904913L,517636848366223360L,16851227968120051027UL,BigInteger.Parse("552890360903850459136"),BigInteger.Parse("20150074601540899828741") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199202Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199202.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199202Inst Instance=new A199202Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199203
{
public static readonly long[] Value={ 4L,9L,8L,5L,6L,3L,2L,8L,7L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199203Inst : IEnumerable<long>
{
public static readonly long[] Value=A199203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199203.Bytes);
public long this[int i]=>Value[i];

public static A199203Inst Instance=new A199203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199204
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,2L,3L,6L,6L,3L,2L,1L,1L,2L,3L,4L,6L,8L,12L,24L,24L,12L,8L,6L,4L,3L,2L,1L,1L,2L,3L,4L,5L,6L,8L,10L,12L,15L,20L,24L,30L,40L,60L,120L,120L,60L,40L,30L,24L,20L,15L,12L,10L,8L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199204Inst : IEnumerable<long>
{
public static readonly long[] Value=A199204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199204.Bytes);
public long this[int i]=>Value[i];

public static A199204Inst Instance=new A199204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}