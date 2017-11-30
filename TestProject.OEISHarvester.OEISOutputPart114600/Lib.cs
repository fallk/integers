using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A280345
{
public static readonly long[] Value={ 3L,7L,12L,25L,48L,97L,192L,385L,768L,1537L,3072L,6145L,12288L,24577L,49152L,98305L,196608L,393217L,786432L,1572865L,3145728L,6291457L,12582912L,25165825L,50331648L,100663297L,201326592L,402653185L,805306368L,1610612737L,3221225472L,6442450945L,12884901888L };
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
public class A280345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280345Inst : IEnumerable<long>
{
public static readonly long[] Value=A280345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280345.Bytes);
public long this[int i]=>Value[i];

public static A280345Inst Instance=new A280345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280346
{
public static readonly BigInteger[] Value={ BigInteger.Parse("302231454903657293676544"),BigInteger.Parse("16423203268260658146231467800709255289"),BigInteger.Parse("3308722450212110699485634768279851414263248443603515625"),BigInteger.Parse("827269706064171159838078900184013751038269841857389464208009274449"),BigInteger.Parse("1692892739326831320764318961708001178036611459414853872137348292520966629744627081") };
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
public class A280346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280346Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280346.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280346.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280346Inst Instance=new A280346Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280347
{
public static readonly BigInteger[] Value={ BigInteger.Parse("4835703278458516698824704"),BigInteger.Parse("1330279464729113309844748891857449678409"),BigInteger.Parse("2067951531382569187178521730174907133914530277252197265625"),BigInteger.Parse("1986274564260074954771227439341817016242885890299592103563430267952049"),BigInteger.Parse("24785642596484137367310393918366845247634028377292875541962916350799472426091085092921") };
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
public class A280347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280347Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280347.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280347.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280347Inst Instance=new A280347Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280348
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,4L,1L,7L,1L,2L,3L,6L,1L,2L,3L,4L,6L,12L,1L,2L,4L,8L,1L,3L,5L,15L,1L,13L,1L,2L,3L,6L,9L,18L,1L,2L,3L,4L,6L,12L,1L,2L,4L,7L,14L,28L,1L,2L,7L,14L,1L,2L,3L,4L,6L,8L,12L,24L,1L,2L,3L,4L,6L,8L,12L,24L,1L,31L,1L,2L,3L,6L,9L,18L,1L,3L,13L,39L,1L,2L,4L,5L,10L,20L,1L,2L,3L,6L,7L,14L,21L,42L,1L,2L,4L,8L,16L,32L,1L,2L,3L,4L,6L,9L,12L,18L,36L };
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
public class A280348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280348Inst : IEnumerable<long>
{
public static readonly long[] Value=A280348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280348.Bytes);
public long this[int i]=>Value[i];

public static A280348Inst Instance=new A280348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280349
{
public static readonly BigInteger[] Value={ BigInteger.Parse("309485009821345068724781056"),BigInteger.Parse("969773729787523602876821942164080815560161"),BigInteger.Parse("32311742677852643549664402033982923967414535582065582275390625"),BigInteger.Parse("233683216210633558353880137011125430143959282107856711392134007594290612801"),BigInteger.Parse("43909277783870034878569768760415886733743786946105343887995366053338664170638348798300219681") };
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
public class A280349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280349Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280349.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280349.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280349Inst Instance=new A280349Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280350
{
public static readonly BigInteger[] Value={ BigInteger.Parse("79228162514264337593543950336"),BigInteger.Parse("6362685441135942358474828762538534230890216321"),BigInteger.Parse("12621774483536188886587657044524579674771302961744368076324462890625"),BigInteger.Parse("1347137238494276547832006567721872890819326613454654477690085519113574118965817601"),BigInteger.Parse("9412343651268540526001186511911506574868063110469548823950876000379062365652829504091329792873336961") };
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
public class A280350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280350Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280350.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280350.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280350Inst Instance=new A280350Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280351
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,9L,37L,121L,331L,793L,1717L,3433L,6436L,11441L,19449L,31825L,50389L,77521L,116281L,170545L,245158L,346105L,480701L,657802L,888058L,1184419L,1564435L,2063206L,2799487L,4272049L,8544097L,23535821L,77331981L,262534537L,865287625L,2720095405L };
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
public class A280351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280351Inst : IEnumerable<long>
{
public static readonly long[] Value=A280351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280351.Bytes);
public long this[int i]=>Value[i];

public static A280351Inst Instance=new A280351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280352
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,12L,22L,43L,85L,164L,308L,573L,1079L,2081L,4097L,8129L,16049L,31315L,60402L,115806L,222416L,430791L,843987L,1670054L,3322167L,6606936L,13078586L,25714238L,50230292L,97708338L,189921842L,370216757L,725680489L,1431888173L,2842060970L,5662371069L };
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
public class A280352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280352Inst : IEnumerable<long>
{
public static readonly long[] Value=A280352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280352.Bytes);
public long this[int i]=>Value[i];

public static A280352Inst Instance=new A280352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280353
{
public static readonly long[] Value={ 1L,9L,36L,180L,225L,441L,450L,468L,625L,1089L,1476L,1521L,1620L,1800L,2025L,2178L,2340L,2601L,3249L,3600L,4050L,4500L,4761L,5202L,5625L,6561L,7569L,8100L,8649L,8712L,9522L,10000L,12321L,13572L,15129L,15138L,16200L,16641L,19881L,20808L,22500L,23400L,25281L,26244L,28224L,28800L };
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
public class A280353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280353Inst : IEnumerable<long>
{
public static readonly long[] Value=A280353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280353.Bytes);
public long this[int i]=>Value[i];

public static A280353Inst Instance=new A280353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280354
{
public static readonly long[] Value={ 1561L,1651L,5346L,6435L,157661L,166751L,301134L,321853L,358123L,431103L,507955L,511665L,517055L,537495L,539946L,550715L,559705L,566115L,576908L,594735L,649935L,729287L,765677L,776567L,782927L,809675L,834498L,894438L,896898L,898698L,905289L,982509L,1257912L,1473302L };
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
public class A280354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280354Inst : IEnumerable<long>
{
public static readonly long[] Value=A280354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280354.Bytes);
public long this[int i]=>Value[i];

public static A280354Inst Instance=new A280354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280355
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,132L,312L,4112L,11133L,11313L,11331L,13113L,13131L,13311L,22112L,31113L,31131L,31311L,33111L,111216L,111612L,112116L,116112L,121116L,161112L,211116L,611112L,1111712L,11111232L,11112132L,11112312L,11113212L,11118112L,11121132L,11121312L,11123112L,11131212L,11132112L };
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
public class A280355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280355Inst : IEnumerable<long>
{
public static readonly long[] Value=A280355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280355.Bytes);
public long this[int i]=>Value[i];

public static A280355Inst Instance=new A280355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280356
{
public static readonly long[] Value={ 0L,1L,3L,4L,4L,4L,3L,3L,5L,5L,4L,5L,6L,5L,2L,3L,7L,8L,7L,7L,8L,5L,1L,4L,9L,8L,5L,7L,8L,6L,3L,8L,14L,11L,7L,8L,7L,4L,4L,8L,13L,9L,4L,8L,8L,5L,4L,8L,11L,5L,5L,8L,8L,6L,4L,6L,9L,6L,6L,10L,6L,2L,3L,4L,10L,10L,9L,13L,12L,7L,2L,7L,11L,9L,7L,9L,6L,2L,3L,7L };
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
public class A280356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280356Inst : IEnumerable<long>
{
public static readonly long[] Value=A280356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280356.Bytes);
public long this[int i]=>Value[i];

public static A280356Inst Instance=new A280356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280389
{
public static readonly long[] Value={ 15L,21L,25L,35L,39L,49L,55L,57L,65L,77L,85L,91L,93L,95L,115L,119L,121L,129L,133L,143L,145L,155L,161L,169L,183L,185L,187L,203L,205L,209L,215L,217L,219L,221L,235L,247L,253L,259L,265L,287L,289L,295L,299L,301L,305L,309L,319L,323L,327L,329L,335L,341L,355L,361L,365L,371L,377L,391L,395L,403L };
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
public class A280389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280389Inst : IEnumerable<long>
{
public static readonly long[] Value=A280389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280389.Bytes);
public long this[int i]=>Value[i];

public static A280389Inst Instance=new A280389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280390
{
public static readonly long[] Value={ 25L,125L,127L,128L,216L,289L,343L,347L,625L,736L,1285L,1296L,1792L,2048L,2187L };
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
public class A280390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280390Inst : IEnumerable<long>
{
public static readonly long[] Value=A280390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280390.Bytes);
public long this[int i]=>Value[i];

public static A280390Inst Instance=new A280390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280391
{
public static readonly long[] Value={ 1L,12L,25L,57L,81L,141L,169L,259L,297L,413L,441L,621L,625L,825L,873L,1079L,1089L,1403L,1369L,1739L,1729L,2021L,2025L,2507L,2433L,2859L,2905L,3301L,3249L,4029L,3721L,4509L,4305L,4793L,4989L,5551L,5329L,6027L,6025L,6807L,6561L,7917L,7225L,8357L,8121L,8677L,8649L,9843L,9481L,10889L };
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
public class A280391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280391Inst : IEnumerable<long>
{
public static readonly long[] Value=A280391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280391.Bytes);
public long this[int i]=>Value[i];

public static A280391Inst Instance=new A280391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280392
{
public static readonly long[] Value={ 0L,2L,14L,74L,358L,1666L,7582L,33978L,150486L,660210L,2873870L,12427562L,53438534L,228667234L,974321278L,4135894426L,17498014902L,73809808338L,310510228206L,1303124892170L,5456835485990L,22804685613122L,95128117129054L };
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
public class A280392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280392Inst : IEnumerable<long>
{
public static readonly long[] Value=A280392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280392.Bytes);
public long this[int i]=>Value[i];

public static A280392Inst Instance=new A280392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280393
{
public static readonly long[] Value={ 2L,6L,66L,554L,4250L,31242L,223706L,1571978L,10887706L,74545802L,505624538L,3402833418L,22750442266L,151248129802L,1000625900506L,6591782458762L,43261686405658L,282980475181450L,1845507292321242L,12003609559311114L };
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
public class A280393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280393Inst : IEnumerable<long>
{
public static readonly long[] Value=A280393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280393.Bytes);
public long this[int i]=>Value[i];

public static A280393Inst Instance=new A280393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280394
{
public static readonly long[] Value={ 2L,16L,238L,3002L,35676L,410670L,4627308L,51310794L,561854184L,6090082758L,65460724868L,698687410882L,7412843182912L,78243277276350L,822166850058812L,8605199231211962L,89752467840352056L,933213129479013558L };
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
public class A280394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280394Inst : IEnumerable<long>
{
public static readonly long[] Value=A280394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280394.Bytes);
public long this[int i]=>Value[i];

public static A280394Inst Instance=new A280394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280395
{
public static readonly ulong[] Value={ 8L,34L,769L,15476L,292622L,5338004L,95102542L,1664838008L,28747146050L,490958066148L,8309711235070L,139594601552248L,2330194531344066L,38685611296842452L,639226798432600750L,10518756259067233176UL };
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
public class A280395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280395Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A280395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280395.Bytes);
public ulong this[int i]=>Value[i];

public static A280395Inst Instance=new A280395Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280396
{
public static readonly BigInteger[] Value={ 14L,76L,2432L,78540L,2366358L,68842232L,1958524652L,54763698930L,1510604213832L,41217398832370L,1114647477686056L,29920032719159886L,798082603602737708L,BigInteger.Parse("21173055142435829418"),BigInteger.Parse("559088423986703320232"),BigInteger.Parse("14702530200374705949828") };
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
public class A280396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280396Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280396.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280396.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280396Inst Instance=new A280396Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280397
{
public static readonly BigInteger[] Value={ 36L,158L,7440L,388686L,18736311L,874372050L,39877186802L,1785907191220L,78870855453277L,3444569084276494L,149070940550252478L,6402525766461308426L,BigInteger.Parse("273223888032122659020"),BigInteger.Parse("11595632519907543615784"),BigInteger.Parse("489776602503009888381042") };
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
public class A280397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280397Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280397.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280397.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280397Inst Instance=new A280397Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280398
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,0L,2L,6L,14L,0L,8L,16L,66L,74L,0L,14L,34L,238L,554L,358L,0L,36L,76L,769L,3002L,4250L,1666L,0L,74L,158L,2432L,15476L,35676L,31242L,7582L,0L,168L,336L,7440L,78540L,292622L,410670L,223706L,33978L,0L,358L,698L,22494L,388686L,2366358L,5338004L };
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
public class A280398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280398Inst : IEnumerable<long>
{
public static readonly long[] Value=A280398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280398.Bytes);
public long this[int i]=>Value[i];

public static A280398Inst Instance=new A280398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280399
{
public static readonly long[] Value={ 0L,0L,2L,2L,8L,14L,36L,74L,168L,358L,780L,1666L,3568L,7582L,16084L,33978L,71608L,150486L,315548L,660210L,1378688L,2873870L,5980772L,12427562L,25787208L,53438534L,110605356L,228667234L,472247568L,974321278L,2008294900L,4135894426L };
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
public class A280399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280399Inst : IEnumerable<long>
{
public static readonly long[] Value=A280399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280399.Bytes);
public long this[int i]=>Value[i];

public static A280399Inst Instance=new A280399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280400
{
public static readonly long[] Value={ 0L,2L,6L,16L,34L,76L,158L,336L,698L,1460L,3030L,6296L,13042L,27004L,55822L,115296L,237866L,490308L,1009734L,2077736L,4271970L,8776972L,18019966L,36972016L,75808154L,155344596L,318145718L,651204536L,1332235218L,2724122780L,5567550190L };
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
public class A280400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280400Inst : IEnumerable<long>
{
public static readonly long[] Value=A280400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280400.Bytes);
public long this[int i]=>Value[i];

public static A280400Inst Instance=new A280400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280401
{
public static readonly long[] Value={ 0L,14L,66L,238L,769L,2432L,7440L,22494L,66934L,197146L,575042L,1664510L,4785950L,13683634L,38931434L,110291246L,311272806L,875559938L,2455439762L,6867568958L,19161061470L,53342827474L,148202912538L,410993902254L,1137828238230L };
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
public class A280401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280401Inst : IEnumerable<long>
{
public static readonly long[] Value=A280401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280401.Bytes);
public long this[int i]=>Value[i];

public static A280401Inst Instance=new A280401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280402
{
public static readonly long[] Value={ 0L,74L,554L,3002L,15476L,78540L,388686L,1909332L,9276316L,44749702L,214274388L,1020029010L,4829443432L,22761611592L,106838241882L,499686947334L,2329557905400L,10829426646892L,50212611191750L,232275648633150L };
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
public class A280402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280402Inst : IEnumerable<long>
{
public static readonly long[] Value=A280402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280402.Bytes);
public long this[int i]=>Value[i];

public static A280402Inst Instance=new A280402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280403
{
public static readonly long[] Value={ 0L,358L,4250L,35676L,292622L,2366358L,18736311L,146853252L,1138334886L,8744869344L,66639459103L,504226940280L,3791507476987L,28354207289578L,211028658043521L,1563987940294912L,11548040454805380L,84985576020376086L };
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
public class A280403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280403Inst : IEnumerable<long>
{
public static readonly long[] Value=A280403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280403.Bytes);
public long this[int i]=>Value[i];

public static A280403Inst Instance=new A280403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280404
{
public static readonly long[] Value={ 0L,1666L,31242L,410670L,5338004L,68842232L,874372050L,10989663174L,136908921742L,1690267696260L,20713635101862L,252098542020936L,3050075961754870L,36706018506588918L,439673171758668484L,5244607430822259138L };
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
public class A280404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280404Inst : IEnumerable<long>
{
public static readonly long[] Value=A280404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280404.Bytes);
public long this[int i]=>Value[i];

public static A280404Inst Instance=new A280404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280453
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,3L,3L,6L,8L,8L,8L,12L,16L,16L,16L,24L,30L,33L,33L,45L,53L,59L,59L,75L,93L,102L,106L,126L,154L,166L,174L,204L,242L,270L,282L,331L,379L,423L,439L,507L,583L,643L,681L,768L,886L,962L,1022L,1138L,1300L,1425L,1507L,1687L,1893L,2086L,2190L,2434L };
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
public class A280453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280453Inst : IEnumerable<long>
{
public static readonly long[] Value=A280453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280453.Bytes);
public long this[int i]=>Value[i];

public static A280453Inst Instance=new A280453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280454
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,2L,1L,0L,0L,1L,2L,1L,0L,0L,1L,3L,2L,0L,0L,1L,3L,3L,1L,0L,1L,4L,4L,1L,0L,1L,4L,5L,2L,0L,1L,5L,7L,3L,0L,1L,5L,8L,5L,1L,1L,6L,10L,6L,1L,1L,6L,12L,9L,2L,1L,7L,14L,11L,3L,1L,7L,16L,15L,5L,1L,8L,19L,18L,7L,2L,8L,21L,23L,10L,2L,9L,24L,27L,13L,3L,9L,27L,34L,18L,4L,10L,30L,39L,23L,6L,10L };
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
public class A280454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280454Inst : IEnumerable<long>
{
public static readonly long[] Value=A280454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280454.Bytes);
public long this[int i]=>Value[i];

public static A280454Inst Instance=new A280454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280455
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,3L,3L,5L,4L,5L,2L,4L,4L,5L,5L,4L,6L,5L,5L,3L,4L,6L,7L,3L,5L,3L,8L,3L,8L,7L,6L,5L,4L,7L,3L,4L,6L,8L,4L,5L,4L,12L,5L,8L,5L,6L,4L,5L,8L,5L,4L,7L,7L,6L,5L,7L,8L,5L,9L,6L,6L,5L,10L,8L,6L,3L,7L,8L,7L,4L,6L,7L,9L,3L,5L,4L,8L,7L,9L,13L };
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
public class A280455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280455Inst : IEnumerable<long>
{
public static readonly long[] Value=A280455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280455.Bytes);
public long this[int i]=>Value[i];

public static A280455Inst Instance=new A280455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280456
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,1L,2L,1L,0L,0L,0L,1L,3L,2L,0L,0L,0L,1L,3L,3L,1L,0L,0L,1L,4L,4L,1L,0L,0L,1L,4L,5L,2L,0L,0L,1L,5L,7L,3L,0L,0L,1L,5L,8L,5L,1L,0L,1L,6L,10L,6L,1L,0L,1L,6L,12L,9L,2L,0L,1L,7L,14L,11L,3L,0L,1L,7L,16L,15L,5L,0L,1L,8L,19L,18L,7L,1L,1L,8L,21L,23L,10L,1L,1L,9L,24L };
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
public class A280456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280456Inst : IEnumerable<long>
{
public static readonly long[] Value=A280456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280456.Bytes);
public long this[int i]=>Value[i];

public static A280456Inst Instance=new A280456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280457
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,1L,3L,2L,0L,0L,0L,0L,1L,3L,3L,1L,0L,0L,0L,1L,4L,4L,1L,0L,0L,0L,1L,4L,5L,2L,0L,0L,0L,1L,5L,7L,3L,0L,0L,0L,1L,5L,8L,5L,1L,0L,0L,1L,6L,10L,6L,1L,0L,0L,1L,6L,12L,9L,2L,0L,0L,1L,7L,14L,11L,3L,0L,0L,1L,7L,16L,15L,5L };
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
public class A280457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280457Inst : IEnumerable<long>
{
public static readonly long[] Value=A280457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280457.Bytes);
public long this[int i]=>Value[i];

public static A280457Inst Instance=new A280457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280458
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,120L,720L,15120L,241920L,6531840L,130636800L,7185024000L,172440576000L,13450364928000L,564915326976000L,33894919618560000L,2169274855587840000L,BigInteger.Parse("295021380359946240000"),BigInteger.Parse("15931154539437096960000"),BigInteger.Parse("2724227426243743580160000"),BigInteger.Parse("217938194099499486412800000") };
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
public class A280458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280458Inst Instance=new A280458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280459
{
public static readonly BigInteger[] Value={ 1L,1L,11L,1010L,111L,110100L,1101L,11101111L,11000L,1111011011L,111100L,111110100101L,1100111L,11111101100100L,11100101L,1111111010100111L,110100100L,111111110110100001L,1111101001L,11111111101000011001UL,11011001001L,BigInteger.Parse("1111111111011010001001"),111110101001L };
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
public class A280459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280459Inst Instance=new A280459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280460
{
public static readonly ulong[] Value={ 1L,10L,110L,101L,11100L,1011L,1011000L,11110111L,110000L,1101101111L,111100000L,101001011111L,1110011000000L,100110111111L,101001110000000L,1110010101111111L,100101100000000L,100001011011111111L,1001011111000000000L,10011000010111111111UL };
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
public class A280460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280460Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A280460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280460.Bytes);
public ulong this[int i]=>Value[i];

public static A280460Inst Instance=new A280460Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280461
{
public static readonly long[] Value={ 1L,1L,3L,10L,7L,52L,13L,239L,24L,987L,60L,4005L,103L,16228L,229L,65191L,420L,261537L,1001L,1047065L,1737L,4191881L,4009L,16771185L,6997L,67099387L,15882L,268411631L,27432L,1073704235L,64812L,4294870829L,107567L,17179714856L,255787L,68719084584L,451883L };
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
public class A280461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280461Inst : IEnumerable<long>
{
public static readonly long[] Value=A280461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280461.Bytes);
public long this[int i]=>Value[i];

public static A280461Inst Instance=new A280461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280462
{
public static readonly long[] Value={ 1L,2L,6L,5L,28L,11L,88L,247L,48L,879L,480L,2655L,7360L,2495L,21376L,58751L,19200L,136959L,310784L,624127L,1207296L,2382847L,4913152L,9312255L,22392832L,58552319L,42196992L,259284991L,43696128L,892190719L,442466304L,3034677247L,8192196608L,1385627647L };
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
public class A280462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280462Inst : IEnumerable<long>
{
public static readonly long[] Value=A280462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280462.Bytes);
public long this[int i]=>Value[i];

public static A280462Inst Instance=new A280462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280463
{
public static readonly ulong[] Value={ 1L,11L,110L,1111L,11000L,111000L,1101000L,11111000L,110001000L,1110010000L,11010111000L,111111101100L,1100000011110L,11100000100011L,110100000100000L,1111100000000000L,11000100000000000L,111001000000000000L,1101011100000000000L,11111110110000000000UL };
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
public class A280463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280463Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A280463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280463.Bytes);
public ulong this[int i]=>Value[i];

public static A280463Inst Instance=new A280463Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280464
{
public static readonly long[] Value={ 1L,11L,11L,1111L,11L,111L,1011L,11111L,100011L,100111L,11101011L,1101111111L,111100000011L,11000100000111L,1000001011L,11111L,100011L,100111L,11101011L,1101111111L,1100000011L,110100000111L,1111000001011L,10000000011111L,110000000100011L,1010000000100111L };
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
public class A280464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280464Inst : IEnumerable<long>
{
public static readonly long[] Value=A280464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280464.Bytes);
public long this[int i]=>Value[i];

public static A280464Inst Instance=new A280464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280465
{
public static readonly long[] Value={ 1L,3L,6L,15L,24L,56L,104L,248L,392L,912L,1720L,4076L,6174L,14371L,26656L,63488L,100352L,233472L,440320L,1043456L,1579008L,3681280L,6831104L,16253952L,25693184L,59773952L,112727040L,267138048L,404235264L,942418944L,1748909056L,4160889856L,6576811008L };
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
public class A280465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280465Inst : IEnumerable<long>
{
public static readonly long[] Value=A280465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280465.Bytes);
public long this[int i]=>Value[i];

public static A280465Inst Instance=new A280465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280466
{
public static readonly long[] Value={ 1L,3L,9L,27L,65L,179L,473L,1163L,2465L,6371L,15785L,36539L };
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
public class A280466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280466Inst : IEnumerable<long>
{
public static readonly long[] Value=A280466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280466.Bytes);
public long this[int i]=>Value[i];

public static A280466Inst Instance=new A280466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280467
{
public static readonly long[] Value={ 1L,3L,3L,15L,3L,7L,11L,31L,35L,39L,235L,895L,3843L,12551L,523L,31L,35L,39L,235L,895L,771L,3335L,7691L,8223L,24611L,40999L,82155L,181119L,295683L,855303L,1981963L,2375711L,6848547L,15794215L,19005675L,54788991L,125829891L,134221063L,402660875L,939532319L };
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
public class A280467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280467Inst : IEnumerable<long>
{
public static readonly long[] Value=A280467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280467.Bytes);
public long this[int i]=>Value[i];

public static A280467Inst Instance=new A280467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280468
{
public static readonly long[] Value={ 4L,16L,187L,245L,1326L,22025L,217076L,2214752L,25047853L,282144055L,694855331L };
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
public class A280468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280468Inst : IEnumerable<long>
{
public static readonly long[] Value=A280468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280468.Bytes);
public long this[int i]=>Value[i];

public static A280468Inst Instance=new A280468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280501
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,6L,7L,1L,7L,6L,1L,6L,1L,7L,1L,1L,1L,18L,19L,20L,21L,1L,1L,6L,1L,1L,7L,7L,1L,6L,1L,1L,1L,6L,7L,18L,1L,19L,1L,20L,1L,21L,1L,1L,7L,6L,1L,6L,7L,1L,1L,1L,19L,18L,1L,7L,1L,6L,1L,20L,1L,1L,21L,1L,21L,6L,1L,20L,1L,7L,1L,18L,1L,1L,1L,19L,1L,6L,7L,20L,1L,1L,7L,21L,1L,6L,1L,1L,1L,18L,1L,6L,7L,1L,19L,6L,1L,7L,1L,1L,7L,6L,1L,1L,1L,106L,107L,108L,109L,1L,1L,7L };
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
public class A280501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280501Inst : IEnumerable<long>
{
public static readonly long[] Value=A280501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280501.Bytes);
public long this[int i]=>Value[i];

public static A280501Inst Instance=new A280501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280502
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,1L,8L,3L,3L,11L,2L,13L,2L,15L,16L,17L,1L,1L,1L,1L,22L,23L,4L,25L,26L,5L,4L,29L,5L,31L,32L,33L,15L,13L,2L,37L,2L,39L,2L,41L,2L,43L,44L,15L,13L,47L,8L,11L,50L,51L,52L,3L,3L,55L,8L,57L,11L,59L,3L,61L,62L,3L,64L,5L,31L,67L,5L,69L,26L,71L,4L,73L,74L,75L,4L,77L,29L,25L,4L,81L,82L,29L,4L,85L,25L,87L,88L,89L,5L,91L,26L,31L,94L,5L,16L,97L,22L,99L,100L,23L,17L };
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
public class A280502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280502Inst : IEnumerable<long>
{
public static readonly long[] Value=A280502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280502.Bytes);
public long this[int i]=>Value[i];

public static A280502Inst Instance=new A280502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280503
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,7L,2L,9L,10L,1L,12L,1L,2L,15L,2L,17L,2L,1L,2L,21L,2L,3L,4L,1L,2L,27L,4L,3L,2L,31L,2L,33L,6L,7L,18L,1L,38L,5L,6L,1L,42L,3L,2L,45L,6L,1L,12L,7L,2L,51L,52L,3L,18L,1L,56L,5L,6L,1L,12L,1L,2L,63L,2L,65L,2L,1L,2L,1L,2L,3L,2L,73L,2L,15L,2L,3L,2L,7L,2L,1L,2L,9L,2L,85L,2L,1L,2L,3L,2L,1L,2L,93L,2L,5L,4L,1L,2L,99L,4L,9L,2L,1L,4L,15L,2L,107L,4L,1L,2L,3L,8L };
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
public class A280503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280503Inst : IEnumerable<long>
{
public static readonly long[] Value=A280503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280503.Bytes);
public long this[int i]=>Value[i];

public static A280503Inst Instance=new A280503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280504
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,1L,4L,1L,1L,11L,1L,13L,7L,1L,8L,1L,9L,19L,10L,1L,11L,13L,6L,25L,13L,1L,7L,11L,15L,1L,16L,1L,15L,13L,2L,37L,1L,11L,12L,41L,1L,25L,22L,1L,13L,47L,4L,11L,25L,1L,1L,19L,3L,55L,1L,13L,11L,59L,5L,61L,31L,1L,32L,1L,33L,67L,34L,69L,35L,61L,36L,1L,37L,13L,38L,59L,39L,25L,40L,81L,41L,11L,42L,1L,43L,87L,44L,55L,45L,91L,46L,1L,47L,19L,24L,97L,49L,1L,25L,13L };
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
public class A280504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280504Inst : IEnumerable<long>
{
public static readonly long[] Value=A280504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280504.Bytes);
public long this[int i]=>Value[i];

public static A280504Inst Instance=new A280504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280505
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,12L,1L,14L,15L,16L,17L,18L,1L,20L,21L,2L,3L,24L,1L,2L,27L,28L,3L,30L,31L,32L,33L,34L,7L,36L,1L,2L,5L,40L,1L,42L,3L,4L,45L,6L,1L,48L,7L,2L,51L,4L,3L,54L,1L,56L,5L,6L,1L,60L,1L,62L,63L,64L,65L,66L,1L,68L,1L,14L,3L,72L,73L,2L,15L,4L,3L,10L,7L,80L,1L,2L,9L,84L,85L,6L,1L,8L,3L,90L,1L,12L,93L,2L,5L,96L,1L,14L,99L,4L,9L,102L,1L,8L,15L,6L };
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
public class A280505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280505Inst : IEnumerable<long>
{
public static readonly long[] Value=A280505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280505.Bytes);
public long this[int i]=>Value[i];

public static A280505Inst Instance=new A280505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280506
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,1L,13L,1L,1L,1L,1L,1L,19L,1L,1L,11L,13L,1L,25L,13L,1L,1L,11L,1L,1L,1L,1L,1L,13L,1L,37L,19L,11L,1L,41L,1L,25L,11L,1L,13L,47L,1L,11L,25L,1L,13L,19L,1L,55L,1L,13L,11L,59L,1L,61L,1L,1L,1L,1L,1L,67L,1L,69L,13L,61L,1L,1L,37L,13L,19L,59L,11L,25L,1L,81L,41L,11L,1L,1L,25L,87L,11L,55L,1L,91L,13L,1L,47L,19L,1L,97L,11L,1L,25L,13L,1L,103L };
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
public class A280506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280506Inst : IEnumerable<long>
{
public static readonly long[] Value=A280506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280506.Bytes);
public long this[int i]=>Value[i];

public static A280506Inst Instance=new A280506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280507
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,0L,0L,7L,7L,6L,6L,6L,6L,7L,7L,1L,1L,0L,0L,0L,0L,1L,1L,6L,6L,7L,7L,7L,7L,6L,6L,19L,19L,18L,18L,18L,18L,19L,19L,20L,20L,21L,21L,21L,21L,20L,20L,18L,18L,19L,19L,19L,19L,18L,18L,21L,21L,20L,20L,20L,20L,21L,21L,21L,21L,20L,20L,20L,20L,21L,21L,18L,18L,19L,19L,19L,19L,18L,18L,20L,20L,21L,21L,21L,21L,20L,20L,19L,19L,18L,18L,18L,18L,19L,19L,6L,6L };
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
public class A280507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280507Inst : IEnumerable<long>
{
public static readonly long[] Value=A280507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280507.Bytes);
public long this[int i]=>Value[i];

public static A280507Inst Instance=new A280507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280508
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,6L,0L,0L,0L,0L,0L,10L,0L,0L,12L,10L,0L,10L,12L,0L,0L,10L,0L,0L,0L,0L,0L,18L,0L,12L,20L,30L,0L,12L,0L,30L,24L,0L,20L,18L,0L,18L,20L,0L,24L,30L,0L,12L,0L,30L,20L,12L,0L,18L,0L,0L,0L,0L,0L,34L,0L,20L,36L,54L,0L,0L,24L,34L,40L,20L,60L,54L,0L,20L,24L,54L,0L,0L,60L,34L,48L,20L,0L,54L,40L,0L,36L,34L,0L,34L,36L,0L,40L,54L,0L,20L,48L };
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
public class A280508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280508Inst : IEnumerable<long>
{
public static readonly long[] Value=A280508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280508.Bytes);
public long this[int i]=>Value[i];

public static A280508Inst Instance=new A280508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280509
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,4L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,2L,4L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,5L,1L,2L,3L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,2L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,4L,1L,1L,2L,1L,1L,2L,2L };
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
public class A280509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280509Inst : IEnumerable<long>
{
public static readonly long[] Value=A280509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280509.Bytes);
public long this[int i]=>Value[i];

public static A280509Inst Instance=new A280509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280510
{
public static readonly long[] Value={ 3L,3L,6L,6L,12L,12L,12L,12L,24L,24L,24L,24L,24L,24L,24L,24L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,192L };
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
public class A280510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280510Inst : IEnumerable<long>
{
public static readonly long[] Value=A280510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280510.Bytes);
public long this[int i]=>Value[i];

public static A280510Inst Instance=new A280510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280511
{
public static readonly long[] Value={ 2L,2L,5L,5L,5L,5L,5L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L };
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
public class A280511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280511Inst : IEnumerable<long>
{
public static readonly long[] Value=A280511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280511.Bytes);
public long this[int i]=>Value[i];

public static A280511Inst Instance=new A280511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280512
{
public static readonly long[] Value={ 1L,3L,2L,1L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,192L,191L,190L,189L,188L };
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
public class A280512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280512Inst : IEnumerable<long>
{
public static readonly long[] Value=A280512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280512.Bytes);
public long this[int i]=>Value[i];

public static A280512Inst Instance=new A280512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280513
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,3L,2L,1L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,89L,88L,87L,86L,85L,84L,83L,82L,81L,80L,79L,78L,77L,76L,75L,74L };
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
public class A280513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280513Inst : IEnumerable<long>
{
public static readonly long[] Value=A280513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280513.Bytes);
public long this[int i]=>Value[i];

public static A280513Inst Instance=new A280513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280514
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,5L,4L,3L,2L,1L,8L,7L,6L,5L,4L,3L,2L,1L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L };
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
public class A280514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280514Inst : IEnumerable<long>
{
public static readonly long[] Value=A280514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280514.Bytes);
public long this[int i]=>Value[i];

public static A280514Inst Instance=new A280514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280515
{
public static readonly long[] Value={ 288L,450L,2640L,5778L,379632L,588042L,2907680L,3041514L };
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
public class A280515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280515Inst : IEnumerable<long>
{
public static readonly long[] Value=A280515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280515.Bytes);
public long this[int i]=>Value[i];

public static A280515Inst Instance=new A280515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280516
{
public static readonly long[] Value={ 1184L,1210L,6232L,6368L,10744L,10856L,66928L,66992L,522405L,525915L,643336L,652664L };
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
public class A280516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280516Inst : IEnumerable<long>
{
public static readonly long[] Value=A280516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280516.Bytes);
public long this[int i]=>Value[i];

public static A280516Inst Instance=new A280516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280581
{
public static readonly long[] Value={ 1L,3L,8L,7L,36L,1728L,64L,225L,13L,5832L,1728L,21952L,196L,331776L,331776L,31L,5832L,1521L,8000L,3111696L,32768L,10077696L,331776L,46656000000L,31L,3111696L,2560000L,9834496L,810000L,139314069504L,32768L,250047L,254803968L,8503056L,254803968L,8281L,1444L };
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
public class A280581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280581Inst : IEnumerable<long>
{
public static readonly long[] Value=A280581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280581.Bytes);
public long this[int i]=>Value[i];

public static A280581Inst Instance=new A280581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280582
{
public static readonly BigInteger[] Value={ 1L,2L,3L,64L,5L,10077696L,7L,2097152L,729L,1000000000L,11L,BigInteger.Parse("2116471057875484488839167999221661362284396544"),13L,20661046784L,38443359375L,36028797018963968L,17L,BigInteger.Parse("52655678627806560751363688397557640770141543227981824"),19L };
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
public class A280582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280582Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280582.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280582.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280582Inst Instance=new A280582Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280583
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,8L,2L,8L,3L,8L,2L,36L,2L,8L,8L,5L,2L,36L,2L,36L,8L,8L,2L,64L,3L,8L,8L,36L,2L,64L,2L,36L,8L,8L,8L,27L,2L,8L,8L,64L,2L,64L,2L,36L,36L,8L,2L,100L,3L,36L,8L,36L,2L,64L,8L,64L,8L,8L,2L,1728L,2L,8L,36L,7L,8L,64L,2L,36L,8L,64L,2L,1728L,2L,8L,36L,36L,8L };
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
public class A280583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280583Inst : IEnumerable<long>
{
public static readonly long[] Value=A280583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280583.Bytes);
public long this[int i]=>Value[i];

public static A280583Inst Instance=new A280583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280584
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,10L,11L,24L,53L,83L,97L,156L,157L,162L,182L,233L,355L,499L,629L,1252L,6378L,8366L,26406L,35345L };
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
public class A280584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280584Inst : IEnumerable<long>
{
public static readonly long[] Value=A280584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280584.Bytes);
public long this[int i]=>Value[i];

public static A280584Inst Instance=new A280584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280585
{
public static readonly long[] Value={ 3L,0L,6L,1L,4L,6L,7L,4L,5L,8L,9L,2L,0L,7L,1L,8L,1L,7L,3L,8L,2L,7L,6L,7L,9L,8L,7L,2L,2L,4L,3L,1L,9L,0L,9L,3L,4L,0L,9L,0L,7L,5L,6L,4L,9L,9L,8L,8L,5L,0L,1L,6L,3L,3L,1L,4L,7L,0L,4L,0L,5L,0L,8L,5L,0L,2L,0L,3L,6L,8L,2L,7L,1L,6L,8L,0L,7L,1L,7L,5L,3L,7L,8L,9L,6L,1L,1L,0L,2L,8L,2L,7L,3L,8L,2L,6L,8L,3L,7L,7L,1L,8L,7L,3L,9L };
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
public class A280585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280585Inst : IEnumerable<long>
{
public static readonly long[] Value=A280585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280585.Bytes);
public long this[int i]=>Value[i];

public static A280585Inst Instance=new A280585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280586
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,2L,1L,0L,0L,2L,1L,0L,0L,4L,2L,1L,0L,4L,2L,1L,0L,6L,5L,2L,2L,6L,5L,2L,2L,10L,8L,5L,4L,12L,8L,5L,4L,16L,14L,8L,9L,18L,16L,8L,9L,24L,23L,15L,14L,30L,25L,18L,14L,36L,36L,26L,25L,42L,42L,29L,28L,52L,54L,42L,40L,65L,60L,50L,43L,78L,78L,65L,63L,93L,92L,73L,72L,110L,117L,96L,94L,135L,133L,114L,103L,158L,166L,145L };
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
public class A280586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280586Inst : IEnumerable<long>
{
public static readonly long[] Value=A280586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280586.Bytes);
public long this[int i]=>Value[i];

public static A280586Inst Instance=new A280586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280587
{
public static readonly long[] Value={ 81L,121L,343L,361L,529L,649L,841L,961L,1219L,1331L,1537L,1633L,1837L,1849L,1909L,1969L,2047L,2209L,2401L,2497L,2773L,2809L,2959L,3113L,3127L,3151L,3223L,3421L,3481L,3487L,3841L,3901L,3953L,4189L,4321L,4399L,4531L,4661L,4741L,4829L,4897L,4913L,5041L,5129L,5137L,5191L,5269L,5401L,5539L,5753L };
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
public class A280587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280587Inst : IEnumerable<long>
{
public static readonly long[] Value=A280587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280587.Bytes);
public long this[int i]=>Value[i];

public static A280587Inst Instance=new A280587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280588
{
public static readonly long[] Value={ 1L,1L,2L,9L,18L,41L,58L,97L,130L,185L,226L,313L,354L,457L,538L,649L,738L,889L,954L,1145L,1266L,1449L,1578L,1809L,1930L,2177L,2362L,2609L,2770L,3129L,3242L,3609L,3810L,4097L,4402L,4793L,5026L,5433L,5674L,6097L,6346L,6929L,7090L,7641L,8010L,8433L,8810L,9369L,9626L,10297L,10690L };
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
public class A280588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280588Inst : IEnumerable<long>
{
public static readonly long[] Value=A280588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280588.Bytes);
public long this[int i]=>Value[i];

public static A280588Inst Instance=new A280588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280589
{
public static readonly long[] Value={ 1L,1L,6L,24L,14L,240L,878L,1872L,34560L,143840L,542880L,4421376L,27644438L,97250652L,1666163520L,10523628456L,30946448412L,779556556800L,5873176163328L,15288823623792L,633207380826720L,6399554302310400L,22325251164046200L,594616643557427040L,5146116019164933120L };
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
public class A280589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280589Inst : IEnumerable<long>
{
public static readonly long[] Value=A280589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280589.Bytes);
public long this[int i]=>Value[i];

public static A280589Inst Instance=new A280589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280590
{
public static readonly long[] Value={ 1L,3L,5L,6L,11L,17L,24L,26L,27L,29L,38L,41L,59L,71L,101L,107L,125L,137L,149L,158L,179L,191L,197L,206L,218L,227L,239L,269L,281L,311L,344L,347L,419L,431L,446L,458L,461L,521L,536L,569L,599L,617L,641L,659L,698L,809L,821L,827L,857L,878L,881L,1019L,1031L,1049L,1061L };
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
public class A280590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280590Inst : IEnumerable<long>
{
public static readonly long[] Value=A280590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280590.Bytes);
public long this[int i]=>Value[i];

public static A280590Inst Instance=new A280590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280591
{
public static readonly long[] Value={ 1L,10L,17L,20L,21L,41L,65L,66L,73L,132L,133L,137L,138L,148L,165L,170L,257L,258L,265L,276L,322L,337L,338L,517L,521L,522L,529L,545L,546L,553L,577L,581L,585L,593L,641L,642L,644L,645L,658L,673L,676L,682L,1032L,1033L,1044L,1097L,1153L,1169L,1172L,1193L,1289L,1297L,1316L,1321L,1361L,1364L,1365L };
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
public class A280591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280591Inst : IEnumerable<long>
{
public static readonly long[] Value=A280591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280591.Bytes);
public long this[int i]=>Value[i];

public static A280591Inst Instance=new A280591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280592
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,15L,16L,20L,24L,30L,185L,219L,273L,285L,292L,296L,304L,315L,364L,370L,380L,432L,438L,444L,456L,468L,504L,540L,546L,570L,630L,3235L,5176L,6470L,7764L,46843L,47423L,47693L,48053L,50431L,52403L,56231L,57965L,59555L,62855L,67655L,67865L,70735L,72123L,72297L,73473L };
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
public class A280592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280592Inst : IEnumerable<long>
{
public static readonly long[] Value=A280592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280592.Bytes);
public long this[int i]=>Value[i];

public static A280592Inst Instance=new A280592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280593
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,14L,21L,23L,25L,32L,36L,41L,45L,47L,52L,54L,56L,58L,63L,65L,69L,74L,78L,85L,87L,89L,96L,98L,123L,125L,145L,147L,214L,236L,254L,256L,258L,321L,325L,365L,369L,412L,452L,456L,458L,478L,521L,523L,541L,547L,563L,569L,587L,589L,632L,652L,654L,658L,698L,741L,745L,785L,789L };
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
public class A280593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280593Inst : IEnumerable<long>
{
public static readonly long[] Value=A280593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280593.Bytes);
public long this[int i]=>Value[i];

public static A280593Inst Instance=new A280593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280594
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,14L,21L,23L,25L,32L,36L,41L,45L,47L,52L,54L,56L,58L,63L,65L,69L,74L,78L,80L,85L,87L,89L,96L,98L,123L,125L,145L,147L,214L,236L,254L,256L,258L,321L,325L,365L,369L,412L,452L,456L,458L,478L,521L,523L,541L,547L,563L,569L,580L,587L,589L,632L,652L,654L,658L,698L,741L };
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
public class A280594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280594Inst : IEnumerable<long>
{
public static readonly long[] Value=A280594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280594.Bytes);
public long this[int i]=>Value[i];

public static A280594Inst Instance=new A280594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280595
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,14L,21L,23L,25L,32L,36L,41L,45L,47L,52L,54L,56L,58L,63L,65L,69L,70L,74L,78L,80L,85L,87L,89L,96L,98L,123L,125L,145L,147L,214L,236L,254L,256L,258L,321L,325L,365L,369L,412L,452L,456L,458L,470L,478L,521L,523L,541L,547L,563L,569L,580L,587L,589L,632L,652L,654L,658L };
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
public class A280595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280595Inst : IEnumerable<long>
{
public static readonly long[] Value=A280595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280595.Bytes);
public long this[int i]=>Value[i];

public static A280595Inst Instance=new A280595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280596
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,0L,1L,1L,2L,0L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,3L,1L,1L,3L,3L,1L,1L,3L,3L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,4L,3L,1L,4L,4L,3L,1L,4L,5L,3L,2L,4L,6L,3L,2L,4L,6L,4L,2L,4L,6L,4L,2L,4L,6L,4L,2L,4L,7L,4L,2L,4L,7L,5L,2L };
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
public class A280596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280596Inst : IEnumerable<long>
{
public static readonly long[] Value=A280596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280596.Bytes);
public long this[int i]=>Value[i];

public static A280596Inst Instance=new A280596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280629
{
public static readonly BigInteger[] Value={ 1L,1L,7L,139L,6913L,508921L,57888967L,9313574419L,1984690709953L,547467006437041L,188946742298214727L,BigInteger.Parse("79783392959511537499"),BigInteger.Parse("40498043815904027702593"),BigInteger.Parse("24314800861291379306213161"),BigInteger.Parse("17047720745682515427867108487"),BigInteger.Parse("13802952030641885344209574247779"),BigInteger.Parse("12780883488499783875309105315925633"),BigInteger.Parse("13420910251496135926622603184056054881"),BigInteger.Parse("15863354775169518855398667975850797997447"),BigInteger.Parse("20966527201075972453953302254528386060431659") };
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
public class A280629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280629Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280629.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280629.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280629Inst Instance=new A280629Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280630
{
public static readonly long[] Value={ 4L,9L,8L,0L,9L,8L,5L,0L,8L,3L,9L,8L,6L,3L,6L,0L,4L,3L,7L,3L,4L,2L,9L,2L,2L,3L,9L,3L,9L,7L,4L,6L,2L,7L,6L,1L,5L,6L,0L,4L,1L,5L,8L,6L,3L,2L,5L,0L,4L,2L,7L,7L,6L,5L,0L,5L,6L,5L,9L,2L,2L,4L,3L,0L,0L,1L,8L,1L,3L,4L,4L,8L,6L,0L,3L,9L,6L,5L,4L,1L };
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
public class A280630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280630Inst : IEnumerable<long>
{
public static readonly long[] Value=A280630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280630.Bytes);
public long this[int i]=>Value[i];

public static A280630Inst Instance=new A280630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280631
{
public static readonly long[] Value={ 0L,24L,1L,43L,19L,762L,640L,3732L,6577L,16061L,247146L,273840L,879326L,5380812L,10593200L };
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
public class A280631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280631Inst : IEnumerable<long>
{
public static readonly long[] Value=A280631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280631.Bytes);
public long this[int i]=>Value[i];

public static A280631Inst Instance=new A280631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280632
{
public static readonly long[] Value={ 1L,3L,4L,9L,10L,11L,14L,25L,38L,74L,110L,133L,145L,469L,1035L,1808L,3323L,4534L,4875L,5306L,16645L,20591L,25904L,29365L,81488L };
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
public class A280632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280632Inst : IEnumerable<long>
{
public static readonly long[] Value=A280632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280632.Bytes);
public long this[int i]=>Value[i];

public static A280632Inst Instance=new A280632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280633
{
public static readonly long[] Value={ 3L,1L,2L,5L,6L,6L,7L,1L,9L,8L,0L,0L,4L,7L,4L,6L,2L,7L,9L,3L,3L,0L,8L,9L,9L,2L,8L,1L,8L,4L,7L,6L,6L,6L,3L,2L,8L,0L,0L,6L,7L,6L,2L,1L,8L,9L,3L,1L,3L,2L,4L,8L,9L,7L,0L,2L,5L,2L,3L,4L,4L,8L,0L,6L,3L,7L,7L,1L,8L,4L,7L,9L,8L,5L,0L,2L,2L,6L,5L,2L,3L,7L,5L,8L,7L,2L,9L,9L,0L,3L,6L,8L,3L,3L,1L,9L,2L,3L,3L,2L,2L,1L,5L,2L,6L };
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
public class A280633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280633Inst : IEnumerable<long>
{
public static readonly long[] Value=A280633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280633.Bytes);
public long this[int i]=>Value[i];

public static A280633Inst Instance=new A280633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280634
{
public static readonly long[] Value={ 1L,1L,0L,0L,2L,0L,1L,1L,1L,2L,0L,1L,2L,0L,1L,1L,0L,2L,1L,0L,2L,1L,0L,3L,0L,1L,1L,0L,2L,1L,1L,2L,0L,2L,0L,2L,2L,1L,1L,3L,1L,2L,1L,1L,2L,3L,0L,5L,2L,2L,1L,2L,2L,3L,1L,4L,1L,4L,0L,5L,1L,2L,1L,3L,1L,3L,1L,3L,1L,5L,0L,7L,1L,3L,1L,3L,2L,3L,1L,5L,0L,6L,0L,7L,1L,3L,1L,5L,0L,3L };
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
public class A280634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280634Inst : IEnumerable<long>
{
public static readonly long[] Value=A280634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280634.Bytes);
public long this[int i]=>Value[i];

public static A280634Inst Instance=new A280634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280635
{
public static readonly long[] Value={ 111L,122L,133L,144L,155L,166L,177L,188L,199L,212L,224L,236L,248L,313L,326L,339L,414L,428L,515L,616L,717L,818L,919L,2510L,2612L,2714L,2816L,2918L,3412L,3515L,3618L,3721L,3824L,3927L,4312L,4416L,4520L,4624L,4728L,4832L,4936L,5210L,5315L,5420L,5525L,5630L,5735L };
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
public class A280635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280635Inst : IEnumerable<long>
{
public static readonly long[] Value=A280635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280635.Bytes);
public long this[int i]=>Value[i];

public static A280635Inst Instance=new A280635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280636
{
public static readonly long[] Value={ 111L,122L,133L,155L,166L,177L,326L,339L,515L,717L,818L,2918L,3721L,5315L,6742L,7214L,7642L,9327L,9763L,11111L,11333L,11555L,12929L,13333L,13535L,13565L,13791L,13939L,14114L,14141L,14242L,14545L,15115L,15151L,15353L,15454L,15757L,16161L,16565L };
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
public class A280636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280636Inst : IEnumerable<long>
{
public static readonly long[] Value=A280636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280636.Bytes);
public long this[int i]=>Value[i];

public static A280636Inst Instance=new A280636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280637
{
public static readonly long[] Value={ 1L,2L,5L,1L,8L,8L,10L,5L,11L,10L,2L,5L,10L,8L,17L,10L,14L,11L,10L,11L,5L,10L,17L,8L,19L,14L,20L,10L,20L,14L,10L,17L,8L,10L,14L,11L,19L,11L,14L,10L,8L,17L,19L,14L,20L,10L,11L,5L,10L,8L,8L,10L,14L,11L,19L,11L,14L,10L,17L,17L,10L,14L,20L,19L,20L,14L,19L,17L,17L,19L,14L };
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
public class A280637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280637Inst : IEnumerable<long>
{
public static readonly long[] Value=A280637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280637.Bytes);
public long this[int i]=>Value[i];

public static A280637Inst Instance=new A280637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280638
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,4L,2L,12L,16L,6L,8L,8L,2L,4L,8L,4L,10L,8L,12L,12L,16L,64L,8L,8L,64L,16L,64L,16L,16L,64L,4L,8L,4L,16L,48L,16L,8L,8L,8L,8L,16L,2L,128L,16L,32L,16L,64L,16L,4L,16L,8L,24L,16L,8L,2L,576L,8L,8L,16L,8L,128L,4L,128L,16L,8L,64L,8L,8L,16L,16L };
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
public class A280638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280638Inst : IEnumerable<long>
{
public static readonly long[] Value=A280638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280638.Bytes);
public long this[int i]=>Value[i];

public static A280638Inst Instance=new A280638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280639
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,2L,0L,0L,4L,0L,0L,0L,0L,0L,8L,0L,2L,2L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,12L,0L,2L,2L,2L,4L,0L,0L,0L,12L,0L,0L,0L,4L,0L,0L,0L,0L,0L,16L,0L,2L,2L,2L,2L,0L,0L,0L,0L,0L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,20L,0L,2L,2L,2L,2L,6L,4L };
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
public class A280639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280639Inst : IEnumerable<long>
{
public static readonly long[] Value=A280639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280639.Bytes);
public long this[int i]=>Value[i];

public static A280639Inst Instance=new A280639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280640
{
public static readonly long[] Value={ 0L,30L,40L,42L,100L,101L,115L,116L,123L,126L,135L,163L,164L,171L,199L,200L,201L,214L,468L,479L,487L,498L,500L,502L,513L,520L,525L,543L,557L,562L,564L,575L,576L,577L,578L,579L,585L,596L,600L,615L,623L,642L,656L,661L,666L,690L,695L,697L,700L,705L,709L,717L,721L };
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
public class A280640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280640Inst : IEnumerable<long>
{
public static readonly long[] Value=A280640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280640.Bytes);
public long this[int i]=>Value[i];

public static A280640Inst Instance=new A280640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280641
{
public static readonly long[] Value={ 1L,6L,8L,23L,44L,45L,102L,106L,110L,114L,117L,121L,137L,148L,152L,153L,162L,168L,176L,185L,189L,194L,206L,210L,478L,488L,512L,533L,553L,560L,574L,580L,626L,639L,655L,662L,669L,671L,676L,682L,683L,684L,685L,693L,704L,710L,730L,731L,737L,742L,758L,761L,767L,771L };
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
public class A280641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280641Inst : IEnumerable<long>
{
public static readonly long[] Value=A280641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280641.Bytes);
public long this[int i]=>Value[i];

public static A280641Inst Instance=new A280641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280642
{
public static readonly long[] Value={ 5L,9L,103L,113L,133L,146L,151L,154L,165L,180L,198L,202L,470L,473L,493L,496L,504L,507L,521L,531L,538L,542L,566L,569L,581L,591L,593L,599L,612L,618L,620L,650L,654L,673L,681L,686L,703L,711L,715L,728L,729L,732L,740L,779L,801L,829L,841L,850L,855L,856L,857L,858L,874L };
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
public class A280642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280642Inst : IEnumerable<long>
{
public static readonly long[] Value=A280642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280642.Bytes);
public long this[int i]=>Value[i];

public static A280642Inst Instance=new A280642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280643
{
public static readonly long[] Value={ 29L,34L,39L,46L,118L,125L,141L,142L,155L,161L,170L,211L,213L,477L,489L,511L,522L,526L,529L,535L,554L,573L,582L,586L,589L,631L,632L,633L,645L,663L,680L,691L,699L,723L,733L,744L,747L,770L,785L,790L,816L,817L,832L,854L,859L,863L,869L,873L,878L,892L,897L,901L,923L };
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
public class A280643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280643Inst : IEnumerable<long>
{
public static readonly long[] Value=A280643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280643.Bytes);
public long this[int i]=>Value[i];

public static A280643Inst Instance=new A280643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280644
{
public static readonly long[] Value={ 7L,104L,112L,140L,143L,158L,166L,186L,188L,195L,465L,467L,490L,541L,558L,572L,595L,598L,604L,605L,606L,607L,613L,616L,622L,625L,630L,634L,635L,640L,643L,647L,653L,667L,675L,679L,687L,702L,712L,718L,720L,727L,734L,738L,759L,764L,783L,787L,802L,810L,815L,818L };
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
public class A280644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280644Inst : IEnumerable<long>
{
public static readonly long[] Value=A280644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280644.Bytes);
public long this[int i]=>Value[i];

public static A280644Inst Instance=new A280644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280677
{
public static readonly BigInteger[] Value={ 41L,4568L,181640L,9439606L,474736149L,23952262535L,1208240638772L,60949510593245L,3074564570571027L,155095359625755139L,7823728447342567501L,BigInteger.Parse("394665220545896300250"),BigInteger.Parse("19908746786901511218365"),BigInteger.Parse("1004289676988490253656371") };
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
public class A280677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280677.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280677Inst Instance=new A280677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280678
{
public static readonly BigInteger[] Value={ 122L,34096L,2642832L,287101721L,29920114246L,3130289979912L,327452072560351L,34253681605884733L,3583141682779617309L,BigInteger.Parse("374819732160862162533"),BigInteger.Parse("39208546724956189523288"),BigInteger.Parse("4101465758881532501508232") };
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
public class A280678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280678Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280678.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280678.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280678Inst Instance=new A280678Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280679
{
public static readonly long[] Value={ 36L,9L,4L,144L,16L,9L,225L,100L,36L,400L,25L,16L,784L,441L,144L,900L,36L,25L,1225L,196L,100L,1600L,576L,225L,1764L,49L,36L,2025L,1296L,400L,3136L,64L,49L,3969L,324L,196L,4356L,3025L,900L,4900L,900L,441L,5184L,81L,64L,5929L,1936L,784L,7056L,3600L,1225L };
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
public class A280679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280679Inst : IEnumerable<long>
{
public static readonly long[] Value=A280679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280679.Bytes);
public long this[int i]=>Value[i];

public static A280679Inst Instance=new A280679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280680
{
public static readonly long[] Value={ 6L,3L,2L,12L,4L,3L,15L,10L,6L,20L,5L,4L,28L,21L,12L,30L,6L,5L,35L,14L,10L,40L,24L,15L,42L,7L,6L,45L,36L,20L,56L,8L,7L,63L,18L,14L,66L,55L,30L,70L,30L,21L,72L,9L,8L,77L,44L,28L,84L,60L,35L,88L,33L,24L,90L,10L,9L,91L,78L,42L,99L,22L,18L,104L,65L,40L };
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
public class A280680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280680Inst : IEnumerable<long>
{
public static readonly long[] Value=A280680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280680.Bytes);
public long this[int i]=>Value[i];

public static A280680Inst Instance=new A280680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280681
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,18L,24L,30L,36L,42L,48L,54L,60L,72L,84L,90L,96L,108L,114L,120L,126L,132L,138L,144L,150L,156L,162L };
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
public class A280681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280681Inst : IEnumerable<long>
{
public static readonly long[] Value=A280681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280681.Bytes);
public long this[int i]=>Value[i];

public static A280681Inst Instance=new A280681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280682
{
public static readonly long[] Value={ 0L,4L,5L,6L,7L,8L,16L,17L,18L,19L,20L,21L,22L,23L,24L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L };
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
public class A280682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280682Inst : IEnumerable<long>
{
public static readonly long[] Value=A280682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280682.Bytes);
public long this[int i]=>Value[i];

public static A280682Inst Instance=new A280682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280683
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,3L,2L,0L,0L,2L,2L,0L,2L,3L,2L,1L,2L,4L,0L,0L,2L,6L,2L,0L,2L,4L,4L,1L,4L,5L,4L,0L,4L,8L,6L,2L,0L,5L,4L,4L,4L,6L,4L,0L,4L,8L,10L,0L,2L,4L,6L,3L,6L,9L,4L,3L,6L,14L,8L,2L,4L,5L,8L,3L,10L,8L,4L,0L,8L,12L,4L,4L,4L,8L,6L,8L,12L,11L,6L,2L,10L,12L,12L,4L,8L,12L,12L,5L,12L,10L,4L,6L };
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
public class A280683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280683Inst : IEnumerable<long>
{
public static readonly long[] Value=A280683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280683.Bytes);
public long this[int i]=>Value[i];

public static A280683Inst Instance=new A280683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280684
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,9L,2L,7L,4L,9L,2L,28L,2L,9L,9L,11L,2L,28L,2L,28L,9L,9L,2L,65L,4L,9L,7L,28L,2L,125L,2L,16L,9L,9L,9L,100L,2L,9L,9L,65L,2L,125L,2L,28L,28L,9L,2L,126L,4L,28L,9L,28L,2L,65L,9L,65L,9L,9L,2L,637L,2L,9L,28L,22L,9L,125L,2L,28L,9L,125L,2L,247L,2L,9L,28L };
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
public class A280684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280684Inst : IEnumerable<long>
{
public static readonly long[] Value=A280684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280684.Bytes);
public long this[int i]=>Value[i];

public static A280684Inst Instance=new A280684Inst();

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