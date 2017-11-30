using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A172005
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,5L,5L,6L,7L,6L,7L,6L,7L,7L,8L,7L,7L,8L,8L,7L,8L,8L,9L,9L,8L,8L,8L,8L,9L,9L,10L,9L,8L,9L,10L,9L,9L,10L,11L,9L,10L,9L,10L,9L,10L,9L,10L,11L,11L,11L,12L,10L,11L,9L,10L,10L,10L,10L,10L,10L,11L,11L,12L,10L,11L,11L,10L,10L,11L,11L,12L,10L,11L,11L,10L,11L,11L,12L,11L,12L,13L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172005Inst : IEnumerable<long>
{
public static readonly long[] Value=A172005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172005.Bytes);
public long this[int i]=>Value[i];

public static A172005Inst Instance=new A172005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172006
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,5L,5L,6L,7L,6L,7L,6L,7L,7L,8L,7L,7L,8L,8L,7L,8L,8L,9L,8L,8L,8L,8L,8L,9L,9L,9L,9L,8L,9L,10L,9L,9L,10L,10L,9L,10L,9L,10L,9L,10L,9L,10L,10L,10L,10L,10L,10L,10L,9L,10L,10L,10L,10L,10L,10L,10L,11L,11L,10L,11L,10L,10L,10L,11L,11L,11L,10L,11L,11L,10L,11L,11L,11L,11L,11L,11L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172006Inst : IEnumerable<long>
{
public static readonly long[] Value=A172006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172006.Bytes);
public long this[int i]=>Value[i];

