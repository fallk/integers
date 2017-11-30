using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198205
{
public static readonly long[] Value={ 4L,43L,658L,11029L,189376L,3272959L,56665678L,981535273L,17003856124L,294580477651L,5103458162314L,88415060881213L,1531751228239288L,26536907089886119L,459740106490112326L,7964792868501695569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198205Inst : IEnumerable<long>
{
public static readonly long[] Value=A198205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198205.Bytes);
public long this[int i]=>Value[i];

public static A198205Inst Instance=new A198205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198206
{
public static readonly BigInteger[] Value={ 43L,1765L,50729L,1660672L,56315642L,1930887802L,66941645630L,2331298473193L,81407459944121L,2846734759084627L,99622031525717855L,3487698946608204322L,BigInteger.Parse("122128077706715335280"),BigInteger.Parse("4277023178407978272400"),BigInteger.Parse("149793878862653254021508") };
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
public class A198206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198206Inst Instance=new A198206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198207
{
public static readonly BigInteger[] Value={ 658L,50729L,3603458L,276030525L,21989253467L,1791994477631L,148260119458624L,12388301166414053L,1042156486950351473L,BigInteger.Parse("88068293220220746165"),BigInteger.Parse("7464940011082766165729"),BigInteger.Parse("634039417143962239696103") };
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
public class A198207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198207Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198207.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198207Inst Instance=new A198207Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198208
{
public static readonly long[] Value={ 11029L,1660672L,276030525L,51432469614L,10120087499636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198208Inst : IEnumerable<long>
{
public static readonly long[] Value=A198208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198208.Bytes);
public long this[int i]=>Value[i];

public static A198208Inst Instance=new A198208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198209
{
public static readonly long[] Value={ 4L,43L,43L,658L,1765L,658L,11029L,50729L,50729L,11029L,189376L,1660672L,3603458L,1660672L,189376L,3272959L,56315642L,276030525L,276030525L,56315642L,3272959L,56665678L,1930887802L,21989253467L,51432469614L,21989253467L,1930887802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198209Inst : IEnumerable<long>
{
public static readonly long[] Value=A198209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198209.Bytes);
public long this[int i]=>Value[i];

public static A198209Inst Instance=new A198209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198210
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,68L,0L,255L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,272L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1020L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198210Inst : IEnumerable<long>
{
public static readonly long[] Value=A198210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198210.Bytes);
public long this[int i]=>Value[i];

public static A198210Inst Instance=new A198210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198211
{
public static readonly long[] Value={ 5L,3L,5L,4L,2L,8L,2L,4L,4L,1L,6L,4L,6L,5L,6L,9L,1L,4L,1L,2L,5L,9L,7L,8L,6L,8L,5L,3L,0L,8L,3L,9L,7L,3L,8L,0L,8L,7L,9L,6L,8L,4L,4L,3L,9L,2L,2L,7L,5L,1L,4L,6L,3L,0L,1L,8L,7L,8L,4L,2L,0L,9L,8L,6L,7L,4L,8L,3L,8L,7L,7L,8L,4L,5L,6L,9L,7L,8L,4L,5L,0L,0L,9L,7L,5L,4L,8L,8L,0L,9L,7L,2L,8L,9L,1L,9L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198211Inst : IEnumerable<long>
{
public static readonly long[] Value=A198211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198211.Bytes);
public long this[int i]=>Value[i];

public static A198211Inst Instance=new A198211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198212
{
public static readonly long[] Value={ 7L,1L,0L,7L,9L,4L,6L,8L,7L,7L,7L,4L,4L,6L,5L,3L,3L,7L,8L,4L,6L,7L,3L,5L,2L,9L,1L,4L,7L,5L,3L,2L,7L,5L,9L,4L,3L,3L,2L,3L,7L,4L,4L,0L,8L,7L,1L,7L,6L,4L,0L,0L,4L,0L,2L,2L,4L,3L,3L,1L,6L,6L,1L,9L,5L,3L,8L,0L,2L,0L,4L,7L,2L,3L,1L,7L,4L,4L,8L,3L,4L,5L,1L,0L,6L,0L,6L,4L,8L,9L,0L,1L,9L,2L,3L,9L,8L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198212Inst : IEnumerable<long>
{
public static readonly long[] Value=A198212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198212.Bytes);
public long this[int i]=>Value[i];

public static A198212Inst Instance=new A198212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198213
{
public static readonly long[] Value={ 9L,0L,6L,5L,9L,2L,4L,7L,4L,0L,9L,2L,4L,3L,7L,9L,6L,6L,9L,7L,9L,3L,0L,6L,8L,2L,4L,6L,7L,2L,1L,4L,9L,3L,8L,0L,6L,0L,4L,9L,7L,0L,7L,3L,7L,7L,5L,2L,2L,3L,6L,1L,4L,9L,7L,3L,2L,4L,7L,2L,0L,4L,1L,9L,2L,1L,2L,1L,6L,4L,9L,5L,8L,2L,5L,2L,1L,8L,0L,7L,1L,5L,3L,3L,3L,1L,3L,1L,1L,3L,6L,8L,2L,3L,7L,4L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198213Inst : IEnumerable<long>
{
public static readonly long[] Value=A198213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198213.Bytes);
public long this[int i]=>Value[i];

public static A198213Inst Instance=new A198213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198214
{
public static readonly long[] Value={ 6L,9L,8L,6L,5L,6L,7L,0L,5L,5L,3L,2L,3L,6L,0L,2L,6L,2L,8L,3L,7L,9L,0L,4L,6L,5L,8L,4L,0L,1L,6L,6L,0L,3L,2L,2L,9L,3L,5L,4L,5L,6L,2L,1L,2L,5L,9L,4L,7L,3L,1L,4L,2L,0L,8L,0L,6L,8L,3L,5L,4L,7L,3L,7L,3L,9L,6L,9L,1L,5L,0L,7L,3L,5L,3L,1L,4L,2L,4L,1L,0L,5L,2L,4L,8L,3L,1L,7L,4L,7L,2L,5L,2L,1L,3L,2L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198214Inst : IEnumerable<long>
{
public static readonly long[] Value=A198214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198214.Bytes);
public long this[int i]=>Value[i];

public static A198214Inst Instance=new A198214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198215
{
public static readonly long[] Value={ 4L,1L,0L,7L,3L,0L,5L,6L,8L,1L,0L,5L,3L,1L,9L,6L,7L,8L,8L,4L,2L,6L,1L,6L,3L,2L,1L,6L,8L,8L,4L,2L,9L,3L,2L,6L,3L,7L,9L,5L,7L,1L,5L,3L,6L,1L,1L,2L,5L,4L,5L,5L,4L,5L,6L,9L,4L,6L,9L,7L,5L,4L,1L,5L,7L,2L,2L,8L,2L,7L,3L,8L,9L,2L,4L,0L,5L,3L,7L,7L,8L,6L,8L,6L,6L,3L,0L,0L,5L,0L,5L,8L,3L,1L,8L,5L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198215Inst : IEnumerable<long>
{
public static readonly long[] Value=A198215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198215.Bytes);
public long this[int i]=>Value[i];

public static A198215Inst Instance=new A198215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198216
{
public static readonly long[] Value={ 8L,5L,0L,4L,4L,0L,0L,8L,1L,4L,2L,7L,0L,0L,8L,5L,3L,8L,5L,4L,7L,9L,1L,3L,1L,7L,7L,8L,9L,1L,5L,5L,7L,8L,2L,5L,8L,5L,6L,6L,9L,5L,9L,9L,1L,4L,6L,9L,9L,8L,3L,3L,9L,3L,8L,3L,7L,3L,5L,4L,8L,7L,8L,8L,1L,2L,2L,2L,4L,3L,4L,5L,2L,2L,6L,4L,2L,2L,8L,7L,0L,0L,8L,6L,1L,1L,9L,6L,7L,7L,4L,3L,3L,7L,5L,9L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198216Inst : IEnumerable<long>
{
public static readonly long[] Value=A198216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198216.Bytes);
public long this[int i]=>Value[i];

public static A198216Inst Instance=new A198216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198217
{
public static readonly long[] Value={ 5L,9L,4L,8L,6L,3L,2L,8L,0L,3L,5L,7L,7L,1L,8L,7L,1L,4L,1L,7L,1L,5L,9L,2L,0L,7L,7L,9L,0L,1L,0L,2L,7L,8L,7L,9L,8L,5L,8L,9L,2L,3L,1L,4L,3L,6L,2L,3L,3L,0L,7L,1L,6L,5L,9L,4L,0L,1L,0L,4L,6L,0L,3L,6L,1L,2L,2L,2L,0L,2L,3L,7L,9L,1L,3L,1L,2L,7L,6L,0L,4L,4L,5L,2L,2L,4L,8L,4L,5L,7L,6L,4L,2L,3L,6L,0L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198217Inst : IEnumerable<long>
{
public static readonly long[] Value=A198217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198217.Bytes);
public long this[int i]=>Value[i];

public static A198217Inst Instance=new A198217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198218
{
public static readonly long[] Value={ 9L,4L,8L,2L,5L,4L,6L,0L,7L,7L,3L,9L,1L,7L,3L,6L,6L,2L,9L,6L,4L,1L,7L,3L,3L,3L,4L,7L,5L,5L,7L,4L,6L,5L,0L,3L,6L,9L,4L,7L,2L,8L,0L,3L,9L,9L,1L,4L,4L,6L,9L,1L,8L,4L,1L,1L,3L,2L,2L,3L,4L,4L,2L,7L,1L,1L,1L,7L,5L,7L,6L,5L,3L,9L,9L,3L,4L,2L,0L,9L,7L,3L,1L,8L,5L,1L,5L,6L,4L,2L,6L,7L,6L,1L,2L,2L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198218Inst : IEnumerable<long>
{
public static readonly long[] Value=A198218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198218.Bytes);
public long this[int i]=>Value[i];

public static A198218Inst Instance=new A198218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198219
{
public static readonly long[] Value={ 7L,1L,7L,2L,8L,5L,1L,7L,0L,8L,0L,2L,5L,7L,9L,3L,7L,2L,6L,8L,0L,2L,5L,0L,7L,2L,8L,2L,8L,2L,1L,1L,6L,9L,1L,5L,3L,4L,4L,4L,6L,0L,8L,6L,7L,8L,7L,1L,9L,5L,8L,6L,9L,1L,4L,1L,2L,2L,9L,6L,0L,1L,7L,4L,4L,9L,3L,9L,0L,5L,6L,7L,3L,6L,8L,7L,6L,5L,9L,2L,4L,9L,9L,2L,3L,2L,3L,6L,1L,3L,6L,5L,4L,4L,1L,7L,9L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198219Inst : IEnumerable<long>
{
public static readonly long[] Value=A198219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198219.Bytes);
public long this[int i]=>Value[i];

public static A198219Inst Instance=new A198219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198220
{
public static readonly long[] Value={ 1L,0L,1L,9L,0L,9L,2L,5L,0L,2L,8L,1L,5L,4L,1L,8L,0L,6L,7L,9L,8L,4L,1L,7L,9L,1L,2L,6L,0L,8L,9L,8L,5L,9L,0L,3L,6L,9L,6L,2L,2L,3L,0L,4L,4L,2L,0L,6L,4L,4L,7L,2L,2L,9L,4L,8L,2L,0L,6L,4L,1L,7L,4L,3L,6L,4L,6L,3L,9L,2L,2L,2L,2L,2L,8L,3L,2L,4L,7L,7L,8L,9L,1L,6L,3L,7L,3L,7L,3L,9L,3L,4L,6L,3L,8L,0L,8L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198220Inst : IEnumerable<long>
{
public static readonly long[] Value=A198220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198220.Bytes);
public long this[int i]=>Value[i];

public static A198220Inst Instance=new A198220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198221
{
public static readonly long[] Value={ 8L,0L,7L,6L,7L,8L,4L,8L,2L,4L,2L,7L,2L,1L,0L,6L,5L,0L,9L,1L,8L,0L,5L,7L,2L,1L,3L,0L,7L,8L,3L,7L,5L,6L,6L,3L,5L,0L,3L,8L,6L,6L,3L,6L,1L,6L,6L,1L,1L,3L,0L,6L,4L,0L,9L,0L,6L,6L,7L,9L,8L,0L,4L,1L,2L,7L,9L,3L,8L,4L,5L,9L,3L,1L,7L,3L,4L,2L,5L,1L,7L,7L,5L,5L,3L,8L,9L,7L,0L,5L,9L,1L,5L,1L,4L,1L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198221Inst : IEnumerable<long>
{
public static readonly long[] Value=A198221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198221.Bytes);
public long this[int i]=>Value[i];

public static A198221Inst Instance=new A198221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198222
{
public static readonly long[] Value={ 8L,9L,7L,9L,9L,1L,2L,1L,7L,8L,1L,5L,7L,7L,3L,7L,2L,3L,2L,7L,0L,9L,4L,3L,4L,7L,4L,5L,5L,1L,2L,3L,8L,3L,2L,2L,3L,4L,4L,2L,6L,5L,1L,2L,3L,7L,9L,3L,4L,8L,0L,7L,1L,3L,1L,4L,1L,5L,1L,3L,4L,7L,0L,8L,1L,2L,5L,4L,3L,5L,5L,9L,8L,9L,3L,2L,4L,5L,5L,8L,5L,1L,9L,4L,4L,4L,4L,2L,6L,7L,2L,5L,8L,4L,4L,1L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198222Inst : IEnumerable<long>
{
public static readonly long[] Value=A198222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198222.Bytes);
public long this[int i]=>Value[i];

public static A198222Inst Instance=new A198222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198223
{
public static readonly long[] Value={ 3L,2L,0L,4L,8L,0L,4L,7L,7L,9L,6L,9L,1L,3L,5L,7L,1L,1L,4L,2L,1L,6L,2L,3L,4L,7L,6L,1L,8L,2L,6L,7L,6L,3L,9L,3L,7L,8L,4L,5L,5L,5L,3L,8L,8L,8L,5L,1L,4L,1L,9L,5L,8L,6L,4L,5L,8L,2L,0L,0L,4L,5L,4L,9L,0L,4L,1L,3L,1L,3L,2L,2L,3L,0L,9L,5L,9L,5L,7L,0L,9L,4L,9L,4L,6L,8L,9L,1L,9L,2L,2L,9L,8L,5L,6L,0L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198223Inst : IEnumerable<long>
{
public static readonly long[] Value=A198223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198223.Bytes);
public long this[int i]=>Value[i];

public static A198223Inst Instance=new A198223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198224
{
public static readonly long[] Value={ 1L,0L,1L,4L,0L,6L,0L,5L,8L,2L,6L,8L,7L,9L,0L,1L,0L,7L,2L,2L,1L,4L,7L,7L,7L,7L,0L,6L,5L,5L,2L,9L,7L,9L,9L,7L,3L,0L,9L,4L,2L,4L,8L,2L,7L,2L,3L,1L,2L,7L,8L,4L,0L,3L,8L,8L,3L,8L,1L,9L,8L,8L,5L,4L,5L,4L,0L,0L,1L,9L,0L,1L,3L,1L,2L,9L,2L,8L,6L,2L,4L,3L,0L,8L,1L,8L,8L,3L,4L,5L,9L,3L,5L,7L,0L,7L,5L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198224Inst : IEnumerable<long>
{
public static readonly long[] Value=A198224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198224.Bytes);
public long this[int i]=>Value[i];

public static A198224Inst Instance=new A198224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198225
{
public static readonly long[] Value={ 5L,0L,0L,8L,6L,6L,3L,1L,0L,2L,5L,3L,0L,1L,1L,7L,6L,9L,7L,9L,0L,8L,0L,2L,7L,5L,4L,6L,9L,4L,6L,5L,6L,3L,3L,0L,3L,2L,1L,5L,5L,6L,9L,7L,4L,9L,5L,5L,9L,5L,6L,2L,7L,5L,7L,4L,5L,2L,1L,3L,3L,0L,3L,1L,2L,7L,4L,0L,4L,8L,0L,4L,4L,3L,8L,4L,7L,3L,5L,1L,5L,1L,5L,2L,3L,9L,2L,8L,1L,5L,2L,3L,5L,5L,3L,9L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198225Inst : IEnumerable<long>
{
public static readonly long[] Value=A198225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198225.Bytes);
public long this[int i]=>Value[i];

public static A198225Inst Instance=new A198225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198226
{
public static readonly long[] Value={ 1L,0L,9L,0L,4L,3L,8L,2L,5L,6L,0L,3L,8L,8L,7L,4L,4L,0L,8L,9L,2L,5L,2L,0L,3L,5L,1L,2L,6L,0L,6L,8L,0L,6L,5L,3L,7L,2L,5L,2L,4L,7L,5L,9L,2L,4L,1L,5L,3L,5L,9L,8L,0L,5L,0L,3L,7L,7L,3L,9L,4L,4L,1L,1L,3L,8L,6L,7L,7L,7L,3L,1L,4L,3L,0L,8L,6L,0L,7L,4L,9L,8L,1L,3L,9L,1L,7L,6L,9L,1L,1L,0L,3L,1L,0L,8L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198226Inst : IEnumerable<long>
{
public static readonly long[] Value=A198226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198226.Bytes);
public long this[int i]=>Value[i];

public static A198226Inst Instance=new A198226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198227
{
public static readonly long[] Value={ 6L,2L,6L,4L,6L,6L,3L,3L,7L,8L,4L,9L,2L,9L,1L,8L,6L,3L,0L,1L,2L,3L,5L,0L,1L,0L,6L,3L,3L,5L,8L,7L,6L,2L,0L,5L,1L,7L,8L,9L,2L,9L,3L,3L,5L,8L,2L,0L,0L,9L,5L,1L,5L,5L,0L,3L,9L,9L,0L,7L,8L,1L,3L,9L,4L,8L,6L,1L,4L,5L,9L,9L,3L,6L,8L,6L,8L,3L,4L,8L,4L,1L,9L,0L,9L,8L,8L,5L,9L,7L,9L,7L,7L,0L,7L,2L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198227Inst : IEnumerable<long>
{
public static readonly long[] Value=A198227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198227.Bytes);
public long this[int i]=>Value[i];

public static A198227Inst Instance=new A198227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198228
{
public static readonly long[] Value={ 1L,1L,4L,6L,0L,6L,9L,5L,8L,0L,2L,1L,0L,4L,4L,1L,8L,1L,3L,3L,9L,4L,3L,5L,1L,1L,9L,5L,7L,8L,0L,6L,1L,1L,8L,3L,1L,9L,6L,9L,7L,1L,2L,7L,5L,0L,3L,5L,7L,5L,4L,0L,7L,7L,1L,5L,5L,7L,0L,1L,3L,0L,4L,9L,3L,6L,2L,3L,7L,0L,6L,6L,8L,2L,1L,7L,8L,2L,2L,1L,5L,8L,2L,5L,7L,1L,7L,2L,9L,2L,4L,0L,2L,2L,2L,0L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198228Inst : IEnumerable<long>
{
public static readonly long[] Value=A198228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198228.Bytes);
public long this[int i]=>Value[i];

public static A198228Inst Instance=new A198228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198229
{
public static readonly long[] Value={ 7L,2L,1L,3L,4L,1L,3L,0L,7L,6L,4L,8L,0L,1L,5L,5L,8L,2L,4L,2L,1L,0L,3L,1L,7L,2L,2L,8L,7L,2L,3L,0L,6L,4L,4L,8L,0L,7L,1L,3L,2L,7L,4L,5L,7L,8L,8L,7L,2L,6L,1L,7L,7L,3L,1L,8L,9L,8L,8L,0L,8L,7L,2L,0L,6L,2L,1L,0L,8L,1L,3L,0L,5L,2L,7L,1L,2L,8L,1L,1L,4L,2L,2L,4L,1L,6L,5L,1L,3L,1L,8L,1L,0L,5L,3L,3L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198229Inst : IEnumerable<long>
{
public static readonly long[] Value=A198229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198229.Bytes);
public long this[int i]=>Value[i];

public static A198229Inst Instance=new A198229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198230
{
public static readonly long[] Value={ 1L,1L,2L,6L,9L,9L,6L,5L,9L,6L,1L,1L,1L,3L,9L,9L,6L,5L,8L,3L,4L,5L,2L,3L,7L,3L,8L,4L,3L,2L,5L,4L,0L,4L,8L,5L,4L,9L,3L,7L,7L,7L,1L,3L,8L,6L,4L,4L,6L,8L,9L,1L,7L,0L,7L,6L,6L,3L,8L,2L,1L,6L,3L,8L,9L,7L,3L,2L,5L,0L,6L,1L,3L,0L,0L,6L,9L,5L,4L,3L,3L,5L,9L,8L,1L,1L,2L,2L,2L,6L,6L,1L,7L,3L,1L,2L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198230Inst : IEnumerable<long>
{
public static readonly long[] Value=A198230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198230.Bytes);
public long this[int i]=>Value[i];

public static A198230Inst Instance=new A198230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198231
{
public static readonly long[] Value={ 2L,5L,6L,5L,8L,4L,9L,3L,4L,2L,2L,3L,5L,6L,9L,4L,4L,0L,1L,5L,0L,4L,5L,7L,9L,4L,7L,4L,9L,9L,0L,9L,3L,5L,5L,9L,7L,4L,9L,3L,1L,3L,4L,1L,1L,9L,4L,6L,0L,6L,7L,2L,9L,3L,7L,2L,5L,2L,0L,1L,7L,4L,8L,4L,7L,5L,7L,2L,0L,4L,3L,3L,0L,3L,2L,9L,1L,8L,9L,9L,0L,1L,8L,4L,9L,6L,1L,4L,3L,3L,4L,1L,3L,0L,9L,1L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198231Inst : IEnumerable<long>
{
public static readonly long[] Value=A198231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198231.Bytes);
public long this[int i]=>Value[i];

public static A198231Inst Instance=new A198231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198232
{
public static readonly long[] Value={ 1L,2L,0L,0L,7L,7L,7L,2L,7L,8L,5L,1L,7L,3L,9L,1L,2L,9L,0L,6L,6L,3L,6L,5L,4L,5L,8L,7L,6L,8L,2L,6L,7L,1L,2L,8L,3L,9L,0L,6L,4L,6L,0L,6L,7L,4L,0L,2L,6L,8L,3L,9L,5L,7L,3L,8L,7L,5L,7L,4L,8L,1L,3L,5L,6L,4L,6L,4L,3L,0L,1L,6L,8L,4L,8L,9L,1L,9L,8L,5L,8L,9L,2L,9L,7L,8L,0L,6L,7L,0L,0L,6L,1L,6L,9L,7L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198232Inst : IEnumerable<long>
{
public static readonly long[] Value=A198232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198232.Bytes);
public long this[int i]=>Value[i];

public static A198232Inst Instance=new A198232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198233
{
public static readonly long[] Value={ 4L,2L,5L,8L,1L,5L,7L,1L,0L,7L,4L,8L,3L,1L,6L,9L,8L,4L,5L,6L,8L,9L,2L,2L,3L,2L,1L,6L,3L,4L,1L,4L,8L,0L,8L,7L,0L,5L,3L,8L,5L,1L,4L,4L,7L,8L,5L,9L,6L,2L,9L,9L,8L,0L,0L,1L,1L,5L,3L,5L,2L,9L,4L,3L,8L,6L,2L,1L,4L,1L,1L,7L,9L,7L,6L,1L,3L,3L,1L,6L,0L,9L,1L,4L,5L,3L,3L,8L,4L,6L,5L,8L,4L,5L,7L,1L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198233Inst : IEnumerable<long>
{
public static readonly long[] Value=A198233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198233.Bytes);
public long this[int i]=>Value[i];

public static A198233Inst Instance=new A198233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198234
{
public static readonly long[] Value={ 1L,2L,8L,8L,3L,8L,9L,2L,3L,7L,3L,2L,2L,8L,2L,6L,9L,2L,0L,4L,4L,6L,9L,5L,3L,7L,6L,1L,9L,8L,4L,1L,5L,2L,6L,3L,6L,5L,4L,6L,9L,2L,7L,5L,3L,7L,0L,8L,5L,4L,5L,5L,9L,2L,9L,1L,2L,6L,9L,9L,7L,2L,0L,6L,3L,6L,3L,3L,2L,7L,2L,4L,5L,6L,6L,2L,9L,8L,9L,2L,8L,5L,0L,3L,6L,9L,9L,0L,3L,4L,9L,0L,3L,7L,6L,8L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198234Inst : IEnumerable<long>
{
public static readonly long[] Value=A198234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198234.Bytes);
public long this[int i]=>Value[i];

public static A198234Inst Instance=new A198234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198235
{
public static readonly long[] Value={ 6L,4L,6L,4L,3L,5L,5L,6L,7L,5L,2L,7L,7L,2L,2L,5L,8L,8L,3L,7L,9L,1L,3L,3L,8L,2L,8L,1L,0L,8L,7L,4L,3L,8L,8L,9L,3L,9L,7L,9L,1L,9L,1L,6L,8L,5L,7L,2L,7L,9L,8L,9L,6L,7L,9L,8L,9L,0L,5L,4L,7L,6L,1L,3L,1L,2L,9L,2L,5L,5L,6L,6L,3L,6L,3L,9L,0L,5L,4L,5L,4L,8L,0L,5L,8L,4L,8L,6L,8L,1L,2L,8L,3L,7L,0L,5L,9L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198235Inst : IEnumerable<long>
{
public static readonly long[] Value=A198235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198235.Bytes);
public long this[int i]=>Value[i];

public static A198235Inst Instance=new A198235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198236
{
public static readonly long[] Value={ 1L,3L,7L,9L,3L,2L,3L,3L,2L,0L,9L,8L,6L,8L,8L,7L,6L,5L,8L,6L,3L,7L,2L,5L,6L,1L,8L,9L,5L,6L,0L,1L,7L,3L,7L,8L,7L,6L,6L,2L,5L,8L,2L,2L,2L,4L,2L,6L,9L,6L,0L,7L,5L,0L,0L,8L,7L,2L,2L,6L,0L,0L,6L,2L,4L,6L,3L,9L,2L,1L,1L,7L,7L,2L,4L,9L,2L,0L,8L,1L,2L,3L,8L,0L,4L,4L,9L,4L,7L,9L,7L,6L,9L,8L,2L,0L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198236Inst : IEnumerable<long>
{
public static readonly long[] Value=A198236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198236.Bytes);
public long this[int i]=>Value[i];

public static A198236Inst Instance=new A198236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198237
{
public static readonly long[] Value={ 2L,1L,1L,0L,4L,7L,2L,9L,4L,4L,9L,0L,0L,4L,0L,2L,8L,4L,2L,0L,8L,2L,1L,9L,2L,9L,2L,6L,6L,0L,1L,9L,0L,8L,2L,8L,8L,0L,8L,4L,5L,8L,3L,4L,0L,1L,0L,3L,0L,2L,3L,9L,4L,9L,9L,4L,3L,9L,5L,2L,1L,7L,4L,2L,3L,5L,6L,7L,1L,9L,7L,8L,1L,2L,9L,8L,7L,1L,4L,9L,3L,9L,2L,3L,8L,1L,5L,5L,4L,6L,8L,2L,7L,8L,7L,6L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198237Inst : IEnumerable<long>
{
public static readonly long[] Value=A198237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198237.Bytes);
public long this[int i]=>Value[i];

public static A198237Inst Instance=new A198237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198238
{
public static readonly long[] Value={ 1L,4L,0L,9L,3L,6L,3L,9L,2L,1L,6L,3L,5L,7L,7L,7L,8L,4L,4L,7L,7L,2L,8L,6L,9L,3L,6L,8L,8L,0L,1L,5L,3L,9L,7L,9L,5L,1L,1L,7L,7L,3L,5L,0L,3L,8L,5L,9L,2L,6L,5L,8L,5L,5L,0L,3L,9L,0L,2L,5L,4L,6L,5L,2L,1L,7L,9L,0L,0L,3L,7L,0L,4L,7L,8L,5L,6L,4L,0L,7L,7L,3L,9L,9L,1L,4L,4L,8L,5L,5L,7L,3L,0L,5L,7L,4L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198238Inst : IEnumerable<long>
{
public static readonly long[] Value=A198238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198238.Bytes);
public long this[int i]=>Value[i];

public static A198238Inst Instance=new A198238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198239
{
public static readonly long[] Value={ 3L,6L,6L,2L,4L,0L,8L,1L,5L,6L,6L,0L,4L,6L,3L,7L,1L,8L,3L,8L,4L,1L,5L,8L,1L,8L,8L,6L,9L,7L,6L,4L,4L,4L,0L,5L,4L,7L,4L,3L,1L,6L,0L,8L,8L,4L,0L,0L,7L,0L,5L,9L,1L,1L,9L,3L,7L,7L,4L,4L,5L,1L,4L,1L,3L,6L,4L,9L,0L,2L,2L,0L,6L,8L,1L,8L,3L,5L,2L,1L,5L,9L,0L,0L,0L,7L,9L,7L,9L,3L,0L,3L,4L,1L,8L,4L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198239Inst : IEnumerable<long>
{
public static readonly long[] Value=A198239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198239.Bytes);
public long this[int i]=>Value[i];

public static A198239Inst Instance=new A198239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198240
{
public static readonly long[] Value={ 1L,4L,3L,0L,8L,3L,3L,4L,2L,0L,7L,1L,7L,7L,2L,8L,5L,4L,2L,5L,6L,6L,5L,4L,3L,9L,3L,3L,6L,3L,9L,1L,3L,8L,8L,5L,9L,9L,0L,2L,1L,8L,3L,5L,9L,2L,1L,4L,8L,4L,4L,4L,7L,5L,8L,6L,5L,1L,2L,9L,3L,6L,0L,4L,8L,3L,7L,1L,3L,3L,8L,0L,5L,4L,1L,2L,3L,2L,2L,6L,5L,7L,9L,2L,4L,5L,7L,1L,3L,4L,4L,7L,6L,3L,9L,6L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198240Inst : IEnumerable<long>
{
public static readonly long[] Value=A198240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198240.Bytes);
public long this[int i]=>Value[i];

public static A198240Inst Instance=new A198240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198241
{
public static readonly long[] Value={ 4L,8L,6L,0L,0L,4L,4L,3L,5L,9L,9L,2L,2L,9L,3L,0L,4L,0L,8L,1L,6L,1L,9L,8L,9L,8L,1L,5L,0L,3L,5L,7L,8L,5L,6L,4L,6L,9L,2L,1L,1L,0L,8L,7L,9L,7L,3L,0L,9L,4L,7L,7L,4L,2L,5L,5L,3L,7L,9L,8L,3L,9L,2L,2L,9L,1L,8L,0L,2L,6L,8L,1L,9L,8L,3L,7L,6L,9L,9L,0L,9L,0L,6L,2L,7L,7L,5L,3L,7L,1L,6L,2L,9L,0L,0L,4L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198241Inst : IEnumerable<long>
{
public static readonly long[] Value=A198241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198241.Bytes);
public long this[int i]=>Value[i];

public static A198241Inst Instance=new A198241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198242
{
public static readonly long[] Value={ 1L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,2L,3L,2L,1L,2L,4L,5L,5L,5L,5L,4L,1L,-3L,-5L,-4L,-2L,-1L,-3L,-9L,-15L,-16L,-14L,-15L,-21L,-29L,-33L,-26L,-7L,12L,14L,-3L,-21L,-22L,-7L,9L,16L,17L,20L,31L,52L,75L,84L,76L,72L,92L,124L,131L,91L,27L,-8L,18L,83L,132L,127L,81L,46L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198242Inst : IEnumerable<long>
{
public static readonly long[] Value=A198242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198242.Bytes);
public long this[int i]=>Value[i];

public static A198242Inst Instance=new A198242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198243
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,-1L,-2L,-2L,-1L,0L,0L,-1L,-2L,-2L,0L,4L,7L,6L,3L,2L,3L,4L,5L,6L,6L,6L,8L,10L,6L,-6L,-18L,-20L,-13L,-7L,-8L,-13L,-16L,-15L,-13L,-15L,-25L,-41L,-53L,-53L,-44L,-32L,-16L,5L,22L,25L,18L,13L,14L,19L,29L,41L,44L,38L,43L,72L,109L,130L,135L,146L,180L,232L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198243Inst : IEnumerable<long>
{
public static readonly long[] Value=A198243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198243.Bytes);
public long this[int i]=>Value[i];

public static A198243Inst Instance=new A198243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198244
{
public static readonly BigInteger[] Value={ 11L,10778947368421L,17513875027111L,610851724137931L,614910264406779661L,BigInteger.Parse("22390512687494871811"),BigInteger.Parse("22793803793211153712637"),BigInteger.Parse("79905927161140977116221"),BigInteger.Parse("184251916941751188170917"),BigInteger.Parse("319465039747605973452001"),BigInteger.Parse("1311848376806967295019263"),BigInteger.Parse("1918542715220370688851293") };
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
public class A198244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198244Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198244.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198244Inst Instance=new A198244Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198245
{
public static readonly long[] Value={ 149L,241L,2946901L,16467631L,17613227L,327784727L,426369739L,1062232319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198245Inst : IEnumerable<long>
{
public static readonly long[] Value=A198245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198245.Bytes);
public long this[int i]=>Value[i];

public static A198245Inst Instance=new A198245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198246
{
public static readonly long[] Value={ 1L,5L,1675L,14520192L,1683040515731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198246Inst : IEnumerable<long>
{
public static readonly long[] Value=A198246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198246.Bytes);
public long this[int i]=>Value[i];

public static A198246Inst Instance=new A198246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198247
{
public static readonly long[] Value={ 1L,5L,40L,485L,6528L,90641L,1268648L,17794141L,249720000L,3505037833L,49198133832L,690571872597L,9693269289152L,136060470673025L,1909825721373608L,26807451423465421L,376285360845321600L,5281765543824353657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198247Inst : IEnumerable<long>
{
public static readonly long[] Value=A198247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198247.Bytes);
public long this[int i]=>Value[i];

public static A198247Inst Instance=new A198247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198248
{
public static readonly BigInteger[] Value={ 2L,40L,1675L,81440L,4059950L,203087097L,10164141586L,508740409496L,25464106707391L,1274565023173456L,63796351813851410L,3193226785065121249L,BigInteger.Parse("159831987739494226958"),BigInteger.Parse("8000141016276333546184"),BigInteger.Parse("400434589880788614683443") };
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
public class A198248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198248Inst Instance=new A198248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198249
{
public static readonly BigInteger[] Value={ 5L,485L,81440L,14520192L,2606019472L,468268681671L,84165911962889L,15129042589276259L,2719545932661264380L,BigInteger.Parse("488859618202335884730"),BigInteger.Parse("87876498667057316198136"),BigInteger.Parse("15796525069912515393284021") };
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
public class A198249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198249Inst Instance=new A198249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198250
{
public static readonly long[] Value={ 15L,6528L,4059950L,2606019472L,1683040515731L,1088857594220452L,704825868750085006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198250Inst : IEnumerable<long>
{
public static readonly long[] Value=A198250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198250.Bytes);
public long this[int i]=>Value[i];

public static A198250Inst Instance=new A198250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198251
{
public static readonly long[] Value={ 51L,90641L,203087097L,468268681671L,1088857594220452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198251Inst : IEnumerable<long>
{
public static readonly long[] Value=A198251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198251.Bytes);
public long this[int i]=>Value[i];

public static A198251Inst Instance=new A198251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198252
{
public static readonly long[] Value={ 187L,1268648L,10164141586L,84165911962889L,704825868750085006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198252Inst : IEnumerable<long>
{
public static readonly long[] Value=A198252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198252.Bytes);
public long this[int i]=>Value[i];

public static A198252Inst Instance=new A198252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198253
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,5L,40L,40L,5L,15L,485L,1675L,485L,15L,51L,6528L,81440L,81440L,6528L,51L,187L,90641L,4059950L,14520192L,4059950L,90641L,187L,715L,1268648L,203087097L,2606019472L,2606019472L,203087097L,1268648L,715L,2795L,17794141L,10164141586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198253Inst : IEnumerable<long>
{
public static readonly long[] Value=A198253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198253.Bytes);
public long this[int i]=>Value[i];

public static A198253Inst Instance=new A198253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198254
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198254Inst : IEnumerable<long>
{
public static readonly long[] Value=A198254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198254.Bytes);
public long this[int i]=>Value[i];

public static A198254Inst Instance=new A198254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198255
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,1L,0L,1L,0L,2L,0L,5L,0L,0L,0L,1L,0L,3L,1L,2L,0L,3L,0L,4L,1L,0L,1L,3L,0L,5L,0L,2L,0L,4L,0L,1L,2L,2L,0L,3L,0L,4L,2L,2L,1L,3L,0L,6L,1L,2L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198255Inst : IEnumerable<long>
{
public static readonly long[] Value=A198255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198255.Bytes);
public long this[int i]=>Value[i];

public static A198255Inst Instance=new A198255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198256
{
public static readonly BigInteger[] Value={ 1L,5L,46L,485L,5626L,69062L,882540L,11614437L,156343330L,2142556130L,29791689148L,419260001030L,5960334608788L,85469709312860L,1234797737654296L,17955907741675749L,262607675818816050L,3860239468267647914L,BigInteger.Parse("57002176852356800700"),BigInteger.Parse("845159480056345448610") };
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
public class A198256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198256Inst Instance=new A198256Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198257
{
public static readonly BigInteger[] Value={ 1L,6L,94L,1700L,35466L,795312L,18848992L,464517468L,11801240050L,307073982116L,8147186436324L,219664321959524L,6003343077661216L,165975724832822400L,4634768975107569024L,BigInteger.Parse("130553813782898706908"),BigInteger.Parse("3705740233107582161538"),BigInteger.Parse("105902829964290241990332") };
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
public class A198257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198257Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198257.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198257.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198257Inst Instance=new A198257Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198258
{
public static readonly BigInteger[] Value={ 1L,7L,190L,5831L,219626L,8976562L,394800204L,18211045575L,873216720082L,43136486269382L,2183722698469676L,112795257850321202L,5925951358743662260L,BigInteger.Parse("315869014732813229716"),BigInteger.Parse("17048301919464100932440"),BigInteger.Parse("930217336628892162216135"),BigInteger.Parse("51244644190683748419791970") };
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
public class A198258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198258Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198258.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198258.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198258Inst Instance=new A198258Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198259
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,2L,6L,5L,9L,9L,17L,13L,26L,26L,39L,39L,66L,61L,104L,102L,156L,162L,265L,249L,405L,419L,646L,652L,1059L,1031L,1676L,1696L,2660L,2705L,4362L,4283L,6937L,7039L,11159L,11206L,18138L,17998L,29130L,29325L,46805L,47075L,76171L,75713L,122502L,123123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198259Inst : IEnumerable<long>
{
public static readonly long[] Value=A198259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198259.Bytes);
public long this[int i]=>Value[i];

public static A198259Inst Instance=new A198259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198260
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,2L,2L,2L,4L,3L,2L,3L,4L,2L,1L,2L,2L,2L,2L,4L,3L,2L,4L,4L,2L,2L,2L,4L,4L,4L,3L,2L,4L,4L,4L,4L,2L,4L,3L,2L,4L,4L,4L,4L,4L,8L,7L,3L,5L,6L,2L,3L,4L,4L,4L,4L,6L,5L,4L,7L,8L,2L,3L,4L,2L,1L,2L,2L,2L,2L,4L,3L,2L,4L,4L,2L,2L,2L,4L,4L,4L,3L,2L,4L,4L,4L,4L,2L,4L,3L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198260Inst : IEnumerable<long>
{
public static readonly long[] Value=A198260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198260.Bytes);
public long this[int i]=>Value[i];

public static A198260Inst Instance=new A198260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198261
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,4L,3L,0L,1L,41L,16L,6L,0L,1L,768L,205L,40L,10L,0L,1L,27449L,4608L,615L,80L,15L,0L,1L,1887284L,192143L,16128L,1435L,140L,21L,0L,1L,252522481L,15098272L,768572L,43008L,2870L,224L,28L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198261Inst : IEnumerable<long>
{
public static readonly long[] Value=A198261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198261.Bytes);
public long this[int i]=>Value[i];

public static A198261Inst Instance=new A198261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198262
{
public static readonly long[] Value={ 1L,-1L,-2L,-1L,-4L,-10L,-13L,-17L,-20L,-16L,-21L,-46L,-77L,-99L,-97L,-81L,-101L,-172L,-265L,-376L,-499L,-595L,-666L,-806L,-1129L,-1639L,-2234L,-2871L,-3624L,-4615L,-6044L,-8177L,-11178L,-15063L,-19793L,-25444L,-32633L,-42751L,-57410L,-77712L,-104221L,-137679L,-180126L,-235775L,-311020L,-413748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198262Inst : IEnumerable<long>
{
public static readonly long[] Value=A198262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198262.Bytes);
public long this[int i]=>Value[i];

public static A198262Inst Instance=new A198262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198263
{
public static readonly long[] Value={ 0L,3L,6L,9L,12L,15L,17L,20L,23L,26L,29L,32L,34L,37L,40L,43L,46L,49L,51L,54L,57L,60L,63L,66L,68L,71L,74L,77L,80L,83L,85L,88L,91L,94L,97L,99L,102L,105L,108L,111L,114L,116L,119L,122L,125L,128L,131L,133L,136L,139L,142L,145L,148L,150L,153L,156L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198263Inst : IEnumerable<long>
{
public static readonly long[] Value=A198263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198263.Bytes);
public long this[int i]=>Value[i];

public static A198263Inst Instance=new A198263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198264
{
public static readonly long[] Value={ 0L,3L,6L,9L,13L,16L,19L,22L,25L,28L,32L,35L,38L,41L,44L,47L,51L,54L,57L,60L,63L,66L,70L,73L,76L,79L,82L,85L,89L,92L,95L,98L,101L,104L,108L,111L,114L,117L,120L,123L,126L,130L,133L,136L,139L,142L,145L,149L,152L,155L,158L,161L,164L,168L,171L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198264Inst : IEnumerable<long>
{
public static readonly long[] Value=A198264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198264.Bytes);
public long this[int i]=>Value[i];

public static A198264Inst Instance=new A198264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198265
{
public static readonly long[] Value={ 0L,4L,7L,10L,13L,16L,19L,23L,26L,29L,32L,35L,38L,42L,45L,48L,51L,54L,57L,61L,64L,67L,70L,73L,76L,80L,83L,86L,89L,92L,95L,99L,102L,105L,108L,111L,114L,118L,121L,124L,127L,130L,133L,136L,140L,143L,146L,149L,152L,155L,159L,162L,165L,168L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198265Inst : IEnumerable<long>
{
public static readonly long[] Value=A198265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198265.Bytes);
public long this[int i]=>Value[i];

public static A198265Inst Instance=new A198265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198266
{
public static readonly long[] Value={ 0L,4L,7L,10L,14L,17L,20L,24L,27L,30L,34L,37L,40L,44L,47L,50L,54L,57L,60L,64L,67L,70L,73L,77L,80L,83L,87L,90L,93L,97L,100L,103L,107L,110L,113L,117L,120L,123L,127L,130L,133L,136L,140L,143L,146L,150L,153L,156L,160L,163L,166L,170L,173L,176L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198266Inst : IEnumerable<long>
{
public static readonly long[] Value=A198266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198266.Bytes);
public long this[int i]=>Value[i];

public static A198266Inst Instance=new A198266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198267
{
public static readonly long[] Value={ 0L,3L,7L,10L,13L,17L,20L,23L,27L,30L,33L,36L,40L,43L,46L,50L,53L,56L,60L,63L,66L,70L,73L,76L,80L,83L,86L,90L,93L,96L,99L,103L,106L,109L,113L,116L,119L,123L,126L,129L,133L,136L,139L,143L,146L,149L,153L,156L,159L,163L,166L,169L,172L,176L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198267Inst : IEnumerable<long>
{
public static readonly long[] Value=A198267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198267.Bytes);
public long this[int i]=>Value[i];

public static A198267Inst Instance=new A198267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198268
{
public static readonly long[] Value={ 0L,3L,7L,10L,14L,17L,21L,24L,28L,31L,35L,38L,42L,45L,48L,52L,55L,59L,62L,66L,69L,73L,76L,80L,83L,87L,90L,94L,97L,100L,104L,107L,111L,114L,118L,121L,125L,128L,132L,135L,139L,142L,145L,149L,152L,156L,159L,163L,166L,170L,173L,177L,180L,184L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198268Inst : IEnumerable<long>
{
public static readonly long[] Value=A198268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198268.Bytes);
public long this[int i]=>Value[i];

public static A198268Inst Instance=new A198268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198269
{
public static readonly long[] Value={ 0L,4L,7L,11L,14L,18L,21L,25L,28L,32L,35L,39L,42L,46L,49L,52L,56L,59L,63L,66L,70L,73L,77L,80L,84L,87L,91L,94L,97L,101L,104L,108L,111L,115L,118L,122L,125L,129L,132L,136L,139L,143L,146L,149L,153L,156L,160L,163L,167L,170L,174L,177L,181L,184L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198269Inst : IEnumerable<long>
{
public static readonly long[] Value=A198269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198269.Bytes);
public long this[int i]=>Value[i];

public static A198269Inst Instance=new A198269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198270
{
public static readonly long[] Value={ 0L,4L,8L,11L,15L,19L,22L,26L,29L,33L,37L,40L,44L,47L,51L,55L,58L,62L,65L,69L,73L,76L,80L,83L,87L,91L,94L,98L,101L,105L,109L,112L,116L,119L,123L,127L,130L,134L,138L,141L,145L,148L,152L,156L,159L,163L,166L,170L,174L,177L,181L,184L,188L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198270Inst : IEnumerable<long>
{
public static readonly long[] Value=A198270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198270.Bytes);
public long this[int i]=>Value[i];

public static A198270Inst Instance=new A198270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198271
{
public static readonly long[] Value={ 0L,4L,7L,11L,14L,18L,22L,25L,29L,32L,36L,40L,43L,47L,50L,54L,58L,61L,65L,69L,72L,76L,79L,83L,87L,90L,94L,97L,101L,105L,108L,112L,115L,119L,123L,126L,130L,133L,137L,141L,144L,148L,151L,155L,159L,162L,166L,169L,173L,177L,180L,184L,187L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198271Inst : IEnumerable<long>
{
public static readonly long[] Value=A198271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198271.Bytes);
public long this[int i]=>Value[i];

public static A198271Inst Instance=new A198271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198272
{
public static readonly long[] Value={ 0L,4L,8L,12L,16L,21L,25L,29L,33L,37L,41L,45L,49L,54L,58L,62L,66L,70L,74L,78L,82L,87L,91L,95L,99L,103L,107L,111L,115L,120L,124L,128L,132L,136L,140L,144L,148L,153L,157L,161L,165L,169L,173L,177L,181L,186L,190L,194L,198L,202L,206L,210L,214L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198272Inst : IEnumerable<long>
{
public static readonly long[] Value=A198272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198272.Bytes);
public long this[int i]=>Value[i];

public static A198272Inst Instance=new A198272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198273
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,19L,29L,37L,43L,61L,67L,73L,97L,101L,103L,109L,137L,139L,149L,157L,163L,173L,181L,193L,197L,199L,211L,223L,229L,233L,241L,257L,277L,281L,283L,307L,313L,317L,331L,337L,347L,349L,353L,367L,373L,379L,389L,397L,401L,409L,421L,433L,457L,461L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198273Inst : IEnumerable<long>
{
public static readonly long[] Value=A198273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198273.Bytes);
public long this[int i]=>Value[i];

public static A198273Inst Instance=new A198273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198274
{
public static readonly long[] Value={ 12L,25L,51L,103L,207L,415L,831L,1663L,3327L,6655L,13311L,26623L,53247L,106495L,212991L,425983L,851967L,1703935L,3407871L,6815743L,13631487L,27262975L,54525951L,109051903L,218103807L,436207615L,872415231L,1744830463L,3489660927L,6979321855L,13958643711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198274Inst : IEnumerable<long>
{
public static readonly long[] Value=A198274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198274.Bytes);
public long this[int i]=>Value[i];

public static A198274Inst Instance=new A198274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198275
{
public static readonly long[] Value={ 16L,33L,67L,135L,271L,543L,1087L,2175L,4351L,8703L,17407L,34815L,69631L,139263L,278527L,557055L,1114111L,2228223L,4456447L,8912895L,17825791L,35651583L,71303167L,142606335L,285212671L,570425343L,1140850687L,2281701375L,4563402751L,9126805503L,18253611007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198275Inst : IEnumerable<long>
{
public static readonly long[] Value=A198275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198275.Bytes);
public long this[int i]=>Value[i];

public static A198275Inst Instance=new A198275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198276
{
public static readonly long[] Value={ 18L,37L,75L,151L,303L,607L,1215L,2431L,4863L,9727L,19455L,38911L,77823L,155647L,311295L,622591L,1245183L,2490367L,4980735L,9961471L,19922943L,39845887L,79691775L,159383551L,318767103L,637534207L,1275068415L,2550136831L,5100273663L,10200547327L,20401094655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198276Inst : IEnumerable<long>
{
public static readonly long[] Value=A198276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198276.Bytes);
public long this[int i]=>Value[i];

public static A198276Inst Instance=new A198276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198277
{
public static readonly long[] Value={ 2L,11L,23L,71L,239L,719L,2879L,5039L,1439L,10079L,37799L,126719L,55439L,110879L,181439L,191519L,166319L,635039L,514079L,665279L,1330559L,907199L,3243239L,831599L,2948399L,6320159L,4989599L,15301439L,14137199L,5266799L,11531519L,8315999L,23284799L,17463599L,45208799L,52390799L,34594559L,111767039L,95633999L,117976319L,70685999L,68468399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198277Inst : IEnumerable<long>
{
public static readonly long[] Value=A198277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198277.Bytes);
public long this[int i]=>Value[i];

public static A198277Inst Instance=new A198277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198278
{
public static readonly long[] Value={ 1L,4L,100L,8784L,2823604L,3337609528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198278Inst : IEnumerable<long>
{
public static readonly long[] Value=A198278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198278.Bytes);
public long this[int i]=>Value[i];

public static A198278Inst Instance=new A198278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198279
{
public static readonly long[] Value={ 1L,4L,14L,52L,190L,700L,2574L,9476L,34878L,128396L,472654L,1739988L,6405438L,23580508L,86807566L,319567268L,1176432574L,4330837036L,15943242574L,58692346740L,216065933246L,795410139132L,2928167715854L,10779553536580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198279Inst : IEnumerable<long>
{
public static readonly long[] Value=A198279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198279.Bytes);
public long this[int i]=>Value[i];

public static A198279Inst Instance=new A198279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198280
{
public static readonly long[] Value={ 2L,14L,100L,662L,4588L,31718L,219060L,1516006L,10490668L,72598710L,502455316L,3477498838L,24068002412L,166577135174L,1152898456372L,7979341139206L,55225944246124L,382225190106390L,2645425190166548L,18309297185224566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198280Inst : IEnumerable<long>
{
public static readonly long[] Value=A198280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198280.Bytes);
public long this[int i]=>Value[i];

public static A198280Inst Instance=new A198280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198281
{
public static readonly long[] Value={ 4L,52L,662L,8784L,112750L,1478756L,19399132L,254611868L,3341562350L,43867978456L,575917076750L,7560973295748L,99265283146820L,1303224636522612L,17109671915393798L,224628189063611744L,2949082376664452782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198281Inst : IEnumerable<long>
{
public static readonly long[] Value=A198281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198281.Bytes);
public long this[int i]=>Value[i];

public static A198281Inst Instance=new A198281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198282
{
public static readonly BigInteger[] Value={ 8L,190L,4588L,112750L,2823604L,70004726L,1748785516L,43705413710L,1092621380500L,27317384777366L,682990333610700L,17076690802445486L,426968760440748852L,10675538566342917910UL,BigInteger.Parse("266921663443974490508"),BigInteger.Parse("6673873780235914735374") };
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
public class A198282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198282Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198282.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198282.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198282Inst Instance=new A198282Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198283
{
public static readonly BigInteger[] Value={ 16L,700L,31718L,1478756L,70004726L,3337609528L,158791292898L,7572454386112L,361223237102398L,17233549055351780L,822235886561754748L,BigInteger.Parse("39230600563964575264"),BigInteger.Parse("1871782716035228820002"),BigInteger.Parse("89307446755046275015160") };
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
public class A198283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198283.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198283Inst Instance=new A198283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198284
{
public static readonly long[] Value={ 32L,2574L,219060L,19399132L,1748785516L,158791292898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198284Inst : IEnumerable<long>
{
public static readonly long[] Value=A198284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198284.Bytes);
public long this[int i]=>Value[i];

public static A198284Inst Instance=new A198284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198285
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,4L,14L,14L,4L,8L,52L,100L,52L,8L,16L,190L,662L,662L,190L,16L,32L,700L,4588L,8784L,4588L,700L,32L,64L,2574L,31718L,112750L,112750L,31718L,2574L,64L,128L,9476L,219060L,1478756L,2823604L,1478756L,219060L,9476L,128L,256L,34878L,1516006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198285Inst : IEnumerable<long>
{
public static readonly long[] Value=A198285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198285.Bytes);
public long this[int i]=>Value[i];

public static A198285Inst Instance=new A198285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198286
{
public static readonly long[] Value={ 1L,5L,10L,9L,26L,50L,50L,25L,19L,130L,122L,90L,170L,250L,260L,41L,290L,95L,362L,234L,500L,610L,530L,250L,51L,850L,100L,450L,842L,1300L,962L,105L,1220L,1450L,1300L,171L,1370L,1810L,1700L,650L,1682L,2500L,1850L,1098L,494L,2650L,2210L,410L,99L,255L,2900L,1530L,2810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198286Inst : IEnumerable<long>
{
public static readonly long[] Value=A198286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198286.Bytes);
public long this[int i]=>Value[i];

public static A198286Inst Instance=new A198286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198287
{
public static readonly BigInteger[] Value={ 2L,17L,272L,4667L,80702L,1397477L,24207692L,419373647L,7265397242L,125869473977L,2180631250952L,37778460128867L,654494991508022L,11338834542738317L,196440265628093252L,3403240245856247927L,BigInteger.Parse("58959623892961901042") };
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
public class A198287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198287Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198287.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198287.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198287Inst Instance=new A198287Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198288
{
public static readonly BigInteger[] Value={ 17L,2452L,413375L,72559212L,12940532183L,2322145946560L,417688220022251L,75197892524349728L,13542776983363615379UL,BigInteger.Parse("2439305921057059368196"),BigInteger.Parse("439386062130801234903655"),BigInteger.Parse("79146996287674677581757652") };
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
public class A198288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198288Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198288.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198288.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198288Inst Instance=new A198288Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198289
{
public static readonly BigInteger[] Value={ 272L,413375L,706120206L,1275102148950L,2366880827870877L,4452440424252727173L,BigInteger.Parse("8428943308912271720848"),BigInteger.Parse("16004596485813250391893906"),BigInteger.Parse("30431540879946488350797932499"),BigInteger.Parse("57901155886923326494331172396019") };
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
public class A198289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198289.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198289Inst Instance=new A198289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198290
{
public static readonly long[] Value={ 2L,17L,17L,272L,2452L,272L,4667L,413375L,413375L,4667L,80702L,72559212L,706120206L,72559212L,80702L,1397477L,12940532183L,1275102148950L,1275102148950L,12940532183L,1397477L,24207692L,2322145946560L,2366880827870877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198290Inst : IEnumerable<long>
{
public static readonly long[] Value=A198290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198290.Bytes);
public long this[int i]=>Value[i];

public static A198290Inst Instance=new A198290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198291
{
public static readonly long[] Value={ 0L,33L,111L,285L,1455L,10275L,21L,75L,45L,13573477665L,232317867705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198291Inst : IEnumerable<long>
{
public static readonly long[] Value=A198291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198291.Bytes);
public long this[int i]=>Value[i];

public static A198291Inst Instance=new A198291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198292
{
public static readonly long[] Value={ 2L,3L,4L,5L,5L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,15L,15L,15L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,23L,24L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,27L,27L,27L,27L,27L,28L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198292Inst : IEnumerable<long>
{
public static readonly long[] Value=A198292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198292.Bytes);
public long this[int i]=>Value[i];

public static A198292Inst Instance=new A198292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198293
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198293Inst : IEnumerable<long>
{
public static readonly long[] Value=A198293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198293.Bytes);
public long this[int i]=>Value[i];

public static A198293Inst Instance=new A198293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198294
{
public static readonly long[] Value={ 0L,63L,68L,135L,155L,248L,276L,407L,420L,651L,980L,1007L,1376L,1488L,2015L,2175L,2928L,3003L,4340L,6251L,6408L,8555L,9207L,12276L,13208L,17595L,18032L,25823L,36960L,37875L,50388L,54188L,72075L,77507L,103076L,105623L,151032L,215943L,221276L,294207L,316355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198294Inst : IEnumerable<long>
{
public static readonly long[] Value=A198294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198294.Bytes);
public long this[int i]=>Value[i];

public static A198294Inst Instance=new A198294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198295
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,2L,1L,0L,1L,1L,3L,1L,0L,1L,2L,3L,4L,1L,0L,0L,4L,4L,6L,5L,1L,0L,1L,2L,9L,8L,10L,6L,1L,0L,1L,3L,9L,17L,15L,15L,7L,1L,0L,0L,6L,9L,24L,30L,26L,21L,8L,1L,0L,1L,3L,18L,26L,51L,51L,42L,28L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198295Inst : IEnumerable<long>
{
public static readonly long[] Value=A198295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198295.Bytes);
public long this[int i]=>Value[i];

public static A198295Inst Instance=new A198295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198296
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,8L,17L,22L,44L,62L,115L,154L,311L,409L,754L,1070L,1949L,2639L,4917L,6645L,12055L,16916L,29594L,40719L,73907L,100959L,176010L,248207L,429626L,594220L,1040624L,1436936L,2473555L,3486360L,5901887L,8233872L,14174779L,19689223L,33203829L,46967767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198296Inst : IEnumerable<long>
{
public static readonly long[] Value=A198296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198296.Bytes);
public long this[int i]=>Value[i];

public static A198296Inst Instance=new A198296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198297
{
public static readonly long[] Value={ 0L,0L,4L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198297Inst : IEnumerable<long>
{
public static readonly long[] Value=A198297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198297.Bytes);
public long this[int i]=>Value[i];

public static A198297Inst Instance=new A198297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198298
{
public static readonly long[] Value={ 3205486917L,3207154869L,4063297185L,4063792185L,4230567819L,4230915678L,4297630518L,4297631805L,5042976318L,5063297184L,5079246318L,5093271486L,5094236718L,5148609327L,5180429763L,5180792463L,5180942367L,5184063297L,5420796318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198298Inst : IEnumerable<long>
{
public static readonly long[] Value=A198298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198298.Bytes);
public long this[int i]=>Value[i];

public static A198298Inst Instance=new A198298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198299
{
public static readonly long[] Value={ 1L,3L,4L,11L,6L,36L,8L,83L,49L,178L,12L,680L,14L,920L,714L,2707L,18L,7119L,20L,14166L,7844L,22564L,24L,94616L,3931L,106538L,88987L,306604L,30L,832606L,32L,1401715L,974736L,2228278L,150758L,9643703L,38L,9961532L,10363682L,28802278L,42L,78793604L,44L,123016344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198299Inst : IEnumerable<long>
{
public static readonly long[] Value=A198299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198299.Bytes);
public long this[int i]=>Value[i];

public static A198299Inst Instance=new A198299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198300
{
public static readonly long[] Value={ 3L,4L,4L,5L,6L,5L,6L,8L,10L,6L,7L,10L,17L,14L,7L,8L,12L,26L,26L,22L,8L,9L,14L,37L,42L,53L,30L,9L,10L,16L,50L,62L,106L,80L,46L,10L,11L,18L,65L,86L,187L,170L,161L,62L,11L,12L,20L,82L,114L,302L,312L,426L,242L,94L,12L,13L,22L,101L,146L,457L,518L,937L,682L,485L,126L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198300Inst : IEnumerable<long>
{
public static readonly long[] Value=A198300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198300.Bytes);
public long this[int i]=>Value[i];

public static A198300Inst Instance=new A198300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198301
{
public static readonly long[] Value={ 1L,1L,3L,5L,12L,18L,42L,62L,131L,206L,398L,610L,1203L,1810L,3358L,5260L,9471L,14518L,26182L,39906L,70320L,108849L,187251L,287525L,497288L,758860L,1286936L,1986352L,3330677L,5102712L,8560107L,13070327L,21685731L,33328561L,54744685L,83792111L,137817745L,210223967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198301Inst : IEnumerable<long>
{
public static readonly long[] Value=A198301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198301.Bytes);
public long this[int i]=>Value[i];

public static A198301Inst Instance=new A198301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198302
{
public static readonly long[] Value={ 1L,5L,7L,21L,11L,65L,15L,133L,106L,245L,23L,1077L,27L,1041L,1637L,3365L,35L,9992L,39L,18361L,16401L,22841L,47L,134461L,15686L,106917L,179494L,355173L,59L,1220075L,63L,1593189L,1952705L,2228909L,631005L,13778268L,75L,9962313L,20732901L,34805473L,83L,113693883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198302Inst : IEnumerable<long>
{
public static readonly long[] Value=A198302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198302.Bytes);
public long this[int i]=>Value[i];

public static A198302Inst Instance=new A198302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198303
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,13L,5L,1L,63L,20L,2L,399L,101L,8L,1L,3268L,743L,48L,1L,33496L,7350L,450L,5L,412943L,91763L,5751L,32L,5883727L,1344782L,90553L,385L,94159721L,22160335L,1612905L,7573L,1L,1661723296L,401278984L,31297357L,181224L,3L,31954666517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198303Inst : IEnumerable<long>
{
public static readonly long[] Value=A198303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198303.Bytes);
public long this[int i]=>Value[i];

public static A198303Inst Instance=new A198303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198304
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,54L,148L,442L,1433L,5061L,19394L,80308L,357241L,1697870L,8577240L,45845235L,258198133L,1526631800L,9445795717L,60988643813L,409933740177L,2862338202947L,20723903238290L,155329193200741L,1203428108558453L,9624564394649845L,79357873429159078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198304Inst : IEnumerable<long>
{
public static readonly long[] Value=A198304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198304.Bytes);
public long this[int i]=>Value[i];

public static A198304Inst Instance=new A198304Inst();

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