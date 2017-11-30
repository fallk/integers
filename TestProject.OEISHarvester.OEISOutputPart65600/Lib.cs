using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A092553
{
public static readonly long[] Value={ 1L,3L,5L,3L,3L,5L,2L,8L,3L,2L,3L,6L,6L,1L,2L,6L,9L,1L,8L,9L,3L,9L,9L,9L,4L,9L,4L,9L,7L,2L,4L,8L,4L,4L,0L,3L,4L,0L,7L,6L,3L,1L,5L,4L,5L,9L,0L,9L,5L,7L,5L,8L,8L,1L,4L,6L,8L,1L,5L,8L,8L,7L,2L,6L,5L,4L,0L,7L,3L,3L,7L,4L,1L,0L,1L,4L,8L,7L,6L,8L,9L,9L,3L,7L,0L,9L,8L,1L,2L,2L,4L,9L,0L,6L,5L,7L,0L,4L,8L,7L,5L,5L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092553Inst : IEnumerable<long>
{
public static readonly long[] Value=A092553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092553.Bytes);
public long this[int i]=>Value[i];

public static A092553Inst Instance=new A092553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092554
{
public static readonly long[] Value={ 0L,4L,9L,7L,8L,7L,0L,6L,8L,3L,6L,7L,8L,6L,3L,9L,4L,2L,9L,7L,9L,3L,4L,2L,4L,1L,5L,6L,5L,0L,0L,6L,1L,7L,7L,6L,6L,3L,1L,6L,9L,9L,5L,9L,2L,1L,8L,8L,4L,2L,3L,2L,1L,5L,5L,6L,7L,6L,2L,7L,7L,2L,7L,6L,0L,6L,0L,6L,0L,6L,6L,7L,7L,3L,0L,1L,9L,9L,5L,5L,0L,1L,5L,4L,0L,5L,4L,2L,4L,4L,2L,3L,6L,6L,3L,3L,3L,4L,4L,5L,2L,6L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092554Inst : IEnumerable<long>
{
public static readonly long[] Value=A092554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092554.Bytes);
public long this[int i]=>Value[i];

public static A092554Inst Instance=new A092554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092555
{
public static readonly long[] Value={ 0L,1L,8L,3L,1L,5L,6L,3L,8L,8L,8L,8L,7L,3L,4L,1L,8L,0L,2L,9L,3L,7L,1L,8L,0L,2L,1L,2L,7L,3L,2L,4L,1L,2L,4L,2L,2L,1L,1L,9L,1L,2L,0L,6L,7L,5L,5L,3L,4L,7L,5L,5L,9L,4L,7L,6L,9L,5L,9L,9L,9L,2L,7L,4L,3L,9L,2L,5L,0L,4L,3L,1L,5L,9L,8L,1L,1L,4L,1L,2L,2L,6L,8L,7L,3L,6L,9L,4L,9L,8L,1L,2L,8L,9L,0L,2L,0L,5L,1L,7L,2L,9L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092555Inst : IEnumerable<long>
{
public static readonly long[] Value=A092555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092555.Bytes);
public long this[int i]=>Value[i];

public static A092555Inst Instance=new A092555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092556
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,7L,2L,5L,11L,13L,2L,7L,11L,17L,23L,2L,7L,13L,19L,29L,31L,2L,11L,17L,23L,29L,37L,43L,2L,11L,17L,29L,37L,41L,53L,59L,2L,11L,19L,29L,37L,47L,59L,67L,73L,2L,11L,23L,31L,41L,53L,61L,71L,83L,97L,2L,13L,23L,37L,47L,59L,67L,79L,89L,101L,113L,2L,13L,29L,37L,53L,61L,73L,89L,97L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092556Inst : IEnumerable<long>
{
public static readonly long[] Value=A092556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092556.Bytes);
public long this[int i]=>Value[i];

public static A092556Inst Instance=new A092556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092557
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,7L,3L,7L,11L,13L,5L,7L,13L,19L,23L,5L,11L,17L,23L,29L,31L,7L,13L,19L,23L,31L,41L,47L,7L,13L,23L,31L,37L,47L,53L,61L,7L,17L,23L,31L,43L,53L,61L,71L,79L,7L,19L,29L,37L,47L,59L,67L,79L,89L,97L,11L,19L,31L,43L,53L,61L,73L,83L,97L,109L,113L,11L,23L,31L,47L,59L,71L,83L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092557Inst : IEnumerable<long>
{
public static readonly long[] Value=A092557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092557.Bytes);
public long this[int i]=>Value[i];

public static A092557Inst Instance=new A092557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092558
{
public static readonly long[] Value={ 11L,23L,101L,167L,199L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092558Inst : IEnumerable<long>
{
public static readonly long[] Value=A092558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092558.Bytes);
public long this[int i]=>Value[i];

public static A092558Inst Instance=new A092558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092559
{
public static readonly long[] Value={ 3L,5L,6L,7L,11L,12L,13L,17L,19L,20L,23L,28L,31L,32L,40L,43L,61L,64L,79L,92L,101L,104L,127L,128L,148L,167L,191L,199L,256L,313L,347L,356L,596L,692L,701L,1004L,1228L,1268L,1709L,2617L,3539L,3824L,5807L,10501L,10691L,11279L,12391L,14479L,42737L,83339L,95369L,117239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092559Inst : IEnumerable<long>
{
public static readonly long[] Value=A092559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092559.Bytes);
public long this[int i]=>Value[i];

public static A092559Inst Instance=new A092559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092560
{
public static readonly long[] Value={ 0L,0L,6L,7L,3L,7L,9L,4L,6L,9L,9L,9L,0L,8L,5L,4L,6L,7L,0L,9L,6L,6L,3L,6L,0L,4L,8L,4L,2L,3L,1L,4L,8L,4L,2L,4L,2L,4L,8L,8L,4L,9L,5L,8L,5L,0L,2L,7L,3L,5L,5L,0L,8L,5L,4L,3L,0L,3L,0L,5L,5L,3L,1L,5L,7L,2L,6L,8L,3L,5L,2L,2L,5L,1L,5L,6L,0L,4L,0L,6L,2L,2L,8L,1L,4L,4L,9L,1L,3L,8L,8L,4L,4L,2L,0L,8L,3L,6L,1L,5L,4L,8L,0L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092560Inst : IEnumerable<long>
{
public static readonly long[] Value=A092560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092560.Bytes);
public long this[int i]=>Value[i];

public static A092560Inst Instance=new A092560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092561
{
public static readonly BigInteger[] Value={ 15L,511L,2047L,8388607L,137438953471L,2199023255551L,562949953421311L,576460752303423487L,BigInteger.Parse("147573952589676412927"),BigInteger.Parse("9671406556917033397649407"),BigInteger.Parse("158456325028528675187087900671"),BigInteger.Parse("2535301200456458802993406410751") };
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
public class A092561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092561.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092561Inst Instance=new A092561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092562
{
public static readonly BigInteger[] Value={ 9L,33L,65L,129L,2049L,4097L,8193L,131073L,524289L,1048577L,8388609L,268435457L,2147483649L,4294967297L,1099511627777L,8796093022209L,2305843009213693953L,BigInteger.Parse("18446744073709551617"),BigInteger.Parse("604462909807314587353089"),BigInteger.Parse("4951760157141521099596496897") };
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
public class A092562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092562Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092562.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092562.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092562Inst Instance=new A092562Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092563
{
public static readonly BigInteger[] Value={ 1L,2L,18L,300L,7350L,238140L,9604980L,463783320L,26087811750L,1675417243500L,120965124980700L,9699203657543400L,855146455806743100L,BigInteger.Parse("82225620750648375000"),BigInteger.Parse("8563211075317523625000"),BigInteger.Parse("960221401912271649150000") };
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
public class A092563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092563.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092563Inst Instance=new A092563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092596
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092596Inst : IEnumerable<long>
{
public static readonly long[] Value=A092596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092596.Bytes);
public long this[int i]=>Value[i];

public static A092596Inst Instance=new A092596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092597
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,14L,15L,16L,17L,18L,19L,28L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092597Inst : IEnumerable<long>
{
public static readonly long[] Value=A092597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092597.Bytes);
public long this[int i]=>Value[i];

public static A092597Inst Instance=new A092597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092598
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,13L,14L,15L,16L,17L,18L,19L,25L,26L,27L,28L,29L,37L,38L,39L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092598Inst : IEnumerable<long>
{
public static readonly long[] Value=A092598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092598.Bytes);
public long this[int i]=>Value[i];

public static A092598Inst Instance=new A092598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092599
{
public static readonly long[] Value={ 0L,10L,17L,25L,40L,58L,70L,81L,88L,90L,109L,122L,131L,141L,150L,160L,173L,187L,194L,213L,227L,239L,254L,268L,282L,297L,314L,325L,346L,364L,381L,400L,419L,435L,459L,477L,492L,520L,542L,564L,589L,609L,630L,652L,673L,686L,712L,729L,746L,760L,780L,795L,809L,822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092599Inst : IEnumerable<long>
{
public static readonly long[] Value=A092599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092599.Bytes);
public long this[int i]=>Value[i];

public static A092599Inst Instance=new A092599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092600
{
public static readonly long[] Value={ 0L,19L,29L,49L,79L,99L,99L,99L,99L,99L,199L,199L,199L,199L,299L,299L,299L,299L,299L,399L,399L,399L,499L,499L,499L,499L,599L,599L,599L,699L,699L,799L,799L,799L,899L,899L,899L,999L,999L,999L,999L,999L,999L,999L,999L,999L,999L,999L,999L,999L,999L,999L,999L,999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092600Inst : IEnumerable<long>
{
public static readonly long[] Value=A092600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092600.Bytes);
public long this[int i]=>Value[i];

public static A092600Inst Instance=new A092600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092601
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,6L,7L,8L,8L,9L,9L,9L,12L,14L,14L,15L,16L,17L,18L,19L,20L,21L,23L,23L,24L,26L,26L,28L,28L,30L,27L,28L,33L,34L,35L,35L,34L,37L,39L,38L,40L,42L,43L,43L,44L,45L,43L,46L,48L,48L,51L,51L,53L,53L,53L,55L,56L,58L,55L,59L,61L,62L,63L,64L,64L,66L,65L,68L,68L,70L,70L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092601Inst : IEnumerable<long>
{
public static readonly long[] Value=A092601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092601.Bytes);
public long this[int i]=>Value[i];

public static A092601Inst Instance=new A092601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092602
{
public static readonly long[] Value={ 3L,5L,11L,19L,31L,79L,101L,113L,127L,163L,173L,223L,271L,383L,419L,431L,503L,571L,599L,619L,641L,659L,673L,683L,701L,733L,757L,827L,863L,971L,1013L,1033L,1087L,1193L,1249L,1423L,1433L,1453L,1483L,1579L,1621L,1667L,1723L,2003L,2113L,2179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092602Inst : IEnumerable<long>
{
public static readonly long[] Value=A092602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092602.Bytes);
public long this[int i]=>Value[i];

public static A092602Inst Instance=new A092602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092603
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,31L,62L,126L,283L,539L,1177L,2459L,4969L,10781L,22297L,45116L,95759L,201615L,400755L,830859L,1741455L,3505627L,7099561L,14607199L,30112789L,60176505L,121626832L,247652036L,504389269L,1010060135L,2030792857L,4102303316L,8289676399L,16659582365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092603Inst : IEnumerable<long>
{
public static readonly long[] Value=A092603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092603.Bytes);
public long this[int i]=>Value[i];

public static A092603Inst Instance=new A092603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092604
{
public static readonly long[] Value={ 5L,10L,13L,16L,18L,22L,25L,27L,29L,32L,35L,38L,41L,42L,46L,48L,50L,52L,55L,57L,59L,62L,63L,66L,68L,70L,73L,76L,78L,80L,83L,85L,87L,89L,91L,94L,95L,98L,100L,103L,105L,106L,109L,111L,113L,114L,117L,120L,122L,124L,126L,128L,129L,132L,135L,138L,139L,141L,143L,145L,147L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092604Inst : IEnumerable<long>
{
public static readonly long[] Value=A092604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092604.Bytes);
public long this[int i]=>Value[i];

public static A092604Inst Instance=new A092604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092605
{
public static readonly long[] Value={ 6L,0L,6L,5L,3L,0L,6L,5L,9L,7L,1L,2L,6L,3L,3L,4L,2L,3L,6L,0L,3L,7L,9L,9L,5L,3L,4L,9L,9L,1L,1L,8L,0L,4L,5L,3L,4L,4L,1L,9L,1L,8L,1L,3L,5L,4L,8L,7L,1L,8L,6L,9L,5L,5L,6L,8L,2L,8L,9L,2L,1L,5L,8L,7L,3L,5L,0L,5L,6L,5L,1L,9L,4L,1L,3L,7L,4L,8L,4L,2L,3L,9L,9L,8L,6L,4L,7L,6L,1L,1L,5L,0L,7L,9L,8L,9L,4L,5L,6L,0L,2L,6L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092605Inst : IEnumerable<long>
{
public static readonly long[] Value=A092605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092605.Bytes);
public long this[int i]=>Value[i];

public static A092605Inst Instance=new A092605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092606
{
public static readonly long[] Value={ 0L,2L,1L,0L,0L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,0L,0L,2L,1L,0L,0L,0L,2L,1L,0L,0L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,0L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,0L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,0L,0L,2L,1L,0L,0L,0L,2L,1L,0L,0L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,0L,0L,2L,1L,0L,0L,0L,2L,1L,0L,0L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,0L,0L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092606Inst : IEnumerable<long>
{
public static readonly long[] Value=A092606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092606.Bytes);
public long this[int i]=>Value[i];

public static A092606Inst Instance=new A092606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092607
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,2L,3L,3L,2L,5L,2L,6L,3L,3L,3L,3L,6L,5L,3L,5L,5L,5L,6L,4L,6L,6L,6L,4L,5L,6L,3L,3L,7L,6L,5L,5L,12L,8L,10L,8L,5L,5L,7L,6L,5L,8L,9L,8L,6L,4L,6L,7L,7L,7L,6L,8L,5L,8L,8L,7L,5L,9L,8L,8L,7L,7L,11L,7L,7L,8L,14L,10L,9L,7L,7L,7L,6L,7L,8L,10L,8L,10L,9L,7L,7L,5L,7L,7L,7L,9L,8L,7L,8L,10L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092607Inst : IEnumerable<long>
{
public static readonly long[] Value=A092607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092607.Bytes);
public long this[int i]=>Value[i];

public static A092607Inst Instance=new A092607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092608
{
public static readonly long[] Value={ 0L,0L,0L,0L,30L,1945L,41901L,410505L,2363160L,9266220L,27058460L,62261590L,117178540L,185037520L,249548910L,290969170L,295695540L,263173865L,205581235L,140943485L,84636895L,44347105L,20159615L,7888705L,2629575L,736281L,169911L,31465L,4495L,465L,31L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092608Inst : IEnumerable<long>
{
public static readonly long[] Value=A092608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092608.Bytes);
public long this[int i]=>Value[i];

public static A092608Inst Instance=new A092608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092609
{
public static readonly BigInteger[] Value={ 11L,341L,13981L,852841L,60551711L,6115722811L,801159688241L,120975112924391L,21896495439314771L,4182230628909121261L,BigInteger.Parse("882450662699824586071"),BigInteger.Parse("212670609710657725243111"),BigInteger.Parse("53380323037375089036020861") };
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
public class A092609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092609Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092609.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092609.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092609Inst Instance=new A092609Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092610
{
public static readonly BigInteger[] Value={ 3L,39L,897L,38571L,2044263L,149231199L,12386189517L,1275777520251L,144162859788363L,23498546145503169L,4065248483172048237L,BigInteger.Parse("784592957252205309741"),BigInteger.Parse("174964229467241784072243"),BigInteger.Parse("40766665465867335688832619"),BigInteger.Parse("10721633017523109286162978797") };
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
public class A092610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092610Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092610.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092610.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092610Inst Instance=new A092610Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092611
{
public static readonly BigInteger[] Value={ 19L,551L,32509L,2568211L,228570779L,24914214911L,3463075872629L,515998305021721L,92363696598888059L,18380375623178723741UL,BigInteger.Parse("4209106017707927736689"),BigInteger.Parse("1005976338232194729068671") };
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
public class A092611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092611Inst Instance=new A092611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092612
{
public static readonly BigInteger[] Value={ 7L,119L,4403L,206941L,13865047L,1344909559L,143905322813L,18275975997251L,2503808711623387L,393097967724871759L,BigInteger.Parse("65647360610053583753"),BigInteger.Parse("12932530040180555999341"),BigInteger.Parse("2935684319120986211850407") };
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
public class A092612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092612Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092612.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092612.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092612Inst Instance=new A092612Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092613
{
public static readonly long[] Value={ 40L,90L,160L,230L,280L,380L,460L,530L,610L,710L,780L,870L,970L,1110L,1180L,1280L,1330L,1460L,1540L,1610L,1690L,1860L,1930L,2000L,2190L,2280L,2390L,2480L,2590L,2670L,2740L,2870L,2980L,3130L,3190L,3310L,3480L,3580L,3720L,3780L,3920L,4000L,4080L,4170L,4260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092613Inst : IEnumerable<long>
{
public static readonly long[] Value=A092613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092613.Bytes);
public long this[int i]=>Value[i];

public static A092613Inst Instance=new A092613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092614
{
public static readonly long[] Value={ 4L,9L,16L,23L,28L,38L,46L,53L,61L,71L,78L,87L,97L,111L,118L,128L,133L,146L,154L,161L,169L,186L,193L,200L,219L,228L,239L,248L,259L,267L,274L,287L,298L,313L,319L,331L,348L,358L,372L,378L,392L,400L,408L,417L,426L,447L,461L,466L,475L,487L,502L,515L,523L,537L,543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092614Inst : IEnumerable<long>
{
public static readonly long[] Value=A092614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092614.Bytes);
public long this[int i]=>Value[i];

public static A092614Inst Instance=new A092614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092615
{
public static readonly long[] Value={ 7L,1L,6L,5L,3L,1L,3L,1L,0L,5L,7L,3L,7L,8L,9L,2L,5L,0L,4L,2L,5L,6L,0L,4L,0L,9L,6L,9L,2L,5L,3L,7L,9L,6L,6L,7L,4L,5L,3L,1L,1L,2L,0L,5L,9L,8L,2L,1L,4L,7L,9L,1L,5L,7L,1L,4L,0L,8L,7L,0L,2L,0L,7L,1L,2L,7L,3L,0L,4L,0L,7L,7L,2L,3L,4L,9L,0L,2L,3L,7L,9L,1L,0L,8L,7L,9L,1L,0L,8L,8L,9L,1L,5L,1L,7L,4L,9L,4L,6L,1L,5L,9L,0L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092615Inst : IEnumerable<long>
{
public static readonly long[] Value=A092615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092615.Bytes);
public long this[int i]=>Value[i];

public static A092615Inst Instance=new A092615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092616
{
public static readonly long[] Value={ 7L,7L,8L,8L,0L,0L,7L,8L,3L,0L,7L,1L,4L,0L,4L,8L,6L,8L,2L,4L,5L,1L,7L,0L,2L,6L,6L,9L,7L,8L,3L,2L,0L,6L,4L,7L,2L,9L,6L,7L,7L,2L,2L,9L,0L,4L,2L,6L,1L,4L,1L,4L,7L,4L,2L,4L,1L,3L,1L,7L,3L,6L,6L,2L,6L,8L,2L,4L,5L,6L,1L,2L,0L,5L,3L,5L,1L,9L,2L,4L,4L,6L,3L,1L,9L,9L,9L,0L,1L,5L,2L,4L,7L,3L,1L,3L,8L,2L,0L,6L,0L,4L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092616Inst : IEnumerable<long>
{
public static readonly long[] Value=A092616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092616.Bytes);
public long this[int i]=>Value[i];

public static A092616Inst Instance=new A092616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092617
{
public static readonly long[] Value={ 0L,0L,0L,0L,30L,2065L,51926L,691686L,6185741L,42149926L,235537736L,1130582442L,4808698802L,18525169347L,65689136552L,217026359262L,674420929513L,1986166442853L,5577112808148L,15006708704808L,38855732384838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092617Inst : IEnumerable<long>
{
public static readonly long[] Value=A092617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092617.Bytes);
public long this[int i]=>Value[i];

public static A092617Inst Instance=new A092617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092618
{
public static readonly long[] Value={ 8L,1L,8L,7L,3L,0L,7L,5L,3L,0L,7L,7L,9L,8L,1L,8L,5L,8L,6L,6L,9L,9L,3L,5L,5L,0L,8L,6L,1L,9L,0L,3L,9L,4L,2L,4L,3L,5L,8L,5L,9L,1L,2L,5L,6L,2L,6L,9L,0L,1L,5L,6L,7L,2L,4L,7L,8L,0L,2L,8L,7L,6L,1L,6L,1L,6L,5L,0L,8L,7L,7L,7L,4L,0L,2L,4L,9L,1L,0L,9L,8L,6L,2L,3L,4L,5L,7L,2L,0L,4L,0L,8L,4L,3L,2L,1L,4L,2L,1L,7L,9L,0L,7L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092618Inst : IEnumerable<long>
{
public static readonly long[] Value=A092618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092618.Bytes);
public long this[int i]=>Value[i];

public static A092618Inst Instance=new A092618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092619
{
public static readonly long[] Value={ 22L,23L,25L,27L,32L,33L,35L,37L,52L,53L,55L,57L,72L,73L,75L,77L,122L,123L,125L,127L,132L,133L,135L,137L,152L,153L,155L,157L,172L,173L,175L,177L,202L,203L,205L,207L,212L,213L,215L,217L,220L,221L,222L,223L,224L,225L,226L,227L,228L,229L,230L,231L,232L,233L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092619Inst : IEnumerable<long>
{
public static readonly long[] Value=A092619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092619.Bytes);
public long this[int i]=>Value[i];

public static A092619Inst Instance=new A092619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092620
{
public static readonly long[] Value={ 2L,3L,5L,7L,12L,13L,15L,17L,20L,21L,24L,26L,28L,29L,30L,31L,34L,36L,38L,39L,42L,43L,45L,47L,50L,51L,54L,56L,58L,59L,62L,63L,65L,67L,70L,71L,74L,76L,78L,79L,82L,83L,85L,87L,92L,93L,95L,97L,102L,103L,105L,107L,112L,113L,115L,117L,120L,121L,124L,126L,128L,129L,130L,131L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092620Inst : IEnumerable<long>
{
public static readonly long[] Value=A092620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092620.Bytes);
public long this[int i]=>Value[i];

public static A092620Inst Instance=new A092620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092621
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,29L,31L,43L,47L,59L,67L,71L,79L,83L,97L,103L,107L,113L,131L,139L,151L,163L,167L,179L,193L,197L,211L,241L,269L,281L,311L,349L,389L,421L,431L,439L,443L,463L,467L,479L,487L,509L,541L,569L,599L,607L,613L,617L,631L,643L,647L,659L,683L,701L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092621Inst : IEnumerable<long>
{
public static readonly long[] Value=A092621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092621.Bytes);
public long this[int i]=>Value[i];

public static A092621Inst Instance=new A092621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092622
{
public static readonly long[] Value={ 23L,37L,53L,73L,127L,137L,157L,173L,229L,239L,251L,263L,271L,283L,293L,307L,313L,317L,331L,347L,359L,367L,379L,383L,397L,433L,457L,503L,521L,547L,563L,571L,587L,593L,653L,673L,677L,739L,743L,751L,787L,797L,823L,827L,853L,857L,877L,937L,953L,977L,1033L,1123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092622Inst : IEnumerable<long>
{
public static readonly long[] Value=A092622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092622.Bytes);
public long this[int i]=>Value[i];

public static A092622Inst Instance=new A092622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092623
{
public static readonly long[] Value={ 223L,227L,233L,257L,277L,337L,353L,373L,523L,557L,577L,727L,733L,757L,773L,1223L,1237L,1277L,1327L,1373L,1523L,1553L,1723L,1733L,1753L,1777L,2027L,2053L,2137L,2153L,2203L,2207L,2213L,2221L,2239L,2243L,2251L,2267L,2287L,2293L,2297L,2339L,2347L,2351L,2371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092623Inst : IEnumerable<long>
{
public static readonly long[] Value=A092623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092623.Bytes);
public long this[int i]=>Value[i];

public static A092623Inst Instance=new A092623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092624
{
public static readonly long[] Value={ 22L,23L,25L,27L,32L,33L,35L,37L,52L,53L,55L,57L,72L,73L,75L,77L,122L,123L,125L,127L,132L,133L,135L,137L,152L,153L,155L,157L,172L,173L,175L,177L,202L,203L,205L,207L,212L,213L,215L,217L,220L,221L,224L,226L,228L,229L,230L,231L,234L,236L,238L,239L,242L,243L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092624Inst : IEnumerable<long>
{
public static readonly long[] Value=A092624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092624.Bytes);
public long this[int i]=>Value[i];

public static A092624Inst Instance=new A092624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092625
{
public static readonly long[] Value={ 222L,223L,225L,227L,232L,233L,235L,237L,252L,253L,255L,257L,272L,273L,275L,277L,322L,323L,325L,327L,332L,333L,335L,337L,352L,353L,355L,357L,372L,373L,375L,377L,522L,523L,525L,527L,532L,533L,535L,537L,552L,553L,555L,557L,572L,573L,575L,577L,722L,723L,725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092625Inst : IEnumerable<long>
{
public static readonly long[] Value=A092625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092625.Bytes);
public long this[int i]=>Value[i];

public static A092625Inst Instance=new A092625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092626
{
public static readonly long[] Value={ 13L,17L,29L,31L,43L,47L,59L,67L,71L,79L,83L,97L,127L,137L,157L,173L,229L,239L,251L,263L,271L,283L,293L,307L,313L,317L,331L,347L,359L,367L,379L,383L,397L,433L,457L,503L,521L,547L,563L,571L,587L,593L,653L,673L,677L,739L,743L,751L,787L,797L,823L,827L,853L,857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092626Inst : IEnumerable<long>
{
public static readonly long[] Value=A092626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092626.Bytes);
public long this[int i]=>Value[i];

public static A092626Inst Instance=new A092626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092627
{
public static readonly long[] Value={ 11L,19L,41L,61L,89L,103L,107L,113L,131L,139L,151L,163L,167L,179L,193L,197L,211L,241L,269L,281L,311L,349L,389L,421L,431L,439L,443L,463L,467L,479L,487L,509L,541L,569L,599L,607L,613L,617L,631L,643L,647L,659L,683L,701L,709L,719L,761L,769L,821L,829L,839L,859L,863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092627Inst : IEnumerable<long>
{
public static readonly long[] Value=A092627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092627.Bytes);
public long this[int i]=>Value[i];

public static A092627Inst Instance=new A092627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092692
{
public static readonly long[] Value={ 0L,1L,1L,8L,18L,184L,660L,8448L,42000L,648576L,4142880L,74972160L,586776960L,12174658560L,113020427520L,2643856588800L,28432576972800L,740051782041600L,9056055981772800L,259500083163955200L,3562946373482496000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092692Inst : IEnumerable<long>
{
public static readonly long[] Value=A092692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092692.Bytes);
public long this[int i]=>Value[i];

public static A092692Inst Instance=new A092692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092693
{
public static readonly long[] Value={ 0L,1L,3L,3L,7L,3L,9L,7L,9L,7L,17L,7L,19L,9L,15L,15L,31L,9L,27L,15L,19L,17L,39L,15L,35L,19L,27L,19L,47L,15L,45L,31L,35L,31L,39L,19L,55L,27L,39L,31L,71L,19L,61L,35L,39L,39L,85L,31L,61L,35L,63L,39L,91L,27L,71L,39L,55L,47L,105L,31L,91L,45L,55L,63L,79L,35L,101L,63L,79L,39L,109L,39L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092693Inst : IEnumerable<long>
{
public static readonly long[] Value=A092693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092693.Bytes);
public long this[int i]=>Value[i];

public static A092693Inst Instance=new A092693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092694
{
public static readonly long[] Value={ 1L,1L,2L,2L,8L,2L,12L,8L,12L,8L,80L,8L,96L,12L,64L,64L,1024L,12L,216L,64L,96L,80L,1760L,64L,1280L,96L,216L,96L,2688L,64L,1920L,1024L,1280L,1024L,1536L,96L,3456L,216L,1536L,1024L,40960L,96L,4032L,1280L,1536L,1760L,80960L,1024L,4032L,1280L,32768L,1536L,79872L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092694Inst : IEnumerable<long>
{
public static readonly long[] Value=A092694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092694.Bytes);
public long this[int i]=>Value[i];

public static A092694Inst Instance=new A092694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092695
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,3L,3L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092695Inst : IEnumerable<long>
{
public static readonly long[] Value=A092695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092695.Bytes);
public long this[int i]=>Value[i];

public static A092695Inst Instance=new A092695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092696
{
public static readonly BigInteger[] Value={ 1212121L,12121212121L,BigInteger.Parse("1212121212121212121212121212121212121212121") };
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
public class A092696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092696.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092696Inst Instance=new A092696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092697
{
public static readonly BigInteger[] Value={ 1L,105263157894736842L,BigInteger.Parse("1034482758620689655172413793"),102564L,142857L,BigInteger.Parse("1016949152542372881355932203389830508474576271186440677966"),BigInteger.Parse("1014492753623188405797"),1012658227848L,BigInteger.Parse("10112359550561797752808988764044943820224719") };
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
public class A092697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092697Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092697.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092697.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092697Inst Instance=new A092697Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092698
{
public static readonly long[] Value={ 0L,2L,40L,310L,1520L,5628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092698Inst : IEnumerable<long>
{
public static readonly long[] Value=A092698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092698.Bytes);
public long this[int i]=>Value[i];

public static A092698Inst Instance=new A092698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092699
{
public static readonly long[] Value={ 0L,2L,100L,1520L,12908L,76488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092699Inst : IEnumerable<long>
{
public static readonly long[] Value=A092699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092699.Bytes);
public long this[int i]=>Value[i];

public static A092699Inst Instance=new A092699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092700
{
public static readonly long[] Value={ 0L,2L,210L,5628L,91070L,680940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092700Inst : IEnumerable<long>
{
public static readonly long[] Value=A092700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092700.Bytes);
public long this[int i]=>Value[i];

public static A092700Inst Instance=new A092700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092701
{
public static readonly long[] Value={ 0L,2L,392L,17184L,353316L,4515558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092701Inst : IEnumerable<long>
{
public static readonly long[] Value=A092701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092701.Bytes);
public long this[int i]=>Value[i];

public static A092701Inst Instance=new A092701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092702
{
public static readonly long[] Value={ 1L,1L,1L,8L,1L,12L,4L,33L,3L,19L,22L,71L,58L,10L,230L,1487L,2887L,555L,1260L,1711L,377L,343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092702Inst : IEnumerable<long>
{
public static readonly long[] Value=A092702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092702.Bytes);
public long this[int i]=>Value[i];

public static A092702Inst Instance=new A092702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092703
{
public static readonly long[] Value={ 0L,0L,-8L,-140L,-118L,-6580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092703Inst : IEnumerable<long>
{
public static readonly long[] Value=A092703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092703.Bytes);
public long this[int i]=>Value[i];

public static A092703Inst Instance=new A092703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092704
{
public static readonly long[] Value={ 0L,0L,-12L,-448L,-6580L,-58240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092704Inst : IEnumerable<long>
{
public static readonly long[] Value=A092704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092704.Bytes);
public long this[int i]=>Value[i];

public static A092704Inst Instance=new A092704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092705
{
public static readonly long[] Value={ 0L,0L,-28L,-1176L,-27840L,-370428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092705Inst : IEnumerable<long>
{
public static readonly long[] Value=A092705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092705.Bytes);
public long this[int i]=>Value[i];

public static A092705Inst Instance=new A092705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092706
{
public static readonly long[] Value={ 0L,0L,-24L,-2688L,-97020L,-1859648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092706Inst : IEnumerable<long>
{
public static readonly long[] Value=A092706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092706.Bytes);
public long this[int i]=>Value[i];

public static A092706Inst Instance=new A092706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092707
{
public static readonly long[] Value={ 0L,0L,0L,10L,100L,540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092707Inst : IEnumerable<long>
{
public static readonly long[] Value=A092707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092707.Bytes);
public long this[int i]=>Value[i];

public static A092707Inst Instance=new A092707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092740
{
public static readonly long[] Value={ 3L,5L,11L,17L,19L,29L,43L,53L,79L,101L,113L,127L,137L,179L,251L,281L,349L,409L,419L,431L,449L,521L,569L,571L,577L,599L,643L,661L,677L,739L,797L,823L,853L,857L,883L,907L,941L,991L,1009L,1049L,1087L,1091L,1129L,1163L,1181L,1259L,1289L,1381L,1451L,1459L,1489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092740Inst : IEnumerable<long>
{
public static readonly long[] Value=A092740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092740.Bytes);
public long this[int i]=>Value[i];

public static A092740Inst Instance=new A092740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092741
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,4L,0L,8L,9L,7L,0L,40L,45L,24L,11L,0L,240L,270L,144L,50L,16L,0L,1680L,1890L,1008L,350L,90L,22L,0L,13440L,15120L,8064L,2800L,720L,147L,29L,0L,120960L,136080L,72576L,25200L,6480L,1323L,224L,37L,0L,1209600L,1360800L,725760L,252000L,64800L,13230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092741Inst : IEnumerable<long>
{
public static readonly long[] Value=A092741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092741.Bytes);
public long this[int i]=>Value[i];

public static A092741Inst Instance=new A092741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092742
{
public static readonly long[] Value={ 1L,0L,1L,3L,2L,1L,1L,8L,3L,6L,4L,2L,3L,3L,7L,7L,7L,1L,4L,4L,3L,8L,7L,9L,4L,6L,3L,2L,0L,9L,7L,2L,7L,6L,3L,8L,9L,0L,4L,3L,5L,8L,7L,7L,4L,6L,7L,2L,2L,4L,6L,5L,4L,8L,8L,4L,5L,6L,0L,9L,0L,3L,1L,8L,9L,4L,1L,7L,3L,1L,2L,0L,9L,6L,2L,2L,3L,5L,4L,4L,1L,1L,9L,1L,2L,0L,9L,2L,7L,3L,9L,2L,5L,6L,2L,1L,8L,3L,7L,6L,1L,3L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092742Inst : IEnumerable<long>
{
public static readonly long[] Value=A092742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092742.Bytes);
public long this[int i]=>Value[i];

public static A092742Inst Instance=new A092742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092743
{
public static readonly long[] Value={ 0L,3L,2L,2L,5L,1L,5L,3L,4L,4L,3L,3L,1L,9L,9L,4L,8L,9L,1L,8L,4L,4L,2L,2L,0L,5L,2L,6L,8L,8L,5L,6L,3L,6L,8L,8L,5L,9L,3L,0L,6L,3L,3L,3L,6L,1L,4L,7L,4L,7L,8L,0L,7L,6L,7L,3L,4L,5L,8L,1L,7L,2L,2L,2L,1L,5L,5L,8L,4L,0L,6L,1L,7L,9L,4L,4L,9L,5L,4L,8L,9L,5L,3L,8L,2L,2L,5L,4L,1L,4L,8L,0L,9L,5L,6L,5L,5L,2L,0L,0L,3L,7L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092743Inst : IEnumerable<long>
{
public static readonly long[] Value=A092743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092743.Bytes);
public long this[int i]=>Value[i];

public static A092743Inst Instance=new A092743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092744
{
public static readonly long[] Value={ 0L,1L,0L,2L,6L,5L,9L,8L,2L,2L,5L,4L,6L,8L,4L,3L,3L,5L,1L,8L,9L,1L,5L,2L,7L,8L,3L,2L,6L,7L,1L,1L,8L,6L,9L,4L,1L,4L,1L,8L,2L,7L,8L,0L,1L,8L,5L,3L,6L,3L,8L,2L,6L,2L,7L,1L,8L,1L,6L,8L,0L,3L,5L,4L,7L,1L,9L,7L,3L,6L,6L,2L,6L,7L,5L,5L,5L,1L,9L,2L,0L,2L,4L,9L,0L,7L,2L,3L,8L,1L,9L,2L,9L,5L,2L,9L,0L,4L,9L,0L,5L,6L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092744Inst : IEnumerable<long>
{
public static readonly long[] Value=A092744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092744.Bytes);
public long this[int i]=>Value[i];

public static A092744Inst Instance=new A092744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092745
{
public static readonly long[] Value={ 0L,0L,3L,2L,6L,7L,7L,6L,3L,6L,4L,3L,0L,5L,3L,3L,8L,5L,4L,7L,2L,6L,2L,8L,2L,4L,9L,6L,2L,2L,6L,5L,2L,5L,0L,9L,5L,4L,5L,0L,8L,2L,4L,6L,4L,2L,5L,8L,3L,1L,6L,3L,6L,8L,0L,9L,7L,5L,2L,3L,4L,5L,2L,8L,5L,8L,1L,8L,3L,6L,4L,5L,4L,3L,2L,8L,8L,3L,0L,6L,1L,5L,5L,8L,7L,6L,3L,1L,7L,3L,5L,4L,6L,3L,3L,4L,2L,5L,5L,3L,7L,6L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092745Inst : IEnumerable<long>
{
public static readonly long[] Value=A092745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092745.Bytes);
public long this[int i]=>Value[i];

public static A092745Inst Instance=new A092745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092746
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,0L,1L,6L,1L,4L,7L,3L,2L,9L,5L,8L,5L,2L,2L,9L,6L,0L,8L,9L,8L,3L,7L,6L,3L,4L,9L,1L,4L,2L,0L,5L,4L,3L,1L,6L,9L,4L,4L,1L,4L,3L,0L,2L,6L,3L,1L,3L,2L,9L,9L,7L,9L,7L,2L,8L,8L,2L,5L,8L,2L,5L,3L,2L,8L,5L,7L,4L,1L,1L,7L,8L,2L,5L,0L,6L,6L,0L,5L,7L,9L,9L,8L,9L,3L,0L,7L,4L,5L,7L,9L,7L,1L,3L,8L,0L,1L,2L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092746Inst : IEnumerable<long>
{
public static readonly long[] Value=A092746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092746.Bytes);
public long this[int i]=>Value[i];

public static A092746Inst Instance=new A092746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092747
{
public static readonly long[] Value={ 0L,0L,0L,3L,3L,1L,0L,9L,3L,6L,8L,0L,1L,7L,7L,5L,6L,6L,7L,6L,4L,3L,2L,5L,9L,5L,2L,8L,0L,1L,2L,5L,3L,0L,6L,8L,0L,1L,6L,5L,5L,0L,0L,7L,2L,2L,0L,8L,3L,1L,3L,3L,8L,7L,2L,5L,8L,7L,4L,6L,8L,0L,7L,7L,5L,8L,6L,3L,2L,4L,1L,1L,0L,5L,7L,3L,9L,5L,8L,2L,4L,8L,7L,9L,0L,4L,7L,2L,5L,9L,1L,4L,5L,0L,4L,5L,6L,0L,6L,8L,0L,4L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092747Inst : IEnumerable<long>
{
public static readonly long[] Value=A092747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092747.Bytes);
public long this[int i]=>Value[i];

public static A092747Inst Instance=new A092747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092748
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,5L,3L,9L,0L,3L,9L,1L,6L,5L,3L,4L,9L,3L,6L,6L,6L,3L,3L,1L,7L,2L,8L,7L,2L,7L,2L,8L,1L,0L,1L,0L,0L,8L,7L,1L,9L,6L,2L,9L,8L,7L,0L,6L,7L,1L,5L,2L,3L,0L,7L,2L,6L,2L,2L,0L,6L,7L,2L,4L,0L,6L,9L,3L,6L,9L,4L,5L,8L,8L,0L,9L,1L,2L,2L,6L,8L,8L,3L,1L,1L,3L,9L,1L,7L,0L,3L,5L,3L,8L,4L,8L,1L,0L,3L,2L,0L,9L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092748Inst : IEnumerable<long>
{
public static readonly long[] Value=A092748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092748.Bytes);
public long this[int i]=>Value[i];

public static A092748Inst Instance=new A092748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092749
{
public static readonly long[] Value={ 2L,3L,5L,5L,11L,11L,11L,11L,11L,11L,17L,17L,17L,17L,17L,17L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092749Inst : IEnumerable<long>
{
public static readonly long[] Value=A092749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092749.Bytes);
public long this[int i]=>Value[i];

public static A092749Inst Instance=new A092749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092750
{
public static readonly long[] Value={ 8L,6L,6L,8L,7L,7L,8L,9L,9L,7L,5L,0L,1L,8L,1L,6L,2L,7L,5L,0L,2L,9L,3L,2L,4L,7L,6L,5L,8L,1L,6L,0L,2L,5L,6L,3L,1L,9L,6L,5L,3L,1L,9L,4L,7L,9L,5L,4L,8L,1L,3L,3L,3L,9L,5L,5L,8L,8L,4L,5L,0L,5L,7L,3L,4L,1L,3L,8L,9L,1L,0L,3L,7L,3L,7L,7L,7L,2L,6L,7L,5L,7L,0L,3L,0L,1L,3L,1L,5L,5L,8L,7L,7L,0L,2L,6L,9L,8L,8L,1L,7L,2L,8L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092750Inst : IEnumerable<long>
{
public static readonly long[] Value=A092750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092750.Bytes);
public long this[int i]=>Value[i];

public static A092750Inst Instance=new A092750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092751
{
public static readonly BigInteger[] Value={ 5L,19L,251L,48619L,155117519L,30067266499541039L,BigInteger.Parse("6637553085023755473070799"),BigInteger.Parse("399608854866744452032002440111"),BigInteger.Parse("5717214010165655645594487649236004008072121335004636113518216597999") };
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
public class A092751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092751Inst Instance=new A092751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092752
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,30L,1000L,2000L,4000L,5000L,8000L,30000L,1000000L,1000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092752Inst : IEnumerable<long>
{
public static readonly long[] Value=A092752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092752.Bytes);
public long this[int i]=>Value[i];

public static A092752Inst Instance=new A092752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092753
{
public static readonly long[] Value={ 1L,4L,8L,12L,17L,24L,33L,43L,56L,71L,89L,111L,136L,166L,201L,242L,290L,345L,408L,481L,565L,660L,768L,892L,1031L,1190L,1368L,1569L,1796L,2049L,2334L,2652L,3008L,3405L,3847L,4339L,4885L,5491L,6162L,6905L,7726L,8634L,9634L,10737L,11951L,13287L,14754L,16364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092753Inst : IEnumerable<long>
{
public static readonly long[] Value=A092753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092753.Bytes);
public long this[int i]=>Value[i];

public static A092753Inst Instance=new A092753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092754
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,9L,10L,15L,16L,17L,18L,19L,20L,21L,22L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,127L,128L,129L,130L,131L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092754Inst : IEnumerable<long>
{
public static readonly long[] Value=A092754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092754.Bytes);
public long this[int i]=>Value[i];

public static A092754Inst Instance=new A092754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092755
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,34L,37L,40L,43L,46L,49L,52L,55L,58L,61L,64L,67L,70L,73L,76L,79L,82L,85L,88L,91L,94L,97L,100L,103L,106L,109L,112L,115L,118L,121L,124L,127L,130L,133L,137L,141L,145L,149L,153L,157L,161L,165L,169L,173L,177L,181L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092755Inst : IEnumerable<long>
{
public static readonly long[] Value=A092755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092755.Bytes);
public long this[int i]=>Value[i];

public static A092755Inst Instance=new A092755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092916
{
public static readonly long[] Value={ 10L,0L,105L,2240L,1512L,0L,660L,0L,617760L,16016L,225225L,0L,495040L,0L,69768L,18604800L,639967910400L,0L,8855L,284680230912L,1245476010240000L,41993952000L,159845400L,0L,475020L,0L,9939793500L,156068011008000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092916Inst : IEnumerable<long>
{
public static readonly long[] Value=A092916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092916.Bytes);
public long this[int i]=>Value[i];

public static A092916Inst Instance=new A092916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092917
{
public static readonly long[] Value={ 0L,3L,5L,9L,11L,21L,30L,37L,38L,53L,62L,92L,129L,157L,186L,189L,234L,237L,250L,285L,353L,376L,413L,416L,473L,496L,513L,516L,553L,645L,710L,813L,889L,891L,915L,1021L,1092L,1105L,1176L,1328L,1439L,1603L,1654L,1783L,1883L,2056L,2122L,2308L,2374L,2392L,2416L,2476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092917Inst : IEnumerable<long>
{
public static readonly long[] Value=A092917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092917.Bytes);
public long this[int i]=>Value[i];

public static A092917Inst Instance=new A092917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092918
{
public static readonly BigInteger[] Value={ 2L,4L,96L,31840L,2147156736L,9223372011084915712L,BigInteger.Parse("170141183460469231602560095199828453376"),BigInteger.Parse("57896044618658097711785492504343953923912733397452774312021795134847892828160") };
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
public class A092918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092918.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092918Inst Instance=new A092918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092919
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,9L,11L,13L,15L,17L,19L,22L,25L,28L,31L,34L,37L,40L,43L,46L,49L,52L,55L,58L,61L,64L,67L,70L,73L,76L,79L,82L,86L,90L,94L,98L,102L,106L,110L,114L,118L,122L,126L,130L,134L,138L,142L,146L,150L,154L,158L,162L,166L,170L,174L,178L,182L,186L,190L,194L,198L,202L,206L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092919Inst : IEnumerable<long>
{
public static readonly long[] Value=A092919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092919.Bytes);
public long this[int i]=>Value[i];

public static A092919Inst Instance=new A092919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092920
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,22L,58L,164L,496L,1601L,5502L,20075L,77531L,315947L,1354279L,6087421L,28611385L,140239297L,715116827L,3785445032L,20760746393L,117759236340L,689745339984L,4165874930885L,25911148634728L,165775085602106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092920Inst : IEnumerable<long>
{
public static readonly long[] Value=A092920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092920.Bytes);
public long this[int i]=>Value[i];

public static A092920Inst Instance=new A092920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092921
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,1L,0L,1L,3L,2L,1L,1L,0L,1L,5L,4L,2L,1L,1L,0L,1L,8L,7L,4L,2L,1L,1L,0L,1L,13L,13L,8L,4L,2L,1L,1L,0L,1L,21L,24L,15L,8L,4L,2L,1L,1L,0L,1L,34L,44L,29L,16L,8L,4L,2L,1L,1L,0L,1L,55L,81L,56L,31L,16L,8L,4L,2L,1L,1L,0L,1L,89L,149L,108L,61L,32L,16L,8L,4L,2L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092921Inst : IEnumerable<long>
{
public static readonly long[] Value=A092921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092921.Bytes);
public long this[int i]=>Value[i];

public static A092921Inst Instance=new A092921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092922
{
public static readonly long[] Value={ 2L,5L,127L,648391L,2428095424619L,75063692618249L,2586559730396077L,98552043847093519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092922Inst : IEnumerable<long>
{
public static readonly long[] Value=A092922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092922.Bytes);
public long this[int i]=>Value[i];

public static A092922Inst Instance=new A092922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092923
{
public static readonly long[] Value={ 1L,7L,39L,211L,1168L,6728L,40561L,256297L,1696707L,11752973L,85047284L,641782220L,5041634549L,41160207335L,348664792199L,3059885806071L,27781291314396L,260599397789924L,2522492941426381L,25166308238897929L,258507111338795491L,2731176458973448817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092923Inst : IEnumerable<long>
{
public static readonly long[] Value=A092923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092923.Bytes);
public long this[int i]=>Value[i];

public static A092923Inst Instance=new A092923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092924
{
public static readonly long[] Value={ 1L,-1008L,8304L,-28224L,66672L,-127008L,232512L,-346752L,533616L,-763056L,1046304L,-1342656L,1866816L,-2215584L,2856576L,-3556224L,4269168L,-4953312L,6286128L,-6914880L,8400672L,-9709056L,11060928L,-12265344L,14941248L,-15877008L,18252192L,-20603520L,22935168L,-24585120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092924Inst : IEnumerable<long>
{
public static readonly long[] Value=A092924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092924.Bytes);
public long this[int i]=>Value[i];

public static A092924Inst Instance=new A092924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092925
{
public static readonly BigInteger[] Value={ 2L,3L,19L,5L,41L,7L,71L,89L,109L,11L,17159L,13L,2729L,239L,271L,17L,5813L,19L,419L,461L,72681839L,23L,599L,19275223967999L,701L,11793599L,811L,29L,929L,31L,BigInteger.Parse("415017197290314178559999"),968330879L,BigInteger.Parse("1659404761645592211554303999999") };
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
public class A092925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092925Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092925.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A092925.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092925Inst Instance=new A092925Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092926
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,3L,0L,2L,1L,1L,0L,2L,0L,1L,1L,5L,0L,1L,9L,1L,4L,1L,0L,1L,0L,16L,5L,21L,1L,2L,0L,1L,1L,6L,0L,3L,0L,1L,1L,1L,0L,1L,5L,1L,3L,4L,0L,1L,1L,1L,6L,2L,0L,1L,0L,3L,5L,1L,1L,1L,0L,1L,2L,1L,0L,6L,0L,5L,3L,1L,16L,3L,0L,6L,2L,4L,0L,8L,1L,1L,8L,15L,0L,30L,7L,6L,1L,1L,8L,1L,0L,2L,5L,1L,0L,70L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092926Inst : IEnumerable<long>
{
public static readonly long[] Value=A092926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092926.Bytes);
public long this[int i]=>Value[i];

public static A092926Inst Instance=new A092926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092927
{
public static readonly long[] Value={ 2L,3L,7L,5L,61L,7L,43L,337L,73L,11L,991L,13L,157L,121080961L,211L,17L,14820309504001L,19L,0L,6841L,421L,23L,10627L,96909121L,601L,15601L,17551L,29L,173059286401L,31L,530122321L,29761L,3569119343741952001L,1123L,25622035084801L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092927Inst : IEnumerable<long>
{
public static readonly long[] Value=A092927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092927.Bytes);
public long this[int i]=>Value[i];

public static A092927Inst Instance=new A092927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092928
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,1L,2L,1L,0L,2L,0L,1L,7L,1L,0L,12L,0L,-1L,2L,1L,0L,2L,5L,1L,2L,2L,0L,7L,0L,5L,2L,12L,1L,8L,0L,4L,5L,1L,0L,22L,0L,2L,4L,14L,0L,9L,7L,5L,5L,1L,0L,2L,4L,1L,13L,6L,0L,25L,0L,5L,9L,1L,5L,4L,0L,1L,4L,8L,0L,10L,0L,5L,8L,5L,1L,4L,0L,1L,12L,1L,0L,7L,5L,2L,2L,7L,0L,12L,1L,1L,8L,2L,4L,5L,0L,8L,7L,14L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092928Inst : IEnumerable<long>
{
public static readonly long[] Value=A092928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092928.Bytes);
public long this[int i]=>Value[i];

public static A092928Inst Instance=new A092928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092929
{
public static readonly long[] Value={ 1L,3L,5L,11L,15L,31L,25L,45L,35L,59L,89L,53L,109L,93L,71L,107L,149L,161L,97L,181L,151L,115L,211L,175L,233L,297L,205L,157L,219L,167L,233L,561L,259L,335L,207L,499L,223L,379L,391L,323L,413L,425L,265L,621L,281L,377L,291L,775L,799L,423L,329L,437L,551L,347L,791L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092929Inst : IEnumerable<long>
{
public static readonly long[] Value=A092929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092929.Bytes);
public long this[int i]=>Value[i];

public static A092929Inst Instance=new A092929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092930
{
public static readonly long[] Value={ 4L,8L,12L,12L,14L,22L,26L,22L,24L,36L,40L,32L,34L,50L,39L,41L,43L,45L,66L,70L,53L,55L,57L,59L,86L,64L,66L,96L,100L,74L,76L,110L,81L,83L,85L,87L,126L,92L,94L,96L,98L,142L,146L,106L,108L,110L,112L,162L,117L,119L,172L,176L,127L,129L,131L,133L,192L,138L,140L,202L,145L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092930Inst : IEnumerable<long>
{
public static readonly long[] Value=A092930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092930.Bytes);
public long this[int i]=>Value[i];

public static A092930Inst Instance=new A092930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092931
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092931Inst : IEnumerable<long>
{
public static readonly long[] Value=A092931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092931.Bytes);
public long this[int i]=>Value[i];

public static A092931Inst Instance=new A092931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092964
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,3L,5L,5L,3L,3L,7L,8L,7L,3L,4L,9L,14L,14L,9L,4L,4L,12L,20L,25L,20L,12L,4L,5L,15L,30L,42L,42L,30L,15L,5L,5L,18L,40L,66L,75L,66L,40L,18L,5L,6L,22L,55L,99L,132L,132L,99L,55L,22L,6L,6L,26L,70L,143L,212L,245L,212L,143L,70L,26L,6L,7L,30L,91L,200L,333L,429L,429L,333L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092964Inst : IEnumerable<long>
{
public static readonly long[] Value=A092964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092964.Bytes);
public long this[int i]=>Value[i];

public static A092964Inst Instance=new A092964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092965
{
public static readonly long[] Value={ 2L,3L,7L,13L,61L,241L,2521L,20161L,72577L,604801L,39916801L,59875201L,3113510401L,17435658241L,186810624001L,10461394944001L,118562476032001L,246245142528001L,24329020081766401L,304112751022080001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092965Inst : IEnumerable<long>
{
public static readonly long[] Value=A092965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092965.Bytes);
public long this[int i]=>Value[i];

public static A092965Inst Instance=new A092965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092966
{
public static readonly long[] Value={ 0L,10L,52L,149L,324L,600L,1000L,1547L,2264L,3174L,4300L,5665L,7292L,9204L,11424L,13975L,16880L,20162L,23844L,27949L,32500L,37520L,43032L,49059L,55624L,62750L,70460L,78777L,87724L,97324L,107600L,118575L,130272L,142714L,155924L,169925L,184740L,200392L,216904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092966Inst : IEnumerable<long>
{
public static readonly long[] Value=A092966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092966.Bytes);
public long this[int i]=>Value[i];

public static A092966Inst Instance=new A092966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092967
{
public static readonly long[] Value={ 2L,3L,7L,7L,31L,31L,211L,211L,211L,211L,2311L,2311L,6007L,6007L,6007L,6007L,102103L,102103L,3233231L,3233231L,3233231L,3233231L,17160991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092967Inst : IEnumerable<long>
{
public static readonly long[] Value=A092967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092967.Bytes);
public long this[int i]=>Value[i];

public static A092967Inst Instance=new A092967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092968
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,13L,15L,16L,18L,19L,20L,23L,24L,28L,29L,30L,31L,37L,41L,42L,43L,46L,49L,50L,52L,54L,60L,62L,63L,65L,69L,70L,71L,75L,83L,85L,87L,91L,94L,95L,96L,98L,100L,106L,108L,109L,114L,123L,124L,128L,130L,134L,136L,137L,139L,145L,146L,151L,152L,153L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092968Inst : IEnumerable<long>
{
public static readonly long[] Value=A092968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092968.Bytes);
public long this[int i]=>Value[i];

public static A092968Inst Instance=new A092968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092969
{
public static readonly ulong[] Value={ 2L,3L,7L,13L,61L,241L,2521L,20161L,72577L,604801L,39916801L,59875201L,3113510401L,17435658241L,186810624001L,10461394944001L,118562476032001L,0L,24329020081766401L,304112751022080001L,12772735542927360001UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092969Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A092969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092969.Bytes);
public ulong this[int i]=>Value[i];

public static A092969Inst Instance=new A092969Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092970
{
public static readonly long[] Value={ 2L,2L,3L,7L,31L,181L,1009L,13441L,45361L,453601L,3991681L,39916801L,566092801L,10897286401L,130767436801L,2988969984001L,25406244864001L,0L,8109673360588801L,304112751022080001L,2688996956405760001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092970Inst : IEnumerable<long>
{
public static readonly long[] Value=A092970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092970.Bytes);
public long this[int i]=>Value[i];

public static A092970Inst Instance=new A092970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092971
{
public static readonly long[] Value={ 1L,1L,2L,-9L,-8L,-5L,-36L,-35L,-64L,729L,640L,385L,5184L,5005L,8960L,-164025L,-143360L,-85085L,-1679616L,-1616615L,-2867200L,72335025L,63078400L,37182145L,967458816L,929553625L,1640038400L,-52732233225L,-45921075200L,-26957055125L,-870712934400L,-835668708875L,-1469474406400L,57425401982025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092971Inst : IEnumerable<long>
{
public static readonly long[] Value=A092971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092971.Bytes);
public long this[int i]=>Value[i];

public static A092971Inst Instance=new A092971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092972
{
public static readonly long[] Value={ 1L,1L,2L,3L,-12L,-10L,-6L,-49L,-48L,-90L,-120L,1320L,1080L,624L,9604L,9360L,17280L,22440L,-403920L,-328320L,-187200L,-4235364L,-4118400L,-7551360L,-9694080L,242352000L,196335360L,111196800L,3320525376L,3224707200L,5890060800L,7512912000L,-240413184000L,-194372006400L,-109640044800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092972Inst : IEnumerable<long>
{
public static readonly long[] Value=A092972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092972.Bytes);
public long this[int i]=>Value[i];

public static A092972Inst Instance=new A092972Inst();

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