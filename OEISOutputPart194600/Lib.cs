using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A245262
{
public static readonly long[] Value={ 4L,2L,7L,6L,8L,6L,6L,1L,6L,0L,1L,7L,9L,2L,8L,7L,9L,7L,4L,0L,6L,7L,5L,5L,6L,4L,2L,1L,1L,2L,6L,9L,5L,1L,9L,1L,9L,3L,6L,2L,4L,5L,5L,3L,4L,5L,2L,7L,8L,1L,9L,5L,8L,8L,7L,6L,3L,6L,0L,6L,0L,9L,7L,1L,9L,0L,3L,5L,2L,0L,5L,5L,9L,0L,8L,8L,3L,4L,0L,0L,3L,6L,9L,6L,4L,3L,9L,6L,9L,8L,3L,4L,2L,8L,4L,5L,8L,8L,9L,3L,4L,9L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245262Inst : IEnumerable<long>
{
public static readonly long[] Value=A245262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245262.Bytes);
public long this[int i]=>Value[i];

public static A245262Inst Instance=new A245262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245263
{
public static readonly long[] Value={ 3L,8L,9L,1L,1L,5L,6L,8L,2L,3L,3L,2L,6L,8L,5L,3L,8L,1L,8L,0L,7L,8L,2L,6L,2L,5L,5L,6L,7L,1L,9L,9L,0L,5L,0L,4L,9L,8L,5L,2L,9L,8L,1L,4L,4L,5L,6L,7L,0L,1L,3L,9L,2L,9L,9L,6L,2L,7L,7L,2L,8L,9L,5L,6L,0L,0L,8L,9L,3L,8L,8L,4L,1L,5L,4L,4L,1L,8L,3L,7L,2L,8L,5L,9L,6L,1L,9L,8L,0L,6L,2L,7L,0L,8L,3L,4L,4L,6L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245263Inst : IEnumerable<long>
{
public static readonly long[] Value=A245263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245263.Bytes);
public long this[int i]=>Value[i];

public static A245263Inst Instance=new A245263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245264
{
public static readonly long[] Value={ 1L,2L,6L,12L,26L,53L,110L,231L,483L,1013L,2125L,4445L,9307L,19487L,40802L,85439L,178910L,374622L,784426L,1642522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245264Inst : IEnumerable<long>
{
public static readonly long[] Value=A245264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245264.Bytes);
public long this[int i]=>Value[i];

public static A245264Inst Instance=new A245264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245265
{
public static readonly BigInteger[] Value={ 1L,1L,3L,37L,649L,15461L,471571L,17456041L,760880625L,38178439849L,2167446089251L,137359883836781L,9612722107574521L,736277501363180557L,BigInteger.Parse("61265207586681046131"),BigInteger.Parse("5503291392884323494961"),BigInteger.Parse("530778414439201798454881"),BigInteger.Parse("54706967800114521799571921"),BigInteger.Parse("6000952913613549583603208515") };
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
public class A245265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245265Inst Instance=new A245265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245266
{
public static readonly BigInteger[] Value={ 1L,1L,2L,12L,102L,1062L,13812L,215592L,3896892L,80103612L,1847079192L,47204854992L,1324132604232L,40446893218632L,1336423937927472L,47492006442366432L,1806200688076918032L,BigInteger.Parse("73199329659111178512"),BigInteger.Parse("3149155288463030836512"),BigInteger.Parse("143338650123433404564672") };
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
public class A245266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245266Inst Instance=new A245266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245267
{
public static readonly BigInteger[] Value={ 1L,1L,2L,14L,140L,1676L,25076L,453332L,9503324L,226526300L,6060973796L,179862832196L,5861003051852L,208044896591564L,7990667301671060L,330174871461525236L,14604088858565826236UL,BigInteger.Parse("688475187932426663612"),BigInteger.Parse("34460842719620518022084"),BigInteger.Parse("1825219532294016983274020") };
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
public class A245267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245267.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245267Inst Instance=new A245267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245268
{
public static readonly long[] Value={ 1L,3L,7L,14L,26L,48L,92L,184L,375L,758L,1497L,2884L,5461L,10286L,19507L,37584L,73866L,147987L,301075L,618794L,1278116L,2640993L,5439593L,11138764L,22640100L,45644797L,91293390L,181301470L,358024924L,704359427L,1383415456L,2718141072L,5351701032L,10570658330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245268Inst : IEnumerable<long>
{
public static readonly long[] Value=A245268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245268.Bytes);
public long this[int i]=>Value[i];

public static A245268Inst Instance=new A245268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245269
{
public static readonly long[] Value={ 1L,3L,7L,15L,31L,63L,127L,254L,502L,978L,1882L,3600L,6904L,13380L,26332L,52664L,106744L,218232L,447736L,917760L,1873312L,3799920L,7653136L,15306272L,30429856L,60234528L,118956831L,234885092L,464595690L,921868388L,1836393687L,3672648928L,7369572624L,14821243232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245269Inst : IEnumerable<long>
{
public static readonly long[] Value=A245269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245269.Bytes);
public long this[int i]=>Value[i];

public static A245269Inst Instance=new A245269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245270
{
public static readonly long[] Value={ 5L,7L,10L,11L,47L,15L,11L,14L,91L,23L,87L,27L,95L,123L,20L,35L,94L,39L,171L,127L,183L,47L,95L,22L,187L,15L,175L,59L,763L,63L,21L,247L,355L,191L,174L,75L,359L,251L,187L,83L,767L,87L,343L,235L,367L,95L,167L,30L,182L,483L,347L,107L,95L,375L,191L,487L,379L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245270Inst : IEnumerable<long>
{
public static readonly long[] Value=A245270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245270.Bytes);
public long this[int i]=>Value[i];

public static A245270Inst Instance=new A245270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245271
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,13L,22L,36L,58L,95L,154L,249L,403L,652L,1056L,1709L,2766L,4475L,7241L,11717L,18959L,30676L,49635L,80311L,129947L,210258L,340205L,550464L,890670L,1441135L,2331806L,3772941L,6104748L,9877690L,15982438L,25860128L,41842566L,67702694L,109545261L,177247955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245271Inst : IEnumerable<long>
{
public static readonly long[] Value=A245271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245271.Bytes);
public long this[int i]=>Value[i];

public static A245271Inst Instance=new A245271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245272
{
public static readonly long[] Value={ 25L,49L,55L,85L,91L,115L,121L,133L,143L,145L,169L,175L,187L,203L,205L,217L,235L,247L,253L,259L,265L,289L,295L,299L,301L,319L,323L,325L,341L,343L,355L,361L,385L,391L,403L,413L,415L,427L,445L,451L,469L,473L,475L,481L,493L,505L,511L,517L,529L,533L,535L,551L,553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245272Inst : IEnumerable<long>
{
public static readonly long[] Value=A245272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245272.Bytes);
public long this[int i]=>Value[i];

public static A245272Inst Instance=new A245272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245273
{
public static readonly long[] Value={ 0L,0L,6L,3L,5L,6L,4L,5L,5L,9L,0L,8L,5L,8L,4L,8L,5L,1L,2L,1L,0L,1L,0L,0L,0L,2L,6L,7L,2L,9L,9L,6L,0L,4L,3L,8L,1L,9L,8L,9L,9L,4L,9L,1L,0L,1L,6L,0L,9L,1L,9L,8L,8L,1L,1L,6L,9L,8L,6L,8L,2L,8L,0L,8L,5L,7L,7L,6L,0L,0L,7L,8L,3L,9L,8L,0L,8L,5L,3L,4L,2L,7L,6L,4L,8L,7L,0L,5L,6L,0L,3L,2L,8L,0L,8L,3L,9L,2L,4L,7L,2L,6L,6L,3L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245273Inst : IEnumerable<long>
{
public static readonly long[] Value=A245273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245273.Bytes);
public long this[int i]=>Value[i];

public static A245273Inst Instance=new A245273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245274
{
public static readonly long[] Value={ 35L,65L,77L,95L,119L,121L,125L,143L,155L,161L,185L,187L,203L,209L,215L,217L,221L,245L,247L,275L,287L,289L,299L,305L,323L,329L,335L,341L,365L,371L,377L,395L,407L,413L,425L,427L,437L,455L,473L,485L,497L,515L,517L,527L,529L,533L,539L,545L,551L,575L,581L,583L,605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245274Inst : IEnumerable<long>
{
public static readonly long[] Value=A245274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245274.Bytes);
public long this[int i]=>Value[i];

public static A245274Inst Instance=new A245274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245275
{
public static readonly long[] Value={ 0L,4L,6L,1L,5L,4L,3L,1L,7L,2L,9L,5L,8L,0L,4L,6L,0L,2L,7L,5L,7L,1L,0L,7L,9L,9L,0L,3L,7L,9L,0L,7L,7L,3L,0L,3L,5L,3L,0L,2L,6L,7L,9L,6L,2L,3L,2L,4L,1L,4L,4L,9L,9L,0L,3L,4L,8L,8L,4L,8L,4L,5L,3L,5L,0L,8L,0L,4L,2L,6L,7L,6L,2L,4L,9L,6L,6L,6L,9L,5L,5L,4L,7L,0L,1L,3L,2L,2L,6L,3L,3L,2L,2L,7L,9L,1L,0L,8L,0L,8L,8L,3L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245275Inst : IEnumerable<long>
{
public static readonly long[] Value=A245275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245275.Bytes);
public long this[int i]=>Value[i];

public static A245275Inst Instance=new A245275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245276
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,5L,8L,2L,3L,1L,4L,5L,2L,1L,0L,5L,9L,2L,2L,7L,6L,2L,6L,6L,8L,2L,3L,8L,9L,1L,4L,5L,7L,8L,4L,7L,3L,9L,6L,4L,1L,8L,9L,2L,4L,8L,9L,8L,6L,5L,1L,8L,7L,7L,0L,2L,7L,3L,4L,5L,2L,6L,7L,2L,8L,9L,1L,2L,1L,3L,0L,0L,0L,6L,2L,6L,2L,4L,0L,2L,2L,6L,6L,8L,2L,9L,8L,1L,0L,0L,3L,4L,8L,1L,3L,6L,6L,9L,9L,4L,1L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245276Inst : IEnumerable<long>
{
public static readonly long[] Value=A245276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245276.Bytes);
public long this[int i]=>Value[i];

public static A245276Inst Instance=new A245276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245277
{
public static readonly long[] Value={ 2L,11L,67L,23L,37L,491L,47L,373L,79L,6043L,379L,2203L,647L,3389L,631L,34807L,211L,28663L,1283L,6449L,439L,266003L,577L,15649L,1811L,244471L,379L,485504623L,157L,31907L,2939L,15269L,2557L,22948529L,853L,197959L,743L,59723L,113L,96873817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245277Inst : IEnumerable<long>
{
public static readonly long[] Value=A245277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245277.Bytes);
public long this[int i]=>Value[i];

public static A245277Inst Instance=new A245277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245278
{
public static readonly long[] Value={ 5L,7L,8L,4L,1L,6L,7L,6L,2L,7L,8L,8L,9L,0L,0L,7L,5L,9L,0L,7L,4L,6L,0L,2L,0L,5L,8L,1L,4L,6L,1L,9L,5L,6L,7L,4L,7L,9L,9L,4L,8L,3L,9L,6L,9L,4L,3L,6L,6L,4L,5L,5L,0L,1L,5L,4L,8L,3L,1L,7L,6L,7L,4L,9L,4L,1L,7L,9L,6L,0L,2L,0L,8L,2L,4L,1L,2L,2L,0L,7L,1L,4L,5L,0L,6L,5L,8L,2L,7L,4L,8L,7L,0L,0L,2L,7L,9L,3L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245278Inst : IEnumerable<long>
{
public static readonly long[] Value=A245278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245278.Bytes);
public long this[int i]=>Value[i];

public static A245278Inst Instance=new A245278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245279
{
public static readonly long[] Value={ 1L,8L,2L,4L,8L,7L,8L,8L,7L,5L,2L,1L,9L,7L,9L,3L,3L,9L,8L,4L,1L,6L,7L,9L,3L,9L,1L,4L,8L,7L,8L,2L,0L,6L,6L,4L,8L,7L,5L,3L,0L,3L,9L,3L,8L,3L,2L,5L,0L,5L,4L,0L,3L,2L,1L,1L,9L,8L,6L,6L,4L,9L,9L,4L,5L,6L,5L,1L,8L,8L,3L,9L,7L,7L,1L,6L,0L,0L,9L,2L,1L,1L,7L,8L,4L,8L,9L,9L,7L,8L,0L,4L,3L,7L,2L,6L,0L,9L,6L,9L,7L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245279Inst : IEnumerable<long>
{
public static readonly long[] Value=A245279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245279.Bytes);
public long this[int i]=>Value[i];

public static A245279Inst Instance=new A245279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245280
{
public static readonly long[] Value={ 8L,1L,7L,5L,1L,2L,1L,1L,2L,4L,7L,8L,0L,2L,0L,6L,6L,0L,1L,5L,8L,3L,2L,0L,6L,0L,8L,5L,1L,2L,1L,7L,9L,3L,3L,5L,1L,2L,4L,6L,9L,6L,0L,6L,1L,6L,7L,4L,9L,4L,5L,9L,6L,7L,8L,8L,0L,1L,3L,3L,5L,0L,0L,5L,4L,3L,4L,8L,1L,1L,6L,0L,2L,2L,8L,3L,9L,9L,0L,7L,8L,8L,2L,1L,5L,1L,0L,0L,2L,1L,9L,5L,6L,2L,7L,3L,9L,0L,3L,0L,2L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245280Inst : IEnumerable<long>
{
public static readonly long[] Value=A245280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245280.Bytes);
public long this[int i]=>Value[i];

public static A245280Inst Instance=new A245280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245281
{
public static readonly long[] Value={ 2L,12L,10L,14L,4L,24L,20L,22L,26L,6L,16L,18L,8L,28L,21L,15L,5L,25L,35L,30L,3L,33L,36L,32L,34L,38L,48L,40L,42L,27L,57L,45L,50L,52L,54L,44L,46L,56L,58L,68L,60L,62L,64L,66L,63L,39L,9L,69L,90L,70L,7L,77L,147L,49L,84L,74L,37L,333L,93L,31L,124L,72L,75L,51L,17L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245281Inst : IEnumerable<long>
{
public static readonly long[] Value=A245281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245281.Bytes);
public long this[int i]=>Value[i];

public static A245281Inst Instance=new A245281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245282
{
public static readonly long[] Value={ 1L,3L,4L,8L,9L,19L,22L,42L,59L,100L,145L,257L,378L,634L,999L,1639L,2585L,4255L,6766L,11051L,17736L,28804L,46369L,75316L,121402L,196798L,317870L,514868L,832041L,1347372L,2178310L,3526217L,5703035L,9230052L,14930382L,24162310L,39088170L,63252754L,102334536L,165591226L,267914297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245282Inst : IEnumerable<long>
{
public static readonly long[] Value=A245282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245282.Bytes);
public long this[int i]=>Value[i];

public static A245282Inst Instance=new A245282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245283
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,6L,48L,2592L,3421440L,1952520007680L,BigInteger.Parse("79423772100432548659200"),BigInteger.Parse("2433694280407609647520301298079459442688000"),BigInteger.Parse("1731103819002733625504286414686785477293241305893841298989509923950758461440000") };
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
public class A245283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245283.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245283Inst Instance=new A245283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245284
{
public static readonly long[] Value={ 55L,85L,91L,105L,115L,133L,140L,145L,187L,195L,204L,205L,217L,231L,235L,247L,253L,259L,265L,275L,285L,295L,301L,319L,351L,355L,357L,385L,391L,403L,415L,425L,427L,429L,445L,451L,465L,469L,476L,481L,483L,493L,505L,511L,517L,535L,553L,555L,559L,565L,575L,583L,589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245284Inst : IEnumerable<long>
{
public static readonly long[] Value=A245284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245284.Bytes);
public long this[int i]=>Value[i];

public static A245284Inst Instance=new A245284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245285
{
public static readonly long[] Value={ 2L,6L,18L,52L,145L,400L,1093L,2977L,8098L,22021L,59868L,162748L,442406L,1202597L,3269009L,8886102L,24154944L,65659960L,178482291L,485165185L,1318815724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245285Inst : IEnumerable<long>
{
public static readonly long[] Value=A245285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245285.Bytes);
public long this[int i]=>Value[i];

public static A245285Inst Instance=new A245285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245286
{
public static readonly long[] Value={ 2L,2L,7L,4L,3L,2L,2L,3L,5L,0L,9L,7L,9L,9L,3L,7L,1L,1L,8L,1L,6L,0L,6L,4L,4L,3L,1L,2L,0L,6L,6L,9L,7L,8L,3L,9L,8L,9L,6L,6L,6L,2L,8L,5L,6L,7L,9L,9L,0L,1L,0L,6L,9L,7L,1L,8L,0L,6L,1L,1L,9L,9L,1L,7L,1L,4L,8L,4L,6L,4L,8L,1L,7L,0L,5L,8L,8L,1L,1L,5L,3L,1L,4L,8L,7L,0L,3L,6L,5L,9L,4L,6L,4L,5L,5L,2L,1L,0L,9L,2L,2L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245286Inst : IEnumerable<long>
{
public static readonly long[] Value=A245286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245286.Bytes);
public long this[int i]=>Value[i];

public static A245286Inst Instance=new A245286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245287
{
public static readonly long[] Value={ 2L,9L,7L,9L,6L,3L,3L,9L,0L,5L,9L,8L,6L,2L,2L,1L,7L,4L,4L,7L,9L,5L,5L,1L,2L,3L,3L,8L,0L,1L,6L,1L,4L,9L,7L,0L,6L,6L,9L,4L,2L,2L,8L,7L,8L,2L,8L,7L,7L,1L,3L,6L,3L,1L,2L,2L,0L,8L,1L,2L,5L,8L,3L,7L,8L,6L,2L,0L,4L,5L,9L,5L,5L,5L,5L,2L,8L,0L,8L,1L,1L,6L,6L,6L,3L,5L,6L,5L,8L,2L,0L,5L,4L,6L,3L,5L,1L,9L,2L,2L,0L,6L,5L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245287Inst : IEnumerable<long>
{
public static readonly long[] Value=A245287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245287.Bytes);
public long this[int i]=>Value[i];

public static A245287Inst Instance=new A245287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245288
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,3L,12L,6L,22L,10L,35L,15L,51L,21L,70L,28L,92L,36L,117L,45L,145L,55L,176L,66L,210L,78L,247L,91L,287L,105L,330L,120L,376L,136L,425L,153L,477L,171L,532L,190L,590L,210L,651L,231L,715L,253L,782L,276L,852L,300L,925L,325L,1001L,351L,1080L,378L,1162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245288Inst : IEnumerable<long>
{
public static readonly long[] Value=A245288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245288.Bytes);
public long this[int i]=>Value[i];

public static A245288Inst Instance=new A245288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245289
{
public static readonly long[] Value={ 2L,6L,14L,17L,19L,22L,26L,30L,34L,38L,42L,53L,55L,58L,66L,70L,78L,86L,89L,91L,94L,102L,106L,110L,114L,130L,138L,142L,158L,161L,163L,166L,170L,178L,182L,186L,194L,197L,199L,202L,210L,214L,218L,222L,230L,233L,235L,238L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245289Inst : IEnumerable<long>
{
public static readonly long[] Value=A245289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245289.Bytes);
public long this[int i]=>Value[i];

public static A245289Inst Instance=new A245289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245290
{
public static readonly BigInteger[] Value={ 1L,31L,5119L,9961471L,259577085951L,94554701453852671L,BigInteger.Parse("494214691850093043122175"),BigInteger.Parse("37747948215762478445361018961919"),BigInteger.Parse("42694960288928350006693371507341885702143"),BigInteger.Parse("722273364120299921501331975953872089285372151857151") };
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
public class A245290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245290.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245290Inst Instance=new A245290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245291
{
public static readonly BigInteger[] Value={ 0L,32L,27648L,258473984L,34924795002880L,BigInteger.Parse("73692421593384353792"),BigInteger.Parse("2475385863878910456755126272"),BigInteger.Parse("1329190247836700110425361699261382656"),BigInteger.Parse("11417938846687390120116281062224453749176270848"),BigInteger.Parse("1569274711573306070659025854469940650153499575743856771072") };
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
public class A245291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245291Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245291.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245291.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245291Inst Instance=new A245291Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245292
{
public static readonly long[] Value={ 0L,0L,9L,5L,8L,1L,9L,3L,0L,2L,6L,7L,8L,3L,9L,3L,1L,7L,5L,4L,9L,0L,2L,3L,2L,9L,3L,2L,1L,0L,7L,7L,8L,4L,3L,8L,7L,5L,8L,6L,9L,4L,4L,9L,5L,2L,9L,7L,3L,8L,5L,5L,1L,6L,1L,5L,7L,1L,3L,5L,2L,1L,6L,9L,3L,5L,8L,2L,0L,7L,3L,6L,1L,0L,2L,0L,2L,6L,7L,8L,4L,9L,1L,1L,2L,8L,8L,1L,7L,9L,0L,6L,6L,8L,7L,9L,5L,0L,8L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245292Inst : IEnumerable<long>
{
public static readonly long[] Value=A245292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245292.Bytes);
public long this[int i]=>Value[i];

public static A245292Inst Instance=new A245292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245293
{
public static readonly long[] Value={ 1L,0L,8L,0L,9L,6L,0L,1L,2L,3L,8L,4L,5L,6L,2L,7L,5L,1L,5L,1L,8L,8L,0L,8L,0L,1L,5L,0L,6L,3L,6L,5L,4L,5L,6L,4L,9L,2L,3L,7L,5L,7L,7L,0L,7L,4L,7L,2L,5L,5L,2L,3L,4L,3L,8L,0L,1L,3L,5L,6L,6L,4L,4L,2L,5L,9L,2L,7L,5L,9L,9L,0L,9L,7L,9L,0L,6L,6L,8L,5L,7L,2L,5L,0L,6L,8L,4L,8L,1L,8L,1L,1L,2L,7L,0L,7L,0L,7L,6L,1L,6L,1L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245293Inst : IEnumerable<long>
{
public static readonly long[] Value=A245293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245293.Bytes);
public long this[int i]=>Value[i];

public static A245293Inst Instance=new A245293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245294
{
public static readonly long[] Value={ 1L,0L,9L,5L,4L,4L,5L,1L,1L,5L,0L,1L,0L,3L,3L,2L,2L,2L,6L,9L,1L,3L,9L,3L,9L,5L,6L,5L,6L,0L,1L,6L,0L,4L,2L,6L,7L,9L,0L,5L,4L,8L,9L,3L,8L,9L,9L,9L,5L,9L,6L,6L,5L,0L,8L,4L,5L,3L,7L,8L,8L,8L,9L,9L,4L,6L,4L,9L,8L,6L,5L,5L,4L,2L,4L,5L,4L,4L,5L,4L,6L,7L,6L,0L,1L,7L,1L,6L,8L,7L,2L,3L,2L,7L,7L,4L,1L,2L,5L,1L,5L,2L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245294Inst : IEnumerable<long>
{
public static readonly long[] Value=A245294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245294.Bytes);
public long this[int i]=>Value[i];

public static A245294Inst Instance=new A245294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245295
{
public static readonly long[] Value={ 1L,4L,8L,0L,1L,6L,5L,6L,0L,8L,9L,8L,4L,5L,7L,0L,5L,0L,1L,1L,3L,3L,5L,7L,9L,9L,3L,2L,3L,2L,7L,6L,7L,3L,6L,3L,8L,5L,9L,8L,1L,2L,3L,5L,8L,2L,6L,1L,2L,3L,7L,6L,2L,3L,6L,6L,4L,9L,7L,2L,4L,8L,1L,1L,8L,3L,1L,4L,9L,3L,3L,7L,3L,1L,5L,9L,9L,2L,3L,0L,5L,2L,4L,0L,8L,8L,8L,3L,9L,0L,3L,8L,0L,3L,7L,6L,7L,9L,7L,3L,4L,5L,1L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245295Inst : IEnumerable<long>
{
public static readonly long[] Value=A245295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245295.Bytes);
public long this[int i]=>Value[i];

public static A245295Inst Instance=new A245295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245296
{
public static readonly long[] Value={ 1L,0L,4L,4L,2L,5L,7L,9L,0L,9L,3L,0L,9L,7L,9L,5L,1L,4L,3L,4L,4L,5L,3L,6L,9L,6L,1L,7L,1L,5L,5L,7L,0L,2L,5L,8L,3L,0L,8L,0L,4L,2L,0L,8L,0L,4L,2L,0L,2L,5L,3L,7L,2L,0L,7L,7L,5L,7L,6L,1L,3L,4L,1L,5L,8L,0L,0L,2L,3L,2L,5L,8L,8L,8L,0L,0L,6L,2L,3L,5L,7L,8L,8L,7L,4L,4L,6L,0L,2L,0L,1L,1L,1L,9L,2L,2L,0L,2L,7L,8L,5L,4L,7L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245296Inst : IEnumerable<long>
{
public static readonly long[] Value=A245296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245296.Bytes);
public long this[int i]=>Value[i];

public static A245296Inst Instance=new A245296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245297
{
public static readonly long[] Value={ 1L,1L,1L,6L,6L,4L,5L,9L,7L,1L,1L,0L,3L,8L,0L,9L,8L,8L,2L,6L,4L,5L,7L,1L,5L,4L,5L,1L,0L,7L,3L,1L,5L,3L,1L,7L,8L,9L,6L,6L,5L,1L,2L,0L,0L,6L,6L,9L,7L,4L,0L,4L,0L,1L,6L,4L,5L,6L,3L,4L,2L,1L,6L,0L,6L,0L,8L,1L,7L,9L,5L,2L,8L,6L,4L,8L,5L,2L,2L,2L,9L,6L,8L,4L,6L,4L,6L,0L,0L,2L,6L,2L,2L,4L,5L,4L,9L,9L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245297Inst : IEnumerable<long>
{
public static readonly long[] Value=A245297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245297.Bytes);
public long this[int i]=>Value[i];

public static A245297Inst Instance=new A245297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245298
{
public static readonly long[] Value={ 1L,1L,1L,9L,4L,2L,3L,7L,3L,1L,7L,3L,5L,1L,0L,7L,6L,1L,1L,6L,2L,9L,7L,1L,1L,0L,8L,2L,0L,8L,1L,2L,6L,1L,0L,4L,1L,2L,4L,9L,9L,8L,5L,5L,6L,7L,0L,5L,8L,6L,0L,7L,0L,8L,6L,5L,2L,0L,9L,8L,2L,7L,9L,9L,1L,3L,1L,5L,4L,2L,2L,9L,2L,2L,9L,6L,9L,0L,4L,5L,1L,5L,2L,5L,2L,6L,2L,8L,6L,5L,9L,6L,1L,3L,0L,8L,5L,2L,2L,9L,2L,9L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245298Inst : IEnumerable<long>
{
public static readonly long[] Value=A245298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245298.Bytes);
public long this[int i]=>Value[i];

public static A245298Inst Instance=new A245298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245299
{
public static readonly long[] Value={ 1L,4L,9L,6L,2L,7L,7L,8L,6L,9L,7L,3L,8L,8L,4L,4L,7L,3L,8L,5L,0L,8L,1L,0L,2L,1L,3L,9L,3L,2L,9L,7L,8L,2L,5L,5L,3L,3L,1L,7L,0L,0L,6L,2L,4L,7L,0L,9L,3L,2L,5L,4L,1L,0L,3L,0L,8L,7L,5L,6L,8L,6L,3L,9L,5L,0L,3L,6L,8L,0L,0L,9L,7L,2L,0L,4L,5L,0L,0L,4L,3L,3L,7L,4L,5L,7L,0L,3L,5L,8L,1L,0L,9L,0L,8L,3L,9L,6L,3L,9L,6L,9L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245299Inst : IEnumerable<long>
{
public static readonly long[] Value=A245299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245299.Bytes);
public long this[int i]=>Value[i];

public static A245299Inst Instance=new A245299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245300
{
public static readonly long[] Value={ 0L,1L,4L,3L,7L,12L,6L,11L,17L,24L,10L,16L,23L,31L,40L,15L,22L,30L,39L,49L,60L,21L,29L,38L,48L,59L,71L,84L,28L,37L,47L,58L,70L,83L,97L,112L,36L,46L,57L,69L,82L,96L,111L,127L,144L,45L,56L,68L,81L,95L,110L,126L,143L,161L,180L,55L,67L,80L,94L,109L,125L,142L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245300Inst : IEnumerable<long>
{
public static readonly long[] Value=A245300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245300.Bytes);
public long this[int i]=>Value[i];

public static A245300Inst Instance=new A245300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245301
{
public static readonly long[] Value={ 0L,5L,22L,58L,120L,215L,350L,532L,768L,1065L,1430L,1870L,2392L,3003L,3710L,4520L,5440L,6477L,7638L,8930L,10360L,11935L,13662L,15548L,17600L,19825L,22230L,24822L,27608L,30595L,33790L,37200L,40832L,44693L,48790L,53130L,57720L,62567L,67678L,73060L,78720L,84665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245301Inst : IEnumerable<long>
{
public static readonly long[] Value=A245301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245301.Bytes);
public long this[int i]=>Value[i];

public static A245301Inst Instance=new A245301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245302
{
public static readonly long[] Value={ 3L,5L,9L,13L,19L,25L,32L,39L,48L,57L,67L,78L,90L,103L,116L,130L,145L,161L,178L,195L,213L,232L,252L,273L,294L,317L,340L,364L,388L,414L,440L,467L,495L,524L,554L,584L,615L,647L,680L,714L,748L,783L,820L,856L,894L,933L,972L,1012L,1053L,1095L,1137L,1181L,1225L,1270L,1316L,1362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245302Inst : IEnumerable<long>
{
public static readonly long[] Value=A245302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245302.Bytes);
public long this[int i]=>Value[i];

public static A245302Inst Instance=new A245302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245303
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,11L,12L,13L,16L,17L,18L,19L,20L,23L,24L,27L,28L,29L,31L,32L,37L,40L,41L,43L,44L,45L,47L,48L,50L,52L,53L,54L,56L,59L,61L,63L,64L,67L,68L,71L,72L,73L,75L,76L,79L,80L,81L,83L,88L,89L,92L,96L,97L,98L,99L,101L,103L,104L,107L,108L,109L,112L,113L,116L,117L,124L,125L,127L,128L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245303Inst : IEnumerable<long>
{
public static readonly long[] Value=A245303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245303.Bytes);
public long this[int i]=>Value[i];

public static A245303Inst Instance=new A245303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245304
{
public static readonly long[] Value={ 4L,10L,100L,1480L,16060L,19420L,21010L,22270L,43780L,55330L,144160L,165700L,166840L,195730L,201820L,225340L,247600L,268810L,326140L,347980L,361210L,397750L,465160L,518800L,536440L,633460L,633790L,661090L,768190L,795790L,829720L,857950L,876010L,958540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245304Inst : IEnumerable<long>
{
public static readonly long[] Value=A245304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245304.Bytes);
public long this[int i]=>Value[i];

public static A245304Inst Instance=new A245304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245305
{
public static readonly long[] Value={ 1L,4L,7L,37L,142L,154L,202L,214L,307L,424L,469L,487L,499L,559L,577L,664L,742L,814L,847L,979L,982L,1054L,1129L,1159L,1162L,1252L,1369L,1522L,1612L,1642L,1672L,1837L,1987L,2107L,2134L,2149L,2209L,2242L,2359L,2407L,2419L,2482L,2632L,2677L,2767L,2887L,2929L,2944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245305Inst : IEnumerable<long>
{
public static readonly long[] Value=A245305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245305.Bytes);
public long this[int i]=>Value[i];

public static A245305Inst Instance=new A245305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245306
{
public static readonly long[] Value={ 1L,2L,2L,5L,10L,26L,65L,170L,442L,1157L,3026L,7922L,20737L,54290L,142130L,372101L,974170L,2550410L,6677057L,17480762L,45765226L,119814917L,313679522L,821223650L,2149991425L,5628750626L,14736260450L,38580030725L,101003831722L,264431464442L,692290561601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245306Inst : IEnumerable<long>
{
public static readonly long[] Value=A245306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245306.Bytes);
public long this[int i]=>Value[i];

public static A245306Inst Instance=new A245306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245307
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,77L,771L,9258L,127656L,1969366L,33422650L,616779303L,12272428173L,261620716744L,5945330149226L,143439343672519L,3661506704040203L,98597706579694403L,2793561790527733313L,BigInteger.Parse("83084652845766283317"),BigInteger.Parse("2588418449175558698525"),BigInteger.Parse("84305591450606402889544") };
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
public class A245307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245307.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245307Inst Instance=new A245307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245308
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,205L,3501L,90271L,3357103L,171841209L,11598601465L,996140770651L,105829573610091L,13602095395648453L,2077762791361106149L,BigInteger.Parse("371766799417828843575"),BigInteger.Parse("76978381709312988826951"),BigInteger.Parse("18256702588619162109630961"),BigInteger.Parse("4915636696257611754342845553"),BigInteger.Parse("1491009565882345791444427756339") };
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
public class A245308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245308.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245308Inst Instance=new A245308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245309
{
public static readonly BigInteger[] Value={ 1L,1L,3L,25L,397L,10101L,372991L,18744853L,1227094905L,101320257097L,10294575759451L,1262050509059121L,183700770307306693L,BigInteger.Parse("31322680620408105085"),BigInteger.Parse("6184922808789945458967"),BigInteger.Parse("1400325997347499801032301"),BigInteger.Parse("360395936189117983848624241"),BigInteger.Parse("104632853179210298481432557073") };
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
public class A245309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245309.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245309Inst Instance=new A245309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245310
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,12L,34L,120L,412L,1608L,6244L,26288L,111448L,499256L,2265288L,10701896L,51339768L,254175048L,1278947304L,6604214760L,34662182904L,186002333640L,1014140252376L,5638617162312L,31837193871480L,182962292354376L,1067120997002680L,6325487157903240L,38030207563538680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245310Inst : IEnumerable<long>
{
public static readonly long[] Value=A245310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245310.Bytes);
public long this[int i]=>Value[i];

public static A245310Inst Instance=new A245310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245311
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,50L,182L,707L,2903L,12479L,55844L,258860L,1238588L,6099054L,30836886L,159770751L,846927495L,4586883023L,25351486346L,142843162421L,819783142271L,4788268962584L,28444114318056L,171737405798836L,1053285775758916L,6558551535958516L,41441942236323008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245311Inst : IEnumerable<long>
{
public static readonly long[] Value=A245311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245311.Bytes);
public long this[int i]=>Value[i];

public static A245311Inst Instance=new A245311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245312
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,10L,60L,360L,2940L,24528L,247968L,2595920L,31175496L,389671200L,5422095536L,78605082528L,1244958773760L,20527083114496L,364984417934400L,6745106725383168L,133136189132775360L,2726068542132666240L,BigInteger.Parse("59173740044950124160"),BigInteger.Parse("1329834118793805335040"),BigInteger.Parse("31493916740885086274304") };
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
public class A245312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245312Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245312.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245312.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245312Inst Instance=new A245312Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245313
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,31L,176L,1158L,8919L,76751L,742597L,7865088L,91553100L,1150905332L,15665172108L,227991734414L,3554320236911L,58795765799791L,1033303679424539L,19151079894682674L,374662948814998855L,7691131223011551255L,BigInteger.Parse("165785969673935575904"),BigInteger.Parse("3734170668741419488552") };
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
public class A245313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245313.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245313Inst Instance=new A245313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245314
{
public static readonly long[] Value={ 0L,3L,5L,8L,10L,13L,16L,19L,20L,22L,25L,28L,30L,32L,35L,38L,39L,42L,44L,47L,49L,52L,54L,57L,59L,60L,64L,66L,68L,71L,73L,76L,78L,81L,83L,85L,88L,91L,93L,95L,97L,100L,103L,105L,107L,110L,112L,115L,116L,119L,122L,124L,126L,129L,131L,134L,136L,139L,141L,143L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245314Inst : IEnumerable<long>
{
public static readonly long[] Value=A245314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245314.Bytes);
public long this[int i]=>Value[i];

public static A245314Inst Instance=new A245314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245315
{
public static readonly long[] Value={ 422L,623L,8222L,933L,1025L,12223L,1427L,1535L,162222L,18233L,20225L,2137L,22211L,242223L,2555L,26213L,27333L,28227L,30235L,3222222L,33311L,34217L,3557L,362233L,38219L,39313L,402225L,42237L,442211L,45335L,46223L,4822223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245315Inst : IEnumerable<long>
{
public static readonly long[] Value=A245315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245315.Bytes);
public long this[int i]=>Value[i];

public static A245315Inst Instance=new A245315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245316
{
public static readonly long[] Value={ 4224L,6235L,82226L,9336L,10257L,122237L,14279L,15358L,1622228L,182338L,202259L,213710L,2221113L,2422239L,255510L,2621315L,273339L,2822711L,3023510L,322222210L,3331114L,3421719L,355712L,36223310L,3821921L,3931316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245316Inst : IEnumerable<long>
{
public static readonly long[] Value=A245316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245316.Bytes);
public long this[int i]=>Value[i];

public static A245316Inst Instance=new A245316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245317
{
public static readonly long[] Value={ 41L,62L,83L,94L,105L,126L,147L,158L,169L,1810L,2011L,2112L,2213L,2414L,2515L,2616L,2717L,2818L,3019L,3220L,3321L,3422L,3523L,3624L,3825L,3926L,4027L,4228L,4429L,4530L,4631L,4832L,4933L,5034L,5135L,5236L,5437L,5538L,5639L,5740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245317Inst : IEnumerable<long>
{
public static readonly long[] Value=A245317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245317.Bytes);
public long this[int i]=>Value[i];

public static A245317Inst Instance=new A245317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245318
{
public static readonly long[] Value={ 1L,7L,133L,1517L,11761L,676333L,1484413L,3627557L,10289371L,1449045241L,2433687407L,12309023183L,29013950411L,11701492535299L,223598572318157L,362232879754103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245318Inst : IEnumerable<long>
{
public static readonly long[] Value=A245318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245318.Bytes);
public long this[int i]=>Value[i];

public static A245318Inst Instance=new A245318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245319
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,12L,18L,24L,36L,72L,88L,198L,228L,1032L,2412L,2838L,4553L,5958L,10008L,24588L,25938L,46777L,65538L,75468L,82505L,130056L,143916L,200364L,540738L,598818L,750852L,797478L,923628L,958212L,1151538L,1250568L,1505388L,1647396L,2365128L,2964036L,3490028L,3704418L,3844808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245319Inst : IEnumerable<long>
{
public static readonly long[] Value=A245319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245319.Bytes);
public long this[int i]=>Value[i];

public static A245319Inst Instance=new A245319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245320
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,1L,-3L,3L,0L,0L,3L,-8L,6L,0L,1L,-8L,28L,-40L,20L,0L,0L,6L,-40L,105L,-120L,50L,0L,1L,-15L,105L,-355L,615L,-525L,175L,0L,0L,10L,-120L,615L,-1624L,2310L,-1680L,490L,0L,1L,-24L,276L,-1624L,5376L,-10416L,11704L,-7056L,1764L,0L,0L,15L,-280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245320Inst : IEnumerable<long>
{
public static readonly long[] Value=A245320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245320.Bytes);
public long this[int i]=>Value[i];

public static A245320Inst Instance=new A245320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245321
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,5L,6L,7L,8L,9L,10L,9L,10L,11L,12L,13L,14L,12L,13L,14L,15L,16L,17L,14L,15L,16L,17L,18L,19L,15L,16L,17L,18L,19L,20L,15L,16L,17L,18L,19L,20L,20L,21L,22L,23L,24L,25L,19L,20L,21L,22L,23L,24L,23L,24L,25L,26L,27L,28L,21L,22L,23L,24L,25L,26L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245321Inst : IEnumerable<long>
{
public static readonly long[] Value=A245321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245321.Bytes);
public long this[int i]=>Value[i];

public static A245321Inst Instance=new A245321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245322
{
public static readonly BigInteger[] Value={ 1L,1L,8L,161L,6016L,360421L,31628288L,3823725821L,609263681536L,123729353398441L,31195066498285568L,9560281195915697081UL,BigInteger.Parse("3500145542231863853056"),BigInteger.Parse("1508772905238685631514061"),BigInteger.Parse("756360258034794813559144448"),BigInteger.Parse("436312320288025061112662937941"),BigInteger.Parse("286966475921556619941746443288576") };
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
public class A245322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245322.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245322Inst Instance=new A245322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245323
{
public static readonly BigInteger[] Value={ 4L,170L,7320L,328380L,15124186L,704915600L,33014404692L,1549142827050L,72743819556328L,3416820019114700L,160507201018772634L,7540231471940495520L,BigInteger.Parse("354226959651753624100"),BigInteger.Parse("16641065639596669234730"),BigInteger.Parse("781774759322033582085816"),BigInteger.Parse("36726752905662141638238300") };
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
public class A245323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245323.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245323Inst Instance=new A245323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245324
{
public static readonly long[] Value={ 4L,2L,1L,7L,9L,9L,3L,6L,1L,4L,8L,4L,4L,4L,2L,7L,6L,9L,7L,6L,8L,0L,7L,6L,1L,4L,6L,1L,0L,1L,8L,1L,7L,4L,4L,9L,6L,8L,8L,0L,3L,4L,8L,3L,8L,6L,1L,6L,0L,9L,9L,6L,9L,4L,0L,1L,3L,5L,9L,5L,5L,0L,1L,4L,7L,7L,0L,5L,7L,6L,7L,9L,5L,9L,3L,1L,8L,1L,3L,3L,6L,9L,8L,4L,4L,8L,1L,5L,6L,1L,2L,1L,3L,2L,4L,1L,0L,8L,2L,1L,8L,8L,7L,8L,7L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245324Inst : IEnumerable<long>
{
public static readonly long[] Value=A245324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245324.Bytes);
public long this[int i]=>Value[i];

public static A245324Inst Instance=new A245324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245325
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,3L,3L,3L,2L,1L,5L,4L,5L,4L,5L,4L,5L,4L,3L,3L,2L,1L,8L,7L,7L,5L,8L,7L,7L,5L,8L,7L,7L,5L,8L,7L,7L,5L,5L,4L,5L,4L,3L,3L,2L,1L,13L,11L,12L,9L,11L,10L,9L,6L,13L,11L,12L,9L,11L,10L,9L,6L,13L,11L,12L,9L,11L,10L,9L,6L,13L,11L,12L,9L,11L,10L,9L,6L,8L,7L,7L,5L,8L,7L,7L,5L,5L,4L,5L,4L,3L,3L,2L,1L,21L,18L,19L,14L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245325Inst : IEnumerable<long>
{
public static readonly long[] Value=A245325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245325.Bytes);
public long this[int i]=>Value[i];

public static A245325Inst Instance=new A245325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245326
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,2L,1L,5L,4L,5L,4L,3L,3L,2L,1L,8L,7L,7L,5L,8L,7L,7L,5L,5L,4L,5L,4L,3L,3L,2L,1L,13L,11L,12L,9L,11L,10L,9L,6L,13L,11L,12L,9L,11L,10L,9L,6L,8L,7L,7L,5L,8L,7L,7L,5L,5L,4L,5L,4L,3L,3L,2L,1L,21L,18L,19L,14L,19L,17L,16L,11L,18L,15L,17L,13L,14L,13L,11L,7L,21L,18L,19L,14L,19L,17L,16L,11L,18L,15L,17L,13L,14L,13L,11L,7L,13L,11L,12L,9L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245326Inst : IEnumerable<long>
{
public static readonly long[] Value=A245326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245326.Bytes);
public long this[int i]=>Value[i];

public static A245326Inst Instance=new A245326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245327
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,1L,3L,3L,5L,2L,5L,3L,4L,1L,4L,5L,8L,3L,8L,5L,7L,2L,7L,4L,7L,3L,7L,4L,5L,1L,5L,8L,13L,5L,13L,8L,11L,3L,11L,7L,12L,5L,12L,7L,9L,2L,9L,7L,11L,4L,11L,7L,10L,3L,10L,5L,9L,4L,9L,5L,6L,1L,6L,13L,21L,8L,21L,13L,18L,5L,18L,11L,19L,8L,19L,11L,14L,3L,14L,12L,19L,7L,19L,12L,17L,5L,17L,9L,16L,7L,16L,9L,11L,2L,11L,11L,18L,7L,18L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245327Inst : IEnumerable<long>
{
public static readonly long[] Value=A245327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245327.Bytes);
public long this[int i]=>Value[i];

public static A245327Inst Instance=new A245327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245328
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,1L,5L,3L,5L,2L,4L,3L,4L,1L,8L,5L,8L,3L,7L,5L,7L,2L,7L,4L,7L,3L,5L,4L,5L,1L,13L,8L,13L,5L,11L,8L,11L,3L,12L,7L,12L,5L,9L,7L,9L,2L,11L,7L,11L,4L,10L,7L,10L,3L,9L,5L,9L,4L,6L,5L,6L,1L,21L,13L,21L,8L,18L,13L,18L,5L,19L,11L,19L,8L,14L,11L,14L,3L,19L,12L,19L,7L,17L,12L,17L,5L,16L,9L,16L,7L,11L,9L,11L,2L,18L,11L,18L,7L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245328Inst : IEnumerable<long>
{
public static readonly long[] Value=A245328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245328.Bytes);
public long this[int i]=>Value[i];

public static A245328Inst Instance=new A245328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245329
{
public static readonly BigInteger[] Value={ 1L,-7L,1L,1001L,-15359L,30233L,3126529L,-61392247L,259448833L,11970181433L,-287815672319L,1854020654633L,48800262650881L,-1443188813338279L,12410505050039041L,198977188596692681L,-7472188661349285887L,BigInteger.Parse("80331498114096555641") };
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
public class A245329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245329Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245329.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245329.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245329Inst Instance=new A245329Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245330
{
public static readonly long[] Value={ 9L,8L,9L,1L,3L,3L,6L,3L,4L,4L,4L,6L,9L,9L,3L,0L,5L,2L,2L,4L,3L,4L,9L,0L,3L,0L,8L,2L,6L,6L,3L,3L,7L,9L,8L,1L,3L,8L,0L,3L,4L,8L,0L,9L,8L,0L,4L,4L,1L,8L,2L,2L,1L,9L,0L,3L,9L,3L,5L,7L,8L,7L,8L,0L,8L,7L,3L,8L,2L,8L,9L,5L,4L,2L,6L,7L,5L,7L,9L,5L,8L,1L,5L,3L,8L,0L,3L,7L,6L,7L,5L,0L,8L,8L,0L,8L,0L,3L,8L,9L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245330Inst : IEnumerable<long>
{
public static readonly long[] Value=A245330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245330.Bytes);
public long this[int i]=>Value[i];

public static A245330Inst Instance=new A245330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245331
{
public static readonly long[] Value={ 2L,23L,87L,157L,1523L,3445551L,26620870L,30512347L,72713283L,344661698L,1129330411L,3886591581L,5085084202L,11916345303L,15510679381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245331Inst : IEnumerable<long>
{
public static readonly long[] Value=A245331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245331.Bytes);
public long this[int i]=>Value[i];

public static A245331Inst Instance=new A245331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245332
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,0L,3L,3L,4L,6L,9L,10L,16L,20L,27L,36L,49L,63L,86L,113L,150L,199L,265L,349L,465L,615L,815L,1080L,1432L,1895L,2513L,3328L,4409L,5841L,7739L,10250L,13581L,17990L,23832L,31571L,41824L,55403L,73396L,97228L,128800L,170624L,226030L,299424L,396655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245332Inst : IEnumerable<long>
{
public static readonly long[] Value=A245332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245332.Bytes);
public long this[int i]=>Value[i];

public static A245332Inst Instance=new A245332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245333
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,0L,6L,7L,4L,7L,0L,8L,1L,7L,6L,2L,1L,3L,1L,6L,9L,2L,7L,7L,9L,9L,0L,8L,7L,3L,3L,7L,6L,0L,1L,9L,6L,4L,6L,7L,6L,3L,1L,8L,2L,4L,0L,9L,3L,8L,5L,3L,8L,2L,2L,2L,7L,1L,5L,6L,5L,0L,1L,2L,9L,3L,6L,5L,4L,0L,4L,4L,4L,5L,6L,7L,3L,2L,9L,5L,9L,5L,3L,9L,6L,8L,5L,6L,4L,7L,9L,6L,1L,9L,2L,5L,7L,9L,0L,4L,9L,9L,7L,6L,2L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245333Inst : IEnumerable<long>
{
public static readonly long[] Value=A245333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245333.Bytes);
public long this[int i]=>Value[i];

public static A245333Inst Instance=new A245333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245334
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,2L,4L,9L,12L,6L,5L,16L,36L,48L,24L,6L,25L,80L,180L,240L,120L,7L,36L,150L,480L,1080L,1440L,720L,8L,49L,252L,1050L,3360L,7560L,10080L,5040L,9L,64L,392L,2016L,8400L,26880L,60480L,80640L,40320L,10L,81L,576L,3528L,18144L,75600L,241920L,544320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245334Inst : IEnumerable<long>
{
public static readonly long[] Value=A245334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245334.Bytes);
public long this[int i]=>Value[i];

public static A245334Inst Instance=new A245334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245335
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,5L,6L,7L,8L,7L,8L,9L,10L,11L,9L,10L,11L,12L,13L,10L,11L,12L,13L,14L,10L,11L,12L,13L,14L,14L,15L,16L,17L,18L,13L,14L,15L,16L,17L,16L,17L,18L,19L,20L,14L,15L,16L,17L,18L,16L,17L,18L,19L,20L,20L,21L,22L,23L,24L,17L,18L,19L,20L,21L,18L,19L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245335Inst : IEnumerable<long>
{
public static readonly long[] Value=A245335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245335.Bytes);
public long this[int i]=>Value[i];

public static A245335Inst Instance=new A245335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245336
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,7L,8L,9L,10L,11L,12L,13L,14L,13L,14L,15L,16L,17L,18L,19L,20L,18L,19L,20L,21L,22L,23L,24L,25L,22L,23L,24L,25L,26L,27L,28L,29L,25L,26L,27L,28L,29L,30L,31L,32L,27L,28L,29L,30L,31L,32L,33L,34L,28L,29L,30L,31L,32L,33L,34L,35L,28L,29L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245336Inst : IEnumerable<long>
{
public static readonly long[] Value=A245336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245336.Bytes);
public long this[int i]=>Value[i];

public static A245336Inst Instance=new A245336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245337
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,6L,7L,8L,9L,10L,11L,12L,11L,12L,13L,14L,15L,16L,17L,15L,16L,17L,18L,19L,20L,21L,18L,19L,20L,21L,22L,23L,24L,20L,21L,22L,23L,24L,25L,26L,21L,22L,23L,24L,25L,26L,27L,21L,22L,23L,24L,25L,26L,27L,27L,28L,29L,30L,31L,32L,33L,26L,27L,28L,29L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245337Inst : IEnumerable<long>
{
public static readonly long[] Value=A245337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245337.Bytes);
public long this[int i]=>Value[i];

public static A245337Inst Instance=new A245337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245338
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,8L,9L,10L,11L,12L,13L,14L,15L,16L,15L,16L,17L,18L,19L,20L,21L,22L,23L,21L,22L,23L,24L,25L,26L,27L,28L,29L,26L,27L,28L,29L,30L,31L,32L,33L,34L,30L,31L,32L,33L,34L,35L,36L,37L,38L,33L,34L,35L,36L,37L,38L,39L,40L,41L,35L,36L,37L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245338Inst : IEnumerable<long>
{
public static readonly long[] Value=A245338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245338.Bytes);
public long this[int i]=>Value[i];

public static A245338Inst Instance=new A245338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245339
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,39L,40L,41L,42L,43L,44L,45L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245339Inst : IEnumerable<long>
{
public static readonly long[] Value=A245339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245339.Bytes);
public long this[int i]=>Value[i];

public static A245339Inst Instance=new A245339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245340
{
public static readonly long[] Value={ 0L,1L,4L,2L,8L,21L,3L,5L,18L,16L,14L,12L,10L,6L,1518L,32L,58L,30L,184L,28L,7L,26L,9L,11L,13L,15L,17L,19L,102L,51L,100L,49L,98L,47L,96L,45L,94L,43L,92L,41L,90L,39L,88L,37L,86L,35L,84L,20L,24L,22L,505L,81L,2510L,79L,166L,77L,296L,75L,501L,73L,162L,71L,498L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245340Inst : IEnumerable<long>
{
public static readonly long[] Value=A245340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245340.Bytes);
public long this[int i]=>Value[i];

public static A245340Inst Instance=new A245340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245341
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,2L,3L,4L,5L,6L,4L,5L,6L,7L,8L,3L,4L,5L,6L,7L,5L,6L,7L,8L,9L,4L,5L,6L,7L,8L,6L,7L,8L,9L,10L,8L,9L,10L,11L,12L,4L,5L,6L,7L,8L,6L,7L,8L,9L,10L,5L,6L,7L,8L,9L,7L,8L,9L,10L,11L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,7L,8L,9L,10L,11L,6L,7L,8L,9L,10L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245341Inst : IEnumerable<long>
{
public static readonly long[] Value=A245341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245341.Bytes);
public long this[int i]=>Value[i];

public static A245341Inst Instance=new A245341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245342
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,9L,10L,6L,7L,8L,9L,10L,11L,12L,3L,4L,5L,6L,7L,8L,9L,5L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,4L,5L,6L,7L,8L,9L,10L,6L,7L,8L,9L,10L,11L,12L,8L,9L,10L,11L,12L,13L,14L,10L,11L,12L,13L,14L,15L,16L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245342Inst : IEnumerable<long>
{
public static readonly long[] Value=A245342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245342.Bytes);
public long this[int i]=>Value[i];

public static A245342Inst Instance=new A245342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245343
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,3L,4L,5L,6L,7L,4L,5L,6L,7L,8L,7L,8L,9L,10L,11L,6L,7L,8L,9L,10L,7L,8L,9L,10L,11L,10L,11L,12L,13L,14L,7L,8L,9L,10L,11L,10L,11L,12L,13L,14L,9L,10L,11L,12L,13L,10L,11L,12L,13L,14L,13L,14L,15L,16L,17L,8L,9L,10L,11L,12L,11L,12L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245343Inst : IEnumerable<long>
{
public static readonly long[] Value=A245343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245343.Bytes);
public long this[int i]=>Value[i];

public static A245343Inst Instance=new A245343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245344
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,3L,4L,5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,11L,12L,5L,6L,7L,8L,9L,10L,11L,8L,9L,10L,11L,12L,13L,14L,7L,8L,9L,10L,11L,12L,13L,10L,11L,12L,13L,14L,15L,16L,5L,6L,7L,8L,9L,10L,11L,8L,9L,10L,11L,12L,13L,14L,11L,12L,13L,14L,15L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245344Inst : IEnumerable<long>
{
public static readonly long[] Value=A245344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245344.Bytes);
public long this[int i]=>Value[i];

public static A245344Inst Instance=new A245344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245345
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,2L,3L,4L,5L,6L,7L,8L,9L,10L,4L,5L,6L,7L,8L,9L,10L,11L,12L,6L,7L,8L,9L,10L,11L,12L,13L,14L,8L,9L,10L,11L,12L,13L,14L,15L,16L,3L,4L,5L,6L,7L,8L,9L,10L,11L,5L,6L,7L,8L,9L,10L,11L,12L,13L,7L,8L,9L,10L,11L,12L,13L,14L,15L,9L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245345Inst : IEnumerable<long>
{
public static readonly long[] Value=A245345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245345.Bytes);
public long this[int i]=>Value[i];

public static A245345Inst Instance=new A245345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245346
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245346Inst : IEnumerable<long>
{
public static readonly long[] Value=A245346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245346.Bytes);
public long this[int i]=>Value[i];

public static A245346Inst Instance=new A245346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245347
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,8L,9L,10L,6L,7L,8L,9L,10L,11L,12L,13L,4L,5L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,14L,10L,11L,12L,13L,14L,15L,16L,17L,8L,9L,10L,11L,12L,13L,14L,15L,11L,12L,13L,14L,15L,16L,17L,18L,4L,5L,6L,7L,8L,9L,10L,11L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245347Inst : IEnumerable<long>
{
public static readonly long[] Value=A245347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245347.Bytes);
public long this[int i]=>Value[i];

public static A245347Inst Instance=new A245347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245348
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,2L,27L,15L,8L,4L,256L,112L,50L,22L,10L,3125L,1125L,430L,166L,66L,26L,46656L,14256L,4752L,1626L,576L,206L,76L,823543L,218491L,64484L,19768L,6310L,2054L,688L,232L,16777216L,3932160L,1040384L,288512L,83736L,24952L,7660L,2388L,764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245348Inst : IEnumerable<long>
{
public static readonly long[] Value=A245348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245348.Bytes);
public long this[int i]=>Value[i];

public static A245348Inst Instance=new A245348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245349
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,4L,5L,6L,7L,8L,9L,10L,5L,6L,7L,8L,9L,10L,11L,9L,10L,11L,12L,13L,14L,15L,7L,8L,9L,10L,11L,12L,13L,11L,12L,13L,14L,15L,16L,17L,12L,13L,14L,15L,16L,17L,18L,7L,8L,9L,10L,11L,12L,13L,11L,12L,13L,14L,15L,16L,17L,12L,13L,14L,15L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245349Inst : IEnumerable<long>
{
public static readonly long[] Value=A245349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245349.Bytes);
public long this[int i]=>Value[i];

public static A245349Inst Instance=new A245349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245350
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,9L,10L,11L,12L,8L,9L,10L,11L,12L,13L,14L,15L,16L,7L,8L,9L,10L,11L,12L,13L,14L,15L,11L,12L,13L,14L,15L,16L,17L,18L,19L,10L,11L,12L,13L,14L,15L,16L,17L,18L,14L,15L,16L,17L,18L,19L,20L,21L,22L,8L,9L,10L,11L,12L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245350Inst : IEnumerable<long>
{
public static readonly long[] Value=A245350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245350.Bytes);
public long this[int i]=>Value[i];

public static A245350Inst Instance=new A245350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245351
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,21L,22L,23L,24L,25L,26L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245351Inst : IEnumerable<long>
{
public static readonly long[] Value=A245351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245351.Bytes);
public long this[int i]=>Value[i];

public static A245351Inst Instance=new A245351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245352
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,5L,6L,7L,8L,9L,10L,11L,8L,9L,10L,11L,12L,13L,14L,9L,10L,11L,12L,13L,14L,15L,14L,15L,16L,17L,18L,19L,20L,13L,14L,15L,16L,17L,18L,19L,16L,17L,18L,19L,20L,21L,22L,13L,14L,15L,16L,17L,18L,19L,18L,19L,20L,21L,22L,23L,24L,19L,20L,21L,22L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245352Inst : IEnumerable<long>
{
public static readonly long[] Value=A245352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245352.Bytes);
public long this[int i]=>Value[i];

public static A245352Inst Instance=new A245352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245353
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,7L,8L,9L,10L,11L,12L,13L,14L,15L,12L,13L,14L,15L,16L,17L,18L,19L,20L,15L,16L,17L,18L,19L,20L,21L,22L,23L,16L,17L,18L,19L,20L,21L,22L,23L,24L,23L,24L,25L,26L,27L,28L,29L,30L,31L,22L,23L,24L,25L,26L,27L,28L,29L,30L,27L,28L,29L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245353Inst : IEnumerable<long>
{
public static readonly long[] Value=A245353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245353.Bytes);
public long this[int i]=>Value[i];

public static A245353Inst Instance=new A245353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245354
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,5L,6L,7L,8L,9L,10L,11L,12L,13L,6L,7L,8L,9L,10L,11L,12L,13L,14L,11L,12L,13L,14L,15L,16L,17L,18L,19L,8L,9L,10L,11L,12L,13L,14L,15L,16L,13L,14L,15L,16L,17L,18L,19L,20L,21L,14L,15L,16L,17L,18L,19L,20L,21L,22L,19L,20L,21L,22L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245354Inst : IEnumerable<long>
{
public static readonly long[] Value=A245354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245354.Bytes);
public long this[int i]=>Value[i];

public static A245354Inst Instance=new A245354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245355
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,5L,6L,7L,8L,9L,10L,11L,12L,7L,8L,9L,10L,11L,12L,13L,14L,12L,13L,14L,15L,16L,17L,18L,19L,11L,12L,13L,14L,15L,16L,17L,18L,13L,14L,15L,16L,17L,18L,19L,20L,18L,19L,20L,21L,22L,23L,24L,25L,14L,15L,16L,17L,18L,19L,20L,21L,13L,14L,15L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245355Inst : IEnumerable<long>
{
public static readonly long[] Value=A245355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245355.Bytes);
public long this[int i]=>Value[i];

public static A245355Inst Instance=new A245355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245356
{
public static readonly long[] Value={ 4L,4L,4L,4L,8L,8L,12L,16L,20L,28L,36L,48L,64L,88L,116L,156L,208L,276L,368L,492L,656L,872L,1164L,1552L,2068L,2760L,3680L,4904L,6540L,8720L,11628L,15504L,20672L,27560L,36748L,48996L,65328L,87104L,116140L,154852L,206472L,275296L,367060L,489412L,652552L,870068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245356Inst : IEnumerable<long>
{
public static readonly long[] Value=A245356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245356.Bytes);
public long this[int i]=>Value[i];

public static A245356Inst Instance=new A245356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245357
{
public static readonly long[] Value={ 5L,5L,5L,5L,5L,10L,10L,15L,15L,20L,25L,30L,40L,50L,60L,75L,95L,120L,150L,185L,235L,290L,365L,455L,570L,710L,890L,1110L,1390L,1735L,2170L,2715L,3390L,4240L,5300L,6625L,8280L,10350L,12940L,16175L,20215L,25270L,31590L,39485L,49355L,61695L,77120L,96400L,120500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245357Inst : IEnumerable<long>
{
public static readonly long[] Value=A245357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245357.Bytes);
public long this[int i]=>Value[i];

public static A245357Inst Instance=new A245357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245358
{
public static readonly BigInteger[] Value={ 2L,12L,199L,113L,14459L,223L,1133779L,1111222L,2225L,222222666689L,111111111222344678L,112225556779999L,BigInteger.Parse("1122233333333444555888888"),BigInteger.Parse("111111111133333333334444555666") };
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
public class A245358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245358Inst Instance=new A245358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245359
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,-1L,2L,0L,2L,0L,2L,0L,0L,0L,1L,2L,0L,2L,0L,2L,0L,0L,0L,1L,1L,0L,2L,0L,1L,0L,0L,0L,2L,0L,0L,2L,0L,1L,0L,0L,0L,1L,0L,2L,1L,0L,2L,0L,0L,0L,2L,0L,2L,0L,0L,2L,0L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,1L,0L,0L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245359Inst : IEnumerable<long>
{
public static readonly long[] Value=A245359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245359.Bytes);
public long this[int i]=>Value[i];

public static A245359Inst Instance=new A245359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245360
{
public static readonly long[] Value={ 8L,36L,100L,128L,144L,216L,576L,1764L,2304L,3844L,5184L,7056L,8100L,8192L,12100L,14400L,14884L,21952L,30276L,41616L,43264L,48400L,53824L,57600L,69696L,74088L,93636L,106276L,112896L,138384L,148996L,166464L,168100L,197136L,206116L,207936L,219024L,220900L,224676L,272484L,279936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245360Inst : IEnumerable<long>
{
public static readonly long[] Value=A245360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245360.Bytes);
public long this[int i]=>Value[i];

public static A245360Inst Instance=new A245360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245361
{
public static readonly long[] Value={ 3L,8L,30L,36L,42L,51L,53L,80L,84L,99L,300L,323L,341L,360L,384L,387L,420L,422L,426L,510L,530L,552L,575L,576L,591L,800L,825L,827L,840L,861L,882L,990L,993L,998L,3000L,3032L,3069L,3072L,3201L,3230L,3264L,3276L,3410L,3441L,3477L,3483L,3600L,3633L,3648L,3671L,3806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245361Inst : IEnumerable<long>
{
public static readonly long[] Value=A245361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245361.Bytes);
public long this[int i]=>Value[i];

public static A245361Inst Instance=new A245361Inst();

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