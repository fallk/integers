using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A156105
{
public static readonly long[] Value={ 7L,11L,17L,29L,31L,37L,41L,59L,67L,79L,101L,107L,109L,127L,139L,151L,157L,167L,179L,191L,197L,199L,211L,239L,241L,277L,281L,307L,311L,317L,337L,347L,349L,359L,367L,389L,419L,431L,449L,491L,499L,521L,541L,547L,569L,571L,587L,601L,619L,647L,661L,701L,739L,751L };
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
public class A156105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156105Inst : IEnumerable<long>
{
public static readonly long[] Value=A156105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156105.Bytes);
public long this[int i]=>Value[i];

public static A156105Inst Instance=new A156105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156106
{
public static readonly long[] Value={ 1L,3L,15L,99L,783L,6987L,67671L,694035L,7418943L,81800091L,923720679L,10630297827L,124224709455L,1470172954347L,17585028636279L,212248303720371L,2581823992868703L };
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
public class A156106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156106Inst : IEnumerable<long>
{
public static readonly long[] Value=A156106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156106.Bytes);
public long this[int i]=>Value[i];

public static A156106Inst Instance=new A156106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156107
{
public static readonly long[] Value={ 5L,7L,13L,19L,23L,29L,37L,47L,53L,67L,79L,83L,89L,97L,107L,113L,127L,137L,139L,149L,163L,167L,173L,193L,223L,229L,239L,257L,277L,313L,317L,347L,359L,379L,397L,419L,433L,443L,449L,457L,463L,487L,499L,503L,509L,547L,557L,599L,607L,613L,617L,643L,653L,677L,683L };
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
public class A156107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156107Inst : IEnumerable<long>
{
public static readonly long[] Value=A156107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156107.Bytes);
public long this[int i]=>Value[i];

public static A156107Inst Instance=new A156107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156108
{
public static readonly BigInteger[] Value={ 1L,3L,42L,2208L,244752L,46518528L,13507994112L,5562729781248L,3083754373711872L,2214222213310906368L,BigInteger.Parse("1999032386887572652032"),BigInteger.Parse("2216366828444296453029888"),BigInteger.Parse("2960497368303914832695918592"),BigInteger.Parse("4689088728161336381621359607808"),BigInteger.Parse("8689565950333823666093720497815552"),BigInteger.Parse("18626301728606130165475133482365616128") };
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
public class A156108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156108Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156108.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156108.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156108Inst Instance=new A156108Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156109
{
public static readonly long[] Value={ 5L,11L,23L,43L,53L,61L,71L,113L,131L,163L,193L,233L,313L,331L,383L,421L,431L,443L,641L,673L,683L,691L,733L,751L,821L,911L,1013L,1033L,1051L,1213L,1283L,1453L,1531L,1583L,1601L,1723L,1741L,1871L,1913L,1993L,2063L,2143L,2203L,2251L,2381L,2423L,2441L,2503L };
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
public class A156109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156109Inst : IEnumerable<long>
{
public static readonly long[] Value=A156109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156109.Bytes);
public long this[int i]=>Value[i];

public static A156109Inst Instance=new A156109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156110
{
public static readonly long[] Value={ 11L,29L,41L,79L,109L,139L,179L,211L,239L,349L,431L,449L,491L,569L,601L,701L,739L,751L,809L,811L,839L,911L,919L,991L,1021L,1031L,1051L,1091L,1231L,1289L,1301L,1381L,1409L,1471L,1481L,1549L,1759L,1861L,1931L,2011L,2069L,2081L,2221L,2269L,2339L,2459L,2521L };
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
public class A156110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156110Inst : IEnumerable<long>
{
public static readonly long[] Value=A156110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156110.Bytes);
public long this[int i]=>Value[i];

public static A156110Inst Instance=new A156110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156111
{
public static readonly long[] Value={ 5L,13L,19L,23L,29L,53L,79L,83L,89L,113L,139L,149L,163L,173L,193L,223L,239L,313L,379L,443L,449L,503L,599L,613L,643L,683L,709L,733L,739L,743L,809L,839L,919L,953L,1069L,1153L,1163L,1279L,1283L,1289L,1303L,1409L,1453L,1493L,1549L,1553L,1579L,1609L,1723L,1993L,1999L };
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
public class A156111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156111Inst : IEnumerable<long>
{
public static readonly long[] Value=A156111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156111.Bytes);
public long this[int i]=>Value[i];

public static A156111Inst Instance=new A156111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156112
{
public static readonly long[] Value={ 7L,11L,17L,31L,37L,67L,101L,127L,157L,191L,197L,241L,277L,281L,311L,317L,337L,347L,431L,521L,541L,571L,647L,751L,787L,911L,941L,947L,977L,997L,1051L,1151L,1187L,1451L,1487L,1621L,1627L,1877L,2017L,2027L,2237L,2311L,2467L,2521L,2621L,2647L,2657L,2677L,2731L };
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
public class A156112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156112Inst : IEnumerable<long>
{
public static readonly long[] Value=A156112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156112.Bytes);
public long this[int i]=>Value[i];

public static A156112Inst Instance=new A156112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156113
{
public static readonly long[] Value={ 1234657L,1245763L,1246537L,1246573L,1247563L,1254367L,1254637L,1256347L,1257463L,1263547L,1264537L,1264573L,1265347L,1275643L,1276543L,1324567L,1342567L,1342657L,1345627L,1354267L,1356247L,1356427L,1362457L,1425367L };
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
public class A156113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156113Inst : IEnumerable<long>
{
public static readonly long[] Value=A156113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156113.Bytes);
public long this[int i]=>Value[i];

public static A156113Inst Instance=new A156113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156114
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,23L,29L,53L,97L,223L,263L,1481L,1607L,1861L,3527L,4637L,4783L,5839L,13679L,14543L,16057L,19417L,27733L,32359L,43777L,44263L,71327L,80669L,84317L,93479L,115763L,122027L,138559L,160073L,187123L,198823L };
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
public class A156114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156114Inst : IEnumerable<long>
{
public static readonly long[] Value=A156114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156114.Bytes);
public long this[int i]=>Value[i];

public static A156114Inst Instance=new A156114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156115
{
public static readonly long[] Value={ 367603L,367613L,367621L,367637L,367649L,367651L,367663L,367673L,367687L,367699L };
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
public class A156115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156115Inst : IEnumerable<long>
{
public static readonly long[] Value=A156115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156115.Bytes);
public long this[int i]=>Value[i];

public static A156115Inst Instance=new A156115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156116
{
public static readonly long[] Value={ 12421L,12541L,12641L,12653L,12721L,12743L,12763L,12821L,12841L,12853L,12941L,12953L,12973L,12983L,13421L,13721L,13751L,13763L,13831L,13841L,13873L,13921L,13931L,13963L,14543L,14621L,14653L,14731L,14741L,14753L,14821L,14831L,14843L,14851L,14951L,14983L };
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
public class A156116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156116Inst : IEnumerable<long>
{
public static readonly long[] Value=A156116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156116.Bytes);
public long this[int i]=>Value[i];

public static A156116Inst Instance=new A156116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156117
{
public static readonly long[] Value={ 48091L,64091L,116293L,139091L,145091L,162091L,244091L,250091L,276781L,321091L,359783L,456293L,558091L,623071L,666091L,684091L,708091L,771091L,810091L,831091L,836071L,873091L,877091L,897781L,939091L,1032071L,1041091L,1065091L,1087091L };
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
public class A156117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156117Inst : IEnumerable<long>
{
public static readonly long[] Value=A156117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156117.Bytes);
public long this[int i]=>Value[i];

public static A156117Inst Instance=new A156117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156118
{
public static readonly long[] Value={ 155921L,268343L,413353L,1004873L,1140091L,1272749L,1280023L,1357201L,1422367L,1444309L,1451423L,1468079L,1491377L,1553653L,1561919L,1653853L,1655707L,1733449L,1904311L,2045213L,2046553L,2052217L,2116291L,2166319L,2244091L };
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
public class A156118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156118Inst : IEnumerable<long>
{
public static readonly long[] Value=A156118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156118.Bytes);
public long this[int i]=>Value[i];

public static A156118Inst Instance=new A156118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156119
{
public static readonly long[] Value={ 10243L,12043L,20143L,20341L,20431L,23041L,24103L,25463L,25643L,30241L,32401L,36457L,40123L,40213L,40231L,41023L,41203L,42013L,43201L,45263L,45673L,45763L,46523L,46573L,47563L,47653L,54367L,54623L,54673L,56437L,56473L,56897L,57689L,58679L,58967L,65423L };
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
public class A156119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156119Inst : IEnumerable<long>
{
public static readonly long[] Value=A156119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156119.Bytes);
public long this[int i]=>Value[i];

public static A156119Inst Instance=new A156119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156120
{
public static readonly long[] Value={ 2423L,102101L,114113L,210209L,264263L,270269L,330329L,342341L,414413L,762761L,774773L,840839L,852851L,912911L,10021001L,11101109L,17641763L,20222021L,21302129L,22322231L,26822681L,27242723L,28322831L,32523251L,36723671L };
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
public class A156120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156120Inst : IEnumerable<long>
{
public static readonly long[] Value=A156120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156120.Bytes);
public long this[int i]=>Value[i];

public static A156120Inst Instance=new A156120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156121
{
public static readonly long[] Value={ 67L,7879L,9091L,186187L,276277L,426427L,438439L,450451L,600601L,606607L,798799L,816817L,858859L,936937L,960961L,11401141L,13981399L,15361537L,17461747L,17881789L,18961897L,21002101L,21902191L,22082209L,27362737L,28802881L };
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
public class A156121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156121Inst : IEnumerable<long>
{
public static readonly long[] Value=A156121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156121.Bytes);
public long this[int i]=>Value[i];

public static A156121Inst Instance=new A156121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156122
{
public static readonly BigInteger[] Value={ 1L,6L,192L,15216L,2249472L,534437376L,186227300352L,89472023771136L,56685374949752832L,BigInteger.Parse("45789401925385322496"),BigInteger.Parse("45932606279820521766912"),BigInteger.Parse("56019030070478949980307456"),BigInteger.Parse("81629508898089483953705582592"),BigInteger.Parse("140066108036622450865749167702016"),BigInteger.Parse("279529326198310211796977967402319872") };
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
public class A156122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156122Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156122.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156122.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156122Inst Instance=new A156122Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156123
{
public static readonly long[] Value={ 5L,7L,23L,37L,47L,53L,67L,113L,127L,137L,163L,193L,257L,277L,313L,317L,347L,397L,443L,463L,487L,557L,607L,617L,683L,733L,823L,827L,947L,1087L,1093L,1223L,1283L,1423L,1453L,1523L,1657L,1723L,1787L,1993L,2017L,2063L,2143L,2203L,2207L,2237L,2273L,2297L,2503L,2543L };
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
public class A156123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156123Inst : IEnumerable<long>
{
public static readonly long[] Value=A156123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156123.Bytes);
public long this[int i]=>Value[i];

public static A156123Inst Instance=new A156123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156124
{
public static readonly long[] Value={ 7L,29L,37L,67L,79L,107L,127L,139L,167L,239L,277L,317L,347L,359L,419L,449L,499L,547L,739L,809L,839L,919L,947L,1019L,1217L,1229L,1289L,1327L,1367L,1399L,1409L,1427L,1439L,1549L,1597L,1789L,1997L,2017L,2069L,2237L,2239L,2267L,2477L,2549L,2647L,2657L,2659L,2897L };
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
public class A156124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156124Inst : IEnumerable<long>
{
public static readonly long[] Value=A156124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156124.Bytes);
public long this[int i]=>Value[i];

public static A156124Inst Instance=new A156124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156125
{
public static readonly BigInteger[] Value={ 1L,5L,60L,1000L,20000L,450000L,11000000L,286000000L,7800000000L,221000000000L,6460000000000L,193800000000000L,5943200000000000L,185725000000000000L,5899500000000000000L,BigInteger.Parse("190095000000000000000"),BigInteger.Parse("6203100000000000000000") };
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
public class A156125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156125Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156125.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156125.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156125Inst Instance=new A156125Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156126
{
public static readonly long[] Value={ 1L,35L,84L,165L,286L,455L,680L,969L,1330L,1771L,2300L,2925L,3654L,4495L,5456L,6545L,7770L,9139L,10660L,12341L,14190L,16215L,18424L,20825L,23426L,26235L,29260L,32509L,35990L,39711L,43680L };
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
public class A156126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156126Inst : IEnumerable<long>
{
public static readonly long[] Value=A156126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156126.Bytes);
public long this[int i]=>Value[i];

public static A156126Inst Instance=new A156126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156127
{
public static readonly long[] Value={ 4L,11L,25L,53L,109L,221L,445L,893L,1789L,3581L,7165L,14333L,28669L,57341L,114685L,229373L,458749L,917501L,1835005L,3670013L,7340029L,14680061L,29360125L,58720253L,117440509L,234881021L,469762045L,939524093L,1879048189L,3758096381L };
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
public class A156127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156127Inst : IEnumerable<long>
{
public static readonly long[] Value=A156127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156127.Bytes);
public long this[int i]=>Value[i];

public static A156127Inst Instance=new A156127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156128
{
public static readonly BigInteger[] Value={ 1L,6L,72L,1080L,18144L,326592L,6158592L,120092544L,2401850880L,48997757952L,1015589892096L,21327387734016L,452796847276032L,9702789584486400L,209580255024906240L,4558370546791710720L,BigInteger.Parse("99747873141559787520"),BigInteger.Parse("2194453209114315325440"),BigInteger.Parse("48508965675158549299200") };
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
public class A156128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156128Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156128.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156128.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156128Inst Instance=new A156128Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156129
{
public static readonly BigInteger[] Value={ 1L,2L,9L,58L,501L,5402L,69909L,1055458L,18211401L,353506802L,7624471809L,180889942858L,4681743794301L,131269240120202L,3963720131525709L,128234893954822258L,4425253713052509201L,BigInteger.Parse("162255367355408805602"),BigInteger.Parse("6299173242134303391609"),BigInteger.Parse("258136328705500135053658") };
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
public class A156129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156129Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156129.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156129.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156129Inst Instance=new A156129Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156130
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,4L,53L,28L,28L,53L,246L,138L,102L,138L,246L,4207L,1775L,814L,814L,1775L,4207L,60922L,25758L,10035L,5654L,10035L,25758L,60922L,1114857L,457387L,168720L,63929L,63929L,168720L,457387L,1114857L,10706482L,4934925L,2063635L,791789L };
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
public class A156130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156130Inst : IEnumerable<long>
{
public static readonly long[] Value=A156130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156130.Bytes);
public long this[int i]=>Value[i];

public static A156130Inst Instance=new A156130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156131
{
public static readonly BigInteger[] Value={ 1L,3L,19L,177L,2201L,34203L,637819L,13876377L,345022001L,9650948403L,299951259619L,10254726248577L,382459993625801L,15452902408998603L,672386203441625419L,BigInteger.Parse("31346622138810396777"),BigInteger.Parse("1558803698602736533601"),BigInteger.Parse("82360892667114765064803"),BigInteger.Parse("4607594447779876771255219") };
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
public class A156131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156131Inst Instance=new A156131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156132
{
public static readonly BigInteger[] Value={ 1L,4L,33L,404L,6597L,134644L,3297693L,94228004L,3077100777L,113046200164L,4614532495353L,207201136625204L,10149511013598957L,538592387976486484L,BigInteger.Parse("30779388439090380213"),BigInteger.Parse("1884616483302733144004"),BigInteger.Parse("123087714448128536653137"),BigInteger.Parse("8541524061361098605073604") };
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
public class A156132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156132Inst Instance=new A156132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156133
{
public static readonly long[] Value={ 1L,-1L,1L,1L,1L,-2L,-2L,1L,1L,-3L,-6L,3L,1L,1L,-4L,-19L,-4L,1L,-1L,8L,40L,-60L,-40L,8L,1L,1L,-13L,-104L,260L,260L,-104L,-13L,1L,1L,-21L,-273L,1092L,1820L,-1092L,-273L,21L,1L,1L,-33L,-747L,3894L,16270L,3894L,-747L,-33L,1L,-1L,55L,1870L,-19635L,-85085L,136136L,85085L };
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
public class A156133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156133Inst : IEnumerable<long>
{
public static readonly long[] Value=A156133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156133.Bytes);
public long this[int i]=>Value[i];

public static A156133Inst Instance=new A156133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156134
{
public static readonly BigInteger[] Value={ 1L,5L,157L,12425L,1836697L,436366445L,152053957237L,73053601590065L,46283414838553777L,BigInteger.Parse("37386890114969267285"),BigInteger.Parse("37503815980582784378317"),BigInteger.Parse("45739346519434253222582105"),BigInteger.Parse("66650214918099514832427062857"),BigInteger.Parse("114363498315755726948758209518525"),BigInteger.Parse("228234739109951323288351261455519397") };
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
public class A156134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156134Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156134.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156134Inst Instance=new A156134Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156135
{
public static readonly long[] Value={ 1L,0L,-1L,1L,0L,1L,-2L,1L,0L,1L,-3L,1L,1L,0L,1L,-4L,-4L,1L,0L,-1L,8L,9L,-23L,6L,1L,0L,1L,-13L,-41L,106L,-41L,-13L,1L,0L,1L,-21L,-146L,484L,-152L,-186L,19L,1L,0L,1L,-33L,-492L,1784L,1784L,-492L,-33L,1L,0L,-1L,55L,1359L,-10701L,-8552L,27128L,-7875L,-1467L,53L,1L,0L,1L,-89L };
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
public class A156135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156135Inst : IEnumerable<long>
{
public static readonly long[] Value=A156135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156135.Bytes);
public long this[int i]=>Value[i];

public static A156135Inst Instance=new A156135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156136
{
public static readonly long[] Value={ 1L,2L,2L,3L,12L,4L,4L,36L,48L,8L,5L,80L,240L,160L,16L,6L,150L,800L,1200L,480L,32L,7L,252L,2100L,5600L,5040L,1344L,64L,8L,392L,4704L,19600L,31360L,18816L,3584L,128L,9L,576L,9408L,56448L,141120L,150528L,64512L,9216L,256L,10L,810L,17280L,141120L,508032L };
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
public class A156136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156136Inst : IEnumerable<long>
{
public static readonly long[] Value=A156136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156136.Bytes);
public long this[int i]=>Value[i];

public static A156136Inst Instance=new A156136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156137
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,36L,81L,1L,1L,148L,1053L,1312L,1L,1L,596L,10809L,37840L,32825L,1L,1L,2388L,102645L,778384L,1766625L,1181736L,1L,1L,9556L,945297L,14096464L,63625225L,106140996L,57905113L,1L,1L,38228L,8593677L,240668176L,1943042225L,6111583956L };
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
public class A156137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156137Inst : IEnumerable<long>
{
public static readonly long[] Value=A156137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156137.Bytes);
public long this[int i]=>Value[i];

public static A156137Inst Instance=new A156137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156138
{
public static readonly BigInteger[] Value={ 1L,17L,901L,99917L,18991081L,5514615017L,2270974911661L,1258937450889317L,903952433274722641L,BigInteger.Parse("816101554527859690817"),BigInteger.Parse("904827968753139590344021"),BigInteger.Parse("1208617989532834039606507517"),BigInteger.Parse("1914312457105234828011498655801"),BigInteger.Parse("3547500444096776665586928259547417"),BigInteger.Parse("7604155838367549221056955383942297981") };
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
public class A156138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156138Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156138.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156138.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156138Inst Instance=new A156138Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156139
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,23L,28L,1L,1L,76L,250L,145L,1L,1L,237L,1608L,2475L,876L,1L,1L,722L,8802L,26847L,25056L,6139L,1L,1L,2179L,43872L,231057L,418806L,268477L,49120L,1L,1L,6552L,205994L,1725621L,5285520L,6486205L,3077730L,442089L,1L,1L,19673L,928808L };
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
public class A156139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156139Inst : IEnumerable<long>
{
public static readonly long[] Value=A156139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156139.Bytes);
public long this[int i]=>Value[i];

public static A156139Inst Instance=new A156139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156140
{
public static readonly long[] Value={ -1L,0L,1L,3L,2L,7L,5L,8L,3L,13L,10L,17L,7L,18L,11L,15L,4L,21L,17L,30L,13L,35L,22L,31L,9L,32L,23L,37L,14L,33L,19L,24L,5L,31L,26L,47L,21L,58L,37L,53L,16L,59L,43L,70L,27L,65L,38L,49L,11L,50L,39L,67L,28L,73L,45L,62L,17L,57L,40L,63L,23L,52L,29L,35L,6L,43L,37L,68L,31L,87L,56L,81L,25L,94L,69L };
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
public class A156140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156140Inst : IEnumerable<long>
{
public static readonly long[] Value=A156140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156140.Bytes);
public long this[int i]=>Value[i];

public static A156140Inst Instance=new A156140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156141
{
public static readonly long[] Value={ 2L,1L,1L,1L,4L,1L,1L,14L,14L,1L,1L,46L,116L,46L,1L,1L,172L,772L,772L,172L,1L,1L,834L,5160L,8800L,5160L,834L,1L,1L,5280L,39594L,90260L,90260L,39594L,5280L,1L,1L,40814L,361086L,981104L,1288040L,981104L,361086L,40814L,1L,1L,363884L,3801180L,12088796L };
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
public class A156141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156141Inst : IEnumerable<long>
{
public static readonly long[] Value=A156141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156141.Bytes);
public long this[int i]=>Value[i];

public static A156141Inst Instance=new A156141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156142
{
public static readonly BigInteger[] Value={ 1L,2L,3L,7L,27L,137L,873L,6667L,59427L,605297L,6936273L,88315027L,1236909627L,18898578857L,312811478073L,5575974948187L,106493278764627L,2169463248814817L,46958188870266273L,1076202413702266147L,BigInteger.Parse("26035005959162168427"),BigInteger.Parse("662975982648919697177"),BigInteger.Parse("17726672005071080580873") };
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
public class A156142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156142Inst Instance=new A156142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156143
{
public static readonly BigInteger[] Value={ 1L,2L,12L,176L,4560L,184832L,10786752L,856856576L,88901310720L,11673832128512L,1892490366446592L,371226769045323776L,BigInteger.Parse("86660664498577428480"),BigInteger.Parse("23742637220974655700992"),BigInteger.Parse("7544062284452303484076032"),BigInteger.Parse("2751743952477326731196235776"),BigInteger.Parse("1142005572999693488899887267840"),BigInteger.Parse("535040063912570172630126949302272") };
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
public class A156143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156143Inst Instance=new A156143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156144
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,3L,2L,3L,1L,1L,2L,1L,1L,3L,5L,2L,5L,1L,1L,2L,1L,1L,5L,8L,4L,8L,2L,1L,4L,1L,1L,7L,13L,5L,13L,2L,2L,5L,1L,1L,11L,20L,9L,19L,3L,2L,9L,1L,1L,15L,31L,12L,29L,4L,3L,11L,2L,1L,22L,46L,20L,42L,7L,4L,18L,2L,2L,30L,68L,27L,61L,9L,6L,23L,3L,2L,42L,98L,42L,85L };
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
public class A156144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156144Inst : IEnumerable<long>
{
public static readonly long[] Value=A156144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156144.Bytes);
public long this[int i]=>Value[i];

public static A156144Inst Instance=new A156144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156145
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,13L,20L,31L,46L,68L,98L,140L,195L,271L,370L,502L,673L,897L,1183L,1553L,2021L,2618L,3367L,4312L,5489L,6961L,8782L,11039L,13815L,17232L,21409L,26519L,32732L,40288L,49433L,60496L,73824L,89872L,109125L,132204L,159785L,192715L,231921L };
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
public class A156145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156145Inst : IEnumerable<long>
{
public static readonly long[] Value=A156145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156145.Bytes);
public long this[int i]=>Value[i];

public static A156145Inst Instance=new A156145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156146
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,1L,3L,58L,11L,2L,4L,5829L,1056L,16L,2L,5L,58292915L,10555528L,1608L,21L,3L,6L,5829291479146458L,1055552805277764L,16080804L,2111L,27L,3L,7L,BigInteger.Parse("58292914791464577914645739573229"),BigInteger.Parse("10555528052777640527776402638882") };
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
public class A156146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156146Inst Instance=new A156146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156147
{
public static readonly BigInteger[] Value={ 1L,1L,6L,58L,5829L,58292915L,5829291479146458L,BigInteger.Parse("58292914791464577914645739573229"),BigInteger.Parse("5829291479146457791464573957322929146457395732288957322869786615") };
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
public class A156147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156147Inst Instance=new A156147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156148
{
public static readonly long[] Value={ 5L,20L,51891L,51893L };
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
public class A156148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156148Inst : IEnumerable<long>
{
public static readonly long[] Value=A156148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156148.Bytes);
public long this[int i]=>Value[i];

public static A156148Inst Instance=new A156148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156149
{
public static readonly long[] Value={ 11L,71L,637319L,637327L };
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
public class A156149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156149Inst : IEnumerable<long>
{
public static readonly long[] Value=A156149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156149.Bytes);
public long this[int i]=>Value[i];

public static A156149Inst Instance=new A156149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156150
{
public static readonly long[] Value={ 31L,353L,9559783L,9559903L };
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
public class A156150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156150Inst : IEnumerable<long>
{
public static readonly long[] Value=A156150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156150.Bytes);
public long this[int i]=>Value[i];

public static A156150Inst Instance=new A156150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156151
{
public static readonly long[] Value={ 2L,31L,353L,9559783L,9559843L,9559903L,3779853313L,27788573801L,204475054073L,204475054723L,1505578024807L,1505578025779L };
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
public class A156151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156151Inst : IEnumerable<long>
{
public static readonly long[] Value=A156151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156151.Bytes);
public long this[int i]=>Value[i];

public static A156151Inst Instance=new A156151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156152
{
public static readonly long[] Value={ 2L,5L,41L,47L,347L,367L,9559817L,514272793L,514274807L,514275529L,3779851091L,27788568469L,27788573621L,204475055227L };
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
public class A156152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156152Inst : IEnumerable<long>
{
public static readonly long[] Value=A156152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156152.Bytes);
public long this[int i]=>Value[i];

public static A156152Inst Instance=new A156152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156153
{
public static readonly long[] Value={ 5L,41L,367L,9559817L,514275529L };
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
public class A156153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156153Inst : IEnumerable<long>
{
public static readonly long[] Value=A156153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156153.Bytes);
public long this[int i]=>Value[i];

public static A156153Inst Instance=new A156153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156154
{
public static readonly long[] Value={ 3L,13L,73L,637321L,27067133L };
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
public class A156154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156154Inst : IEnumerable<long>
{
public static readonly long[] Value=A156154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156154.Bytes);
public long this[int i]=>Value[i];

public static A156154Inst Instance=new A156154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156155
{
public static readonly long[] Value={ 2L,6L,21L,51892L };
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
public class A156155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156155Inst : IEnumerable<long>
{
public static readonly long[] Value=A156155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156155.Bytes);
public long this[int i]=>Value[i];

public static A156155Inst Instance=new A156155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156156
{
public static readonly long[] Value={ 13L,53L,305L,1777L,10357L,60365L,351833L,2050633L,11951965L,69661157L,406014977L,2366428705L,13792557253L,80388914813L,468540931625L,2730856674937L,15916599117997L,92768738033045L,540695829080273L,3151406236448593L };
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
public class A156156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156156Inst : IEnumerable<long>
{
public static readonly long[] Value=A156156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156156.Bytes);
public long this[int i]=>Value[i];

public static A156156Inst Instance=new A156156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156157
{
public static readonly long[] Value={ 17L,85L,493L,2873L,16745L,97597L,568837L,3315425L,19323713L,112626853L,656437405L,3825997577L,22299548057L,129971290765L,757528196533L,4415197888433L,25733659134065L,149986756915957L,874186882361677L,5095134537254105L };
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
public class A156157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156157Inst : IEnumerable<long>
{
public static readonly long[] Value=A156157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156157.Bytes);
public long this[int i]=>Value[i];

public static A156157Inst Instance=new A156157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156158
{
public static readonly long[] Value={ 25L,137L,797L,4645L,27073L,157793L,919685L,5360317L,31242217L,182092985L,1061315693L,6185801173L,36053491345L,210135146897L,1224757390037L,7138409193325L,41605697769913L,242495777426153L,1413368966787005L };
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
public class A156158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156158Inst : IEnumerable<long>
{
public static readonly long[] Value=A156158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156158.Bytes);
public long this[int i]=>Value[i];

public static A156158Inst Instance=new A156158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156159
{
public static readonly long[] Value={ 169L,289L,625L,2809L,7225L,18769L,93025L,243049L,635209L,3157729L,8254129L,21576025L,107267449L,280395025L,732947329L,3643933225L,9525174409L,24898630849L,123786459889L,323575532569L,845820499225L,4205095700689L };
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
public class A156159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156159Inst : IEnumerable<long>
{
public static readonly long[] Value=A156159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156159.Bytes);
public long this[int i]=>Value[i];

public static A156159Inst Instance=new A156159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156160
{
public static readonly BigInteger[] Value={ 169L,2809L,93025L,3157729L,107267449L,3643933225L,123786459889L,4205095700689L,142849467361225L,4852676794578649L,164848161548310529L,5599984815847977025L,BigInteger.Parse("190234635577282906009"),BigInteger.Parse("6462377624811770824969") };
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
public class A156160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156160Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156160.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156160Inst Instance=new A156160Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156161
{
public static readonly BigInteger[] Value={ 289L,7225L,243049L,8254129L,280395025L,9525174409L,323575532569L,10992042930625L,373405884106369L,12684808016683609L,430910066683134025L,14638257459209870929UL,BigInteger.Parse("497269843546452475249"),BigInteger.Parse("16892536423120174285225") };
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
public class A156161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156161Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156161.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156161.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156161Inst Instance=new A156161Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156162
{
public static readonly BigInteger[] Value={ 625L,18769L,635209L,21576025L,732947329L,24898630849L,845820499225L,28732998340489L,976076123075089L,33157855186210225L,1126391000208070249L,BigInteger.Parse("38264136151888175929"),BigInteger.Parse("1299854238163989909025"),BigInteger.Parse("44156779961423768728609") };
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
public class A156162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156162Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156162.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156162Inst Instance=new A156162Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156163
{
public static readonly long[] Value={ 1L,6L,1L,6L,7L,8L,1L,2L,5L,7L,3L,0L,8L,1L,5L,1L,1L,9L,3L,6L,9L,4L,7L,1L,3L,6L,6L,7L,3L,6L,8L,1L,2L,8L,7L,3L,3L,6L,1L,2L,8L,2L,5L,3L,6L,7L,7L,8L,0L,0L,9L,9L,3L,1L,9L,9L,4L,4L,7L,1L,0L,4L,9L,5L,7L,6L,1L,4L,3L,4L,9L,9L,2L,3L,9L,8L,3L,9L,0L,7L,1L,9L,5L,9L,4L,2L,5L,4L,4L,2L,3L,8L,8L,0L,3L,4L,4L,0L,8L,4L,4L,9L,4L,7L,1L };
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
public class A156163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156163Inst : IEnumerable<long>
{
public static readonly long[] Value=A156163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156163.Bytes);
public long this[int i]=>Value[i];

public static A156163Inst Instance=new A156163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156164
{
public static readonly long[] Value={ 3L,3L,9L,7L,0L,5L,6L,2L,7L,4L,8L,4L,7L,7L,1L,4L,0L,5L,8L,5L,6L,2L,0L,2L,6L,4L,6L,9L,0L,5L,1L,6L,3L,7L,6L,9L,4L,2L,8L,3L,6L,0L,6L,2L,5L,0L,4L,5L,2L,3L,3L,7L,6L,8L,7L,8L,1L,2L,0L,1L,5L,6L,8L,5L,5L,8L,8L,8L,7L,8L,9L,7L,4L,1L,5L,4L,5L,2L,8L,4L,4L,6L,6L,2L,0L,4L,6L,5L,0L,4L,1L,1L,9L,3L,1L,6L,9L,8L,8L,7L,2L,8L,2L,0L,1L };
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
public class A156164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156164Inst : IEnumerable<long>
{
public static readonly long[] Value=A156164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156164.Bytes);
public long this[int i]=>Value[i];

public static A156164Inst Instance=new A156164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156165
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,9L,10L,12L,13L,24L,25L,26L,29L,31L,35L,36L,47L,49L,57L,58L,64L,71L,73L,75L,78L,80L,97L,123L,125L,129L,131L,135L,147L,150L,159L,183L,201L,250L,251L,255L,298L,336L,337L,458L,467L,556L,570L,657L,743L,801L,908L,925L,1003L,1209L,1473L,1524L,1716L,1881L,1926L };
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
public class A156165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156165Inst : IEnumerable<long>
{
public static readonly long[] Value=A156165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156165.Bytes);
public long this[int i]=>Value[i];

public static A156165Inst Instance=new A156165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156166
{
public static readonly long[] Value={ 1L,14L,43L,507L,609L,2473L,2624L,28292L,181299L };
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
public class A156166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156166Inst : IEnumerable<long>
{
public static readonly long[] Value=A156166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156166.Bytes);
public long this[int i]=>Value[i];

public static A156166Inst Instance=new A156166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156167
{
public static readonly long[] Value={ 3L,4L,6L,8L,9L,10L,11L,12L,14L,17L,20L,24L,30L,31L,32L,46L,52L,54L,59L,98L,104L,143L,145L,160L,174L,198L,199L,202L,212L,215L,254L,371L,382L,452L,674L,739L,959L,1249L,1657L,2291L,2553L,2650L,3562L,3727L,3853L,4389L,4604L,5449L,5659L,6026L,6878L,7900L,9564L,10150L,12444L,13321L,22642L,24014L,26598L,27430L,31386L,40707L,43328L,45811L };
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
public class A156167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156167Inst : IEnumerable<long>
{
public static readonly long[] Value=A156167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156167.Bytes);
public long this[int i]=>Value[i];

public static A156167Inst Instance=new A156167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156168
{
public static readonly BigInteger[] Value={ 1L,305L,6815585L,1077270776465L,626055764653322945L,BigInteger.Parse("968553361387420436695025"),BigInteger.Parse("3286322019402928956112227932705"),BigInteger.Parse("21485762937086358457367440231243675985"),BigInteger.Parse("246710262382186399710713892753099905250964865"),BigInteger.Parse("4640407584638100957359112105517273132340130164039345") };
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
public class A156168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156168Inst Instance=new A156168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156169
{
public static readonly BigInteger[] Value={ 7L,33367L,2237423527L,715153093789687L,BigInteger.Parse("698774745485355051847"),BigInteger.Parse("1632180870878422847476890007"),BigInteger.Parse("7791592461957309952817483706344167"),BigInteger.Parse("68182479037890270018102486211434811414327"),BigInteger.Parse("1009677846565093510000577124729596523472890660487"),BigInteger.Parse("23798205151780687193785106278522250169201817256662802647") };
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
public class A156169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156169Inst Instance=new A156169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156170
{
public static readonly BigInteger[] Value={ 1L,1L,3L,10L,41L,219L,1602L,16635L,247171L,5242108L,157390565L,6663089873L,396778864166L,33200932308437L,3906922702271961L,646161881511137940L,BigInteger.Parse("150482521507292513413"),BigInteger.Parse("49318093291540113084965"),BigInteger.Parse("22790150225552744270503692"),BigInteger.Parse("14843990673285561887923674163"),BigInteger.Parse("13646527810852572644275538963207"),BigInteger.Parse("17710656073227095563348293151121448") };
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
public class A156170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156170Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156170.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156170.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156170Inst Instance=new A156170Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156171
{
public static readonly BigInteger[] Value={ 1L,1L,3L,11L,53L,357L,3521L,51665L,1122135L,35638903L,1639453459L,108526044099L,10298220348807L,1396920580458279L,270394562069007327L,BigInteger.Parse("74574294532698008703"),BigInteger.Parse("29276455806256470979269") };
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
public class A156171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156171Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156171.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156171.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156171Inst Instance=new A156171Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156172
{
public static readonly BigInteger[] Value={ 2L,14L,610L,66734L,13631170L,4474847054L,2154541552930L,1430306187579374L,1252111529306645890L,BigInteger.Parse("1397549490970710103694"),BigInteger.Parse("1937106722774840873390050"),BigInteger.Parse("3264361741756845694953780014"),BigInteger.Parse("6572644038805857912224455865410"),BigInteger.Parse("15583184923914619905634967412688334"),BigInteger.Parse("42971525874172716914734880462487351970") };
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
public class A156172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156172Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156172.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156172.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156172Inst Instance=new A156172Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156173
{
public static readonly long[] Value={ 1L,3L,4L,21L,52L,105L,315L,2080L,8925L,29016L,9765L,251680L,3043425L,22661496L,121226245L,615195L,91611520L,4154275125L,88515803376L,1131162092095L,10017774259200L,78129765L,100131391360L,22686496457625L,1728802155736656L };
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
public class A156173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156173Inst : IEnumerable<long>
{
public static readonly long[] Value=A156173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156173.Bytes);
public long this[int i]=>Value[i];

public static A156173Inst Instance=new A156173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156174
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L };
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
public class A156174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156174Inst : IEnumerable<long>
{
public static readonly long[] Value=A156174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156174.Bytes);
public long this[int i]=>Value[i];

public static A156174Inst Instance=new A156174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156175
{
public static readonly BigInteger[] Value={ 1L,1681L,67637281L,15442193173681L,11735529528739490881UL,BigInteger.Parse("22427641105413135505628881"),BigInteger.Parse("90592214447886493688036507587681"),BigInteger.Parse("687051872949101429716075902637226327281"),BigInteger.Parse("8977220765593827294384825469501847565263767681"),BigInteger.Parse("189320918307961834904462117789058282666933576006788881") };
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
public class A156175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156175Inst Instance=new A156175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156176
{
public static readonly BigInteger[] Value={ 23L,257543L,27138236663L,11828536957233383L,BigInteger.Parse("14639678925928297567703"),BigInteger.Parse("41393949926819051111431239623"),BigInteger.Parse("231969423543894989257690172433129143"),BigInteger.Parse("2330640193014931063017585202490874608196263"),BigInteger.Parse("38966520031501064708241399303059964064529134680983"),BigInteger.Parse("1023409776429490887726960719866571404072100379273323303303") };
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
public class A156176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156176Inst Instance=new A156176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156177
{
public static readonly BigInteger[] Value={ 1L,352L,7869952L,1243925143552L,722906928498737152L,BigInteger.Parse("1118389087843083461066752"),BigInteger.Parse("3794717805092151129643367268352"),BigInteger.Parse("24809622030942586708931326728787197952"),BigInteger.Parse("284876472796397041595189052788763077537431552"),BigInteger.Parse("5358281136280777382502986500754127200892786313265152") };
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
public class A156177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156177Inst Instance=new A156177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156178
{
public static readonly BigInteger[] Value={ 8L,38528L,2583554048L,825787662368768L,BigInteger.Parse("806875574817679474688"),BigInteger.Parse("1884680130335630169428983808"),BigInteger.Parse("8996956010653823687821026161328128"),BigInteger.Parse("78730345253083926602212304047862498459648"),BigInteger.Parse("1165875553018316795143687738745856008854981050368"),BigInteger.Parse("27479800301221036852377324247444630678920385132167692288") };
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
public class A156178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156178Inst Instance=new A156178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156179
{
public static readonly BigInteger[] Value={ 1L,-1L,-2L,13L,22L,-121L,-602L,18581L,30742L,-305071L,-2523002L,61203943L,303692662L,-4353296221L,-50402079002L,6669149100757L,11030684333782L,-206772189255571L,-3077986048956602L,128970681211645873L,1066578948824962102L,BigInteger.Parse("-24697503335329725121"),BigInteger.Parse("-449342758735568563802") };
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
public class A156179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156179Inst Instance=new A156179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156180
{
public static readonly long[] Value={ 1L,6L,9L,108L,81L,486L,729L,17496L,6561L,39366L,59049L,708588L,531441L,3188646L,4782969L,229582512L,43046721L,258280326L,387420489L,4649045868L,3486784401L,20920706406L,31381059609L,753145430616L,282429536481L,1694577218886L,2541865828329L,30502389939948L };
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
public class A156180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156180Inst : IEnumerable<long>
{
public static readonly long[] Value=A156180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156180.Bytes);
public long this[int i]=>Value[i];

public static A156180Inst Instance=new A156180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156181
{
public static readonly long[] Value={ 1L,3L,13L,65L,403L,2669L,18759L,136477L,1020373L,7785741L,60395165L,474817833L,3775005799L,30298719855L,245167429681L,1997854542163L,16381233095985L,135050690760831L,1118800428892925L,9308791880014333L,77755512086256649L };
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
public class A156181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156181Inst : IEnumerable<long>
{
public static readonly long[] Value=A156181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156181.Bytes);
public long this[int i]=>Value[i];

public static A156181Inst Instance=new A156181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156182
{
public static readonly BigInteger[] Value={ 1L,-3L,-4L,99L,116L,-2523L,-8764L,1074243L,1242356L,-48982293L,-283202524L,27296351769L,94690800596L,-5393115879063L,-43653497804284L,22950350777886291L,26538141745926836L,-1976553215554138833L,BigInteger.Parse("-20569900661155862044"),BigInteger.Parse("3424560766779704633439") };
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
public class A156182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156182Inst Instance=new A156182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156183
{
public static readonly long[] Value={ 1L,10L,25L,500L,625L,6250L,15625L,625000L,390625L,3906250L,9765625L,195312500L,244140625L,2441406250L,6103515625L,488281250000L,152587890625L,1525878906250L,3814697265625L,76293945312500L,95367431640625L };
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
public class A156183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156183Inst : IEnumerable<long>
{
public static readonly long[] Value=A156183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156183.Bytes);
public long this[int i]=>Value[i];

public static A156183Inst Instance=new A156183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156184
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,7L,16L,7L,1L,1L,11L,53L,53L,11L,1L,1L,16L,150L,318L,150L,16L,1L,1L,22L,380L,1554L,1554L,380L,22L,1L,1L,29L,892L,6562L,12432L,6562L,892L,29L,1L,1L,37L,1987L,25038L,82538L,82538L,25038L,1987L,37L,1L,1L,46L,4270L,89023L,480380L,825380L,480380L };
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
public class A156184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156184Inst : IEnumerable<long>
{
public static readonly long[] Value=A156184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156184.Bytes);
public long this[int i]=>Value[i];

public static A156184Inst Instance=new A156184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156185
{
public static readonly BigInteger[] Value={ 1L,-1L,-6L,37L,186L,-961L,-14166L,410189L,2009946L,-18708871L,-458225526L,10426234927L,153212718906L,-2059985998981L,-70632832168086L,8766253488312013L,42939614599671066L,-754976143412185291L,BigInteger.Parse("-33282798350926545846"),BigInteger.Parse("1308065815531646653417") };
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
public class A156185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156185Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156185.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156185.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156185Inst Instance=new A156185Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156186
{
public static readonly long[] Value={ 2L,1L,1L,1L,6L,1L,1L,30L,30L,1L,1L,159L,360L,159L,1L,1L,1119L,3639L,3639L,1119L,1L,1L,10932L,41262L,57414L,41262L,10932L,1L,1L,136764L,582642L,898632L,898632L,582642L,136764L,1L,1L,2031933L,9957168L,16634718L,17182152L,16634718L,9957168L,2031933L,1L,1L };
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
public class A156186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156186Inst : IEnumerable<long>
{
public static readonly long[] Value=A156186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156186.Bytes);
public long this[int i]=>Value[i];

public static A156186Inst Instance=new A156186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156187
{
public static readonly BigInteger[] Value={ 1L,-1L,-5L,23L,205L,-1681L,-22265L,257543L,4544185L,-67637281L,-1491632525L,27138236663L,718181418565L,-15442193173681L,-476768795646785L,11828536957233383L,417370516232719345L,BigInteger.Parse("-11735529528739490881"),BigInteger.Parse("-465849831125196593045"),BigInteger.Parse("14639678925928297567703") };
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
public class A156187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156187.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156187Inst Instance=new A156187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156188
{
public static readonly long[] Value={ 2L,1L,1L,1L,10L,1L,1L,80L,80L,1L,1L,775L,1520L,775L,1L,1L,10915L,25945L,25945L,10915L,1L,1L,213720L,542910L,624670L,542910L,213720L,1L,1L,5245530L,14690640L,16408670L,16408670L,14690640L,5245530L,1L,1L,151534685L,479956020L,553630850L,464654480L };
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
public class A156188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156188Inst : IEnumerable<long>
{
public static readonly long[] Value=A156188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156188.Bytes);
public long this[int i]=>Value[i];

public static A156188Inst Instance=new A156188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156189
{
public static readonly long[] Value={ 1L,3L,36L,108L,1296L,3888L,46656L,139968L,1679616L,5038848L,60466176L,181398528L,2176782336L,6530347008L,78364164096L,235092492288L,2821109907456L,8463329722368L,101559956668416L,304679870005248L,3656158440062976L };
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
public class A156189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156189Inst : IEnumerable<long>
{
public static readonly long[] Value=A156189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156189.Bytes);
public long this[int i]=>Value[i];

public static A156189Inst Instance=new A156189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156190
{
public static readonly long[] Value={ 0L,0L,2L,6L,9L,18L,29L,43L,66L,101L,187L,257L,470L,717L,1033L,1293L,2442L,3168L,6011L,7911L,11179L,16888L,32603L,39587L,53063L,79742L,97707L,127679L,246428L,302205L,585129L,670409L,923535L,1385145L,1813935L,2099557L,4091926L,6142573L,8416157L };
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
public class A156190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156190Inst : IEnumerable<long>
{
public static readonly long[] Value=A156190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156190.Bytes);
public long this[int i]=>Value[i];

public static A156190Inst Instance=new A156190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156191
{
public static readonly BigInteger[] Value={ 1L,-5L,-6L,305L,330L,-15125L,-48726L,12612265L,13534410L,-1127063075L,-6046913046L,1231021544435L,3962771924490L,-476712360617225L,-3580686141374166L,3976143129381065225L,4266519857080266570L,BigInteger.Parse("-671177298561550791575"),BigInteger.Parse("-6481738795978992136086") };
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
public class A156191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156191.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156191Inst Instance=new A156191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156192
{
public static readonly long[] Value={ 1L,14L,49L,1372L,2401L,33614L,117649L,6588344L,5764801L,80707214L,282475249L,7909306972L,13841287201L,193778020814L,678223072849L,75960984159088L,33232930569601L,465261027974414L,1628413597910449L,45595580741492572L };
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
public class A156192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156192Inst : IEnumerable<long>
{
public static readonly long[] Value=A156192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156192.Bytes);
public long this[int i]=>Value[i];

public static A156192Inst Instance=new A156192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156193
{
public static readonly BigInteger[] Value={ 1L,-3L,-10L,207L,590L,-10443L,-87730L,8725719L,24386030L,-779929533L,-10896056050L,851890629837L,7140660673070L,-329895072654423L,-6452172716731570L,2751576311657256183L,7688003030273049710L,BigInteger.Parse("-464469099846794359113"),BigInteger.Parse("-11679689713099591922290") };
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
public class A156193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156193Inst Instance=new A156193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156194
{
public static readonly long[] Value={ 1L,2L,7L,1L,7L,2L,1L,1L,4L,2L,4L,1L,1L,2L,7L,1L,7L,2L,1L,1L,4L,2L,4L,1L,1L,2L,7L,1L,7L,2L,1L,1L,4L,2L,4L,1L,1L,2L,7L,1L,7L,2L,1L,1L,4L,2L,4L,1L };
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
public class A156194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156194Inst : IEnumerable<long>
{
public static readonly long[] Value=A156194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156194.Bytes);
public long this[int i]=>Value[i];

public static A156194Inst Instance=new A156194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156195
{
public static readonly long[] Value={ 1L,5L,30L,175L,1050L,6250L,37500L,224375L,1346250L,8068750L,48412500L,290343750L,1742062500L,10450312500L,62701875000L,376177734375L,2257066406250L,13541839843750L,81251039062500L,487496738281250L,2924980429687500L,17549718554687500L,105298311328125000L };
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
public class A156195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156195Inst : IEnumerable<long>
{
public static readonly long[] Value=A156195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156195.Bytes);
public long this[int i]=>Value[i];

public static A156195Inst Instance=new A156195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156196
{
public static readonly BigInteger[] Value={ 1L,-1L,-12L,73L,732L,-3721L,-109332L,3113561L,30406812L,-278347351L,-13587056052L,304035474763L,8904250650492L,-117738154950781L,-8045727017033172L,982026184893828457L,9586782871360007772UL,BigInteger.Parse("-165767101918545512011"),BigInteger.Parse("-14564334832981893064692") };
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
public class A156196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156196Inst Instance=new A156196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156197
{
public static readonly long[] Value={ 2L,2L,2L,3L,4L,3L,6L,8L,8L,6L,15L,18L,18L,18L,15L,43L,47L,42L,42L,47L,43L,133L,138L,110L,96L,110L,138L,133L,430L,436L,324L,240L,240L,324L,436L,430L,1431L,1438L,1036L,682L,550L,682L,1036L,1438L,1431L,4863L,4871L,3476L,2156L,1430L,1430L,2156L,3476L,4871L,4863L,16797L };
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
public class A156197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156197Inst : IEnumerable<long>
{
public static readonly long[] Value=A156197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156197.Bytes);
public long this[int i]=>Value[i];

public static A156197Inst Instance=new A156197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156198
{
public static readonly long[] Value={ 8L,19L,41L,85L,173L,349L,701L,1405L,2813L,5629L,11261L,22525L,45053L,90109L,180221L,360445L,720893L,1441789L,2883581L,5767165L,11534333L,23068669L,46137341L,92274685L,184549373L,369098749L,738197501L,1476395005L,2952790013L };
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
public class A156198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156198Inst : IEnumerable<long>
{
public static readonly long[] Value=A156198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156198.Bytes);
public long this[int i]=>Value[i];

public static A156198Inst Instance=new A156198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156199
{
public static readonly long[] Value={ 1L,1L,4L,2L,4L,1L,1L,2L,7L,1L,7L,2L,1L,1L,4L,2L,4L,1L,1L,2L,7L,1L,7L,2L,1L,1L,4L,2L,4L,1L,1L,2L,7L,1L,7L,2L,1L,1L,4L,2L,4L,1L,1L,2L,7L,1L,7L,2L,1L,1L,4L,2L,4L,1L,1L,2L,7L,1L,7L,2L,1L,1L,4L,2L,4L,1L,1L,2L,7L,1L,7L,2L,1L,1L,4L,2L,4L,1L,1L,2L,7L,1L,7L,2L,1L,1L,4L,2L,4L,1L,1L,2L,7L,1L,7L,2L,1L,1L,4L,2L,4L,1L,1L,2L,7L };
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
public class A156199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156199Inst : IEnumerable<long>
{
public static readonly long[] Value=A156199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156199.Bytes);
public long this[int i]=>Value[i];

public static A156199Inst Instance=new A156199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156200
{
public static readonly long[] Value={ 6089L,8069L,8609L,60089L,60689L,60869L,60889L,60899L,66089L,66809L,68099L,68909L,69809L,80669L,86069L,88069L,88609L,89069L,600689L,600889L,606899L,608089L,608099L,608609L,608669L,608899L,608989L,608999L,609809L,609989L,660809L,660899L,666089L };
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
public class A156200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156200Inst : IEnumerable<long>
{
public static readonly long[] Value=A156200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156200.Bytes);
public long this[int i]=>Value[i];

public static A156200Inst Instance=new A156200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156201
{
public static readonly BigInteger[] Value={ 1L,-3L,-7L,117L,497L,-15123L,-95767L,4116837L,34741217L,-1921996323L,-20273087527L,1370953667157L,17352768515537L,-1386843017916723L,-20479521468959287L,1888542637550347077L,BigInteger.Parse("31872138933891307457"),BigInteger.Parse("-3331009898404800736323"),BigInteger.Parse("-63243057486503656319047") };
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
public class A156201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156201.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156201Inst Instance=new A156201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156202
{
public static readonly long[] Value={ 10L,23L,49L,101L,205L,413L,829L,1661L,3325L,6653L,13309L,26621L,53245L,106493L,212989L,425981L,851965L,1703933L,3407869L,6815741L,13631485L,27262973L,54525949L,109051901L,218103805L,436207613L,872415229L,1744830461L,3489660925L };
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
public class A156202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156202Inst : IEnumerable<long>
{
public static readonly long[] Value=A156202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156202.Bytes);
public long this[int i]=>Value[i];

public static A156202Inst Instance=new A156202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156203
{
public static readonly long[] Value={ 14L,31L,65L,133L,269L,541L,1085L,2173L,4349L,8701L,17405L,34813L,69629L,139261L,278525L,557053L,1114109L,2228221L,4456445L,8912893L,17825789L,35651581L,71303165L,142606333L,285212669L,570425341L,1140850685L,2281701373L };
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
public class A156203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156203Inst : IEnumerable<long>
{
public static readonly long[] Value=A156203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156203.Bytes);
public long this[int i]=>Value[i];

public static A156203Inst Instance=new A156203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156204
{
public static readonly long[] Value={ 7L,107L,359L,541L,2221L,6673L,7457L,10103L,25643L,26861L,27337L,35051L,56149L,61553L,65557L,73523L,84317L,110819L,115733L,131581L,135151L,137447L,179321L,228587L,243553L,252163L,279421L,281717L,310711L,320119L,337367L,345487L,347167L,357079L };
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
public class A156204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156204Inst : IEnumerable<long>
{
public static readonly long[] Value=A156204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156204.Bytes);
public long this[int i]=>Value[i];

public static A156204Inst Instance=new A156204Inst();

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