public static A172006Inst Instance=new A172006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172007
{
public static readonly long[] Value={ 25L,32L,40L,49L,50L,51L,52L,54L,62L,64L,67L,72L,79L,81L,82L,85L,92L,96L,100L,102L,122L,127L,128L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172007Inst : IEnumerable<long>
{
public static readonly long[] Value=A172007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172007.Bytes);
public long this[int i]=>Value[i];

public static A172007Inst Instance=new A172007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172008
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,2L,4L,4L,4L,4L,2L,4L,2L,2L,4L,2L,6L,2L,2L,2L,8L,8L,4L,2L,2L,2L,2L,2L,2L,6L,2L,2L,10L,10L,4L,2L,8L,8L,2L,2L,4L,8L,2L,2L,2L,6L,14L,2L,4L,4L,8L,8L,2L,4L,2L,4L,2L,2L,2L,4L,6L,6L,2L,2L,2L,2L,4L,4L,18L,18L,2L,2L,4L,2L,8L,2L,10L,2L,2L,2L,4L,4L,6L,4L,4L,4L,2L,2L,2L,4L,6L,6L,2L,2L,2L,8L,2L,2L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172008Inst : IEnumerable<long>
{
public static readonly long[] Value=A172008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172008.Bytes);
public long this[int i]=>Value[i];

public static A172008Inst Instance=new A172008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172009
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,2L,6L,12L,4L,8L,2L,4L,4L,10L,4L,2L,12L,4L,2L,6L,8L,10L,2L,2L,2L,2L,2L,2L,10L,2L,8L,2L,14L,22L,8L,2L,18L,8L,4L,14L,4L,12L,2L,4L,2L,8L,6L,2L,6L,6L,10L,2L,2L,4L,6L,4L,4L,2L,4L,2L,22L,8L,2L,4L,2L,2L,4L,6L,24L,6L,2L,2L,12L,2L,12L,4L,2L,2L,6L,6L,12L,18L,6L,4L,6L,6L,2L,2L,2L,2L,8L,12L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172009Inst : IEnumerable<long>
{
public static readonly long[] Value=A172009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172009.Bytes);
public long this[int i]=>Value[i];

public static A172009Inst Instance=new A172009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172010
{
public static readonly BigInteger[] Value={ 1L,26L,2741L,683870L,315704418L,234725594388L,257237392999893L,390832857108454838L,BigInteger.Parse("787178784737043042806"),BigInteger.Parse("2031210797603911366282796") };
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
public class A172010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172010Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A172010.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A172010.Bytes);
public BigInteger this[int i]=>Value[i];

public static A172010Inst Instance=new A172010Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172011
{
public static readonly long[] Value={ 0L,12L,24L,72L,192L,528L,1440L,3936L,10752L,29376L,80256L,219264L,599040L,1636608L,4471296L,12215808L,33374208L,91180032L,249108480L,680577024L,1859371008L,5079896064L,13878534144L,37916860416L,103590789120L,283015299072L,773212176384L,2112454950912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172011Inst : IEnumerable<long>
{
public static readonly long[] Value=A172011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172011.Bytes);
public long this[int i]=>Value[i];

public static A172011Inst Instance=new A172011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172012
{
public static readonly long[] Value={ 2L,3L,15L,54L,207L,783L,2970L,11259L,42687L,161838L,613575L,2326239L,8819442L,33437043L,126769455L,480619494L,1822166847L,6908359023L,26191577610L,99299809899L,376474162527L,1427321917278L,5411388239415L,20516130470079L,77782556128482L,294896059795683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172012Inst : IEnumerable<long>
{
public static readonly long[] Value=A172012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172012.Bytes);
public long this[int i]=>Value[i];

public static A172012Inst Instance=new A172012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172013
{
public static readonly BigInteger[] Value={ 3L,118L,20343L,8530698L,6711481694L,8575821262764L,16243345162977759L,BigInteger.Parse("42826533033277249154"),BigInteger.Parse("150138953276380791799098"),BigInteger.Parse("675925071086215282939520628") };
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
public class A172013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172013Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A172013.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A172013.Bytes);
public BigInteger this[int i]=>Value[i];

public static A172013Inst Instance=new A172013Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172014
{
public static readonly BigInteger[] Value={ 1L,5L,354L,88153L,48340622L,46980371858L,71465177189700L,157019003242118337L,BigInteger.Parse("471091863366049740694"),BigInteger.Parse("1851713757075363098855542") };
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
public class A172014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A172014.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A172014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A172014Inst Instance=new A172014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172015
{
public static readonly long[] Value={ 23L,25L,47L,49L,53L,55L,83L,85L,89L,91L,113L,115L,131L,133L,167L,169L,173L,175L,233L,235L,251L,253L,257L,259L,263L,265L,293L,295L,317L,319L,353L,355L,359L,361L,383L,385L,389L,391L,401L,403L,443L,445L,449L,451L,467L,469L,479L,481L,491L,493L,503L,505L,509L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172015Inst : IEnumerable<long>
{
public static readonly long[] Value=A172015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172015.Bytes);
public long this[int i]=>Value[i];

public static A172015Inst Instance=new A172015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172016
{
public static readonly long[] Value={ 35L,37L,65L,67L,77L,79L,95L,97L,125L,127L,155L,157L,161L,163L,209L,211L,221L,223L,275L,277L,305L,307L,329L,331L,335L,337L,365L,367L,371L,373L,377L,379L,395L,397L,407L,409L,437L,439L,455L,457L,485L,487L,497L,499L,539L,541L,545L,547L,575L,577L,605L,607L,611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172016Inst : IEnumerable<long>
{
public static readonly long[] Value=A172016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172016.Bytes);
public long this[int i]=>Value[i];

public static A172016Inst Instance=new A172016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172017
{
public static readonly long[] Value={ 119L,121L,143L,145L,185L,187L,203L,205L,215L,217L,287L,289L,299L,301L,413L,415L,515L,517L,527L,529L,533L,535L,551L,553L,581L,583L,695L,697L,779L,781L,791L,793L,815L,817L,869L,871L,893L,895L,899L,901L,959L,961L,1055L,1057L,1079L,1081L,1133L,1135L,1139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172017Inst : IEnumerable<long>
{
public static readonly long[] Value=A172017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172017.Bytes);
public long this[int i]=>Value[i];

public static A172017Inst Instance=new A172017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172018
{
public static readonly BigInteger[] Value={ 1L,4L,182L,27410L,8890310L,5051270688L,4459786293372L,5659222645997646L,9770821427711370950UL,BigInteger.Parse("22041005972637205198568") };
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
public class A172018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172018Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A172018.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A172018.Bytes);
public BigInteger this[int i]=>Value[i];

public static A172018Inst Instance=new A172018Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172019
{
public static readonly long[] Value={ 5L,8L,10L,12L,13L,15L,16L,17L,20L,21L,24L,25L,26L,28L,29L,30L,32L,33L,34L,35L,36L,37L,39L,40L,41L,42L,44L,45L,48L,50L,51L,52L,53L,55L,56L,57L,58L,60L,61L,63L,64L,65L,66L,68L,69L,70L,72L,73L,74L,75L,76L,77L,78L,80L,82L,84L,85L,87L,88L,89L,90L,91L,92L,93L,95L,96L,97L,99L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172019Inst : IEnumerable<long>
{
public static readonly long[] Value=A172019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172019.Bytes);
public long this[int i]=>Value[i];

public static A172019Inst Instance=new A172019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172020
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,28L,49L,84L,144L,252L,441L,777L,1369L,2405L,4225L,7410L,12996L,22800L,40000L,70200L,123201L,216216L,379456L,665896L,1168561L,2050657L,3598609L,6315113L,11082241L,19448018L,34128964L,59892184L,105103504L,184443732L,323676081L,568011852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172020Inst : IEnumerable<long>
{
public static readonly long[] Value=A172020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172020.Bytes);
public long this[int i]=>Value[i];

public static A172020Inst Instance=new A172020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172021
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,4L,6L,6L,1L,2L,4L,8L,14L,20L,20L,1L,2L,4L,8L,16L,30L,50L,70L,70L,1L,2L,4L,8L,16L,32L,62L,112L,182L,252L,252L,1L,2L,4L,8L,16L,32L,64L,126L,238L,420L,672L,924L,924L,1L,2L,4L,8L,16L,32L,64L,128L,254L,492L,912L,1584L,2508L,3432L,3432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172021Inst : IEnumerable<long>
{
public static readonly long[] Value=A172021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172021.Bytes);
public long this[int i]=>Value[i];

public static A172021Inst Instance=new A172021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172022
{
public static readonly long[] Value={ 1L,4L,4L,8L,10L,14L,16L,20L,22L,30L,30L,38L,40L,44L,46L,54L,58L,62L,66L,72L,72L,80L,82L,90L,96L,102L,102L,108L,108L,114L,126L,132L,136L,140L,148L,152L,156L,164L,166L,174L,178L,182L,190L,194L,196L,200L,210L,224L,226L,230L,232L,240L,240L,252L,256L,264L,268L,272L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172022Inst : IEnumerable<long>
{
public static readonly long[] Value=A172022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172022.Bytes);
public long this[int i]=>Value[i];

public static A172022Inst Instance=new A172022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172023
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,13L,38L,133L,534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172023Inst : IEnumerable<long>
{
public static readonly long[] Value=A172023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172023.Bytes);
public long this[int i]=>Value[i];

public static A172023Inst Instance=new A172023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172024
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,9L,10L,11L,12L,13L,14L,15L,16L,20L,21L,23L,26L,27L,30L,35L,36L,37L,39L,40L,43L,53L,55L,67L,72L,85L,97L,98L,123L,130L,131L,132L,138L,141L,146L,180L,182L,185L,188L,192L,201L,225L,231L,236L,240L,248L,252L,254L,276L,300L,322L,326L,346L,372L,401L,413L,424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172024Inst : IEnumerable<long>
{
public static readonly long[] Value=A172024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172024.Bytes);
public long this[int i]=>Value[i];

public static A172024Inst Instance=new A172024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172025
{
public static readonly long[] Value={ 1L,4L,16L,62L,239L,920L,3544L,13672L,52834L,204528L,793092L,3080226L,11980667L,46662704L,181971248L,710454896L,2776717742L,10863073784L,42537035408L,166704021596L,653827252022L,2566222449104L,10079023179536L,39611016586832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172025Inst : IEnumerable<long>
{
public static readonly long[] Value=A172025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172025.Bytes);
public long this[int i]=>Value[i];

public static A172025Inst Instance=new A172025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172026
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,2L,0L,1L,3L,0L,3L,0L,1L,0L,7L,0L,4L,0L,1L,12L,0L,12L,0L,5L,0L,1L,0L,30L,0L,18L,0L,6L,0L,1L,55L,0L,55L,0L,25L,0L,7L,0L,1L,0L,143L,0L,88L,0L,33L,0L,8L,0L,1L,273L,0L,273L,0L,130L,0L,42L,0L,9L,0L,1L,0L,728L,0L,455L,0L,182L,0L,52L,0L,10L,0L,1L,1428L,0L,1428L,0L,700L,0L,245L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172026Inst : IEnumerable<long>
{
public static readonly long[] Value=A172026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172026.Bytes);
public long this[int i]=>Value[i];

public static A172026Inst Instance=new A172026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172027
{
public static readonly BigInteger[] Value={ 1L,7L,169L,86191L,22286924017L,BigInteger.Parse("1490120946485455020919"),BigInteger.Parse("6661381305464124918785090511089856547876441") };
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
public class A172027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172027Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A172027.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A172027.Bytes);
public BigInteger this[int i]=>Value[i];

public static A172027Inst Instance=new A172027Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172028
{
public static readonly BigInteger[] Value={ 2L,19L,1141L,3909067L,45842426158669L,BigInteger.Parse("6304584108339196948770030691"),BigInteger.Parse("119243342337369441148530917575983600568317619049555904517") };
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
public class A172028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172028Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A172028.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A172028.Bytes);
public BigInteger this[int i]=>Value[i];

public static A172028Inst Instance=new A172028Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172029
{
public static readonly BigInteger[] Value={ 3L,37L,4219L,53412541L,8558698768467667L,BigInteger.Parse("219753973828109905009157978671669"),BigInteger.Parse("144875427039736839295788447509321763094522140738437260379045751691") };
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
public class A172029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172029Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A172029.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A172029.Bytes);
public BigInteger this[int i]=>Value[i];

public static A172029Inst Instance=new A172029Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172030
{
public static readonly long[] Value={ 0L,1L,5L,31L,31L,619L,619L,5779L,5779L,69341L,69341L,3051179L,3051179L,52884569L,52884569L,634649863L,634649863L,43152570067L,43152570067L,1093376176159L,1093376176159L,2623076354557L,2623076354557L,241599308325943L,241599308325943L,1604223576455477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172030Inst : IEnumerable<long>
{
public static readonly long[] Value=A172030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172030.Bytes);
public long this[int i]=>Value[i];

public static A172030Inst Instance=new A172030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172031
{
public static readonly long[] Value={ 1L,1L,2L,6L,3L,30L,15L,70L,35L,210L,105L,2310L,1155L,10010L,5005L,30030L,15015L,510510L,255255L,3233230L,1616615L,1939938L,969969L,44618574L,22309287L,74364290L,37182145L,223092870L,111546435L,6469693230L,3234846615L,66853496710L,33426748355L,200560490130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172031Inst : IEnumerable<long>
{
public static readonly long[] Value=A172031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172031.Bytes);
public long this[int i]=>Value[i];

public static A172031Inst Instance=new A172031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172032
{
public static readonly long[] Value={ 0L,1L,3L,19L,19L,379L,379L,3539L,3539L,42461L,42461L,1868459L,1868459L,32384089L,32384089L,388644103L,388644103L,26424178387L,26424178387L,669590253599L,669590253599L,1605990140413L,1605990140413L,148027376624695L,148027376624695L,980410698447157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172032Inst : IEnumerable<long>
{
public static readonly long[] Value=A172032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172032.Bytes);
public long this[int i]=>Value[i];

public static A172032Inst Instance=new A172032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172033
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,8L,8L,10L,10L,12L,12L,15L,15L,18L,18L,22L,22L,27L,27L,32L,32L,38L,38L,46L,46L,54L,54L,64L,64L,76L,76L,89L,89L,104L,104L,122L,122L,142L,142L,165L,165L,192L,192L,222L,222L,256L,256L,296L,296L,340L,340L,390L,390L,448L,448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172033Inst : IEnumerable<long>
{
public static readonly long[] Value=A172033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172033.Bytes);
public long this[int i]=>Value[i];

public static A172033Inst Instance=new A172033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172034
{
public static readonly long[] Value={ 23L,52L,111L,172L,239L,310L,389L,472L,581L,718L,857L,1006L,1199L,1426L,1659L,1898L,2149L,2406L,2675L,2946L,3223L,3516L,3823L,4134L,4451L,4810L,5189L,5572L,5961L,6358L,6759L,7178L,7609L,8058L,8519L,8982L,9449L,9928L,10427L,10930L,11451L,12008L,12571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172034Inst : IEnumerable<long>
{
public static readonly long[] Value=A172034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172034.Bytes);
public long this[int i]=>Value[i];

public static A172034Inst Instance=new A172034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172035
{
public static readonly long[] Value={ 5L,0L,2L,2L,9L,3L,2L,5L,3L,2L,7L,2L,4L,5L,2L,2L,5L,2L,3L,6L,2L,2L,2L,2L,4L,8L,4L,2L,2L,4L,2L,8L,2L,3L,2L,2L,4L,4L,6L,2L,4L,2L,10L,3L,4L,2L,3L,2L,4L,3L,5L,6L,3L,4L,4L,2L,2L,2L,2L,2L,3L,4L,3L,3L,3L,5L,3L,3L,8L,2L,3L,12L,2L,3L,2L,5L,2L,3L,8L,16L,8L,3L,4L,2L,3L,2L,4L,2L,2L,5L,7L,4L,3L,8L,3L,2L,6L,2L,3L,6L,2L,2L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172035Inst : IEnumerable<long>
{
public static readonly long[] Value=A172035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172035.Bytes);
public long this[int i]=>Value[i];

public static A172035Inst Instance=new A172035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172036
{
public static readonly long[] Value={ 5L,23L,509L,2267L,9157L,26437L,44357L,55921L,82301L,184843L,276173L,611069L,732271L,757577L,1006559L,1067611L,1195547L,2132113L,2576683L,3243511L,3302393L,4258091L,5530033L,7326931L,7984121L,10518353L,10748449L,10864151L,11096587L,11937257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172036Inst : IEnumerable<long>
{
public static readonly long[] Value=A172036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172036.Bytes);
public long this[int i]=>Value[i];

public static A172036Inst Instance=new A172036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172037
{
public static readonly long[] Value={ 2L,5L,73L,167L,2423L,7621L,39233L,50969L,89563L,198139L,207029L,267143L,322963L,335117L,438517L,481207L,541547L,812051L,874697L,917611L,939293L,1077761L,1149593L,1354267L,1464011L,1695559L,1880401L,2510083L,2548703L,3115249L,3157487L,3505849L,4519057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172037Inst : IEnumerable<long>
{
public static readonly long[] Value=A172037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172037.Bytes);
public long this[int i]=>Value[i];

public static A172037Inst Instance=new A172037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172038
{
public static readonly long[] Value={ 0L,-1L,1L,0L,2L,-1L,3L,1L,0L,-1L,5L,2L,6L,-1L,1L,0L,8L,-1L,9L,4L,2L,-1L,11L,1L,0L,-1L,3L,6L,14L,-1L,15L,2L,4L,-1L,1L,0L,18L,-1L,5L,3L,20L,-1L,21L,10L,2L,-1L,23L,1L,0L,-1L,7L,12L,26L,-1L,3L,5L,8L,-1L,29L,2L,30L,-1L,1L,0L,4L,-1L,33L,16L,10L,-1L,35L,3L,36L,-1L,5L,18L,2L,-1L,39L,1L,0L,-1L,41L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172038Inst : IEnumerable<long>
{
public static readonly long[] Value=A172038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172038.Bytes);
public long this[int i]=>Value[i];

public static A172038Inst Instance=new A172038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172039
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,43L,47L,53L,59L,61L,67L,71L,73L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,251L,257L,163L,271L,277L,181L,283L,293L,307L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172039Inst : IEnumerable<long>
{
public static readonly long[] Value=A172039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172039.Bytes);
public long this[int i]=>Value[i];

public static A172039Inst Instance=new A172039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172040
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,4L,0L,6L,8L,8L,0L,22L,28L,24L,16L,0L,90L,112L,96L,64L,32L,0L,394L,484L,416L,288L,160L,64L,0L,1806L,2200L,1896L,1344L,800L,384L,128L,0L,8558L,10364L,8952L,6448L,4000L,2112L,896L,256L,0L,41586L,50144L,43392L,31616L,20160L,11264L,5376L,2048L,512L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172040Inst : IEnumerable<long>
{
public static readonly long[] Value=A172040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172040.Bytes);
public long this[int i]=>Value[i];

public static A172040Inst Instance=new A172040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172041
{
public static readonly BigInteger[] Value={ 5L,29L,536870909L,BigInteger.Parse("13803492693581127574869511724554050904902217944340773110325048447598589") };
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
public class A172041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172041Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A172041.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A172041.Bytes);
public BigInteger this[int i]=>Value[i];

public static A172041Inst Instance=new A172041Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172042
{
public static readonly long[] Value={ 1L,4L,8L,16L,32L,64L,96L,120L,240L,192L,288L,384L,384L,528L,1056L,1344L,896L,960L,960L,1152L,1728L,1920L,3200L,2560L,2560L,2560L,3328L,3744L,3456L,4032L,3456L,6144L,5632L,6336L,5760L,5760L,7776L,8856L,13776L,14784L,8448L,8640L,9216L,10752L,10080L,8640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172042Inst : IEnumerable<long>
{
public static readonly long[] Value=A172042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172042.Bytes);
public long this[int i]=>Value[i];

public static A172042Inst Instance=new A172042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172043
{
public static readonly long[] Value={ 1L,5L,19L,43L,77L,121L,175L,239L,313L,397L,491L,595L,709L,833L,967L,1111L,1265L,1429L,1603L,1787L,1981L,2185L,2399L,2623L,2857L,3101L,3355L,3619L,3893L,4177L,4471L,4775L,5089L,5413L,5747L,6091L,6445L,6809L,7183L,7567L,7961L,8365L,8779L,9203L,9637L,10081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172043Inst : IEnumerable<long>
{
public static readonly long[] Value=A172043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172043.Bytes);
public long this[int i]=>Value[i];

public static A172043Inst Instance=new A172043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172044
{
public static readonly long[] Value={ 1L,17L,43L,79L,125L,181L,247L,323L,409L,505L,611L,727L,853L,989L,1135L,1291L,1457L,1633L,1819L,2015L,2221L,2437L,2663L,2899L,3145L,3401L,3667L,3943L,4229L,4525L,4831L,5147L,5473L,5809L,6155L,6511L,6877L,7253L,7639L,8035L,8441L,8857L,9283L,9719L,10165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172044Inst : IEnumerable<long>
{
public static readonly long[] Value=A172044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172044.Bytes);
public long this[int i]=>Value[i];

public static A172044Inst Instance=new A172044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172045
{
public static readonly long[] Value={ 0L,1L,17L,80L,240L,565L,1141L,2072L,3480L,5505L,8305L,12056L,16952L,23205L,31045L,40720L,52496L,66657L,83505L,103360L,126560L,153461L,184437L,219880L,260200L,305825L,357201L,414792L,479080L,550565L,629765L,717216L,813472L,919105L,1034705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172045Inst : IEnumerable<long>
{
public static readonly long[] Value=A172045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172045.Bytes);
public long this[int i]=>Value[i];

public static A172045Inst Instance=new A172045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172046
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,6L,11L,18L,27L,38L,52L,69L,89L,113L,141L,173L,209L,250L,296L,347L,404L,467L,536L,611L,693L,782L,878L,982L,1094L,1214L,1342L,1479L,1625L,1780L,1945L,2120L,2305L,2500L,2706L,2923L,3151L,3391L,3643L,3907L,4183L,4472L,4774L,5089L,5418L,5761L,6118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172046Inst : IEnumerable<long>
{
public static readonly long[] Value=A172046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172046.Bytes);
public long this[int i]=>Value[i];

public static A172046Inst Instance=new A172046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172047
{
public static readonly long[] Value={ 0L,1L,25L,124L,380L,905L,1841L,3360L,5664L,8985L,13585L,19756L,27820L,38129L,51065L,67040L,86496L,109905L,137769L,170620L,209020L,253561L,304865L,363584L,430400L,506025L,591201L,686700L,793324L,911905L,1043305L,1188416L,1348160L,1523489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172047Inst : IEnumerable<long>
{
public static readonly long[] Value=A172047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172047.Bytes);
public long this[int i]=>Value[i];

public static A172047Inst Instance=new A172047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172048
{
public static readonly long[] Value={ 2L,14L,23L,32L,38L,41L,50L,53L,59L,68L,74L,77L,83L,86L,95L,98L,104L,113L,116L,122L,128L,131L,137L,140L,143L,149L,158L,167L,173L,176L,179L,182L,185L,188L,194L,200L,203L,212L,215L,218L,221L,230L,233L,239L,242L,248L,254L,257L,263L,266L,275L,278L,281L,284L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172048Inst : IEnumerable<long>
{
public static readonly long[] Value=A172048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172048.Bytes);
public long this[int i]=>Value[i];

public static A172048Inst Instance=new A172048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172049
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,7L,1L,3L,5L,7L,1L,3L,5L,7L,9L,11L,13L,15L,17L,1L,3L,5L,7L,9L,11L,13L,15L,17L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172049Inst : IEnumerable<long>
{
public static readonly long[] Value=A172049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172049.Bytes);
public long this[int i]=>Value[i];

public static A172049Inst Instance=new A172049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172050
{
public static readonly long[] Value={ 0L,4L,8L,13L,20L,30L,46L,72L,116L,191L,320L,542L,924L,1580L,2704L,4625L,7900L,13470L,22922L,38928L,65980L,111619L,188488L,317758L,534840L,898900L,1508696L,2528917L,4233956L,7080606L,11828710L,19741272L,32916164L,54835655L,91276304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172050Inst : IEnumerable<long>
{
public static readonly long[] Value=A172050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172050.Bytes);
public long this[int i]=>Value[i];

public static A172050Inst Instance=new A172050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172051
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172051Inst : IEnumerable<long>
{
public static readonly long[] Value=A172051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172051.Bytes);
public long this[int i]=>Value[i];

public static A172051Inst Instance=new A172051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172052
{
public static readonly long[] Value={ 1L,18L,21L,26L,27L,26L,29L,31L,32L,31L,32L,39L,39L,46L,48L,48L,44L,45L,45L,46L,36L,39L,39L,32L,35L,32L,31L,29L,29L,6L,8L,11L,7L,7L,10L,5L,4L,3L,6L,13L,25L,24L,25L,26L,27L,42L,41L,40L,39L,57L,58L,59L,61L,64L,74L,87L,87L,91L,93L,99L,102L,103L,102L,101L,102L,101L,108L,106L,111L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172052Inst : IEnumerable<long>
{
public static readonly long[] Value=A172052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172052.Bytes);
public long this[int i]=>Value[i];

public static A172052Inst Instance=new A172052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172053
{
public static readonly long[] Value={ 1L,22L,27L,36L,41L,46L,53L,65L,68L,77L,82L,99L,103L,112L,124L,128L,134L,139L,149L,162L,176L,183L,193L,206L,225L,232L,237L,243L,249L,276L,282L,287L,293L,301L,330L,339L,346L,351L,358L,371L,385L,402L,405L,408L,413L,434L,443L,454L,457L,479L,482L,497L,505L,510L,522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172053Inst : IEnumerable<long>
{
public static readonly long[] Value=A172053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172053.Bytes);
public long this[int i]=>Value[i];

public static A172053Inst Instance=new A172053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172054
{
public static readonly long[] Value={ 2L,3L,4L,2L,6L,7L,5L,7L,8L,7L,9L,12L,12L,12L,9L,4L,6L,4L,8L,9L,7L,8L,12L,11L,14L,17L,17L,12L,18L,17L,19L,13L,13L,10L,11L,9L,8L,7L,15L,17L,18L,13L,12L,13L,13L,11L,11L,15L,19L,19L,23L,23L,19L,12L,16L,17L,12L,11L,18L,22L,27L,29L,27L,27L,25L,18L,27L,28L,23L,22L,23L,17L,21L,24L,23L,23L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172054Inst : IEnumerable<long>
{
public static readonly long[] Value=A172054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172054.Bytes);
public long this[int i]=>Value[i];

public static A172054Inst Instance=new A172054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172055
{
public static readonly long[] Value={ 10L,19L,22L,30L,36L,45L,49L,63L,66L,85L,93L,98L,100L,110L,115L,122L,126L,132L,138L,143L,155L,158L,168L,171L,178L,185L,187L,198L,206L,213L,217L,229L,231L,236L,239L,243L,248L,255L,269L,275L,284L,293L,300L,309L,317L,321L,325L,331L,337L,343L,349L,351L,357L,378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172055Inst : IEnumerable<long>
{
public static readonly long[] Value=A172055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172055.Bytes);
public long this[int i]=>Value[i];

public static A172055Inst Instance=new A172055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172056
{
public static readonly long[] Value={ 59L,61L,103L,109L,149L,151L,163L,257L,313L,389L,401L,449L,479L,541L,569L,571L,673L,677L,709L,733L,769L,821L,823L,839L,857L,883L,919L,947L,971L,983L,1061L,1087L,1093L,1097L,1129L,1151L,1163L,1181L,1249L,1283L,1301L,1319L,1321L,1381L,1433L,1489L,1493L,1549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172056Inst : IEnumerable<long>
{
public static readonly long[] Value=A172056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172056.Bytes);
public long this[int i]=>Value[i];

public static A172056Inst Instance=new A172056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172057
{
public static readonly long[] Value={ 7L,13L,19L,31L,43L,61L,73L,103L,109L,139L,151L,181L,193L,199L,229L,241L,271L,283L,313L,349L,421L,433L,463L,523L,571L,601L,619L,643L,661L,811L,823L,829L,859L,883L,1021L,1033L,1051L,1063L,1093L,1153L,1231L,1279L,1291L,1303L,1321L,1429L,1453L,1483L,1489L,1609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172057Inst : IEnumerable<long>
{
public static readonly long[] Value=A172057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172057.Bytes);
public long this[int i]=>Value[i];

public static A172057Inst Instance=new A172057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172058
{
public static readonly long[] Value={ 3L,5L,19L,163L,379L,419L,827L,907L,1427L,1787L,1979L,1987L,2083L,2243L,2339L,2539L,2659L,2699L,3083L,3643L,3659L,4723L,5147L,5443L,5563L,5779L,6203L,6299L,6547L,6619L,6803L,6947L,7043L,7283L,7499L,7547L,7883L,7907L,8219L,8387L,8539L,8563L,8627L,8923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172058Inst : IEnumerable<long>
{
public static readonly long[] Value=A172058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172058.Bytes);
public long this[int i]=>Value[i];

public static A172058Inst Instance=new A172058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172059
{
public static readonly BigInteger[] Value={ 2L,5L,10L,17L,28L,41L,58L,89L,126L,197L,270L,349L,446L,559L,690L,889L,1200L,1537L,1910L,2643L,3562L,4553L,1111111111111115664L,BigInteger.Parse("11112222222222222226775") };
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
public class A172059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A172059.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A172059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A172059Inst Instance=new A172059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172060
{
public static readonly long[] Value={ 0L,2L,14L,76L,374L,1748L,7916L,35096L,153254L,661636L,2831300L,12030632L,50826684L,213707336L,894945944L,3734901296L,15540685574L,64496348516L,267060529364L,1103587381256L,4552196053844L,18747042089816L,77092267322984L,316602500019536L,1298657603761244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172060Inst : IEnumerable<long>
{
public static readonly long[] Value=A172060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172060.Bytes);
public long this[int i]=>Value[i];

public static A172060Inst Instance=new A172060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172061
{
public static readonly long[] Value={ 1L,5L,22L,91L,367L,1461L,5776L,22748L,89402L,350974L,1377174L,5403193L,21201211L,83211277L,326703424L,1283211208L,5042294926L,19822108582L,77958648604L,306739666198L,1207433301046L,4754874514690L,18732340230592L,73827134976216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172061Inst : IEnumerable<long>
{
public static readonly long[] Value=A172061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172061.Bytes);
public long this[int i]=>Value[i];

public static A172061Inst Instance=new A172061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172062
{
public static readonly long[] Value={ 1L,6L,29L,128L,541L,2232L,9076L,36568L,146446L,584082L,2322967L,9220544L,36548573L,144732176L,572756312L,2265577184L,8959034798L,35421613196L,140035644602L,553606049024L,2188652065586L,8653317051056L,34216118389384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172062Inst : IEnumerable<long>
{
public static readonly long[] Value=A172062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172062.Bytes);
public long this[int i]=>Value[i];

public static A172062Inst Instance=new A172062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172063
{
public static readonly long[] Value={ 1L,7L,37L,174L,771L,3300L,13820L,57044L,233108L,945793L,3817351L,15347362L,61520899L,246052888L,982365976L,3916739872L,15599504614L,62076995998L,246866382826L,981218764540L,3898442536366L,15483778158792L,61482966826992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172063Inst : IEnumerable<long>
{
public static readonly long[] Value=A172063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172063.Bytes);
public long this[int i]=>Value[i];

public static A172063Inst Instance=new A172063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172064
{
public static readonly long[] Value={ 1L,8L,46L,230L,1068L,4744L,20476L,86662L,361711L,1494384L,6126818L,24972326L,101320712L,409609664L,1651162688L,6640469816L,26655382802L,106830738224L,427612715516L,1709790470780L,6830461107736L,27266848437608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172064Inst : IEnumerable<long>
{
public static readonly long[] Value=A172064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172064.Bytes);
public long this[int i]=>Value[i];

public static A172064Inst Instance=new A172064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172065
{
public static readonly long[] Value={ 1L,9L,56L,297L,1444L,6656L,29618L,128603L,548591L,2309467L,9624964L,39799813L,163556776L,668796712L,2723729944L,11055878188L,44753742226L,180746332690L,728571706240L,2932018571370L,11783070278816L,47297147250204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172065Inst : IEnumerable<long>
{
public static readonly long[] Value=A172065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172065.Bytes);
public long this[int i]=>Value[i];

public static A172065Inst Instance=new A172065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172066
{
public static readonly long[] Value={ 1L,10L,67L,376L,1912L,9142L,41941L,186880L,815083L,3498146L,14827487L,62236064L,259187048L,1072567256L,4415408372L,18098359424L,73915594466L,300958990724L,1222228100590L,4952609171080L,20030298812596L,80876902778482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172066Inst : IEnumerable<long>
{
public static readonly long[] Value=A172066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172066.Bytes);
public long this[int i]=>Value[i];

public static A172066Inst Instance=new A172066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172067
{
public static readonly long[] Value={ 1L,11L,79L,468L,2486L,12323L,58277L,266492L,1188679L,5202523L,22436251L,95630272L,403770544L,1691678428L,7042481236L,29161852240L,120212658034L,493656394350L,2020590599710L,8247228533780L,33579755528278L,136434358356201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172067Inst : IEnumerable<long>
{
public static readonly long[] Value=A172067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172067.Bytes);
public long this[int i]=>Value[i];

public static A172067Inst Instance=new A172067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172068
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,4L,6L,6L,4L,12L,12L,8L,20L,20L,16L,8L,40L,40L,32L,16L,70L,70L,60L,40L,16L,140L,140L,120L,80L,32L,252L,252L,224L,168L,96L,32L,504L,504L,448L,336L,192L,64L,924L,924L,840L,672L,448L,224L,64L,1848L,1848L,1680L,1344L,896L,448L,128L,3432L,3432L,3168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172068Inst : IEnumerable<long>
{
public static readonly long[] Value=A172068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172068.Bytes);
public long this[int i]=>Value[i];

public static A172068Inst Instance=new A172068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172069
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,0L,1L,1L,0L,0L,0L,1L,2L,0L,2L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,2L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172069Inst : IEnumerable<long>
{
public static readonly long[] Value=A172069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172069.Bytes);
public long this[int i]=>Value[i];

public static A172069Inst Instance=new A172069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172070
{
public static readonly long[] Value={ 3L,11L,17L,29L,41L,59L,71L,101L,107L,137L,149L,179L,191L,197L,227L,239L,269L,281L,311L,347L,419L,431L,461L,521L,569L,599L,617L,641L,659L,809L,821L,827L,857L,881L,1019L,1031L,1049L,1061L,1091L,1151L,1229L,1277L,1289L,1301L,1319L,1427L,1451L,1481L,1487L,1607L,1619L,1667L,1697L,1721L,1787L,1871L,1877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172070Inst : IEnumerable<long>
{
public static readonly long[] Value=A172070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172070.Bytes);
public long this[int i]=>Value[i];

public static A172070Inst Instance=new A172070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172071
{
public static readonly long[] Value={ 2L,11L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,67L,73L,79L,89L,103L,107L,109L,113L,137L,157L,163L,173L,179L,197L,199L,229L,233L,239L,257L,263L,269L,277L,283L,313L,317L,337L,353L,359L,373L,379L,389L,439L,449L,463L,467L,509L,547L,563L,569L,577L,593L,599L,607L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172071Inst : IEnumerable<long>
{
public static readonly long[] Value=A172071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172071.Bytes);
public long this[int i]=>Value[i];

public static A172071Inst Instance=new A172071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172072
{
public static readonly long[] Value={ 1L,5L,6L,7L,8L,9L,10L,12L,14L,15L,16L,17L,19L,21L,22L,24L,27L,28L,29L,30L,33L,37L,38L,40L,41L,45L,46L,50L,51L,52L,55L,56L,57L,59L,61L,65L,66L,68L,71L,72L,74L,75L,77L,85L,87L,90L,91L,97L,101L,103L,104L,106L,108L,109L,111L,112L,114L,118L,119L,120L,124L,130L,131L,134L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172072Inst : IEnumerable<long>
{
public static readonly long[] Value=A172072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172072.Bytes);
public long this[int i]=>Value[i];

public static A172072Inst Instance=new A172072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172073
{
public static readonly long[] Value={ 0L,1L,15L,54L,130L,255L,441L,700L,1044L,1485L,2035L,2706L,3510L,4459L,5565L,6840L,8296L,9945L,11799L,13870L,16170L,18711L,21505L,24564L,27900L,31525L,35451L,39690L,44254L,49155L,54405L,60016L,66000L,72369L,79135L,86310L,93906L,101935L,110409L,119340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172073Inst : IEnumerable<long>
{
public static readonly long[] Value=A172073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172073.Bytes);
public long this[int i]=>Value[i];

public static A172073Inst Instance=new A172073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172074
{
public static readonly long[] Value={ 161L,1L,4L,11L,1L,1L,3L,6L,1L,13L,8L,1L,6L,1L,4L,1L,1L,2L,1L,1L,1L,1L,13L,2L,1L,3L,8L,1L,2L,19L,1L,54L,1L,19L,2L,1L,8L,3L,1L,2L,13L,1L,1L,1L,1L,2L,1L,1L,4L,1L,6L,1L,8L,13L,1L,6L,3L,1L,1L,11L,4L,1L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172074Inst : IEnumerable<long>
{
public static readonly long[] Value=A172074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172074.Bytes);
public long this[int i]=>Value[i];

public static A172074Inst Instance=new A172074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172075
{
public static readonly long[] Value={ 0L,1L,29L,146L,450L,1075L,2191L,4004L,6756L,10725L,16225L,23606L,33254L,45591L,61075L,80200L,103496L,131529L,164901L,204250L,250250L,303611L,365079L,435436L,515500L,606125L,708201L,822654L,950446L,1092575L,1250075L,1424016L,1615504L,1825681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172075Inst : IEnumerable<long>
{
public static readonly long[] Value=A172075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172075.Bytes);
public long this[int i]=>Value[i];

public static A172075Inst Instance=new A172075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172076
{
public static readonly long[] Value={ 0L,1L,17L,62L,150L,295L,511L,812L,1212L,1725L,2365L,3146L,4082L,5187L,6475L,7960L,9656L,11577L,13737L,16150L,18830L,21791L,25047L,28612L,32500L,36725L,41301L,46242L,51562L,57275L,63395L,69936L,76912L,84337L,92225L,100590L,109446L,118807L,128687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172076Inst : IEnumerable<long>
{
public static readonly long[] Value=A172076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172076.Bytes);
public long this[int i]=>Value[i];

public static A172076Inst Instance=new A172076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172077
{
public static readonly long[] Value={ 0L,1L,33L,168L,520L,1245L,2541L,4648L,7848L,12465L,18865L,27456L,38688L,53053L,71085L,93360L,120496L,153153L,192033L,237880L,291480L,353661L,425293L,507288L,600600L,706225L,825201L,958608L,1107568L,1273245L,1456845L,1659616L,1882848L,2127873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172077Inst : IEnumerable<long>
{
public static readonly long[] Value=A172077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172077.Bytes);
public long this[int i]=>Value[i];

public static A172077Inst Instance=new A172077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172078
{
public static readonly long[] Value={ 0L,1L,19L,70L,170L,335L,581L,924L,1380L,1965L,2695L,3586L,4654L,5915L,7385L,9080L,11016L,13209L,15675L,18430L,21490L,24871L,28589L,32660L,37100L,41925L,47151L,52794L,58870L,65395L,72385L,79856L,87824L,96305L,105315L,114870L,124986L,135679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172078Inst : IEnumerable<long>
{
public static readonly long[] Value=A172078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172078.Bytes);
public long this[int i]=>Value[i];

public static A172078Inst Instance=new A172078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172079
{
public static readonly long[] Value={ 6L,12L,24L,12L,48L,60L,12L,48L,120L,12L,480L,180L,300L,48L,120L,132L,408L,180L,792L,120L,660L,132L,288L,240L,12L,300L,540L,240L,780L,120L,48L,732L,1260L,1188L,600L,1092L,408L,432L,1848L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172079Inst : IEnumerable<long>
{
public static readonly long[] Value=A172079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172079.Bytes);
public long this[int i]=>Value[i];

public static A172079Inst Instance=new A172079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172080
{
public static readonly long[] Value={ 0L,1L,37L,190L,590L,1415L,2891L,5292L,8940L,14205L,21505L,31306L,44122L,60515L,81095L,106520L,137496L,174777L,219165L,271510L,332710L,403711L,485507L,579140L,685700L,806325L,942201L,1094562L,1264690L,1453915L,1663615L,1895216L,2150192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172080Inst : IEnumerable<long>
{
public static readonly long[] Value=A172080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172080.Bytes);
public long this[int i]=>Value[i];

public static A172080Inst Instance=new A172080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172081
{
public static readonly long[] Value={ 8L,9L,6L,9L,4L,6L,3L,8L,7L,4L,2L,4L,6L,0L,6L,1L,7L,2L,9L,1L,2L,6L,0L,0L,3L,7L,1L,0L,6L,8L,7L,6L,5L,4L,4L,4L,1L,7L,9L,9L,9L,3L,7L,5L,7L,4L,2L,0L,9L,1L,8L,0L,5L,6L,1L,6L,5L,8L,2L,7L,4L,6L,4L,9L,6L,1L,0L,3L,8L,1L,4L,1L,5L,4L,0L,6L,2L,4L,2L,0L,8L,2L,2L,4L,1L,3L,4L,6L,3L,5L,6L,7L,1L,9L,7L,5L,3L,1L,4L,4L,4L,7L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172081Inst : IEnumerable<long>
{
public static readonly long[] Value=A172081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172081.Bytes);
public long this[int i]=>Value[i];

public static A172081Inst Instance=new A172081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172082
{
public static readonly long[] Value={ 0L,1L,21L,78L,190L,375L,651L,1036L,1548L,2205L,3025L,4026L,5226L,6643L,8295L,10200L,12376L,14841L,17613L,20710L,24150L,27951L,32131L,36708L,41700L,47125L,53001L,59346L,66178L,73515L,81375L,89776L,98736L,108273L,118405L,129150L,140526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172082Inst : IEnumerable<long>
{
public static readonly long[] Value=A172082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172082.Bytes);
public long this[int i]=>Value[i];

public static A172082Inst Instance=new A172082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172083
{
public static readonly long[] Value={ 1L,-3L,2L,-1L,-1L,1L,1L,-1L,-1L,1L,5L,-5L,-691L,691L,7L,-7L,-3617L,3617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172083Inst : IEnumerable<long>
{
public static readonly long[] Value=A172083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172083.Bytes);
public long this[int i]=>Value[i];

public static A172083Inst Instance=new A172083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172084
{
public static readonly long[] Value={ 3L,2L,8L,6L,4L,5L,0L,5L,5L,2L,7L,7L,9L,4L,1L,0L,4L,2L,2L,8L,7L,8L,2L,5L,7L,1L,9L,3L,7L,7L,2L,9L,2L,9L,0L,6L,5L,3L,1L,4L,7L,4L,4L,5L,2L,1L,4L,0L,2L,6L,7L,4L,2L,2L,4L,4L,0L,3L,0L,5L,5L,1L,8L,7L,7L,4L,4L,6L,8L,3L,6L,1L,9L,7L,8L,8L,3L,3L,1L,8L,5L,4L,4L,5L,7L,7L,3L,0L,7L,8L,8L,9L,8L,1L,1L,8L,9L,6L,0L,0L,4L,9L,3L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172084Inst : IEnumerable<long>
{
public static readonly long[] Value=A172084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172084.Bytes);
public long this[int i]=>Value[i];

public static A172084Inst Instance=new A172084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172085
{
public static readonly long[] Value={ 0L,1L,41L,212L,660L,1585L,3241L,5936L,10032L,15945L,24145L,35156L,49556L,67977L,91105L,119680L,154496L,196401L,246297L,305140L,373940L,453761L,545721L,650992L,770800L,906425L,1059201L,1230516L,1421812L,1634585L,1870385L,2130816L,2417536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172085Inst : IEnumerable<long>
{
public static readonly long[] Value=A172085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172085.Bytes);
public long this[int i]=>Value[i];

public static A172085Inst Instance=new A172085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172086
{
public static readonly long[] Value={ 2L,-2L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,5L,-5L,-691L,691L,7L,-7L,-3617L,3617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172086Inst : IEnumerable<long>
{
public static readonly long[] Value=A172086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172086.Bytes);
public long this[int i]=>Value[i];

public static A172086Inst Instance=new A172086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172087
{
public static readonly long[] Value={ 1L,1L,3L,3L,15L,15L,21L,21L,15L,15L,33L,33L,1365L,1365L,3L,3L,255L,255L,399L,399L,165L,165L,69L,69L,1365L,1365L,3L,3L,435L,435L,7161L,7161L,255L,255L,3L,3L,959595L,959595L,3L,3L,6765L,6765L,903L,903L,345L,345L,141L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172087Inst : IEnumerable<long>
{
public static readonly long[] Value=A172087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172087.Bytes);
public long this[int i]=>Value[i];

public static A172087Inst Instance=new A172087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172088
{
public static readonly long[] Value={ -1L,-1L,-1L,-1L,0L,-1L,-1L,0L,0L,-1L,-1L,4L,4L,4L,-1L,-1L,6L,10L,10L,6L,-1L,-1L,32L,38L,42L,38L,32L,-1L,-1L,56L,88L,94L,94L,88L,56L,-1L,-1L,278L,334L,366L,368L,366L,334L,278L,-1L,-1L,560L,838L,894L,922L,922L,894L,838L,560L,-1L,-1L,2894L,3454L,3732L,3784L,3810L,3784L,3732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172088Inst : IEnumerable<long>
{
public static readonly long[] Value=A172088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172088.Bytes);
public long this[int i]=>Value[i];

public static A172088Inst Instance=new A172088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172089
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,3L,2L,3L,8L,6L,8L,3L,8L,15L,20L,20L,15L,8L,15L,48L,45L,80L,45L,48L,15L,48L,105L,168L,210L,210L,168L,105L,48L,105L,384L,420L,896L,630L,896L,420L,384L,105L,384L,945L,1728L,2520L,3024L,3024L,2520L,1728L,945L,384L,945L,3840L,4725L,11520L,9450L,16128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172089Inst : IEnumerable<long>
{
public static readonly long[] Value=A172089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172089.Bytes);
public long this[int i]=>Value[i];

public static A172089Inst Instance=new A172089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172090
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172090Inst : IEnumerable<long>
{
public static readonly long[] Value=A172090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172090.Bytes);
public long this[int i]=>Value[i];

public static A172090Inst Instance=new A172090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172091
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,1L,1L,-17L,-17L,1L,1L,-293L,-309L,-293L,1L,1L,-9449L,-9741L,-9741L,-9449L,1L,1L,-605429L,-614877L,-615153L,-614877L,-605429L,1L,1L,-77514569L,-78119997L,-78129429L,-78129429L,-78119997L,-77514569L,1L,1L,-19844960309L,-19922474877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172091Inst : IEnumerable<long>
{
public static readonly long[] Value=A172091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172091.Bytes);
public long this[int i]=>Value[i];

public static A172091Inst Instance=new A172091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172092
{
public static readonly long[] Value={ 1L,1L,1L,1L,-2L,1L,1L,-47L,-47L,1L,1L,-2027L,-2072L,-2027L,1L,1L,-249599L,-251624L,-251624L,-249599L,1L,1L,-91359839L,-91609436L,-91611416L,-91609436L,-91359839L,1L,1L,-100039779839L,-100131139676L,-100131389228L,-100131389228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172092Inst : IEnumerable<long>
{
public static readonly long[] Value=A172092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172092.Bytes);
public long this[int i]=>Value[i];

public static A172092Inst Instance=new A172092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172093
{
public static readonly long[] Value={ 1L,1L,1L,1L,-3L,1L,1L,-99L,-99L,1L,1L,-8819L,-8915L,-8819L,1L,1L,-3034499L,-3043315L,-3043315L,-3034499L,1L,1L,-4151231699L,-4154266195L,-4154274915L,-4154266195L,-4151231699L,1L,1L,-22682342182499L,-22686493414195L,-22686496448595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172093Inst : IEnumerable<long>
{
public static readonly long[] Value=A172093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172093.Bytes);
public long this[int i]=>Value[i];

public static A172093Inst Instance=new A172093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172094
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,11L,17L,7L,1L,45L,76L,40L,10L,1L,197L,353L,216L,72L,13L,1L,903L,1688L,1145L,458L,113L,16L,1L,4279L,8257L,6039L,2745L,829L,163L,19L,1L,20793L,41128L,31864L,15932L,5558L,1356L,222L,22L,1L,103049L,207905L,168584L,90776L,35318L,10070L,2066L,290L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172094Inst : IEnumerable<long>
{
public static readonly long[] Value=A172094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172094.Bytes);
public long this[int i]=>Value[i];

public static A172094Inst Instance=new A172094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172095
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,13L,17L,19L,27L,37L,53L,107L,163L,243L,2187L,2917L,4373L,8747L,1594323L,86093443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172095Inst : IEnumerable<long>
{
public static readonly long[] Value=A172095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172095.Bytes);
public long this[int i]=>Value[i];

public static A172095Inst Instance=new A172095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172096
{
public static readonly long[] Value={ 13L,17L,23L,31L,41L,47L,53L,59L,61L,67L,71L,73L,89L,97L,103L,107L,109L,131L,137L,151L,157L,167L,181L,191L,193L,199L,211L,227L,229L,233L,239L,241L,257L,263L,277L,281L,283L,293L,311L,313L,317L,331L,337L,347L,353L,359L,367L,379L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172096Inst : IEnumerable<long>
{
public static readonly long[] Value=A172096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172096.Bytes);
public long this[int i]=>Value[i];

public static A172096Inst Instance=new A172096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172097
{
public static readonly long[] Value={ 3L,3L,7L,3L,7L,11L,15L,3L,7L,11L,15L,19L,23L,27L,31L,3L,7L,11L,15L,19L,23L,27L,31L,35L,39L,43L,47L,51L,55L,59L,63L,3L,7L,11L,15L,19L,23L,27L,31L,35L,39L,43L,47L,51L,55L,59L,63L,67L,71L,75L,79L,83L,87L,91L,95L,99L,103L,107L,111L,115L,119L,123L,127L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172097Inst : IEnumerable<long>
{
public static readonly long[] Value=A172097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172097.Bytes);
public long this[int i]=>Value[i];

public static A172097Inst Instance=new A172097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172098
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,3L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,2L,3L,2L,3L,2L,3L,3L,3L,3L,2L,3L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172098Inst : IEnumerable<long>
{
public static readonly long[] Value=A172098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172098.Bytes);
public long this[int i]=>Value[i];

public static A172098Inst Instance=new A172098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172099
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172099Inst : IEnumerable<long>
{
public static readonly long[] Value=A172099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172099.Bytes);
public long this[int i]=>Value[i];

public static A172099Inst Instance=new A172099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172100
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172100Inst : IEnumerable<long>
{
public static readonly long[] Value=A172100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172100.Bytes);
public long this[int i]=>Value[i];

public static A172100Inst Instance=new A172100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172101
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,2L,2L,1L,0L,1L,2L,4L,2L,1L,0L,1L,3L,6L,6L,3L,1L,0L,1L,3L,9L,9L,9L,3L,1L,0L,1L,4L,12L,18L,18L,12L,4L,1L,0L,1L,4L,16L,24L,36L,24L,16L,4L,1L,0L,1L,5L,20L,40L,60L,60L,40L,20L,5L,1L,0L,1L,5L,25L,50L,100L,100L,100L,50L,25L,5L,1L,0L,1L,6L,30L,75L,150L,200L,200L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172101Inst : IEnumerable<long>
{
public static readonly long[] Value=A172101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172101.Bytes);
public long this[int i]=>Value[i];

public static A172101Inst Instance=new A172101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172102
{
public static readonly long[] Value={ 3L,11L,29L,59L,101L,239L,619L,809L,4253L,5323L,5923L,6551L,29131L,37277L,48341L,54413L,58711L,60937L,70537L,101063L,110533L,214993L,224603L,417203L,445069L,466537L,473867L,511391L,519089L,534629L,633449L,686269L,713771L,741913L,770767L,1000537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172102Inst : IEnumerable<long>
{
public static readonly long[] Value=A172102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172102.Bytes);
public long this[int i]=>Value[i];

public static A172102Inst Instance=new A172102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172103
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,5L,6L,7L,8L,9L,9L,10L,10L,11L,12L,12L,13L,14L,15L,15L,15L,16L,17L,17L,18L,18L,18L,19L,20L,21L,21L,22L,23L,23L,23L,23L,23L,24L,25L,26L,26L,27L,28L,29L,30L,30L,31L,31L,32L,32L,32L,33L,34L,34L,34L,34L,34L,35L,36L,37L,37L,37L,37L,38L,39L,39L,40L,40L,40L,41L,41L,42L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172103Inst : IEnumerable<long>
{
public static readonly long[] Value=A172103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172103.Bytes);
public long this[int i]=>Value[i];

public static A172103Inst Instance=new A172103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A172104
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,6L,6L,6L,7L,8L,9L,10L,10L,10L,11L,12L,13L,13L,13L,14L,14L,15L,15L,16L,17L,18L,18L,18L,19L,19L,20L,21L,21L,22L,22L,23L,24L,24L,25L,25L,25L,25L,25L,26L,27L,28L,28L,28L,28L,29L,30L,30L,30L,31L,32L,32L,33L,33L,33L,34L,35L,36L,36L,36L,37L,37L,38L,38L,39L,39L,40L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A172104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A172104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A172104Inst : IEnumerable<long>
{
public static readonly long[] Value=A172104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A172104.Bytes);
public long this[int i]=>Value[i];

public static A172104Inst Instance=new A172104Inst();

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