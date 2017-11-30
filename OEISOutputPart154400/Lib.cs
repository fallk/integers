using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A197505
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,121L,1665L,43883L,2437423L,289320049L,71423435521L,35912764315347L,36427941634714575L,BigInteger.Parse("74226534887938021609"),BigInteger.Parse("303199273967377493113473"),BigInteger.Parse("2480131664037469755458069819"),BigInteger.Parse("40602053121132407513785975382767"),BigInteger.Parse("1329877926764331449042460153768864481") };
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
public class A197505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197505Inst Instance=new A197505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197506
{
public static readonly long[] Value={ 1L,1L,0L,1L,9L,6L,9L,5L,6L,5L,5L,4L,4L,0L,6L,8L,6L,6L,9L,4L,9L,6L,9L,1L,2L,8L,3L,5L,8L,8L,6L,2L,6L,7L,2L,2L,1L,9L,9L,8L,4L,4L,3L,3L,3L,3L,6L,0L,6L,2L,2L,9L,1L,2L,0L,7L,6L,6L,2L,5L,7L,2L,2L,0L,0L,8L,3L,9L,8L,9L,8L,7L,2L,1L,8L,9L,7L,9L,5L,0L,2L,9L,0L,3L,6L,9L,0L,5L,9L,2L,5L,5L,5L,0L,2L,6L,5L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197506Inst : IEnumerable<long>
{
public static readonly long[] Value=A197506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197506.Bytes);
public long this[int i]=>Value[i];

public static A197506Inst Instance=new A197506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197507
{
public static readonly long[] Value={ 3L,9L,4L,2L,6L,8L,2L,5L,8L,5L,3L,5L,5L,9L,1L,5L,9L,0L,5L,6L,3L,3L,0L,9L,1L,5L,4L,5L,7L,5L,1L,3L,7L,7L,4L,0L,9L,5L,5L,0L,1L,7L,2L,9L,4L,0L,8L,4L,1L,8L,3L,4L,3L,9L,7L,9L,6L,1L,7L,3L,6L,5L,7L,1L,0L,4L,6L,0L,0L,7L,0L,3L,2L,6L,3L,8L,1L,8L,2L,0L,2L,5L,0L,1L,0L,2L,9L,6L,6L,1L,0L,1L,0L,2L,0L,3L,1L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197507Inst : IEnumerable<long>
{
public static readonly long[] Value=A197507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197507.Bytes);
public long this[int i]=>Value[i];

public static A197507Inst Instance=new A197507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197508
{
public static readonly long[] Value={ 5L,0L,6L,2L,9L,7L,8L,9L,9L,2L,3L,4L,0L,5L,9L,8L,2L,6L,7L,5L,0L,0L,1L,1L,5L,6L,2L,7L,8L,3L,6L,9L,7L,0L,3L,2L,5L,2L,8L,6L,5L,8L,1L,6L,3L,9L,5L,8L,2L,8L,9L,4L,7L,4L,1L,9L,1L,4L,3L,2L,4L,7L,4L,1L,1L,1L,0L,7L,6L,9L,2L,2L,7L,8L,9L,7L,5L,3L,6L,7L,6L,3L,4L,2L,8L,4L,5L,7L,9L,5L,4L,3L,5L,4L,0L,0L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197508Inst : IEnumerable<long>
{
public static readonly long[] Value=A197508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197508.Bytes);
public long this[int i]=>Value[i];

public static A197508Inst Instance=new A197508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197509
{
public static readonly long[] Value={ 4L,0L,5L,7L,4L,6L,6L,6L,0L,7L,5L,1L,2L,4L,8L,2L,1L,5L,1L,1L,6L,0L,8L,4L,7L,7L,7L,0L,5L,8L,3L,0L,6L,9L,0L,5L,3L,2L,0L,0L,0L,9L,9L,3L,9L,1L,6L,2L,0L,4L,6L,8L,7L,5L,5L,3L,2L,0L,7L,0L,4L,0L,3L,4L,6L,6L,4L,6L,2L,8L,5L,6L,9L,4L,4L,5L,2L,2L,0L,0L,8L,0L,0L,4L,8L,5L,5L,7L,2L,3L,3L,2L,0L,0L,5L,7L,6L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197509Inst : IEnumerable<long>
{
public static readonly long[] Value=A197509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197509.Bytes);
public long this[int i]=>Value[i];

public static A197509Inst Instance=new A197509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197510
{
public static readonly long[] Value={ 6L,6L,3L,4L,9L,0L,0L,4L,6L,0L,5L,6L,6L,3L,7L,3L,2L,0L,7L,8L,9L,8L,3L,6L,1L,6L,6L,9L,1L,5L,1L,9L,0L,2L,1L,3L,3L,2L,1L,5L,0L,3L,2L,7L,9L,6L,4L,5L,8L,6L,8L,0L,6L,0L,0L,9L,3L,9L,2L,7L,8L,8L,8L,1L,7L,1L,0L,9L,3L,2L,8L,4L,7L,9L,2L,1L,9L,4L,6L,9L,2L,3L,6L,6L,4L,7L,1L,7L,6L,8L,4L,0L,2L,6L,3L,8L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197510Inst : IEnumerable<long>
{
public static readonly long[] Value=A197510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197510.Bytes);
public long this[int i]=>Value[i];

public static A197510Inst Instance=new A197510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197511
{
public static readonly long[] Value={ 6L,3L,9L,1L,9L,9L,1L,9L,2L,8L,3L,7L,2L,2L,4L,8L,4L,0L,4L,4L,3L,6L,4L,7L,8L,6L,6L,1L,5L,3L,4L,1L,8L,2L,8L,8L,3L,3L,4L,3L,2L,2L,1L,1L,8L,1L,9L,9L,8L,6L,4L,1L,7L,3L,7L,5L,6L,3L,9L,8L,9L,0L,4L,6L,6L,8L,9L,0L,2L,5L,9L,4L,3L,4L,9L,6L,2L,0L,5L,8L,5L,4L,7L,2L,4L,8L,9L,0L,1L,1L,6L,0L,9L,6L,8L,5L,8L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197511Inst : IEnumerable<long>
{
public static readonly long[] Value=A197511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197511.Bytes);
public long this[int i]=>Value[i];

public static A197511Inst Instance=new A197511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197512
{
public static readonly long[] Value={ 3L,0L,8L,1L,3L,7L,3L,5L,9L,9L,2L,8L,2L,3L,2L,6L,4L,6L,2L,3L,1L,7L,7L,0L,5L,6L,9L,9L,4L,5L,5L,4L,1L,1L,1L,9L,3L,9L,0L,5L,4L,8L,4L,3L,4L,9L,6L,7L,8L,8L,9L,4L,1L,4L,9L,5L,9L,3L,0L,9L,7L,0L,7L,6L,0L,3L,0L,2L,3L,7L,2L,0L,2L,2L,2L,4L,8L,1L,5L,5L,7L,2L,2L,9L,9L,5L,9L,9L,0L,2L,1L,0L,2L,1L,6L,1L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197512Inst : IEnumerable<long>
{
public static readonly long[] Value=A197512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197512.Bytes);
public long this[int i]=>Value[i];

public static A197512Inst Instance=new A197512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197513
{
public static readonly long[] Value={ 2L,4L,0L,5L,2L,3L,3L,7L,0L,3L,8L,7L,7L,0L,3L,6L,5L,3L,6L,0L,3L,8L,1L,1L,2L,8L,0L,2L,5L,2L,2L,8L,2L,7L,2L,4L,6L,0L,2L,6L,4L,4L,9L,5L,6L,3L,9L,6L,4L,4L,8L,2L,0L,1L,5L,0L,2L,8L,6L,6L,8L,2L,4L,5L,4L,3L,2L,2L,4L,5L,9L,6L,2L,3L,0L,7L,1L,7L,7L,3L,8L,0L,7L,2L,7L,9L,9L,8L,0L,9L,0L,1L,1L,6L,1L,1L,3L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197513Inst : IEnumerable<long>
{
public static readonly long[] Value=A197513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197513.Bytes);
public long this[int i]=>Value[i];

public static A197513Inst Instance=new A197513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197514
{
public static readonly long[] Value={ 2L,4L,0L,3L,4L,7L,6L,9L,7L,8L,9L,9L,9L,9L,2L,5L,2L,2L,5L,4L,5L,1L,2L,9L,6L,4L,6L,3L,2L,4L,8L,1L,1L,8L,3L,1L,0L,8L,3L,7L,9L,2L,0L,0L,5L,2L,9L,0L,9L,6L,8L,0L,9L,5L,2L,8L,3L,5L,5L,5L,5L,7L,2L,2L,5L,3L,4L,8L,5L,7L,9L,3L,2L,2L,9L,5L,8L,4L,4L,3L,5L,5L,2L,3L,2L,9L,9L,5L,9L,4L,6L,7L,9L,3L,2L,7L,9L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197514Inst : IEnumerable<long>
{
public static readonly long[] Value=A197514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197514.Bytes);
public long this[int i]=>Value[i];

public static A197514Inst Instance=new A197514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197515
{
public static readonly long[] Value={ 1L,5L,0L,1L,5L,2L,4L,9L,8L,0L,4L,5L,5L,7L,6L,2L,5L,5L,0L,6L,8L,3L,9L,4L,7L,2L,6L,2L,8L,8L,6L,2L,7L,8L,1L,5L,7L,1L,3L,6L,5L,1L,4L,4L,5L,3L,0L,7L,2L,3L,4L,1L,1L,2L,5L,6L,3L,8L,4L,9L,9L,4L,4L,2L,6L,0L,3L,3L,6L,3L,3L,7L,7L,9L,5L,5L,4L,5L,0L,0L,8L,4L,2L,8L,5L,0L,5L,8L,5L,0L,5L,1L,3L,5L,3L,6L,6L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197515Inst : IEnumerable<long>
{
public static readonly long[] Value=A197515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197515.Bytes);
public long this[int i]=>Value[i];

public static A197515Inst Instance=new A197515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197516
{
public static readonly long[] Value={ 1L,7L,9L,8L,5L,9L,1L,0L,3L,7L,0L,2L,8L,6L,9L,8L,4L,4L,2L,7L,7L,5L,5L,7L,2L,9L,2L,8L,4L,5L,2L,1L,6L,1L,3L,1L,1L,7L,0L,8L,8L,7L,0L,5L,1L,1L,1L,7L,5L,7L,5L,5L,6L,1L,5L,0L,4L,0L,8L,7L,1L,5L,6L,4L,2L,6L,4L,7L,6L,4L,6L,4L,9L,7L,8L,2L,0L,0L,6L,9L,9L,0L,1L,9L,0L,4L,3L,4L,6L,4L,0L,4L,9L,1L,3L,8L,5L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197516Inst : IEnumerable<long>
{
public static readonly long[] Value=A197516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197516.Bytes);
public long this[int i]=>Value[i];

public static A197516Inst Instance=new A197516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197517
{
public static readonly long[] Value={ 1L,6L,5L,1L,9L,5L,8L,3L,1L,3L,6L,2L,2L,5L,0L,0L,7L,8L,9L,7L,6L,4L,6L,7L,8L,2L,8L,5L,7L,3L,4L,4L,4L,7L,2L,0L,3L,8L,1L,2L,6L,5L,5L,8L,3L,9L,5L,5L,9L,0L,7L,8L,4L,0L,3L,0L,1L,0L,6L,8L,1L,8L,8L,8L,7L,1L,2L,5L,4L,2L,3L,1L,3L,9L,5L,6L,6L,8L,9L,4L,5L,8L,7L,7L,0L,0L,5L,2L,4L,1L,4L,1L,2L,3L,4L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197517Inst : IEnumerable<long>
{
public static readonly long[] Value=A197517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197517.Bytes);
public long this[int i]=>Value[i];

public static A197517Inst Instance=new A197517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197518
{
public static readonly long[] Value={ 8L,2L,5L,9L,7L,9L,1L,5L,6L,8L,1L,1L,2L,5L,0L,3L,9L,4L,8L,8L,2L,3L,3L,9L,1L,4L,2L,8L,6L,7L,2L,2L,3L,6L,0L,1L,9L,0L,6L,3L,2L,7L,9L,1L,9L,7L,7L,9L,5L,3L,9L,2L,0L,1L,5L,0L,5L,3L,4L,0L,9L,4L,4L,3L,5L,6L,2L,7L,1L,1L,5L,6L,9L,7L,8L,3L,4L,4L,7L,2L,9L,3L,8L,5L,0L,2L,6L,2L,0L,7L,0L,6L,1L,7L,2L,0L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197518Inst : IEnumerable<long>
{
public static readonly long[] Value=A197518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197518.Bytes);
public long this[int i]=>Value[i];

public static A197518Inst Instance=new A197518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197519
{
public static readonly long[] Value={ 7L,5L,0L,7L,6L,2L,4L,9L,0L,2L,2L,7L,8L,8L,1L,2L,7L,5L,3L,4L,1L,9L,7L,3L,6L,3L,1L,4L,4L,3L,1L,3L,9L,0L,7L,8L,5L,6L,8L,2L,5L,7L,2L,2L,6L,5L,3L,6L,1L,7L,0L,5L,6L,2L,8L,1L,9L,2L,4L,9L,7L,2L,1L,3L,0L,1L,6L,8L,1L,6L,8L,8L,9L,7L,7L,7L,2L,5L,0L,4L,2L,1L,4L,2L,5L,2L,9L,2L,5L,2L,5L,6L,7L,6L,8L,3L,4L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197519Inst : IEnumerable<long>
{
public static readonly long[] Value=A197519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197519.Bytes);
public long this[int i]=>Value[i];

public static A197519Inst Instance=new A197519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197520
{
public static readonly long[] Value={ 9L,0L,6L,3L,6L,2L,2L,3L,6L,5L,3L,8L,7L,2L,1L,4L,1L,7L,5L,1L,9L,6L,9L,1L,9L,2L,2L,7L,5L,8L,8L,4L,6L,9L,1L,0L,3L,1L,2L,0L,8L,8L,7L,1L,0L,3L,0L,1L,9L,2L,0L,1L,8L,0L,4L,1L,4L,4L,0L,8L,9L,3L,8L,8L,7L,3L,7L,2L,3L,9L,2L,8L,6L,2L,0L,8L,5L,9L,6L,8L,1L,5L,6L,0L,8L,2L,0L,2L,8L,8L,5L,2L,4L,6L,7L,6L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197520Inst : IEnumerable<long>
{
public static readonly long[] Value=A197520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197520.Bytes);
public long this[int i]=>Value[i];

public static A197520Inst Instance=new A197520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197521
{
public static readonly long[] Value={ 3L,5L,2L,1L,3L,3L,7L,8L,2L,9L,5L,7L,1L,7L,1L,5L,6L,9L,8L,6L,9L,1L,9L,8L,8L,5L,6L,4L,4L,5L,4L,9L,1L,7L,9L,7L,7L,3L,0L,9L,1L,8L,1L,3L,9L,4L,7L,3L,3L,6L,8L,8L,7L,1L,9L,5L,4L,9L,1L,8L,4L,8L,6L,2L,5L,1L,5L,5L,9L,0L,6L,0L,9L,6L,1L,0L,2L,5L,9L,8L,8L,8L,9L,7L,4L,9L,7L,5L,6L,9L,0L,0L,3L,9L,4L,9L,7L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197521Inst : IEnumerable<long>
{
public static readonly long[] Value=A197521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197521.Bytes);
public long this[int i]=>Value[i];

public static A197521Inst Instance=new A197521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197522
{
public static readonly long[] Value={ 2L,1L,2L,0L,7L,1L,0L,7L,1L,9L,1L,8L,1L,0L,4L,2L,8L,2L,0L,4L,4L,3L,5L,1L,1L,7L,5L,6L,9L,4L,2L,8L,3L,5L,2L,2L,5L,6L,8L,5L,2L,0L,3L,0L,5L,0L,9L,1L,1L,6L,4L,7L,9L,0L,9L,2L,9L,7L,8L,5L,0L,4L,1L,1L,7L,5L,6L,7L,9L,8L,7L,1L,8L,7L,3L,8L,4L,5L,8L,1L,6L,1L,5L,5L,0L,9L,7L,0L,5L,7L,4L,7L,6L,0L,0L,1L,8L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197522Inst : IEnumerable<long>
{
public static readonly long[] Value=A197522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197522.Bytes);
public long this[int i]=>Value[i];

public static A197522Inst Instance=new A197522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197523
{
public static readonly BigInteger[] Value={ 1L,1L,32L,289L,26282L,4538784L,2095251333L,2629509487169L,9372400936796449L,BigInteger.Parse("87780282753696748644") };
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
public class A197523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197523Inst Instance=new A197523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197524
{
public static readonly long[] Value={ 1L,3L,32L,69L,308L,1444L,5048L,20265L,83277L,322864L,1280598L,5112008L,20189827L,80032884L,317712722L,1258773307L,4990157041L,19788837323L,78445935632L,310998937948L,1233039388705L,4888402255720L,19380385472489L,76835860723308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197524Inst : IEnumerable<long>
{
public static readonly long[] Value=A197524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197524.Bytes);
public long this[int i]=>Value[i];

public static A197524Inst Instance=new A197524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197525
{
public static readonly long[] Value={ 1L,7L,69L,289L,2131L,12071L,74637L,454685L,2748523L,16739531L,101635341L,617647081L,3752641091L,22798729927L,138527481045L,841658638245L,5113753205699L,31070163145411L,188776416736109L,1146970428535417L,6968770713230523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197525Inst : IEnumerable<long>
{
public static readonly long[] Value=A197525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197525.Bytes);
public long this[int i]=>Value[i];

public static A197525Inst Instance=new A197525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197526
{
public static readonly long[] Value={ 1L,17L,308L,2131L,26282L,266240L,2818424L,29249599L,308300414L,3239050114L,33917534848L,356001407488L,3736740898853L,39200753974016L,411284436121799L,4315679852563777L,45282304376141812L,475113528147885886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197526Inst : IEnumerable<long>
{
public static readonly long[] Value=A197526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197526.Bytes);
public long this[int i]=>Value[i];

public static A197526Inst Instance=new A197526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197527
{
public static readonly long[] Value={ 1L,41L,1444L,12071L,266240L,4538784L,73297686L,1237970513L,21169912001L,353504327702L,5958282895132L,100604292119446L,1693082387823415L,28523128648184140L,480717546283691822L,8098057861011371455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197527Inst : IEnumerable<long>
{
public static readonly long[] Value=A197527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197527.Bytes);
public long this[int i]=>Value[i];

public static A197527Inst Instance=new A197527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197528
{
public static readonly BigInteger[] Value={ 1L,99L,5048L,74637L,2818424L,73297686L,2095251333L,58226014909L,1640490253969L,46006820800296L,1290659247439150L,36216071381563588L,1016338870833268879L,BigInteger.Parse("28519809510464622005"),BigInteger.Parse("800263279008322539229"),BigInteger.Parse("22456612946242234293115") };
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
public class A197528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197528Inst Instance=new A197528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197529
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,7L,32L,7L,1L,1L,17L,69L,69L,17L,1L,1L,41L,308L,289L,308L,41L,1L,1L,99L,1444L,2131L,2131L,1444L,99L,1L,1L,239L,5048L,12071L,26282L,12071L,5048L,239L,1L,1L,577L,20265L,74637L,266240L,266240L,74637L,20265L,577L,1L,1L,1393L,83277L,454685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197529Inst : IEnumerable<long>
{
public static readonly long[] Value=A197529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197529.Bytes);
public long this[int i]=>Value[i];

public static A197529Inst Instance=new A197529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197530
{
public static readonly long[] Value={ 1L,9L,56L,1419L,107655L,23325250L,14991391782L,27504159228709L,145843735771766573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197530Inst : IEnumerable<long>
{
public static readonly long[] Value=A197530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197530.Bytes);
public long this[int i]=>Value[i];

public static A197530Inst Instance=new A197530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197531
{
public static readonly long[] Value={ 3L,9L,16L,33L,73L,160L,361L,835L,1966L,4703L,11399L,27914L,68903L,171121L,426940L,1068865L,2682789L,6746336L,16988333L,42822747L,108024178L,272648551L,688426371L,1738750602L,4392467427L,11098043841L,28043540864L,70868720569L,179102669081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197531Inst : IEnumerable<long>
{
public static readonly long[] Value=A197531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197531.Bytes);
public long this[int i]=>Value[i];

public static A197531Inst Instance=new A197531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197532
{
public static readonly long[] Value={ 4L,16L,56L,216L,868L,3500L,14085L,56842L,229706L,928664L,3755722L,15191220L,61451640L,248596817L,1005703793L,4068662528L,16460279703L,66592450774L,269410213656L,1089943115100L,4409547400430L,17839571907124L,72173035560719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197532Inst : IEnumerable<long>
{
public static readonly long[] Value=A197532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197532.Bytes);
public long this[int i]=>Value[i];

public static A197532Inst Instance=new A197532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197533
{
public static readonly long[] Value={ 5L,33L,216L,1419L,9373L,62586L,423085L,2879723L,19671764L,134643523L,922592723L,6325665762L,43386843099L,297644913045L,2042157812212L,14012277918367L,96148923597911L,659765081841360L,4527301927394765L,31066516652385893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197533Inst : IEnumerable<long>
{
public static readonly long[] Value=A197533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197533.Bytes);
public long this[int i]=>Value[i];

public static A197533Inst Instance=new A197533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197534
{
public static readonly long[] Value={ 9L,73L,868L,9373L,107655L,1220630L,14056707L,162042137L,1874230689L,21698542215L,251403042154L,2913819348602L,33779087426950L,391635814747885L,4540933400612193L,52653016886940873L,610534294176601038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197534Inst : IEnumerable<long>
{
public static readonly long[] Value=A197534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197534.Bytes);
public long this[int i]=>Value[i];

public static A197534Inst Instance=new A197534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197535
{
public static readonly BigInteger[] Value={ 16L,160L,3500L,62586L,1220630L,23325250L,454280983L,8844380028L,172982554332L,3386294190736L,66356347688978L,1300795127521094L,25506585069158562L,500211695453958433L,9810478953775130079UL,BigInteger.Parse("192417797960470740096") };
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
public class A197535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197535Inst Instance=new A197535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197536
{
public static readonly BigInteger[] Value={ 25L,361L,14085L,423085L,14056707L,454280983L,14991391782L,493785636151L,16343961543732L,541269402906501L,17943273862788427L,595019891173209941L,BigInteger.Parse("19736497896904338854"),BigInteger.Parse("654726724059190203302"),BigInteger.Parse("21721092108797190824889") };
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
public class A197536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197536Inst Instance=new A197536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197537
{
public static readonly long[] Value={ 1L,3L,3L,4L,9L,4L,5L,16L,16L,5L,9L,33L,56L,33L,9L,16L,73L,216L,216L,73L,16L,25L,160L,868L,1419L,868L,160L,25L,39L,361L,3500L,9373L,9373L,3500L,361L,39L,64L,835L,14085L,62586L,107655L,62586L,14085L,835L,64L,105L,1966L,56842L,423085L,1220630L,1220630L,423085L,56842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197537Inst : IEnumerable<long>
{
public static readonly long[] Value=A197537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197537.Bytes);
public long this[int i]=>Value[i];

public static A197537Inst Instance=new A197537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197538
{
public static readonly long[] Value={ 1L,5L,11L,131L,494L,12019L,223832L,9712913L,396593739L,39500650780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197538Inst : IEnumerable<long>
{
public static readonly long[] Value=A197538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197538.Bytes);
public long this[int i]=>Value[i];

public static A197538Inst Instance=new A197538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197539
{
public static readonly long[] Value={ 1L,5L,8L,19L,28L,58L,119L,219L,395L,776L,1529L,2826L,5300L,10299L,19763L,37051L,70380L,135411L,257788L,487412L,929135L,1776855L,3377845L,6414026L,12229725L,23320560L,44346952L,84364697L,160777089L,306229857L,582642042L,1109154715L,2112783972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197539Inst : IEnumerable<long>
{
public static readonly long[] Value=A197539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197539.Bytes);
public long this[int i]=>Value[i];

public static A197539Inst Instance=new A197539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197540
{
public static readonly long[] Value={ 2L,8L,11L,24L,61L,121L,270L,614L,1296L,2973L,6574L,14527L,32621L,72032L,160402L,357304L,792903L,1765982L,3926185L,8727963L,19420018L,43174998L,96024756L,213571465L,474912978L,1056243677L,2348975193L,5223841988L,11617743070L,25836617638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197540Inst : IEnumerable<long>
{
public static readonly long[] Value=A197540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197540.Bytes);
public long this[int i]=>Value[i];

public static A197540Inst Instance=new A197540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197541
{
public static readonly long[] Value={ 3L,19L,24L,131L,206L,834L,2081L,6653L,15931L,48796L,135249L,391078L,1061878L,3054971L,8582689L,24243393L,67728862L,192162581L,541573358L,1525969004L,4291400929L,12116692925L,34147187837L,96210697228L,271054147869L,764411232314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197541Inst : IEnumerable<long>
{
public static readonly long[] Value=A197541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197541.Bytes);
public long this[int i]=>Value[i];

public static A197541Inst Instance=new A197541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197542
{
public static readonly long[] Value={ 4L,28L,61L,206L,494L,2095L,6279L,21530L,69977L,248366L,813400L,2838023L,9457181L,32284759L,108523371L,370702868L,1251432293L,4258479323L,14389442735L,48816423022L,165305055080L,561221682936L,1901461841900L,6447263273359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197542Inst : IEnumerable<long>
{
public static readonly long[] Value=A197542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197542.Bytes);
public long this[int i]=>Value[i];

public static A197542Inst Instance=new A197542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197543
{
public static readonly long[] Value={ 6L,58L,121L,834L,2095L,12019L,48014L,225222L,831160L,3944345L,16773428L,72763421L,300929135L,1319535052L,5704373966L,24566253078L,104395539577L,449962758422L,1938348799951L,8344538708719L,35799140191716L,153820463246984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197543Inst : IEnumerable<long>
{
public static readonly long[] Value=A197543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197543.Bytes);
public long this[int i]=>Value[i];

public static A197543Inst Instance=new A197543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197544
{
public static readonly long[] Value={ 9L,119L,270L,2081L,6279L,48014L,223832L,1258673L,6255191L,36099651L,182317148L,1002566978L,5243822530L,28535482208L,150520120228L,809991814859L,4299042626683L,23075139229373L,122959297359243L,658044273422935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197544Inst : IEnumerable<long>
{
public static readonly long[] Value=A197544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197544.Bytes);
public long this[int i]=>Value[i];

public static A197544Inst Instance=new A197544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197545
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,3L,8L,8L,3L,4L,19L,11L,19L,4L,6L,28L,24L,24L,28L,6L,9L,58L,61L,131L,61L,58L,9L,13L,119L,121L,206L,206L,121L,119L,13L,19L,219L,270L,834L,494L,834L,270L,219L,19L,28L,395L,614L,2081L,2095L,2095L,2081L,614L,395L,28L,41L,776L,1296L,6653L,6279L,12019L,6279L,6653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197545Inst : IEnumerable<long>
{
public static readonly long[] Value=A197545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197545.Bytes);
public long this[int i]=>Value[i];

public static A197545Inst Instance=new A197545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197546
{
public static readonly long[] Value={ 1L,4L,7L,13L,40L,264L,888L,2335L,22885L,134738L,1291220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197546Inst : IEnumerable<long>
{
public static readonly long[] Value=A197546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197546.Bytes);
public long this[int i]=>Value[i];

public static A197546Inst Instance=new A197546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197547
{
public static readonly long[] Value={ 0L,2L,1L,1L,2L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,2L,0L,1L,1L,0L,1L,2L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,2L,0L,1L,0L,2L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,2L,0L,0L,1L,1L,1L,1L,0L,2L,1L,0L,1L,1L,2L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197547Inst : IEnumerable<long>
{
public static readonly long[] Value=A197547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197547.Bytes);
public long this[int i]=>Value[i];

public static A197547Inst Instance=new A197547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197548
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,0L,0L,1L,1L,1L,1L,1L,2L,0L,1L,1L,2L,1L,2L,1L,0L,0L,2L,1L,1L,0L,1L,2L,0L,1L,1L,1L,1L,1L,1L,2L,0L,0L,0L,0L,2L,0L,1L,1L,2L,2L,0L,0L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197548Inst : IEnumerable<long>
{
public static readonly long[] Value=A197548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197548.Bytes);
public long this[int i]=>Value[i];

public static A197548Inst Instance=new A197548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197549
{
public static readonly long[] Value={ 1L,1L,5L,16L,62L,276L,1222L,5563L,25805L,120909L,572011L,2727485L,13089106L,63164265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197549Inst : IEnumerable<long>
{
public static readonly long[] Value=A197549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197549.Bytes);
public long this[int i]=>Value[i];

public static A197549Inst Instance=new A197549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197550
{
public static readonly long[] Value={ 1L,3L,7L,28L,99L,433L,1852L,8463L,38798L,181889L,858570L,4093739L,19636172L,94759074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197550Inst : IEnumerable<long>
{
public static readonly long[] Value=A197550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197550.Bytes);
public long this[int i]=>Value[i];

public static A197550Inst Instance=new A197550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197551
{
public static readonly long[] Value={ 1L,1L,4L,10L,37L,147L,637L,2823L,13020L,60649L,286549L,1364667L,6547108L,31586568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197551Inst : IEnumerable<long>
{
public static readonly long[] Value=A197551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197551.Bytes);
public long this[int i]=>Value[i];

public static A197551Inst Instance=new A197551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197552
{
public static readonly long[] Value={ 1L,1L,4L,10L,36L,146L,631L,2815L,12987L,60601L,286376L,1364399L,6546220L,31585133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197552Inst : IEnumerable<long>
{
public static readonly long[] Value=A197552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197552.Bytes);
public long this[int i]=>Value[i];

public static A197552Inst Instance=new A197552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197553
{
public static readonly long[] Value={ 1L,2L,7L,24L,99L,416L,1852L,8386L,38797L,181530L,858560L,4092031L,19636098L,94750833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197553Inst : IEnumerable<long>
{
public static readonly long[] Value=A197553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197553.Bytes);
public long this[int i]=>Value[i];

public static A197553Inst Instance=new A197553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197554
{
public static readonly long[] Value={ 1L,2L,7L,24L,98L,415L,1846L,8378L,38764L,181482L,858387L,4091763L,19635210L,94749398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197554Inst : IEnumerable<long>
{
public static readonly long[] Value=A197554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197554.Bytes);
public long this[int i]=>Value[i];

public static A197554Inst Instance=new A197554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197555
{
public static readonly long[] Value={ 1L,7L,35L,927L,36877L,4706533L,1435938748L,1096211683589L,2097209821463073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197555Inst : IEnumerable<long>
{
public static readonly long[] Value=A197555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197555.Bytes);
public long this[int i]=>Value[i];

public static A197555Inst Instance=new A197555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197556
{
public static readonly long[] Value={ 2L,10L,35L,106L,410L,1479L,5280L,18882L,67751L,242440L,867925L,3107159L,11124592L,39826674L,142586969L,510485048L,1827627898L,6543219347L,23425871440L,83868676944L,300264436266L,1074998739399L,3848682051842L,13778949324677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197556Inst : IEnumerable<long>
{
public static readonly long[] Value=A197556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197556.Bytes);
public long this[int i]=>Value[i];

public static A197556Inst Instance=new A197556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197557
{
public static readonly long[] Value={ 3L,23L,106L,927L,4055L,23710L,139477L,791905L,4560098L,25954025L,148624999L,851071784L,4868658595L,27861309921L,159413524406L,912205738931L,5219849087169L,29868491830580L,170911982112069L,977981992958773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197557Inst : IEnumerable<long>
{
public static readonly long[] Value=A197557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197557.Bytes);
public long this[int i]=>Value[i];

public static A197557Inst Instance=new A197557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197558
{
public static readonly long[] Value={ 5L,57L,410L,4055L,36877L,310658L,2817383L,25115833L,223137190L,1986928549L,17695730995L,157551002096L,1402893385536L,12491465131399L,111225018303022L,990363617390993L,8818318528316601L,78519303830481116L,699145265959550188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197558Inst : IEnumerable<long>
{
public static readonly long[] Value=A197558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197558.Bytes);
public long this[int i]=>Value[i];

public static A197558Inst Instance=new A197558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197559
{
public static readonly long[] Value={ 8L,122L,1479L,23710L,310658L,4706533L,64257852L,901951086L,12684564675L,178322495650L,2506556414671L,35223505169401L,495117362856222L,6957878417748008L,97787038707298921L,1374307359034315960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197559Inst : IEnumerable<long>
{
public static readonly long[] Value=A197559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197559.Bytes);
public long this[int i]=>Value[i];

public static A197559Inst Instance=new A197559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197560
{
public static readonly BigInteger[] Value={ 13L,275L,5280L,139477L,2817383L,64257852L,1435938748L,31372791803L,696517116880L,15437789226545L,341765449897848L,7569824125142348L,167639023580466828L,3712571610572571780L,BigInteger.Parse("82219714950533940171"),BigInteger.Parse("1820858468171700800429") };
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
public class A197560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197560Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197560.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197560Inst Instance=new A197560Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197561
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,10L,10L,3L,5L,23L,35L,23L,5L,8L,57L,106L,106L,57L,8L,13L,122L,410L,927L,410L,122L,13L,21L,275L,1479L,4055L,4055L,1479L,275L,21L,34L,623L,5280L,23710L,36877L,23710L,5280L,623L,34L,55L,1394L,18882L,139477L,310658L,310658L,139477L,18882L,1394L,55L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197561Inst : IEnumerable<long>
{
public static readonly long[] Value=A197561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197561.Bytes);
public long this[int i]=>Value[i];

public static A197561Inst Instance=new A197561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197562
{
public static readonly long[] Value={ 6L,13L,17L,25L,35L,107L,109L,157L,167L,191L,211L,251L,332L,332L,368L,383L,387L,396L,436L,448L,484L,484L,496L,528L,549L,561L,617L,620L,626L,661L,679L,709L,709L,713L,745L,817L,845L,852L,897L,946L,948L,972L,1035L,1035L,1116L,1143L,1161L,1224L,1269L,1278L,1278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197562Inst : IEnumerable<long>
{
public static readonly long[] Value=A197562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197562.Bytes);
public long this[int i]=>Value[i];

public static A197562Inst Instance=new A197562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197563
{
public static readonly long[] Value={ 5L,13L,18L,27L,34L,51L,54L,68L,75L,86L,95L,108L,126L,133L,146L,154L,158L,164L,177L,184L,196L,198L,206L,218L,228L,235L,250L,254L,259L,271L,282L,293L,299L,303L,315L,332L,343L,351L,365L,379L,382L,392L,408L,411L,429L,441L,450L,466L,480L,490L,495L,509L,522L,531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197563Inst : IEnumerable<long>
{
public static readonly long[] Value=A197563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197563.Bytes);
public long this[int i]=>Value[i];

public static A197563Inst Instance=new A197563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197564
{
public static readonly long[] Value={ 1L,3L,4L,18L,51L,266L,1518L,11396L,111218L,1345019L,21178437L,420441727L,10691248879L,346431341394L,14306876354446L,754052504644414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197564Inst : IEnumerable<long>
{
public static readonly long[] Value=A197564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197564.Bytes);
public long this[int i]=>Value[i];

public static A197564Inst Instance=new A197564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197565
{
public static readonly long[] Value={ 1L,7L,33L,499L,11575L,531309L,48475501L,7812612736L,2508492642639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197565Inst : IEnumerable<long>
{
public static readonly long[] Value=A197565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197565.Bytes);
public long this[int i]=>Value[i];

public static A197565Inst Instance=new A197565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197566
{
public static readonly long[] Value={ 4L,7L,5L,9L,5L,12L,5L,15L,13L,11L,12L,12L,18L,15L,18L,7L,10L,7L,16L,6L,6L,6L,11L,12L,9L,11L,11L,7L,5L,13L,14L,11L,3L,10L,9L,9L,11L,8L,11L,7L,4L,6L,18L,4L,16L,18L,11L,7L,10L,8L,6L,7L,16L,8L,2L,10L,10L,9L,13L,8L,12L,11L,11L,4L,10L,0L,12L,10L,7L,6L,8L,6L,8L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197566Inst : IEnumerable<long>
{
public static readonly long[] Value=A197566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197566.Bytes);
public long this[int i]=>Value[i];

public static A197566Inst Instance=new A197566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197567
{
public static readonly long[] Value={ 4L,11L,16L,25L,30L,42L,47L,62L,75L,86L,98L,110L,128L,143L,161L,168L,178L,185L,201L,207L,213L,219L,230L,242L,251L,262L,273L,280L,285L,298L,312L,323L,326L,336L,345L,354L,365L,373L,384L,391L,395L,401L,419L,423L,439L,457L,468L,475L,485L,493L,499L,506L,522L,530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197567Inst : IEnumerable<long>
{
public static readonly long[] Value=A197567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197567.Bytes);
public long this[int i]=>Value[i];

public static A197567Inst Instance=new A197567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197568
{
public static readonly long[] Value={ 3L,6L,4L,8L,0L,27L,6L,54L,40L,24L,35L,32L,81L,56L,81L,12L,16L,12L,64L,8L,0L,8L,30L,32L,18L,24L,24L,12L,6L,42L,45L,30L,0L,16L,8L,8L,28L,7L,18L,0L,3L,0L,81L,3L,63L,81L,24L,0L,25L,7L,0L,10L,64L,12L,0L,9L,21L,20L,36L,16L,32L,30L,18L,4L,21L,0L,35L,16L,6L,0L,16L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197568Inst : IEnumerable<long>
{
public static readonly long[] Value=A197568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197568.Bytes);
public long this[int i]=>Value[i];

public static A197568Inst Instance=new A197568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197569
{
public static readonly long[] Value={ 3L,9L,13L,21L,21L,48L,54L,108L,148L,172L,207L,239L,320L,376L,457L,469L,485L,497L,561L,569L,569L,577L,607L,639L,657L,681L,705L,717L,723L,765L,810L,840L,840L,856L,864L,872L,900L,907L,925L,925L,928L,928L,1009L,1012L,1075L,1156L,1180L,1180L,1205L,1212L,1212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197569Inst : IEnumerable<long>
{
public static readonly long[] Value=A197569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197569.Bytes);
public long this[int i]=>Value[i];

public static A197569Inst Instance=new A197569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197570
{
public static readonly long[] Value={ 1L,1L,7L,50L,475L,7758L,232920L,10474252L,800434581L,103737269018L,21673922882462L,7564482881717686L,4386514307465653148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197570Inst : IEnumerable<long>
{
public static readonly long[] Value=A197570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197570.Bytes);
public long this[int i]=>Value[i];

public static A197570Inst Instance=new A197570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197571
{
public static readonly long[] Value={ 2L,7L,5L,1L,5L,5L,8L,5L,5L,0L,7L,9L,9L,8L,7L,5L,1L,3L,7L,7L,0L,9L,8L,5L,8L,2L,0L,9L,0L,2L,1L,3L,7L,9L,7L,2L,2L,0L,8L,2L,9L,6L,6L,3L,1L,4L,4L,8L,2L,5L,9L,1L,7L,9L,4L,0L,3L,3L,8L,1L,4L,8L,3L,7L,7L,4L,2L,8L,3L,1L,1L,3L,6L,0L,2L,5L,8L,1L,1L,1L,1L,1L,6L,0L,0L,0L,7L,8L,3L,7L,4L,1L,4L,9L,6L,5L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197571Inst : IEnumerable<long>
{
public static readonly long[] Value=A197571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197571.Bytes);
public long this[int i]=>Value[i];

public static A197571Inst Instance=new A197571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197572
{
public static readonly long[] Value={ 3L,9L,3L,6L,9L,6L,4L,2L,4L,7L,6L,1L,2L,8L,3L,7L,4L,1L,8L,8L,3L,3L,5L,3L,0L,4L,7L,0L,0L,9L,7L,7L,6L,6L,0L,0L,4L,3L,8L,5L,1L,3L,2L,5L,9L,6L,8L,3L,3L,0L,3L,9L,9L,7L,6L,6L,8L,4L,1L,5L,4L,8L,2L,1L,1L,0L,7L,2L,5L,1L,2L,5L,2L,0L,4L,9L,3L,6L,9L,8L,0L,5L,0L,0L,0L,3L,6L,5L,7L,8L,2L,8L,9L,6L,5L,9L,3L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197572Inst : IEnumerable<long>
{
public static readonly long[] Value=A197572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197572.Bytes);
public long this[int i]=>Value[i];

public static A197572Inst Instance=new A197572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197573
{
public static readonly long[] Value={ 5L,0L,3L,6L,8L,1L,8L,0L,7L,6L,2L,5L,6L,5L,8L,3L,1L,1L,1L,5L,0L,3L,2L,4L,8L,1L,5L,7L,1L,0L,4L,9L,1L,4L,5L,5L,6L,6L,5L,7L,0L,7L,0L,6L,0L,9L,9L,5L,1L,3L,3L,9L,8L,4L,0L,9L,7L,3L,8L,1L,7L,2L,1L,2L,8L,3L,1L,5L,0L,1L,9L,9L,3L,5L,3L,0L,1L,9L,4L,5L,9L,7L,2L,9L,5L,0L,2L,5L,8L,6L,3L,0L,2L,3L,5L,0L,5L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197573Inst : IEnumerable<long>
{
public static readonly long[] Value=A197573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197573.Bytes);
public long this[int i]=>Value[i];

public static A197573Inst Instance=new A197573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197574
{
public static readonly long[] Value={ 1L,0L,4L,8L,7L,5L,9L,9L,9L,7L,1L,1L,7L,4L,3L,8L,7L,3L,9L,6L,8L,4L,1L,3L,8L,9L,4L,3L,2L,6L,4L,8L,1L,6L,1L,7L,6L,1L,7L,8L,8L,1L,4L,9L,8L,5L,1L,0L,2L,7L,6L,9L,7L,2L,7L,1L,1L,8L,2L,8L,0L,6L,4L,8L,1L,9L,5L,0L,4L,2L,8L,7L,7L,5L,9L,7L,7L,0L,9L,4L,9L,5L,7L,0L,8L,8L,1L,5L,9L,3L,0L,1L,0L,4L,5L,3L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197574Inst : IEnumerable<long>
{
public static readonly long[] Value=A197574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197574.Bytes);
public long this[int i]=>Value[i];

public static A197574Inst Instance=new A197574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197575
{
public static readonly long[] Value={ 4L,6L,9L,9L,1L,1L,4L,0L,0L,5L,7L,6L,9L,0L,6L,9L,6L,0L,9L,2L,9L,1L,9L,7L,3L,6L,6L,5L,5L,2L,7L,7L,5L,2L,0L,0L,8L,1L,6L,0L,5L,2L,5L,7L,1L,2L,0L,4L,6L,6L,9L,5L,2L,7L,0L,2L,4L,8L,5L,6L,1L,6L,1L,3L,2L,8L,5L,7L,7L,5L,3L,2L,6L,9L,3L,4L,0L,5L,8L,5L,5L,5L,1L,0L,4L,6L,0L,5L,7L,8L,7L,6L,8L,6L,9L,7L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197575Inst : IEnumerable<long>
{
public static readonly long[] Value=A197575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197575.Bytes);
public long this[int i]=>Value[i];

public static A197575Inst Instance=new A197575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197576
{
public static readonly long[] Value={ 8L,2L,0L,3L,4L,3L,0L,7L,3L,8L,2L,7L,7L,6L,2L,4L,7L,4L,8L,5L,6L,1L,9L,9L,5L,8L,8L,7L,0L,9L,9L,0L,4L,8L,0L,5L,0L,5L,6L,5L,5L,1L,6L,5L,7L,3L,4L,6L,5L,5L,6L,6L,9L,5L,6L,5L,9L,6L,4L,2L,6L,7L,3L,1L,4L,1L,1L,7L,1L,0L,9L,6L,4L,7L,7L,6L,3L,7L,6L,3L,5L,7L,8L,0L,4L,1L,2L,6L,7L,5L,1L,4L,3L,9L,5L,5L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197576Inst : IEnumerable<long>
{
public static readonly long[] Value=A197576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197576.Bytes);
public long this[int i]=>Value[i];

public static A197576Inst Instance=new A197576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197577
{
public static readonly long[] Value={ 6L,3L,4L,6L,6L,4L,0L,8L,3L,9L,7L,6L,9L,8L,5L,4L,2L,4L,4L,6L,8L,0L,9L,2L,5L,7L,4L,8L,5L,1L,8L,9L,4L,4L,0L,3L,6L,9L,8L,9L,3L,5L,6L,3L,8L,6L,6L,9L,0L,4L,3L,0L,5L,0L,7L,2L,5L,8L,4L,4L,5L,9L,1L,4L,4L,3L,2L,9L,4L,2L,8L,4L,6L,6L,6L,9L,1L,5L,4L,9L,1L,0L,3L,8L,4L,1L,2L,5L,8L,8L,3L,4L,2L,5L,8L,4L,9L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197577Inst : IEnumerable<long>
{
public static readonly long[] Value=A197577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197577.Bytes);
public long this[int i]=>Value[i];

public static A197577Inst Instance=new A197577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197578
{
public static readonly long[] Value={ 5L,1L,3L,5L,5L,8L,3L,3L,4L,3L,1L,1L,3L,3L,7L,5L,0L,3L,6L,2L,6L,8L,2L,6L,0L,7L,9L,8L,4L,0L,8L,1L,1L,4L,4L,8L,1L,2L,9L,4L,6L,4L,7L,0L,0L,6L,8L,1L,8L,1L,8L,8L,6L,6L,0L,8L,3L,4L,6L,4L,5L,2L,5L,2L,1L,3L,1L,1L,4L,3L,7L,5L,8L,6L,0L,1L,5L,3L,8L,7L,6L,4L,6L,0L,4L,9L,2L,0L,6L,9L,7L,9L,8L,6L,3L,8L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197578Inst : IEnumerable<long>
{
public static readonly long[] Value=A197578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197578.Bytes);
public long this[int i]=>Value[i];

public static A197578Inst Instance=new A197578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197579
{
public static readonly long[] Value={ 1L,2L,6L,9L,3L,2L,8L,1L,6L,7L,9L,5L,3L,9L,7L,0L,8L,4L,8L,9L,3L,6L,1L,8L,5L,1L,4L,9L,7L,0L,3L,7L,8L,8L,8L,0L,7L,3L,9L,7L,8L,7L,1L,2L,7L,7L,3L,3L,8L,0L,8L,6L,1L,0L,1L,4L,5L,1L,6L,8L,9L,1L,8L,2L,8L,8L,6L,5L,8L,8L,5L,6L,9L,3L,3L,3L,8L,3L,0L,9L,8L,2L,0L,7L,6L,8L,2L,5L,1L,7L,6L,6L,8L,5L,1L,6L,9L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197579Inst : IEnumerable<long>
{
public static readonly long[] Value=A197579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197579.Bytes);
public long this[int i]=>Value[i];

public static A197579Inst Instance=new A197579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197580
{
public static readonly long[] Value={ 4L,9L,8L,6L,3L,6L,5L,1L,5L,4L,7L,9L,9L,9L,8L,2L,8L,5L,8L,3L,2L,1L,9L,1L,7L,2L,8L,7L,7L,2L,3L,2L,2L,6L,9L,7L,0L,6L,6L,0L,4L,5L,6L,3L,7L,7L,2L,4L,3L,0L,2L,0L,1L,9L,3L,5L,7L,0L,3L,3L,5L,9L,9L,2L,3L,6L,1L,3L,5L,3L,2L,2L,5L,3L,8L,6L,1L,5L,4L,6L,8L,5L,9L,8L,7L,1L,0L,5L,3L,1L,9L,7L,5L,0L,7L,9L,2L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197580Inst : IEnumerable<long>
{
public static readonly long[] Value=A197580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197580.Bytes);
public long this[int i]=>Value[i];

public static A197580Inst Instance=new A197580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197581
{
public static readonly long[] Value={ 1L,6L,4L,0L,6L,8L,6L,1L,4L,7L,6L,5L,5L,5L,2L,4L,9L,4L,9L,7L,1L,2L,3L,9L,9L,1L,7L,7L,4L,1L,9L,8L,0L,9L,6L,1L,0L,1L,1L,3L,1L,0L,3L,3L,1L,4L,6L,9L,3L,1L,1L,3L,3L,9L,1L,3L,1L,9L,2L,8L,5L,3L,4L,6L,2L,8L,2L,3L,4L,2L,1L,9L,2L,9L,5L,5L,2L,7L,5L,2L,7L,1L,5L,6L,0L,8L,2L,5L,3L,5L,0L,2L,8L,7L,9L,1L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197581Inst : IEnumerable<long>
{
public static readonly long[] Value=A197581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197581.Bytes);
public long this[int i]=>Value[i];

public static A197581Inst Instance=new A197581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197582
{
public static readonly long[] Value={ 1L,4L,9L,4L,4L,4L,3L,8L,1L,9L,6L,1L,2L,0L,8L,7L,3L,8L,9L,6L,7L,4L,0L,8L,2L,2L,7L,8L,1L,7L,5L,5L,3L,0L,0L,6L,0L,6L,7L,6L,2L,9L,8L,4L,3L,4L,2L,7L,0L,0L,6L,2L,0L,7L,2L,7L,7L,4L,8L,7L,7L,7L,9L,2L,3L,0L,6L,9L,4L,7L,9L,4L,8L,5L,1L,5L,0L,3L,6L,3L,0L,9L,5L,2L,2L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197582Inst : IEnumerable<long>
{
public static readonly long[] Value=A197582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197582.Bytes);
public long this[int i]=>Value[i];

public static A197582Inst Instance=new A197582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197583
{
public static readonly long[] Value={ 1L,1L,2L,0L,9L,1L,5L,6L,8L,2L,2L,5L,4L,8L,5L,4L,3L,0L,3L,2L,2L,1L,5L,9L,3L,7L,5L,8L,1L,3L,6L,7L,9L,9L,1L,4L,6L,0L,1L,0L,3L,2L,2L,9L,2L,7L,9L,4L,7L,9L,5L,2L,3L,2L,6L,5L,8L,5L,6L,6L,5L,4L,7L,5L,0L,8L,3L,2L,7L,1L,8L,0L,2L,5L,9L,3L,1L,2L,4L,6L,5L,7L,7L,6L,0L,7L,9L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197583Inst : IEnumerable<long>
{
public static readonly long[] Value=A197583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197583.Bytes);
public long this[int i]=>Value[i];

public static A197583Inst Instance=new A197583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197584
{
public static readonly long[] Value={ 4L,5L,0L,4L,5L,7L,4L,9L,4L,1L,3L,6L,7L,2L,8L,7L,6L,5L,2L,0L,5L,1L,8L,4L,1L,7L,8L,8L,6L,5L,8L,8L,3L,4L,4L,7L,1L,4L,0L,9L,5L,4L,3L,3L,5L,9L,2L,1L,7L,0L,2L,3L,3L,7L,6L,9L,1L,5L,4L,9L,8L,3L,2L,7L,8L,1L,0L,0L,9L,0L,1L,3L,3L,8L,6L,6L,3L,5L,0L,2L,5L,2L,8L,5L,5L,1L,7L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197584Inst : IEnumerable<long>
{
public static readonly long[] Value=A197584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197584.Bytes);
public long this[int i]=>Value[i];

public static A197584Inst Instance=new A197584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197585
{
public static readonly long[] Value={ 4L,6L,7L,4L,5L,6L,3L,7L,6L,3L,3L,3L,3L,5L,8L,1L,6L,7L,5L,0L,9L,6L,3L,7L,3L,3L,8L,0L,1L,6L,9L,4L,6L,7L,0L,5L,9L,7L,5L,0L,8L,5L,9L,6L,6L,4L,0L,8L,8L,4L,0L,9L,3L,6L,3L,9L,4L,4L,0L,1L,1L,2L,8L,3L,5L,1L,6L,4L,6L,2L,4L,2L,5L,7L,1L,7L,0L,2L,2L,5L,2L,8L,4L,3L,2L,4L,7L,6L,5L,9L,1L,0L,7L,4L,6L,8L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197585Inst : IEnumerable<long>
{
public static readonly long[] Value=A197585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197585.Bytes);
public long this[int i]=>Value[i];

public static A197585Inst Instance=new A197585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197586
{
public static readonly long[] Value={ 3L,2L,2L,6L,4L,7L,7L,6L,3L,7L,7L,3L,4L,2L,4L,5L,9L,2L,6L,8L,1L,3L,8L,9L,6L,3L,4L,5L,6L,9L,9L,0L,8L,0L,9L,6L,5L,6L,1L,4L,9L,7L,0L,7L,3L,3L,5L,5L,0L,9L,3L,5L,7L,2L,3L,5L,6L,8L,7L,3L,3L,1L,4L,7L,4L,6L,2L,0L,8L,2L,0L,4L,1L,8L,1L,6L,7L,0L,3L,1L,6L,7L,3L,1L,3L,9L,0L,3L,7L,4L,6L,7L,0L,1L,3L,1L,1L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197586Inst : IEnumerable<long>
{
public static readonly long[] Value=A197586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197586.Bytes);
public long this[int i]=>Value[i];

public static A197586Inst Instance=new A197586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197587
{
public static readonly long[] Value={ 2L,4L,5L,3L,0L,4L,0L,5L,4L,5L,2L,7L,4L,1L,1L,3L,9L,3L,8L,3L,9L,2L,8L,2L,0L,9L,4L,8L,6L,9L,0L,9L,5L,6L,4L,3L,1L,9L,0L,5L,8L,0L,0L,5L,6L,6L,2L,5L,6L,7L,5L,0L,2L,8L,8L,9L,6L,1L,9L,6L,5L,5L,0L,2L,3L,3L,8L,7L,6L,1L,4L,7L,3L,4L,0L,0L,0L,3L,7L,0L,8L,9L,0L,9L,1L,0L,1L,4L,4L,9L,0L,2L,2L,2L,5L,3L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197587Inst : IEnumerable<long>
{
public static readonly long[] Value=A197587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197587.Bytes);
public long this[int i]=>Value[i];

public static A197587Inst Instance=new A197587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197588
{
public static readonly long[] Value={ 1L,7L,6L,9L,8L,0L,0L,3L,5L,8L,9L,1L,9L,5L,0L,1L,0L,1L,9L,3L,4L,5L,5L,3L,1L,7L,0L,7L,3L,3L,5L,9L,4L,3L,2L,7L,4L,1L,9L,6L,8L,0L,2L,3L,3L,5L,0L,2L,6L,8L,3L,5L,8L,3L,4L,6L,9L,1L,4L,6L,9L,7L,6L,8L,6L,4L,5L,3L,0L,3L,5L,6L,3L,0L,7L,0L,5L,7L,7L,7L,9L,4L,2L,5L,8L,2L,8L,7L,1L,9L,4L,1L,1L,4L,3L,3L,2L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197588Inst : IEnumerable<long>
{
public static readonly long[] Value=A197588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197588.Bytes);
public long this[int i]=>Value[i];

public static A197588Inst Instance=new A197588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197589
{
public static readonly long[] Value={ 1L,1L,2L,8L,6L,8L,0L,1L,9L,4L,3L,3L,7L,7L,5L,2L,8L,4L,4L,7L,0L,0L,6L,0L,4L,9L,8L,4L,5L,3L,3L,4L,6L,2L,9L,4L,7L,2L,6L,0L,9L,5L,3L,6L,4L,3L,8L,6L,6L,8L,3L,8L,6L,0L,6L,0L,5L,8L,6L,9L,2L,8L,2L,5L,2L,1L,7L,5L,0L,0L,0L,9L,6L,6L,8L,2L,8L,9L,4L,5L,0L,2L,1L,9L,3L,6L,8L,6L,5L,1L,3L,0L,4L,5L,7L,2L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197589Inst : IEnumerable<long>
{
public static readonly long[] Value=A197589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197589.Bytes);
public long this[int i]=>Value[i];

public static A197589Inst Instance=new A197589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197590
{
public static readonly long[] Value={ 8L,1L,4L,2L,8L,5L,4L,4L,8L,4L,2L,0L,5L,4L,3L,4L,1L,5L,2L,5L,3L,1L,7L,6L,8L,6L,6L,7L,6L,5L,4L,8L,7L,8L,5L,1L,5L,3L,3L,7L,7L,3L,4L,7L,4L,0L,3L,7L,2L,8L,5L,7L,4L,7L,1L,8L,1L,7L,8L,5L,3L,7L,8L,1L,2L,6L,5L,7L,5L,0L,9L,4L,6L,7L,4L,2L,8L,9L,0L,9L,6L,2L,3L,3L,0L,5L,8L,9L,9L,0L,8L,8L,0L,1L,2L,0L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197590Inst : IEnumerable<long>
{
public static readonly long[] Value=A197590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197590.Bytes);
public long this[int i]=>Value[i];

public static A197590Inst Instance=new A197590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197591
{
public static readonly long[] Value={ 1L,2L,2L,5L,3L,0L,5L,4L,5L,4L,2L,4L,0L,3L,8L,1L,0L,3L,6L,4L,5L,0L,2L,8L,0L,1L,5L,6L,0L,8L,1L,7L,4L,7L,9L,1L,7L,8L,5L,7L,6L,4L,2L,6L,5L,6L,0L,4L,2L,2L,2L,1L,8L,8L,0L,4L,5L,0L,8L,0L,7L,3L,7L,9L,3L,0L,0L,7L,4L,3L,7L,7L,1L,4L,4L,9L,4L,2L,6L,8L,2L,8L,2L,5L,1L,7L,5L,3L,0L,1L,0L,4L,3L,6L,4L,5L,0L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197591Inst : IEnumerable<long>
{
public static readonly long[] Value=A197591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197591.Bytes);
public long this[int i]=>Value[i];

public static A197591Inst Instance=new A197591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197592
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,5L,1L,9L,0L,4L,0L,0L,1L,8L,9L,3L,4L,2L,9L,1L,4L,8L,9L,8L,9L,2L,0L,7L,9L,8L,3L,6L,6L,4L,2L,2L,6L,1L,6L,0L,7L,6L,2L,9L,3L,3L,9L,8L,4L,5L,1L,2L,5L,5L,1L,1L,1L,2L,1L,8L,8L,2L,5L,6L,0L,4L,5L,3L,0L,8L,2L,9L,9L,6L,8L,5L,5L,4L,0L,0L,6L,4L,8L,0L,3L,8L,7L,0L,4L,2L,9L,2L,9L,6L,7L,5L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197592Inst : IEnumerable<long>
{
public static readonly long[] Value=A197592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197592.Bytes);
public long this[int i]=>Value[i];

public static A197592Inst Instance=new A197592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197593
{
public static readonly long[] Value={ 1L,1L,4L,18L,98L,1460L,35691L,1385653L,113578137L,17175107452L,4747357788947L,2462207136693903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197593Inst : IEnumerable<long>
{
public static readonly long[] Value=A197593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197593.Bytes);
public long this[int i]=>Value[i];

public static A197593Inst Instance=new A197593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197594
{
public static readonly BigInteger[] Value={ 3L,7L,15L,127L,511L,1023L,65535L,2147483647L,35184372088831L,18014398509481983L,18446744073709551615UL,BigInteger.Parse("3705346855594118253554271520278013051304639509300498049262642688253220148477951") };
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
public class A197594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197594Inst Instance=new A197594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197595
{
public static readonly BigInteger[] Value={ 7L,156L,6162L,345817L,25120872L,2237952687L,236084694122L,28771727614749L,3977205817386552L,614815375624938276L,BigInteger.Parse("105089416995538138497"),BigInteger.Parse("19679693805738843682350"),BigInteger.Parse("4006775128162674717660621"),BigInteger.Parse("881207085092349552894218729"),BigInteger.Parse("208190711541113653367733416163") };
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
public class A197595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197595Inst Instance=new A197595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197596
{
public static readonly BigInteger[] Value={ 8L,210L,9709L,636903L,54039748L,5621026396L,692186010834L,98457959756722L,15883727818630151L,2865366503771469410L,BigInteger.Parse("571524481184700575469"),BigInteger.Parse("124887520213444076248619"),BigInteger.Parse("29669385469799155774434098"),BigInteger.Parse("7613687050766411443598268998") };
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
public class A197596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197596Inst Instance=new A197596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197597
{
public static readonly BigInteger[] Value={ 9L,272L,14408L,1081730L,104985728L,12487616538L,1758172862979L,285903205720512L,52725376090628155L,10872393464815690143UL,BigInteger.Parse("2478802987043990078456"),BigInteger.Parse("619122710473385614426209"),BigInteger.Parse("168115507427305189329095427"),BigInteger.Parse("49309285630177314887251611600") };
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
public class A197597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197597Inst Instance=new A197597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197598
{
public static readonly BigInteger[] Value={ 10L,342L,20421L,1726760L,188665362L,25257633873L,4001931082417L,732295911309956L,151957855559538858L,BigInteger.Parse("35257207352182955134"),BigInteger.Parse("9044237131202445725077"),BigInteger.Parse("2541585712463861383036826"),BigInteger.Parse("776473970630759909605090447"),BigInteger.Parse("256232041409079180707274204957") };
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
public class A197598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197598Inst Instance=new A197598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197599
{
public static readonly BigInteger[] Value={ 11L,420L,27910L,2624602L,318800200L,47439020041L,8353801755006L,1698808167100875L,391746480089540115L,BigInteger.Parse("101004512021025221012"),BigInteger.Parse("28791615763253886202480"),BigInteger.Parse("8990685731188213404550238"),BigInteger.Parse("3052132045866636492112058599"),BigInteger.Parse("1119164206256115117485135326641"),BigInteger.Parse("440822282742124422495281791483358") };
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
public class A197599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197599Inst Instance=new A197599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197600
{
public static readonly BigInteger[] Value={ 12L,506L,37037L,3834008L,512501792L,83914215402L,16258109291002L,3637416562713075L,922786228220640101L,BigInteger.Parse("261741863272493596614"),BigInteger.Parse("82078032321730681299097"),BigInteger.Parse("28195269239973685901676782"),BigInteger.Parse("10529425953839699619063326835"),BigInteger.Parse("4247266693140960691762845677068") };
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
public class A197600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197600Inst Instance=new A197600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197601
{
public static readonly long[] Value={ 1L,1L,5L,14L,52L,187L,708L,2734L,10758L,43004L,174004L,711660L,2936564L,12211688L,51124185L,215299685L,911445413L,3876523626L,16556573129L,70980163570L,305343924258L,1317634326631L,5702146948069L,24741071869651L,107608326588838L,469073933764287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197601Inst : IEnumerable<long>
{
public static readonly long[] Value=A197601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197601.Bytes);
public long this[int i]=>Value[i];

public static A197601Inst Instance=new A197601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197602
{
public static readonly long[] Value={ 8L,15L,37L,76L,140L,234L,364L,536L,756L,1030L,1364L,1764L,2236L,2786L,3420L,4144L,4964L,5886L,6916L,8060L,9324L,10714L,12236L,13896L,15700L,17654L,19764L,22036L,24476L,27090L,29884L,32864L,36036L,39406L,42980L,46764L,50764L,54986L,59436L,64120L,69044L,74214L,79636L,85316L,91260L,97474L,103964L,110736L,117796L,125150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197602Inst : IEnumerable<long>
{
public static readonly long[] Value=A197602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197602.Bytes);
public long this[int i]=>Value[i];

public static A197602Inst Instance=new A197602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197603
{
public static readonly long[] Value={ 16L,39L,123L,326L,731L,1446L,2603L,4358L,6891L,10406L,15131L,21318L,29243L,39206L,51531L,66566L,84683L,106278L,131771L,161606L,196251L,236198L,281963L,334086L,393131L,459686L,534363L,617798L,710651L,813606L,927371L,1052678L,1190283L,1340966L,1505531L,1684806L,1879643L,2090918L,2319531L,2566406L,2832491L,3118758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197603Inst : IEnumerable<long>
{
public static readonly long[] Value=A197603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197603.Bytes);
public long this[int i]=>Value[i];

public static A197603Inst Instance=new A197603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197604
{
public static readonly long[] Value={ 32L,97L,411L,1386L,3802L,8917L,18593L,35409L,62785L,105101L,167816L,257592L,382408L,551684L,776400L,1069216L,1444592L,1918908L,2510584L,3240200L,4130616L,5207092L,6497408L,8031984L,9844000L,11969516L,14447592L,17320408L,20633384L,24435300L,28778416L,33718592L,39315408L,45632284L,52736600L,60699816L,69597592L,79509908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197604Inst : IEnumerable<long>
{
public static readonly long[] Value=A197604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197604.Bytes);
public long this[int i]=>Value[i];

public static A197604Inst Instance=new A197604Inst();

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