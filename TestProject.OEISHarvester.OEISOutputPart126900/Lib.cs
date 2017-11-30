using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A156205
{
public static readonly BigInteger[] Value={ 1L,-1L,-15L,47L,1185L,-6241L,-230895L,1704527L,83860545L,-796079041L,-48942778575L,567864586607L,41893214676705L,-574448847467041L,-49441928730798255L,782259922208550287L,BigInteger.Parse("76946148390480577665"),BigInteger.Parse("-1379749466246228538241"),BigInteger.Parse("-152682246738275154625935") };
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
public class A156205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156205Inst Instance=new A156205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156206
{
public static readonly BigInteger[] Value={ 1L,-7L,-8L,679L,712L,-55447L,-173528L,76401143L,79667272L,-11285650537L,-58837937048L,20376570109189L,63739859095432L,-13043993481939427L,-95206619832302168L,BigInteger.Parse("179847781675544019751"),BigInteger.Parse("187526908256964757192"),BigInteger.Parse("-50184461824867212568117") };
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
public class A156206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156206Inst Instance=new A156206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156207
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,8L,10L };
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
public class A156207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156207Inst : IEnumerable<long>
{
public static readonly long[] Value=A156207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156207.Bytes);
public long this[int i]=>Value[i];

public static A156207Inst Instance=new A156207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156208
{
public static readonly long[] Value={ 2L,3L,5L,7L,3L,5L,7L,11L,13L,17L,19L,2L,3L,5L,7L,11L,13L,17L,19L,5L,7L,11L,13L,17L,19L,23L,7L,11L,13L,17L,19L,23L,11L,13L,17L,19L,23L,7L,13L,19L,3L,5L,11L,17L,23L,29L,7L,13L,19L,31L,11L,17L,23L,29L,13L,19L,31L,37L,17L,23L,29L,41L,19L,31L,37L,43L,2L,5L,11L,17L,23L,29L,7L,13L,19L,31L,11L };
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
public class A156208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156208Inst : IEnumerable<long>
{
public static readonly long[] Value=A156208.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156208.Bytes);
public long this[int i]=>Value[i];

public static A156208Inst Instance=new A156208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156209
{
public static readonly long[] Value={ 1L,3L,7L,13L,24L,39L,62L,97L,147L,215L,312L,440L,617L,851L,1161L,1569L,2098L,2778L,3649L,4764L,6163L,7939L,10160L,12924L,16361L,20613L,25833L,32259L,40097L,49667L,61272L,75337L,92306L,112755L,137272L,166654L,201734L,243582L,293288L };
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
public class A156209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156209Inst : IEnumerable<long>
{
public static readonly long[] Value=A156209.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156209.Bytes);
public long this[int i]=>Value[i];

public static A156209Inst Instance=new A156209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156210
{
public static readonly long[] Value={ 3L,7L,11L,29L,41L,43L,47L,59L,67L,71L,101L,103L,127L,131L,139L,151L,163L,179L,191L,199L,223L,239L,251L,263L,281L,283L,307L,311L,331L,347L,359L,367L,401L,419L,431L,449L,461L,463L,479L,487L,491L,509L,521L,523L,547L,563L,569L,599L,607L,619L,641L,643L,659L,709L };
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
public class A156210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156210Inst : IEnumerable<long>
{
public static readonly long[] Value=A156210.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156210.Bytes);
public long this[int i]=>Value[i];

public static A156210Inst Instance=new A156210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156211
{
public static readonly BigInteger[] Value={ 1L,2L,26L,732L,116390L,40513052L,137522735588L,643647384796344L,BigInteger.Parse("34588935490621449862"),BigInteger.Parse("3492521559898834682830380"),BigInteger.Parse("2281778066215315012669841569932"),BigInteger.Parse("2900138372618260977222563124493089544") };
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
public class A156211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156211Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156211.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156211.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156211Inst Instance=new A156211Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156212
{
public static readonly BigInteger[] Value={ 1L,2L,26L,732L,116390L,74067484L,206309321188L,2332635556428984L,BigInteger.Parse("108379291296448423558"),BigInteger.Parse("20417630652420537229303340"),BigInteger.Parse("15592143220454380480367922739340") };
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
public class A156212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156212Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156212.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156212.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156212Inst Instance=new A156212Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156213
{
public static readonly BigInteger[] Value={ 1L,2L,26L,1756L,577190L,846763548L,5293107304932L,138013765804872888L,BigInteger.Parse("14838375909837963204230"),BigInteger.Parse("6530915607537754235471687212"),BigInteger.Parse("11710315776946229385945240614099084") };
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
public class A156213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156213Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156213.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156213Inst Instance=new A156213Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156214
{
public static readonly BigInteger[] Value={ 1L,2L,14L,256L,18734L,6932928L,11550075900L,80606017093632L,2307293302418365718L,BigInteger.Parse("268696321569450570148864"),BigInteger.Parse("126770971088210751226430473604"),BigInteger.Parse("241680859880056839468193961216049152") };
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
public class A156214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156214Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156214.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156214Inst Instance=new A156214Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156215
{
public static readonly long[] Value={ 1L,-5L,27L,-41L,146L,-243L,510L,-887L,1755L,-2728L,5052L,-7857L,13157L,-20253L,32805L,-48680L,76568L,-112320L,169814L,-246263L,365013L,-519046L,755632L,-1063368L,1516404L,-2112551L,2972160L,-4089098L,5683166L,-7750782L,10633276L,-14382932L,19539387L };
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
public class A156215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156215Inst : IEnumerable<long>
{
public static readonly long[] Value=A156215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156215.Bytes);
public long this[int i]=>Value[i];

public static A156215Inst Instance=new A156215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156216
{
public static readonly BigInteger[] Value={ 1L,1L,5L,26L,634L,32928L,5704263L,2470113915L,2978904483553L,9401949327631932L,BigInteger.Parse("79268874871208384494"),BigInteger.Parse("1762019469678472912173354"),BigInteger.Parse("103537245443913551792800303420"),BigInteger.Parse("16030602885085486700462431379649694") };
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
public class A156216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156216Inst Instance=new A156216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156217
{
public static readonly BigInteger[] Value={ 1L,1L,5L,26L,634L,2273L,502568L,821149L,323391480L,1514316108L,360153555251L,440146271717L,19353735645240631L,19423959923754863L,1599762850473552085L,BigInteger.Parse("35664862808194240282"),BigInteger.Parse("45517618403498070780338"),BigInteger.Parse("45844669861151626268272") };
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
public class A156217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156217Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156217.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156217.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156217Inst Instance=new A156217Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156218
{
public static readonly long[] Value={ 1L,18L,81L,2916L,6561L,118098L,531441L,38263752L,43046721L,774840978L,3486784401L,125524238436L,282429536481L,5083731656658L,22876792454961L,3294258113514384L,1853020188851841L,33354363399333138L,150094635296999121L };
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
public class A156218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156218Inst : IEnumerable<long>
{
public static readonly long[] Value=A156218.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156218.Bytes);
public long this[int i]=>Value[i];

public static A156218Inst Instance=new A156218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156219
{
public static readonly BigInteger[] Value={ 1L,-5L,-14L,545L,1330L,-45125L,-325934L,62271385L,149716210L,-9199961075L,-110578403054L,16611095045315L,119791661123890L,-10633558277471225L,-178929901418355374L,BigInteger.Parse("146613250885940140025"),BigInteger.Parse("352435300540743552370"),BigInteger.Parse("-40910747987067422049575") };
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
public class A156219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156219Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156219.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156219Inst Instance=new A156219Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156220
{
public static readonly BigInteger[] Value={ -2L,-2L,3L,-2L,3L,-1L,-2L,3L,-1L,109L,-2L,3L,-1L,325L,1555523L,-2L,3L,-1L,973L,32671835L,49621794478165L,-2L,3L,-1L,2917L,686126051L,15630874866123949L,BigInteger.Parse("27744919164118690798376051"),-2L,3L,-1L,8749L,14408699579L };
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
public class A156220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156220Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156220.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156220.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156220Inst Instance=new A156220Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156221
{
public static readonly long[] Value={ 3L,5L,11L,13L,19L,31L,41L,43L,53L,59L,113L,131L,139L,149L,151L,191L,193L,311L,349L,359L,419L,431L,439L,491L,541L,593L,911L,941L,953L,1153L,1193L,1319L,1439L,1451L,1453L,1459L,1493L,1531L,1543L,1549L,1913L,1931L,1951L,3119L,3191L,3491L,3511L,3541L,3911L,4139L };
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
public class A156221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156221Inst : IEnumerable<long>
{
public static readonly long[] Value=A156221.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156221.Bytes);
public long this[int i]=>Value[i];

public static A156221Inst Instance=new A156221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156222
{
public static readonly BigInteger[] Value={ -2L,-6L,9L,-18L,21L,-15L,-54L,57L,-51L,375L,-162L,165L,-159L,1131L,4666413L,-486L,489L,-483L,3399L,98015025L,148865383434975L,-1458L,1461L,-1455L,10203L,2058376701L,46892624598373299L,BigInteger.Parse("83234757492356072395126701"),-4374L,4377L,-4371L,30615L };
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
public class A156222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156222Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156222.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156222.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156222Inst Instance=new A156222Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156223
{
public static readonly long[] Value={ 1L,4L,27L,108L,256L,1024L,3125L,6912L,12500L,27648L,46656L,84375L,186624L,337500L,800000L,823543L,1259712L,3200000L,3294172L,5038848L,11943936L,16777216L,21600000L,22235661L,47775744L,67108864L };
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
public class A156223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156223Inst : IEnumerable<long>
{
public static readonly long[] Value=A156223.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156223.Bytes);
public long this[int i]=>Value[i];

public static A156223Inst Instance=new A156223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156224
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,3L,10L,10L,3L,3L,18L,22L,18L,3L,5L,28L,58L,58L,28L,5L,7L,46L,103L,158L,103L,46L,7L,9L,68L,187L,313L,313L,187L,68L,9L,11L,94L,306L,614L,698L,614L,306L,94L,11L,15L,133L,502L,1174L,1636L,1636L,1174L,502L,133L,15L,19L,188L,763L,2038L,3358L,4030L,3358L,2038L,763L };
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
public class A156224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156224Inst : IEnumerable<long>
{
public static readonly long[] Value=A156224.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156224.Bytes);
public long this[int i]=>Value[i];

public static A156224Inst Instance=new A156224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156225
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,3L,42L,42L,3L,3L,128L,262L,128L,3L,5L,340L,1810L,1810L,340L,5L,7L,958L,8335L,19326L,8335L,958L,7L,9L,2468L,38635L,140569L,140569L,38635L,2468L,9L,11L,6022L,160686L,970572L,1561898L,970572L,160686L,6022L,11L,15L,15193L,669758L,6372686L };
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
public class A156225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156225Inst : IEnumerable<long>
{
public static readonly long[] Value=A156225.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156225.Bytes);
public long this[int i]=>Value[i];

public static A156225Inst Instance=new A156225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156226
{
public static readonly long[] Value={ 37L,577L,1297L,2917L,4357L,7057L,8101L,14401L,15877L,22501L,24337L,32401L,41617L,44101L,57601L,69697L,72901L,90001L,93637L,147457L,156817L,176401L,197137L,224677L,324901L,331777L,352837L,404497L,427717L,476101L,484417L,509797L,562501L };
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
public class A156226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156226Inst : IEnumerable<long>
{
public static readonly long[] Value=A156226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156226.Bytes);
public long this[int i]=>Value[i];

public static A156226Inst Instance=new A156226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156227
{
public static readonly long[] Value={ 0L,1L,3L,8L,3L,1L,0L,8L,6L,1L,6L,8L,0L,1L,3L,8L,3L,1L,0L,8L,6L,1L,6L,8L,0L,1L,3L,8L,3L,1L,0L,8L,6L,1L,6L,8L,0L,1L,3L,8L,3L,1L,0L,8L,6L,1L,6L,8L };
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
public class A156227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156227Inst : IEnumerable<long>
{
public static readonly long[] Value=A156227.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156227.Bytes);
public long this[int i]=>Value[i];

public static A156227Inst Instance=new A156227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156228
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,7L,31L,98L,446L,1894L,9049L,43151L };
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
public class A156228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156228Inst : IEnumerable<long>
{
public static readonly long[] Value=A156228.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156228.Bytes);
public long this[int i]=>Value[i];

public static A156228Inst Instance=new A156228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156229
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,5L,7L,8L,8L,9L,10L,11L,12L,13L,13L,14L,16L,16L,17L,17L,18L,20L,21L,21L,22L,23L,23L,24L,25L,26L,27L,29L,29L,29L,30L,30L,32L,33L,34L,35L,35L,35L,37L,38L,38L,39L,41L,41L,42L,43L,43L,45L,45L,45L,45L,47L,49L,50L,51L,51L,52L };
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
public class A156229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156229Inst : IEnumerable<long>
{
public static readonly long[] Value=A156229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156229.Bytes);
public long this[int i]=>Value[i];

public static A156229Inst Instance=new A156229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156230
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L };
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
public class A156230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156230Inst : IEnumerable<long>
{
public static readonly long[] Value=A156230.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156230.Bytes);
public long this[int i]=>Value[i];

public static A156230Inst Instance=new A156230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156231
{
public static readonly long[] Value={ 1L,0L,6L,8L,24L,48L,106L,192L,369L,624L,1080L,1728L,2787L,4248L,6498L,9528L,13962L,19824L,28066L,38760L,53334L,71936L,96618L,127680L,167983L,218040L,281784L,360024L,458037L,577080L,724098L,900936L,1116636L,1373808L,1684038L };
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
public class A156231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156231Inst : IEnumerable<long>
{
public static readonly long[] Value=A156231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156231.Bytes);
public long this[int i]=>Value[i];

public static A156231Inst Instance=new A156231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156232
{
public static readonly long[] Value={ 0L,4L,4L,16L,24L,64L,112L,256L,480L,1024L,1984L,4096L,8064L,16384L,32512L,65536L,130560L,262144L,523264L,1048576L,2095104L,4194304L,8384512L,16777216L,33546240L,67108864L,134201344L,268435456L,536838144L,1073741824L,2147418112L };
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
public class A156232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156232Inst : IEnumerable<long>
{
public static readonly long[] Value=A156232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156232.Bytes);
public long this[int i]=>Value[i];

public static A156232Inst Instance=new A156232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156233
{
public static readonly long[] Value={ 2L,1L,1L,1L,6L,1L,1L,37L,37L,1L,1L,226L,606L,226L,1L,1L,1565L,7972L,7972L,1565L,1L,1L,13514L,102407L,187824L,102407L,13514L,1L,1L,150753L,1445555L,3859373L,3859373L,1445555L,150753L,1L,1L,2105142L,23789060L,79955452L,115641606L,79955452L,23789060L };
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
public class A156233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156233Inst : IEnumerable<long>
{
public static readonly long[] Value=A156233.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156233.Bytes);
public long this[int i]=>Value[i];

public static A156233Inst Instance=new A156233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156234
{
public static readonly long[] Value={ 1L,1L,5L,10L,30L,63L,170L,355L,880L,1875L,4349L,9189L,20810L,43355L,95140L,198247L,424527L,875965L,1849535L,3781820L,7873167L,16005196L,32883560L,66390850L,135198990L,271051271L,546931398L,1090751095L,2183512495L,4329540830L };
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
public class A156234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156234Inst : IEnumerable<long>
{
public static readonly long[] Value=A156234.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156234.Bytes);
public long this[int i]=>Value[i];

public static A156234Inst Instance=new A156234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156235
{
public static readonly long[] Value={ 1L,1L,4L,198L,209342L };
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
public class A156235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156235Inst : IEnumerable<long>
{
public static readonly long[] Value=A156235.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156235.Bytes);
public long this[int i]=>Value[i];

public static A156235Inst Instance=new A156235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156236
{
public static readonly BigInteger[] Value={ 5L,12L,70L,210L,11310L,145860L,1560090L,23130030L,2491434660L,200736225690L,1906748513670L,281993526895080L,9427390580377770L,904832960818356570L,BigInteger.Parse("117584828859645537390"),BigInteger.Parse("2928413909631253063020"),BigInteger.Parse("400579656276180828206760") };
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
public class A156236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156236Inst Instance=new A156236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156237
{
public static readonly BigInteger[] Value={ 6L,66L,630L,7140L,103740L,1272810L,56812470L,1722580860L,48098217090L,1850186768430L,139261952960130L,17743036637876550L,741902728913225880L,BigInteger.Parse("21549201398378163510"),BigInteger.Parse("2378522762792139793830"),BigInteger.Parse("351206814022419685159830") };
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
public class A156237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156237Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156237.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156237Inst Instance=new A156237Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156238
{
public static readonly BigInteger[] Value={ 7L,18L,286L,3010L,32890L,769230L,3333330L,159189030L,16015883940L,477463360374L,21643407275490L,1148540321999070L,18489352726664820L,4561561662153109614L,BigInteger.Parse("71000485538666794110"),BigInteger.Parse("14440652550858108745170"),BigInteger.Parse("927869754030522488795610") };
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
public class A156238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156238Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156238.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156238Inst Instance=new A156238Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156239
{
public static readonly BigInteger[] Value={ 8L,21L,280L,1680L,38760L,326040L,10986360L,185040240L,4897368840L,383246454360L,13143876816840L,376306806515640L,27961718389364760L,3250163645572822440L,BigInteger.Parse("152582219844376633080"),BigInteger.Parse("6202664616058189439160"),BigInteger.Parse("1454199694916714984358120") };
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
public class A156239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156239Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156239.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156239.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156239Inst Instance=new A156239Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156240
{
public static readonly long[] Value={ 7L,113L,1808L,28928L,462849L,7405582L,118489311L,1895828980L,30333263677L,485332218825L,7765315501194L,124245048019102L,1987920768305639L,31806732292890228L,508907716686243641L,8142523466979898252L };
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
public class A156240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156240Inst : IEnumerable<long>
{
public static readonly long[] Value=A156240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156240.Bytes);
public long this[int i]=>Value[i];

public static A156240Inst Instance=new A156240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156241
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,1L,-1L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,-1L,0L,0L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,-1L,0L,0L,0L,0L,-1L,0L,0L };
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
public class A156241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156241Inst : IEnumerable<long>
{
public static readonly long[] Value=A156241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156241.Bytes);
public long this[int i]=>Value[i];

public static A156241Inst Instance=new A156241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156242
{
public static readonly long[] Value={ 3L,6L,9L,12L,15L,19L,21L,24L,27L,30L,33L,36L,39L,42L,45L,47L,50L,54L,57L,60L,63L,66L,69L,72L,75L,77L,81L,84L,87L,90L,93L,96L,100L,102L,105L,108L,111L,114L,117L,120L,123L,127L,129L,132L,136L,139L,142L,145L,147L,151L,154L,156L,159L,163L,166L,169L,172L,174L,177L,181L };
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
public class A156242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156242Inst : IEnumerable<long>
{
public static readonly long[] Value=A156242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156242.Bytes);
public long this[int i]=>Value[i];

public static A156242Inst Instance=new A156242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156243
{
public static readonly long[] Value={ 1L,5L,7L,10L,14L,17L,20L,23L,25L,29L,32L,34L,37L,41L,43L,46L,49L,52L,55L,59L,61L,64L,68L,71L,73L,76L,79L,82L,86L,88L,91L,95L,98L,101L,104L,106L,109L,113L,116L,118L,122L,125L,128L,131L,134L,137L,141L,143L,146L,149L,152L,155L,158L,161L,164L,168L,170L,173L,176L,179L,182L };
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
public class A156243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156243Inst : IEnumerable<long>
{
public static readonly long[] Value=A156243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156243.Bytes);
public long this[int i]=>Value[i];

public static A156243Inst Instance=new A156243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156244
{
public static readonly long[] Value={ 4L,11L,16L,22L,28L,35L,40L,48L,53L,58L,65L,70L,78L,83L,89L,94L,99L,107L,112L,119L,124L,130L,135L,140L,148L,153L,160L,165L,171L,178L,184L,190L,197L,203L,208L,215L,220L,226L,231L,238L,244L,249L,256L,261L,269L,274L,281L,287L,294L,299L,305L,310L,317L,322L,328L,335L };
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
public class A156244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156244Inst : IEnumerable<long>
{
public static readonly long[] Value=A156244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156244.Bytes);
public long this[int i]=>Value[i];

public static A156244Inst Instance=new A156244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156245
{
public static readonly long[] Value={ 2L,8L,13L,18L,26L,31L,38L,44L,51L,56L,62L,67L,74L,80L,85L,92L,97L,103L,110L,115L,121L,126L,133L,138L,144L,150L,157L,162L,167L,175L,180L,188L,193L,201L,206L,212L,217L,224L,229L,234L,242L,247L,253L,258L,265L,271L,278L,283L,291L,296L,303L,308L,314L,319L,324L,332L };
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
public class A156245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156245Inst : IEnumerable<long>
{
public static readonly long[] Value=A156245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156245.Bytes);
public long this[int i]=>Value[i];

public static A156245Inst Instance=new A156245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156246
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,10L,12L,13L,15L,17L,18L,19L,21L,22L,23L,25L,27L,28L,30L,31L,32L,34L,36L,37L,38L,40L,41L,43L,44L,45L,47L,49L,50L,52L,53L,54L,56L,58L,59L,61L,63L,64L,66L,68L,69L,71L,72L,73L,75L,76L,77L,79L,81L,82L,84L,85L,86L,88L,90L,91L,93L,94L,96L,98L,99L,100L,102L,103L,105L };
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
public class A156246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156246Inst : IEnumerable<long>
{
public static readonly long[] Value=A156246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156246.Bytes);
public long this[int i]=>Value[i];

public static A156246Inst Instance=new A156246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156247
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,10L,11L,12L,14L,15L,16L,18L,20L,21L,23L,24L,25L,27L,29L,30L,32L,34L,35L,36L,38L,39L,41L,43L,44L,46L,48L,49L,51L,52L,53L,55L,57L,58L,59L,61L,62L,64L,65L,66L,68L,70L,71L,73L,74L,76L,78L,79L,80L,82L,84L,85L,87L,88L,89L,91L,92L,93L,95L,96L,97L,99L,100L,102L,104L,105L };
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
public class A156247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156247Inst : IEnumerable<long>
{
public static readonly long[] Value=A156247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156247.Bytes);
public long this[int i]=>Value[i];

public static A156247Inst Instance=new A156247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156248
{
public static readonly long[] Value={ -2L,-1L,-3L,-1L,-2L,0L,-1L,0L,-2L,-1L,-2L,0L,-2L,-1L,-3L,-2L,-3L,-1L,-3L,-2L,-4L,-2L,-3L,-2L,-4L,-3L,-5L,-3L,-4L,-2L,-4L,-3L,-5L,-4L,-5L,-3L,-5L,-4L,-5L,-3L,-4L,-2L,-3L,-2L,-4L,-2L,-3L,-1L,-2L,0L,-2L,-1L,-2L,0L,-2L,-1L,-3L,-2L,-3L,-1L,-2L,-1L,-3L,-2L,-3L,-1L,-2L,0L,-2L,-1L,-3L };
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
public class A156248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156248Inst : IEnumerable<long>
{
public static readonly long[] Value=A156248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156248.Bytes);
public long this[int i]=>Value[i];

public static A156248Inst Instance=new A156248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156249
{
public static readonly long[] Value={ -1L,1L,0L,1L,-1L,1L,0L,2L,1L,3L,1L,2L,1L,3L,2L,3L,1L,3L,2L,4L,3L,4L,2L,4L,3L,4L,2L,3L,1L,2L,1L,3L,1L,2L,0L,1L,0L,2L,0L,1L,-1L,1L,0L,2L,0L,1L,-1L,0L,-1L,1L,0L,1L,-1L,1L,0L,2L,1L,2L,0L,2L,1L,3L,2L,4L,2L,3L,2L,4L,3L,5L,4L,5L,3L,5L,4L,6L,4L,5L,4L,6L,5L,7L,5L,6L,4L,6L,5L,6L,4L,5L,3L,5L,4L,5L,3L,4L,3L,5L,3L,4L };
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
public class A156249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156249Inst : IEnumerable<long>
{
public static readonly long[] Value=A156249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156249.Bytes);
public long this[int i]=>Value[i];

public static A156249Inst Instance=new A156249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156250
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,4L,4L,5L,6L,6L,7L,8L,8L,8L,9L,9L,9L,10L,11L,11L,12L,12L,12L,13L,13L,14L,15L,15L,15L,16L,16L,16L,17L,17L,18L,19L,19L,20L,21L,21L,21L,22L,22L,23L,24L,24L,25L,25L,25L,26L,26L,26L,27L,28L,28L,29L,30L,30L,30L,31L,31L,32L,33L,33L,34L,35L,35L,35L,36L,36L,36L,37L,37L,38L,39L };
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
public class A156250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156250Inst : IEnumerable<long>
{
public static readonly long[] Value=A156250.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156250.Bytes);
public long this[int i]=>Value[i];

public static A156250Inst Instance=new A156250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156251
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,5L,6L,6L,6L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,18L,18L,19L,19L,19L,20L,20L,21L,21L,21L,21L,22L,22L,22L,23L,23L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,26L };
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
public class A156251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156251Inst : IEnumerable<long>
{
public static readonly long[] Value=A156251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156251.Bytes);
public long this[int i]=>Value[i];

public static A156251Inst Instance=new A156251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156252
{
public static readonly long[] Value={ 43L,53L,71L,97L,131L,173L,223L,281L,347L,421L,503L,593L,691L,797L,911L,1033L,1163L,1301L,1447L,1601L,1933L,2111L,2297L,2693L,2903L,3121L,3347L,3581L,3823L,4073L,4597L,4871L,5153L,5443L,5741L,6047L,6361L,7013L,7351L,8783L,9161L,9547L,9941L,10343L,10753L };
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
public class A156252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156252Inst : IEnumerable<long>
{
public static readonly long[] Value=A156252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156252.Bytes);
public long this[int i]=>Value[i];

public static A156252Inst Instance=new A156252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156253
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,5L,6L,6L,7L,8L,8L,9L,9L,10L,11L,11L,12L,12L,13L,14L,15L,15L,16L,17L,18L,18L,19L,19L,20L,21L,21L,22L,23L,24L,24L,25L,26L,26L,27L,27L,28L,29L,30L,30L,31L,32L,33L,33L,34L,35L,35L,36L,36L,37L,38L,38L,39L,39L,40L,41L,42L,42L,43L,44L,44L,45L,45L,46L,47L,47L,48L,49L,50L };
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
public class A156253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156253Inst : IEnumerable<long>
{
public static readonly long[] Value=A156253.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156253.Bytes);
public long this[int i]=>Value[i];

public static A156253Inst Instance=new A156253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156254
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L };
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
public class A156254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156254Inst : IEnumerable<long>
{
public static readonly long[] Value=A156254.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156254.Bytes);
public long this[int i]=>Value[i];

public static A156254Inst Instance=new A156254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156255
{
public static readonly BigInteger[] Value={ 1L,-1L,-20L,121L,2020L,-10201L,-498860L,14111177L,229352740L,-2085384391L,-169413817100L,3765413859931L,183531216526660L,-2410430851171981L,-274136470848578540L,BigInteger.Parse("33234524120454778969"),BigInteger.Parse("539962197767023975780"),BigInteger.Parse("-9273713631027601262971") };
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
public class A156255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156255Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156255.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156255.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156255Inst Instance=new A156255Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156256
{
public static readonly long[] Value={ 0L,2L,1L,0L,1L,0L,2L,2L,0L,1L,2L,1L,0L,2L,2L,1L,0L,1L,0L,2L,1L,0L,1L,2L,2L,0L,1L,0L,2L,1L,0L,1L,0L,2L,2L,1L,0L,1L,2L,0L,1L,0L,2L,1L,0L,1L,0L,2L,2L,0L,1L,2L,1L,0L,1L,0L,2L,2L,1L,0L,2L,2L,0L,1L,2L,2L,0L,1L,0L,2L,1L,0L,1L,2L,0L,1L,0L,1L,2L,2L,0L,1L,0L,2L,1L,0L,1L,2L,2L,0L,1L,2L,1L,0L,2L,2L,1L,0L,1L,2L };
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
public class A156256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156256Inst : IEnumerable<long>
{
public static readonly long[] Value=A156256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156256.Bytes);
public long this[int i]=>Value[i];

public static A156256Inst Instance=new A156256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156257
{
public static readonly long[] Value={ 2L,1L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L };
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
public class A156257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156257Inst : IEnumerable<long>
{
public static readonly long[] Value=A156257.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156257.Bytes);
public long this[int i]=>Value[i];

public static A156257Inst Instance=new A156257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156258
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L };
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
public class A156258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156258Inst : IEnumerable<long>
{
public static readonly long[] Value=A156258.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156258.Bytes);
public long this[int i]=>Value[i];

public static A156258Inst Instance=new A156258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156259
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L };
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
public class A156259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156259Inst : IEnumerable<long>
{
public static readonly long[] Value=A156259.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156259.Bytes);
public long this[int i]=>Value[i];

public static A156259Inst Instance=new A156259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156260
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,4L,2L,1L,1L,4L,2L,1L,2L,4L,4L,1L,2L,1L,2L,1L,4L,4L,2L,1L,1L,4L,1L,1L,2L,8L,2L,1L,4L,4L,4L,1L,2L,4L,4L,1L,2L,8L,2L,1L,1L,4L,2L,1L,1L,1L,4L,1L,2L,1L,4L,1L,4L,4L,2L,1L,2L,4L,1L,1L,4L,8L,2L,1L,4L,8L,2L,1L,2L,4L,1L };
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
public class A156260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156260Inst : IEnumerable<long>
{
public static readonly long[] Value=A156260.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156260.Bytes);
public long this[int i]=>Value[i];

public static A156260Inst Instance=new A156260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156261
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,3L,4L,4L,5L,6L,6L,6L,7L,7L,8L,9L,9L,9L,10L,10L,10L,11L,12L,12L,13L,13L,13L,14L,14L,14L,15L,16L,16L,17L,17L,17L,18L,19L,19L,20L,21L,21L,22L,23L,23L,23L,24L,24L,25L,25L,25L,26L,27L,27L,27L,28L,28L,29L,30L,30L,31L,31L,32L,33L,33L,34L,34L,34L,35L,35L,35L,36L,37L,37L,38L };
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
public class A156261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156261Inst : IEnumerable<long>
{
public static readonly long[] Value=A156261.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156261.Bytes);
public long this[int i]=>Value[i];

public static A156261Inst Instance=new A156261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156262
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,3L,4L,4L,5L,5L,5L,6L,7L,7L,8L,8L,8L,9L,10L,10L,11L,12L,12L,12L,13L,13L,14L,15L,15L,16L,17L,17L,17L,18L,18L,19L,20L,20L,20L,21L,21L,21L,22L,22L,22L,23L,24L,24L,25L,25L,26L,27L,27L,27L,28L,29L,29L,30L,30L,30L,31L,31L,32L,32L,32L,33L,33L,34L,35L,35L,36L,37L,37L,37L,38L };
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
public class A156262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156262Inst : IEnumerable<long>
{
public static readonly long[] Value=A156262.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156262.Bytes);
public long this[int i]=>Value[i];

public static A156262Inst Instance=new A156262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156263
{
public static readonly long[] Value={ 2L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,1L,1L,2L,2L,2L,2L,1L,2L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L };
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
public class A156263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156263Inst : IEnumerable<long>
{
public static readonly long[] Value=A156263.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156263.Bytes);
public long this[int i]=>Value[i];

public static A156263Inst Instance=new A156263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156264
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,1L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A156264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156264Inst : IEnumerable<long>
{
public static readonly long[] Value=A156264.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156264.Bytes);
public long this[int i]=>Value[i];

public static A156264Inst Instance=new A156264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156265
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,2L,3L,2L,1L,2L,2L,1L,1L,2L,1L,0L,0L,1L,1L,2L,1L,1L,2L,2L,1L,0L,1L,1L,2L,1L,1L,2L,2L,3L,2L,1L,1L,2L,2L,1L,2L,2L,3L,2L,2L,3L,3L,4L,3L,2L,3L,3L,2L,2L,3L,3L,4L,3L,2L,2L,3L,2L,1L,2L,2L,1L,0L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,3L,3L,2L,1L,2L,2L,3L,2L,2L,3L,3L,2L,1L,2L,2L,1L,1L,2L,1L,0L,0L,1L,1L,0L,1L,1L,2L,1L };
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
public class A156265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156265Inst : IEnumerable<long>
{
public static readonly long[] Value=A156265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156265.Bytes);
public long this[int i]=>Value[i];

public static A156265Inst Instance=new A156265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156266
{
public static readonly BigInteger[] Value={ 1L,7L,98L,1715L,33614L,705894L,15529668L,353299947L,8243665430L,196199237234L,4744454282204L,116239129913998L,2879153833254412L,71978845831360300L,1813866914950279560L,BigInteger.Parse("46026872966863343835"),BigInteger.Parse("1175038992212864189670") };
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
public class A156266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156266Inst Instance=new A156266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156267
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,3L,3L,2L,1L,2L,2L,1L,1L,2L,1L,-1L,-1L,1L,1L,2L,1L,1L,2L,2L,1L,-1L,1L,1L,2L,1L,1L,2L,3L,3L,2L,1L,1L,2L,2L,1L,2L,3L,3L,2L,3L,4L,4L,5L,3L,3L,4L,3L,2L,3L,4L,4L,5L,3L,2L,3L,3L,2L,1L,2L,2L,1L,-1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,3L,4L,3L,2L,1L,2L,3L,3L,2L,3L,4L,3L,2L,1L,2L,2L,1L,1L,2L,1L,-1L,-1L,1L,1L,-1L,1L,1L };
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
public class A156267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156267Inst : IEnumerable<long>
{
public static readonly long[] Value=A156267.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156267.Bytes);
public long this[int i]=>Value[i];

public static A156267Inst Instance=new A156267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156268
{
public static readonly long[] Value={ 0L,2L,2L,1L,1L,2L,2L,2L,2L,2L,3L,3L,2L,2L,2L,0L,-1L,1L,2L,2L,2L,1L,1L,2L,0L,0L,2L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,2L,3L,1L,1L,2L,2L,2L,3L,3L,4L,4L,2L,2L,2L,1L,1L,2L,2L,3L,5L,3L,1L,2L,2L,2L,2L,2L,3L,3L,1L,1L,2L,2L,0L,1L,1L,2L,2L,2L,3L,3L,2L,2L,2L,2L,3L,5L,3L,2L,4L,3L,3L,3L,3L,4L,4L,3L,3L,3L,1L,0L,2L,3L,1L,3L,2L,2L,2L };
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
public class A156268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156268Inst : IEnumerable<long>
{
public static readonly long[] Value=A156268.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156268.Bytes);
public long this[int i]=>Value[i];

public static A156268Inst Instance=new A156268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156269
{
public static readonly long[] Value={ 1L,2L,6L,-20L,-24L,-56L,144L,160L,352L,-832L,-896L,-1920L,4352L,4608L,9728L,-21504L,-22528L,-47104L,102400L,106496L,221184L,-475136L,-491520L,-1015808L,2162688L,2228224L,4587520L,-9699328L,-9961472L,-20447232L,42991616L,44040192L,90177536L };
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
public class A156269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156269Inst : IEnumerable<long>
{
public static readonly long[] Value=A156269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156269.Bytes);
public long this[int i]=>Value[i];

public static A156269Inst Instance=new A156269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156270
{
public static readonly BigInteger[] Value={ 1L,8L,128L,2560L,57344L,1376256L,34603008L,899678208L,23991418880L,652566593536L,18034567675904L,504967894925312L,14294475794808832L,408413594137395200L,11762311511156981760UL,BigInteger.Parse("341107033823552471040"),BigInteger.Parse("9952299339793060331520") };
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
public class A156270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156270Inst Instance=new A156270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156271
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,9L,11L,12L,14L,15L,16L,18L,20L,21L,23L,24L,25L,27L,29L,30L,32L,34L,35L,36L,38L,39L,41L,43L,44L,46L,48L,49L,50L,52L,53L,55L,57L,58L,59L,61L,62L,63L,65L,66L,67L,69L,71L,72L,74L,75L,77L,79L,80L,81L,83L,85L,86L,88L,89L,90L,92L,93L,95L,96L,97L,99L,100L,102L,104L,105L };
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
public class A156271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156271Inst : IEnumerable<long>
{
public static readonly long[] Value=A156271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156271.Bytes);
public long this[int i]=>Value[i];

public static A156271Inst Instance=new A156271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156272
{
public static readonly BigInteger[] Value={ 1L,-2L,-9L,59L,981L,-11881L,-295029L,5052179L,167213961L,-3685319761L,-152462570049L,4107372360299L,203906790454941L,-6492149024819641L,-376012858170009069L,13813635108523428419UL,BigInteger.Parse("914353480122881739921"),BigInteger.Parse("-38069496495248009807521") };
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
public class A156272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156272.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156272Inst Instance=new A156272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156273
{
public static readonly BigInteger[] Value={ 1L,9L,162L,3645L,91854L,2480058L,70150212L,2051893701L,61556811030L,1883638417518L,58564030799196L,1844766970174674L,58748732742485772L,1888352123865614100L,BigInteger.Parse("61182608813245896840"),BigInteger.Parse("1996082612532147384405"),BigInteger.Parse("65518476340761072970470"),BigInteger.Parse("2162109719245115408025510") };
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
public class A156273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156273Inst Instance=new A156273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156274
{
public static readonly long[] Value={ 5L,11L,7L,13L,11L,17L,13L,19L,17L,23L,23L,29L,31L,37L,37L,43L,41L,47L,47L,53L,53L,59L,61L,67L,67L,73L,73L,79L,83L,89L,97L,103L,101L,107L,103L,109L,107L,113L,131L,137L,151L,157L,157L,163L,167L,173L,173L,179L,191L,197L,193L,199L,223L,229L,227L,233L,233L,239L,251L,257L };
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
public class A156274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156274Inst : IEnumerable<long>
{
public static readonly long[] Value=A156274.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156274.Bytes);
public long this[int i]=>Value[i];

public static A156274Inst Instance=new A156274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156275
{
public static readonly BigInteger[] Value={ 1L,10L,200L,5000L,140000L,4200000L,132000000L,4290000000L,143000000000L,4862000000000L,167960000000000L,5878600000000000L,208012000000000000L,7429000000000000000L,BigInteger.Parse("267444000000000000000"),BigInteger.Parse("9694845000000000000000"),BigInteger.Parse("353576700000000000000000") };
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
public class A156275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156275Inst Instance=new A156275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156276
{
public static readonly long[] Value={ 1L,5L,100L,250L,10000L,25000L,1000000L,2500000L,100000000L,250000000L,10000000000L,25000000000L,1000000000000L,2500000000000L,100000000000000L,250000000000000L,10000000000000000L,25000000000000000L };
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
public class A156276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156276Inst : IEnumerable<long>
{
public static readonly long[] Value=A156276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156276.Bytes);
public long this[int i]=>Value[i];

public static A156276Inst Instance=new A156276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156277
{
public static readonly long[] Value={ 1L,-1L,0L,0L,-1L,0L,-1L,0L,0L,1L,-1L,0L,-1L,1L,0L,0L,-1L,0L,-1L,0L,0L,1L,-1L,0L,0L,1L,0L,0L,-1L,0L,-1L,0L,0L,1L,1L,0L,-1L,1L,0L,0L,-1L,0L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,1L,-1L,0L,-1L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,-1L,0L,-1L,1L,0L,0L,1L,0L,-1L,0L };
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
public class A156277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156277Inst : IEnumerable<long>
{
public static readonly long[] Value=A156277.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156277.Bytes);
public long this[int i]=>Value[i];

public static A156277Inst Instance=new A156277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156278
{
public static readonly long[] Value={ 1L,1L,1L,1L,9L,1L,1L,52L,44L,1L,1L,270L,716L,187L,1L,1L,1363L,8428L,7069L,762L,1L,1L,6831L,85143L,162039L,60151L,3065L,1L,1L,34174L,790440L,2889288L,2462504L,473162L,12280L,1L,1L,170892L,6972826L,44429208L,72035800L,32668794L,3557734L,49143L,1L,1L,854485L };
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
public class A156278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156278Inst : IEnumerable<long>
{
public static readonly long[] Value=A156278.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156278.Bytes);
public long this[int i]=>Value[i];

public static A156278Inst Instance=new A156278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156279
{
public static readonly long[] Value={ 8L,4L,12L,16L,28L,44L,72L,116L,188L,304L,492L,796L,1288L,2084L,3372L,5456L,8828L,14284L,23112L,37396L,60508L,97904L,158412L,256316L,414728L,671044L,1085772L,1756816L,2842588L,4599404L,7441992L };
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
public class A156279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156279Inst : IEnumerable<long>
{
public static readonly long[] Value=A156279.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156279.Bytes);
public long this[int i]=>Value[i];

public static A156279Inst Instance=new A156279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156280
{
public static readonly long[] Value={ 1L,1L,1L,1L,12L,1L,1L,93L,71L,1L,1L,664L,1618L,370L,1L,1L,4665L,26430L,20112L,1869L,1L,1L,32676L,370035L,645270L,216519L,9368L,1L,1L,228757L,4756581L,15969645L,12502371L,2164135L,46867L,1L,1L,1601328L,58041316L,339432876L,509029014L,212305928L };
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
public class A156280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156280Inst : IEnumerable<long>
{
public static readonly long[] Value=A156280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156280.Bytes);
public long this[int i]=>Value[i];

public static A156280Inst Instance=new A156280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156281
{
public static readonly long[] Value={ 1L,-1L,1L,1L,0L,-2L,1L,-1L,-1L,1L,2L,1L,-3L,1L,1L,2L,1L,-1L,-4L,-2L,0L,3L,3L,-4L,1L,-1L,-3L,-4L,-3L,1L,5L,8L,5L,-1L,-4L,-5L,-3L,3L,6L,-5L,1L,1L,4L,8L,11L,10L,5L,-5L,-15L,-19L,-17L,-7L,5L,13L,9L,7L,-1L,-7L,-8L,1L,10L,-6L,1L,-1L,-5L,-13L,-24L,-34L,-39L,-34L,-17L,9L,38L,59L,63L,50L,26L,-6L };
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
public class A156281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156281Inst : IEnumerable<long>
{
public static readonly long[] Value=A156281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156281.Bytes);
public long this[int i]=>Value[i];

public static A156281Inst Instance=new A156281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156282
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,2L,3L,3L,2L,1L,1L,3L,6L,9L,11L,11L,9L,6L,3L,1L,1L,2L,4L,6L,8L,9L,9L,8L,6L,4L,2L,1L,1L,3L,7L,13L,21L,30L,39L,46L,50L,50L,46L,39L,30L,21L,13L,7L,3L,1L,1L,3L,7L,13L,22L,33L,46L,59L,71L,80L,85L,85L,80L,71L,59L,46L,33L,22L,13L,7L,3L,1L,1L,3L,7L,14L,25L,40L,60L,84L,111L,139L };
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
public class A156282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156282Inst : IEnumerable<long>
{
public static readonly long[] Value=A156282.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156282.Bytes);
public long this[int i]=>Value[i];

public static A156282Inst Instance=new A156282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156283
{
public static readonly long[] Value={ 1L,2L,4L,-4L,-2L,-1L,1L,2L,4L,-4L,-2L,-1L,1L,2L,4L,-4L,-2L,-1L,1L,2L,4L,-4L,-2L,-1L,1L,2L,4L,-4L,-2L,-1L,1L,2L,4L,-4L,-2L,-1L,1L,2L,4L,-4L,-2L,-1L,1L,2L,4L,-4L,-2L,-1L,1L,2L,4L,-4L,-2L,-1L,1L,2L,4L,-4L,-2L,-1L,1L,2L,4L,-4L,-2L,-1L,1L,2L,4L,-4L,-2L,-1L,1L,2L };
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
public class A156283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156283Inst : IEnumerable<long>
{
public static readonly long[] Value=A156283.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156283.Bytes);
public long this[int i]=>Value[i];

public static A156283Inst Instance=new A156283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156284
{
public static readonly long[] Value={ 3L,7L,11L,17L,19L,23L,31L,37L,43L,59L,67L,71L,73L,79L,83L,89L,101L,103L,107L,113L,127L,131L,137L,139L,151L,157L,163L,179L,181L,191L,193L,199L,211L,223L,227L,229L,241L,251L,257L,263L,269L };
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
public class A156284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156284Inst : IEnumerable<long>
{
public static readonly long[] Value=A156284.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156284.Bytes);
public long this[int i]=>Value[i];

public static A156284Inst Instance=new A156284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156285
{
public static readonly BigInteger[] Value={ 1L,-1L,-21L,71L,2541L,-14641L,-771561L,6242711L,437721081L,-4555133281L,-399147115101L,5076970085351L,533834157267621L,-8024733763147921L,-984414289344742641L,17074591123571719991UL,BigInteger.Parse("2393808447230495554161"),BigInteger.Parse("-47056485265721520250561") };
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
public class A156285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156285Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156285.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156285.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156285Inst Instance=new A156285Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156286
{
public static readonly long[] Value={ 1L,1L,10L,1L,140L,1419L,1L,5740L,242649L,3350536L,1L,700280L,165729267L,7853656384L,161827775045L,1L,255602200L,452606628177L,92036999164096L,6040221703554625L,193317016162131576L,1L,279628806800L,4943822199577371L,5392815929021041024L };
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
public class A156286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156286Inst : IEnumerable<long>
{
public static readonly long[] Value=A156286.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156286.Bytes);
public long this[int i]=>Value[i];

public static A156286Inst Instance=new A156286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156287
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,9L,12L,13L,16L,18L,19L,21L,22L,27L,28L,33L,34L,36L,39L,42L,43L,46L,49L,51L,54L,57L,58L,61L,64L,67L,69L,72L,78L,79L,84L,88L,91L,93L,96L,97L,106L,109L,111L,112L,117L,118L,121L,123L,124L,126L,127L,132L,138L,142L,144L,148L,151L,153L,156L,159L,162L,163L,166L };
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
public class A156287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156287Inst : IEnumerable<long>
{
public static readonly long[] Value=A156287.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156287.Bytes);
public long this[int i]=>Value[i];

public static A156287Inst Instance=new A156287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156288
{
public static readonly long[] Value={ 5L,8L,10L,11L,14L,15L,17L,20L,23L,24L,25L,26L,29L,30L,31L,32L,35L,37L,38L,40L,41L,44L,45L,47L,48L,50L,52L,53L,55L,56L,59L,60L,62L,63L,65L,66L,68L,70L,71L,73L,74L,75L,76L,77L,80L,81L,82L,83L,85L,86L,87L,89L,90L,92L,94L,95L,98L,99L,100L,101L,102L,103L,104L,105L,107L,108L,110L };
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
public class A156288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156288Inst : IEnumerable<long>
{
public static readonly long[] Value=A156288.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156288.Bytes);
public long this[int i]=>Value[i];

public static A156288Inst Instance=new A156288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156289
{
public static readonly long[] Value={ 1L,1L,3L,1L,15L,15L,1L,63L,210L,105L,1L,255L,2205L,3150L,945L,1L,1023L,21120L,65835L,51975L,10395L,1L,4095L,195195L,1201200L,1891890L,945945L,135135L,1L,16383L,1777230L,20585565L,58108050L,54864810L,18918900L,2027025L,1L,65535L,16076985L };
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
public class A156289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156289Inst : IEnumerable<long>
{
public static readonly long[] Value=A156289.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156289.Bytes);
public long this[int i]=>Value[i];

public static A156289Inst Instance=new A156289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156290
{
public static readonly long[] Value={ 1L,-4L,1L,15L,-6L,1L,-56L,28L,-8L,1L,210L,-120L,45L,-10L,1L,-792L,495L,-220L,66L,-12L,1L,3003L,-2002L,1001L,-364L,91L,-14L,1L,-11440L,8008L,-4368L,1820L,-560L,120L,-16L,1L,43758L,-31824L,18564L,-8568L,3060L,-816L,153L,-18L,1L,-167960L,125970L,-77520L };
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
public class A156290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156290Inst : IEnumerable<long>
{
public static readonly long[] Value=A156290.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156290.Bytes);
public long this[int i]=>Value[i];

public static A156290Inst Instance=new A156290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156291
{
public static readonly long[] Value={ 1L,3L,8L,21L,104L,315L,105L,1040L,5355L,19344L,3255L,125840L,1826055L,15107664L,86590175L,9765L,880880L,23738715L,317260944L,2684295425L,16476602400L,1240155L,962801840L,129637122615L,6196423497264L,150285647959475L,2261529015616800L };
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
public class A156291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156291Inst : IEnumerable<long>
{
public static readonly long[] Value=A156291.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156291.Bytes);
public long this[int i]=>Value[i];

public static A156291Inst Instance=new A156291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156292
{
public static readonly BigInteger[] Value={ 1L,-9L,-10L,1269L,1310L,-154449L,-476530L,317846493L,326791070L,-70135077879L,-360532916050L,189164275688799L,583443224756030L,-180891788804426709L,-1301832061482312370L,BigInteger.Parse("3725749956010732159581"),BigInteger.Parse("3830467285470508564190"),BigInteger.Parse("-1553024263191639076482939") };
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
public class A156292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156292.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156292Inst Instance=new A156292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156293
{
public static readonly long[] Value={ 1L,22L,121L,5324L,14641L,322102L,1771561L,155897368L,214358881L,4715895382L,25937424601L,1141246682444L,3138428376721L,69045424287862L,379749833583241L,66835970710650416L,45949729863572161L,1010894056998587542L };
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
public class A156293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156293Inst : IEnumerable<long>
{
public static readonly long[] Value=A156293.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156293.Bytes);
public long this[int i]=>Value[i];

public static A156293Inst Instance=new A156293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156294
{
public static readonly long[] Value={ 2L,3L,5L,7L,3L,7L,15L,19L,8L,20L,5L,17L,6L,10L,18L,11L,23L,8L,20L,9L,13L,25L,14L,26L,23L,4L,10L,22L,28L,12L,26L,10L,28L,34L,36L,14L,32L,22L,34L,24L,42L,20L,22L,28L,40L,46L,7L,15L,27L,33L,17L,35L,13L,15L,33L,23L,41L,19L,37L,21L,27L,29L,24L,8L,14L,26L,12L,30L,32L,38L,22L,40L,36L,26L,44L };
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
public class A156294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156294Inst : IEnumerable<long>
{
public static readonly long[] Value=A156294.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156294.Bytes);
public long this[int i]=>Value[i];

public static A156294Inst Instance=new A156294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156295
{
public static readonly BigInteger[] Value={ 1L,-7L,-18L,1099L,2502L,-135247L,-914058L,278640803L,627079302L,-61491355177L,-691854229098L,165853074191329L,1119618748420902L,-158600253933384907L,-2498197283109211338L,BigInteger.Parse("3266621368881927679651"),BigInteger.Parse("7350612843632165455302"),BigInteger.Parse("-1361643264763393114646437") };
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
public class A156295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156295Inst Instance=new A156295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156296
{
public static readonly BigInteger[] Value={ 1L,2L,10L,140L,5740L,700280L,255602200L,279628806800L,917462115110800L,9029662136920493600L,BigInteger.Parse("266600774592577573540000"),BigInteger.Parse("23613897008762965998731960000"),BigInteger.Parse("6274708327065504088149055143160000") };
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
public class A156296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156296.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156296Inst Instance=new A156296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156297
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A156297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156297Inst : IEnumerable<long>
{
public static readonly long[] Value=A156297.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156297.Bytes);
public long this[int i]=>Value[i];

public static A156297Inst Instance=new A156297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156298
{
public static readonly long[] Value={ 31L,41L,43L,53L,61L,71L,73L,83L,97L,101L,103L,107L,109L,211L,307L,311L,313L,317L,401L,409L,419L,421L,431L,433L,439L,503L,509L,521L,523L,541L,547L,601L,607L,613L,617L,619L,631L,641L,643L,647L,653L,659L,701L,709L,719L,727L,733L,739L,743L,751L,757L,761L,769L,809L };
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
public class A156298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156298Inst : IEnumerable<long>
{
public static readonly long[] Value=A156298.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156298.Bytes);
public long this[int i]=>Value[i];

public static A156298Inst Instance=new A156298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156299
{
public static readonly long[] Value={ 31L,41L,43L,53L,61L,71L,73L,83L,97L,211L,311L,401L,421L,431L,433L,503L,521L,523L,541L,601L,613L,631L,641L,643L,653L,701L,733L,743L,751L,761L,811L,821L,823L,827L,853L,857L,863L,877L,907L,911L,937L,941L,947L,953L,967L,971L,977L,983L };
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
public class A156299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156299Inst : IEnumerable<long>
{
public static readonly long[] Value=A156299.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156299.Bytes);
public long this[int i]=>Value[i];

public static A156299Inst Instance=new A156299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156300
{
public static readonly long[] Value={ 2L,3L,7L,13L,19L,43L,61L,67L,79L,97L,109L,127L,151L,163L,181L,211L,223L,229L,277L,307L,331L,373L,379L,397L,457L,463L,523L,601L,607L,613L,673L,727L,733L,751L,757L,853L,883L,907L,919L,967L,1021L,1033L,1069L,1117L,1171L,1201L,1231L,1237L,1321L,1327L,1381L,1399L };
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
public class A156300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156300Inst : IEnumerable<long>
{
public static readonly long[] Value=A156300.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156300.Bytes);
public long this[int i]=>Value[i];

public static A156300Inst Instance=new A156300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156301
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,4L,5L,6L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,12L,13L,14L,14L,15L,16L,16L,17L,18L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,24L,25L,26L,26L,27L,28L,28L,29L,30L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L,43L,43L,44L,45L,45L,46L,47L };
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
public class A156301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156301Inst : IEnumerable<long>
{
public static readonly long[] Value=A156301.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156301.Bytes);
public long this[int i]=>Value[i];

public static A156301Inst Instance=new A156301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156302
{
public static readonly long[] Value={ 1L,1L,5L,10L,30L,57L,152L,289L,676L,1304L,2809L,5335L,10961L,20487L,40329L,74476L,141914L,258094L,479638L,860025L,1563716L,2767982L,4940567L,8636563L,15173805L,26217392L,45416811L,77629455L,132800937L,224695510L,380079521L,637006921L };
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
public class A156302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156302Inst : IEnumerable<long>
{
public static readonly long[] Value=A156302.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156302.Bytes);
public long this[int i]=>Value[i];

public static A156302Inst Instance=new A156302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156303
{
public static readonly long[] Value={ 1L,1L,4L,8L,20L,38L,88L,162L,336L,624L,1211L,2195L,4109L,7295L,13190L,23072L,40618L,69838L,120486L,204006L,345595L,577387L,962961L,1588483L,2613930L,4262138L,6928799L,11179251L,17976330L,28720552L,45729595L,72401921L,114239033L };
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
public class A156303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156303Inst : IEnumerable<long>
{
public static readonly long[] Value=A156303.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156303.Bytes);
public long this[int i]=>Value[i];

public static A156303Inst Instance=new A156303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156304
{
public static readonly long[] Value={ 1L,1L,8L,21L,77L,199L,661L,1663L,4852L,12382L,33289L,82877L,213026L,518109L,1279852L,3053404L,7312985L,17093793L,39952528L,91661695L,209709116L,473095589L,1062567288L,2359804486L,5214774263L,11415904502L,24860918943L,53709881911L };
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
public class A156304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156304Inst : IEnumerable<long>
{
public static readonly long[] Value=A156304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156304.Bytes);
public long this[int i]=>Value[i];

public static A156304Inst Instance=new A156304Inst();

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