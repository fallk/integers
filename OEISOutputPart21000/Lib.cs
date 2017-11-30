using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040516
{
public static readonly long[] Value={ 23L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040516Inst : IEnumerable<long>
{
public static readonly long[] Value=A040516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040516.Bytes);
public long this[int i]=>Value[i];

public static A040516Inst Instance=new A040516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040515
{
public static readonly long[] Value={ 23L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040515Inst : IEnumerable<long>
{
public static readonly long[] Value=A040515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040515.Bytes);
public long this[int i]=>Value[i];

public static A040515Inst Instance=new A040515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040514
{
public static readonly long[] Value={ 23L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040514Inst : IEnumerable<long>
{
public static readonly long[] Value=A040514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040514.Bytes);
public long this[int i]=>Value[i];

public static A040514Inst Instance=new A040514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040513
{
public static readonly long[] Value={ 23L,5L,1L,3L,2L,1L,1L,1L,2L,1L,14L,1L,2L,1L,1L,1L,2L,3L,1L,5L,46L,5L,1L,3L,2L,1L,1L,1L,2L,1L,14L,1L,2L,1L,1L,1L,2L,3L,1L,5L,46L,5L,1L,3L,2L,1L,1L,1L,2L,1L,14L,1L,2L,1L,1L,1L,2L,3L,1L,5L,46L,5L,1L,3L,2L,1L,1L,1L,2L,1L,14L,1L,2L,1L,1L,1L,2L,3L,1L,5L,46L,5L,1L,3L,2L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040513Inst : IEnumerable<long>
{
public static readonly long[] Value=A040513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040513.Bytes);
public long this[int i]=>Value[i];

public static A040513Inst Instance=new A040513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040512
{
public static readonly long[] Value={ 23L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040512Inst : IEnumerable<long>
{
public static readonly long[] Value=A040512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040512.Bytes);
public long this[int i]=>Value[i];

public static A040512Inst Instance=new A040512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040511
{
public static readonly long[] Value={ 23L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040511Inst : IEnumerable<long>
{
public static readonly long[] Value=A040511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040511.Bytes);
public long this[int i]=>Value[i];

public static A040511Inst Instance=new A040511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040510
{
public static readonly long[] Value={ 23L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040510Inst : IEnumerable<long>
{
public static readonly long[] Value=A040510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040510.Bytes);
public long this[int i]=>Value[i];

public static A040510Inst Instance=new A040510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040509
{
public static readonly long[] Value={ 23L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040509Inst : IEnumerable<long>
{
public static readonly long[] Value=A040509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040509.Bytes);
public long this[int i]=>Value[i];

public static A040509Inst Instance=new A040509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040492
{
public static readonly long[] Value={ 22L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040492Inst : IEnumerable<long>
{
public static readonly long[] Value=A040492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040492.Bytes);
public long this[int i]=>Value[i];

public static A040492Inst Instance=new A040492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040491
{
public static readonly long[] Value={ 22L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040491Inst : IEnumerable<long>
{
public static readonly long[] Value=A040491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040491.Bytes);
public long this[int i]=>Value[i];

public static A040491Inst Instance=new A040491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040490
{
public static readonly long[] Value={ 22L,1L,1L,1L,5L,1L,4L,5L,2L,5L,4L,1L,5L,1L,1L,1L,44L,1L,1L,1L,5L,1L,4L,5L,2L,5L,4L,1L,5L,1L,1L,1L,44L,1L,1L,1L,5L,1L,4L,5L,2L,5L,4L,1L,5L,1L,1L,1L,44L,1L,1L,1L,5L,1L,4L,5L,2L,5L,4L,1L,5L,1L,1L,1L,44L,1L,1L,1L,5L,1L,4L,5L,2L,5L,4L,1L,5L,1L,1L,1L,44L,1L,1L,1L,5L,1L,4L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040490Inst : IEnumerable<long>
{
public static readonly long[] Value=A040490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040490.Bytes);
public long this[int i]=>Value[i];

public static A040490Inst Instance=new A040490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040489
{
public static readonly long[] Value={ 22L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040489Inst : IEnumerable<long>
{
public static readonly long[] Value=A040489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040489.Bytes);
public long this[int i]=>Value[i];

public static A040489Inst Instance=new A040489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040488
{
public static readonly long[] Value={ 22L,1L,1L,1L,1L,6L,1L,14L,4L,1L,21L,1L,4L,14L,1L,6L,1L,1L,1L,1L,44L,1L,1L,1L,1L,6L,1L,14L,4L,1L,21L,1L,4L,14L,1L,6L,1L,1L,1L,1L,44L,1L,1L,1L,1L,6L,1L,14L,4L,1L,21L,1L,4L,14L,1L,6L,1L,1L,1L,1L,44L,1L,1L,1L,1L,6L,1L,14L,4L,1L,21L,1L,4L,14L,1L,6L,1L,1L,1L,1L,44L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040488Inst : IEnumerable<long>
{
public static readonly long[] Value=A040488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040488.Bytes);
public long this[int i]=>Value[i];

public static A040488Inst Instance=new A040488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040487
{
public static readonly long[] Value={ 22L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040487Inst : IEnumerable<long>
{
public static readonly long[] Value=A040487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040487.Bytes);
public long this[int i]=>Value[i];

public static A040487Inst Instance=new A040487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040486
{
public static readonly long[] Value={ 22L,1L,1L,3L,1L,1L,2L,10L,1L,8L,8L,1L,10L,2L,1L,1L,3L,1L,1L,44L,1L,1L,3L,1L,1L,2L,10L,1L,8L,8L,1L,10L,2L,1L,1L,3L,1L,1L,44L,1L,1L,3L,1L,1L,2L,10L,1L,8L,8L,1L,10L,2L,1L,1L,3L,1L,1L,44L,1L,1L,3L,1L,1L,2L,10L,1L,8L,8L,1L,10L,2L,1L,1L,3L,1L,1L,44L,1L,1L,3L,1L,1L,2L,10L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040486Inst : IEnumerable<long>
{
public static readonly long[] Value=A040486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040486.Bytes);
public long this[int i]=>Value[i];

public static A040486Inst Instance=new A040486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040485
{
public static readonly long[] Value={ 22L,1L,1L,5L,1L,14L,5L,1L,1L,3L,4L,1L,2L,1L,1L,1L,10L,1L,1L,1L,2L,1L,4L,3L,1L,1L,5L,14L,1L,5L,1L,1L,44L,1L,1L,5L,1L,14L,5L,1L,1L,3L,4L,1L,2L,1L,1L,1L,10L,1L,1L,1L,2L,1L,4L,3L,1L,1L,5L,14L,1L,5L,1L,1L,44L,1L,1L,5L,1L,14L,5L,1L,1L,3L,4L,1L,2L,1L,1L,1L,10L,1L,1L,1L,2L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040485Inst : IEnumerable<long>
{
public static readonly long[] Value=A040485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040485.Bytes);
public long this[int i]=>Value[i];

public static A040485Inst Instance=new A040485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040484
{
public static readonly long[] Value={ 22L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040484Inst : IEnumerable<long>
{
public static readonly long[] Value=A040484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040484.Bytes);
public long this[int i]=>Value[i];

public static A040484Inst Instance=new A040484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040483
{
public static readonly long[] Value={ 22L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040483Inst : IEnumerable<long>
{
public static readonly long[] Value=A040483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040483.Bytes);
public long this[int i]=>Value[i];

public static A040483Inst Instance=new A040483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040482
{
public static readonly long[] Value={ 22L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040482Inst : IEnumerable<long>
{
public static readonly long[] Value=A040482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040482.Bytes);
public long this[int i]=>Value[i];

public static A040482Inst Instance=new A040482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040481
{
public static readonly long[] Value={ 22L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040481Inst : IEnumerable<long>
{
public static readonly long[] Value=A040481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040481.Bytes);
public long this[int i]=>Value[i];

public static A040481Inst Instance=new A040481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040480
{
public static readonly long[] Value={ 22L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040480Inst : IEnumerable<long>
{
public static readonly long[] Value=A040480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040480.Bytes);
public long this[int i]=>Value[i];

public static A040480Inst Instance=new A040480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040479
{
public static readonly long[] Value={ 22L,2L,2L,7L,14L,1L,4L,22L,4L,1L,14L,7L,2L,2L,44L,2L,2L,7L,14L,1L,4L,22L,4L,1L,14L,7L,2L,2L,44L,2L,2L,7L,14L,1L,4L,22L,4L,1L,14L,7L,2L,2L,44L,2L,2L,7L,14L,1L,4L,22L,4L,1L,14L,7L,2L,2L,44L,2L,2L,7L,14L,1L,4L,22L,4L,1L,14L,7L,2L,2L,44L,2L,2L,7L,14L,1L,4L,22L,4L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040479Inst : IEnumerable<long>
{
public static readonly long[] Value=A040479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040479.Bytes);
public long this[int i]=>Value[i];

public static A040479Inst Instance=new A040479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040478
{
public static readonly long[] Value={ 22L,2L,1L,1L,1L,1L,3L,8L,1L,2L,10L,1L,5L,2L,14L,2L,5L,1L,10L,2L,1L,8L,3L,1L,1L,1L,1L,2L,44L,2L,1L,1L,1L,1L,3L,8L,1L,2L,10L,1L,5L,2L,14L,2L,5L,1L,10L,2L,1L,8L,3L,1L,1L,1L,1L,2L,44L,2L,1L,1L,1L,1L,3L,8L,1L,2L,10L,1L,5L,2L,14L,2L,5L,1L,10L,2L,1L,8L,3L,1L,1L,1L,1L,2L,44L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040478Inst : IEnumerable<long>
{
public static readonly long[] Value=A040478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040478.Bytes);
public long this[int i]=>Value[i];

public static A040478Inst Instance=new A040478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040477
{
public static readonly long[] Value={ 22L,2L,1L,3L,2L,1L,1L,10L,1L,1L,2L,3L,1L,2L,44L,2L,1L,3L,2L,1L,1L,10L,1L,1L,2L,3L,1L,2L,44L,2L,1L,3L,2L,1L,1L,10L,1L,1L,2L,3L,1L,2L,44L,2L,1L,3L,2L,1L,1L,10L,1L,1L,2L,3L,1L,2L,44L,2L,1L,3L,2L,1L,1L,10L,1L,1L,2L,3L,1L,2L,44L,2L,1L,3L,2L,1L,1L,10L,1L,1L,2L,3L,1L,2L,44L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040477Inst : IEnumerable<long>
{
public static readonly long[] Value=A040477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040477.Bytes);
public long this[int i]=>Value[i];

public static A040477Inst Instance=new A040477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040460
{
public static readonly long[] Value={ 21L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040460Inst : IEnumerable<long>
{
public static readonly long[] Value=A040460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040460.Bytes);
public long this[int i]=>Value[i];

public static A040460Inst Instance=new A040460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040459
{
public static readonly long[] Value={ 21L,1L,13L,1L,1L,1L,4L,4L,1L,1L,1L,13L,1L,42L,1L,13L,1L,1L,1L,4L,4L,1L,1L,1L,13L,1L,42L,1L,13L,1L,1L,1L,4L,4L,1L,1L,1L,13L,1L,42L,1L,13L,1L,1L,1L,4L,4L,1L,1L,1L,13L,1L,42L,1L,13L,1L,1L,1L,4L,4L,1L,1L,1L,13L,1L,42L,1L,13L,1L,1L,1L,4L,4L,1L,1L,1L,13L,1L,42L,1L,13L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040459Inst : IEnumerable<long>
{
public static readonly long[] Value=A040459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040459.Bytes);
public long this[int i]=>Value[i];

public static A040459Inst Instance=new A040459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040458
{
public static readonly long[] Value={ 21L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040458Inst : IEnumerable<long>
{
public static readonly long[] Value=A040458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040458.Bytes);
public long this[int i]=>Value[i];

public static A040458Inst Instance=new A040458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040457
{
public static readonly long[] Value={ 21L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040457Inst : IEnumerable<long>
{
public static readonly long[] Value=A040457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040457.Bytes);
public long this[int i]=>Value[i];

public static A040457Inst Instance=new A040457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040456
{
public static readonly long[] Value={ 21L,1L,6L,3L,4L,1L,1L,5L,1L,2L,3L,1L,1L,1L,1L,1L,13L,1L,20L,1L,13L,1L,1L,1L,1L,1L,3L,2L,1L,5L,1L,1L,4L,3L,6L,1L,42L,1L,6L,3L,4L,1L,1L,5L,1L,2L,3L,1L,1L,1L,1L,1L,13L,1L,20L,1L,13L,1L,1L,1L,1L,1L,3L,2L,1L,5L,1L,1L,4L,3L,6L,1L,42L,1L,6L,3L,4L,1L,1L,5L,1L,2L,3L,1L,1L,1L,1L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040456Inst : IEnumerable<long>
{
public static readonly long[] Value=A040456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040456.Bytes);
public long this[int i]=>Value[i];

public static A040456Inst Instance=new A040456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040455
{
public static readonly long[] Value={ 21L,1L,5L,3L,1L,4L,10L,1L,2L,2L,4L,2L,2L,1L,10L,4L,1L,3L,5L,1L,42L,1L,5L,3L,1L,4L,10L,1L,2L,2L,4L,2L,2L,1L,10L,4L,1L,3L,5L,1L,42L,1L,5L,3L,1L,4L,10L,1L,2L,2L,4L,2L,2L,1L,10L,4L,1L,3L,5L,1L,42L,1L,5L,3L,1L,4L,10L,1L,2L,2L,4L,2L,2L,1L,10L,4L,1L,3L,5L,1L,42L,1L,5L,3L,1L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040455Inst : IEnumerable<long>
{
public static readonly long[] Value=A040455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040455.Bytes);
public long this[int i]=>Value[i];

public static A040455Inst Instance=new A040455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040454
{
public static readonly long[] Value={ 21L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040454Inst : IEnumerable<long>
{
public static readonly long[] Value=A040454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040454.Bytes);
public long this[int i]=>Value[i];

public static A040454Inst Instance=new A040454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040453
{
public static readonly long[] Value={ 21L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040453Inst : IEnumerable<long>
{
public static readonly long[] Value=A040453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040453.Bytes);
public long this[int i]=>Value[i];

public static A040453Inst Instance=new A040453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040452
{
public static readonly long[] Value={ 21L,1L,3L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,42L,1L,3L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,42L,1L,3L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,42L,1L,3L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,42L,1L,3L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,42L,1L,3L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,42L,1L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040452Inst : IEnumerable<long>
{
public static readonly long[] Value=A040452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040452.Bytes);
public long this[int i]=>Value[i];

public static A040452Inst Instance=new A040452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040451
{
public static readonly long[] Value={ 21L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040451Inst : IEnumerable<long>
{
public static readonly long[] Value=A040451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040451.Bytes);
public long this[int i]=>Value[i];

public static A040451Inst Instance=new A040451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040450
{
public static readonly long[] Value={ 21L,1L,2L,1L,1L,1L,4L,5L,4L,1L,1L,1L,2L,1L,42L,1L,2L,1L,1L,1L,4L,5L,4L,1L,1L,1L,2L,1L,42L,1L,2L,1L,1L,1L,4L,5L,4L,1L,1L,1L,2L,1L,42L,1L,2L,1L,1L,1L,4L,5L,4L,1L,1L,1L,2L,1L,42L,1L,2L,1L,1L,1L,4L,5L,4L,1L,1L,1L,2L,1L,42L,1L,2L,1L,1L,1L,4L,5L,4L,1L,1L,1L,2L,1L,42L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040450Inst : IEnumerable<long>
{
public static readonly long[] Value=A040450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040450.Bytes);
public long this[int i]=>Value[i];

public static A040450Inst Instance=new A040450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040449
{
public static readonly long[] Value={ 21L,1L,2L,2L,1L,3L,4L,14L,4L,3L,1L,2L,2L,1L,42L,1L,2L,2L,1L,3L,4L,14L,4L,3L,1L,2L,2L,1L,42L,1L,2L,2L,1L,3L,4L,14L,4L,3L,1L,2L,2L,1L,42L,1L,2L,2L,1L,3L,4L,14L,4L,3L,1L,2L,2L,1L,42L,1L,2L,2L,1L,3L,4L,14L,4L,3L,1L,2L,2L,1L,42L,1L,2L,2L,1L,3L,4L,14L,4L,3L,1L,2L,2L,1L,42L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040449Inst : IEnumerable<long>
{
public static readonly long[] Value=A040449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040449.Bytes);
public long this[int i]=>Value[i];

public static A040449Inst Instance=new A040449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040448
{
public static readonly long[] Value={ 21L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040448Inst : IEnumerable<long>
{
public static readonly long[] Value=A040448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040448.Bytes);
public long this[int i]=>Value[i];

public static A040448Inst Instance=new A040448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040447
{
public static readonly long[] Value={ 21L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040447Inst : IEnumerable<long>
{
public static readonly long[] Value=A040447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040447.Bytes);
public long this[int i]=>Value[i];

public static A040447Inst Instance=new A040447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040446
{
public static readonly long[] Value={ 21L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040446Inst : IEnumerable<long>
{
public static readonly long[] Value=A040446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040446.Bytes);
public long this[int i]=>Value[i];

public static A040446Inst Instance=new A040446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040445
{
public static readonly long[] Value={ 21L,1L,1L,1L,1L,3L,3L,21L,3L,3L,1L,1L,1L,1L,42L,1L,1L,1L,1L,3L,3L,21L,3L,3L,1L,1L,1L,1L,42L,1L,1L,1L,1L,3L,3L,21L,3L,3L,1L,1L,1L,1L,42L,1L,1L,1L,1L,3L,3L,21L,3L,3L,1L,1L,1L,1L,42L,1L,1L,1L,1L,3L,3L,21L,3L,3L,1L,1L,1L,1L,42L,1L,1L,1L,1L,3L,3L,21L,3L,3L,1L,1L,1L,1L,42L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040445Inst : IEnumerable<long>
{
public static readonly long[] Value=A040445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040445.Bytes);
public long this[int i]=>Value[i];

public static A040445Inst Instance=new A040445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040412
{
public static readonly long[] Value={ 20L,1L,4L,4L,2L,2L,1L,3L,13L,1L,1L,1L,1L,13L,3L,1L,2L,2L,4L,4L,1L,40L,1L,4L,4L,2L,2L,1L,3L,13L,1L,1L,1L,1L,13L,3L,1L,2L,2L,4L,4L,1L,40L,1L,4L,4L,2L,2L,1L,3L,13L,1L,1L,1L,1L,13L,3L,1L,2L,2L,4L,4L,1L,40L,1L,4L,4L,2L,2L,1L,3L,13L,1L,1L,1L,1L,13L,3L,1L,2L,2L,4L,4L,1L,40L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040412Inst : IEnumerable<long>
{
public static readonly long[] Value=A040412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040412.Bytes);
public long this[int i]=>Value[i];

public static A040412Inst Instance=new A040412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040411
{
public static readonly long[] Value={ 20L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040411Inst : IEnumerable<long>
{
public static readonly long[] Value=A040411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040411.Bytes);
public long this[int i]=>Value[i];

public static A040411Inst Instance=new A040411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040410
{
public static readonly long[] Value={ 20L,1L,3L,5L,1L,2L,7L,1L,19L,1L,7L,2L,1L,5L,3L,1L,40L,1L,3L,5L,1L,2L,7L,1L,19L,1L,7L,2L,1L,5L,3L,1L,40L,1L,3L,5L,1L,2L,7L,1L,19L,1L,7L,2L,1L,5L,3L,1L,40L,1L,3L,5L,1L,2L,7L,1L,19L,1L,7L,2L,1L,5L,3L,1L,40L,1L,3L,5L,1L,2L,7L,1L,19L,1L,7L,2L,1L,5L,3L,1L,40L,1L,3L,5L,1L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040410Inst : IEnumerable<long>
{
public static readonly long[] Value=A040410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040410.Bytes);
public long this[int i]=>Value[i];

public static A040410Inst Instance=new A040410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040409
{
public static readonly long[] Value={ 20L,1L,2L,1L,3L,1L,6L,8L,6L,1L,3L,1L,2L,1L,40L,1L,2L,1L,3L,1L,6L,8L,6L,1L,3L,1L,2L,1L,40L,1L,2L,1L,3L,1L,6L,8L,6L,1L,3L,1L,2L,1L,40L,1L,2L,1L,3L,1L,6L,8L,6L,1L,3L,1L,2L,1L,40L,1L,2L,1L,3L,1L,6L,8L,6L,1L,3L,1L,2L,1L,40L,1L,2L,1L,3L,1L,6L,8L,6L,1L,3L,1L,2L,1L,40L,1L,2L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040409Inst : IEnumerable<long>
{
public static readonly long[] Value=A040409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040409.Bytes);
public long this[int i]=>Value[i];

public static A040409Inst Instance=new A040409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040408
{
public static readonly long[] Value={ 20L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040408Inst : IEnumerable<long>
{
public static readonly long[] Value=A040408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040408.Bytes);
public long this[int i]=>Value[i];

public static A040408Inst Instance=new A040408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040407
{
public static readonly long[] Value={ 20L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040407Inst : IEnumerable<long>
{
public static readonly long[] Value=A040407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040407.Bytes);
public long this[int i]=>Value[i];

public static A040407Inst Instance=new A040407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040406
{
public static readonly long[] Value={ 20L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040406Inst : IEnumerable<long>
{
public static readonly long[] Value=A040406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040406.Bytes);
public long this[int i]=>Value[i];

public static A040406Inst Instance=new A040406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040405
{
public static readonly long[] Value={ 20L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040405Inst : IEnumerable<long>
{
public static readonly long[] Value=A040405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040405.Bytes);
public long this[int i]=>Value[i];

public static A040405Inst Instance=new A040405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040404
{
public static readonly long[] Value={ 20L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040404Inst : IEnumerable<long>
{
public static readonly long[] Value=A040404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040404.Bytes);
public long this[int i]=>Value[i];

public static A040404Inst Instance=new A040404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040403
{
public static readonly long[] Value={ 20L,1L,1L,2L,4L,5L,1L,1L,1L,9L,1L,1L,1L,5L,4L,2L,1L,1L,40L,1L,1L,2L,4L,5L,1L,1L,1L,9L,1L,1L,1L,5L,4L,2L,1L,1L,40L,1L,1L,2L,4L,5L,1L,1L,1L,9L,1L,1L,1L,5L,4L,2L,1L,1L,40L,1L,1L,2L,4L,5L,1L,1L,1L,9L,1L,1L,1L,5L,4L,2L,1L,1L,40L,1L,1L,2L,4L,5L,1L,1L,1L,9L,1L,1L,1L,5L,4L,2L,1L,1L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040403Inst : IEnumerable<long>
{
public static readonly long[] Value=A040403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040403.Bytes);
public long this[int i]=>Value[i];

public static A040403Inst Instance=new A040403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040402
{
public static readonly long[] Value={ 20L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040402Inst : IEnumerable<long>
{
public static readonly long[] Value=A040402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040402.Bytes);
public long this[int i]=>Value[i];

public static A040402Inst Instance=new A040402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040401
{
public static readonly long[] Value={ 20L,1L,1L,5L,2L,1L,3L,20L,3L,1L,2L,5L,1L,1L,40L,1L,1L,5L,2L,1L,3L,20L,3L,1L,2L,5L,1L,1L,40L,1L,1L,5L,2L,1L,3L,20L,3L,1L,2L,5L,1L,1L,40L,1L,1L,5L,2L,1L,3L,20L,3L,1L,2L,5L,1L,1L,40L,1L,1L,5L,2L,1L,3L,20L,3L,1L,2L,5L,1L,1L,40L,1L,1L,5L,2L,1L,3L,20L,3L,1L,2L,5L,1L,1L,40L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040401Inst : IEnumerable<long>
{
public static readonly long[] Value=A040401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040401.Bytes);
public long this[int i]=>Value[i];

public static A040401Inst Instance=new A040401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040400
{
public static readonly long[] Value={ 20L,1L,1L,13L,5L,1L,3L,1L,2L,1L,1L,1L,2L,9L,1L,7L,3L,3L,2L,2L,3L,3L,7L,1L,9L,2L,1L,1L,1L,2L,1L,3L,1L,5L,13L,1L,1L,40L,1L,1L,13L,5L,1L,3L,1L,2L,1L,1L,1L,2L,9L,1L,7L,3L,3L,2L,2L,3L,3L,7L,1L,9L,2L,1L,1L,1L,2L,1L,3L,1L,5L,13L,1L,1L,40L,1L,1L,13L,5L,1L,3L,1L,2L,1L,1L,1L,2L,9L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040400Inst : IEnumerable<long>
{
public static readonly long[] Value=A040400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040400.Bytes);
public long this[int i]=>Value[i];

public static A040400Inst Instance=new A040400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040399
{
public static readonly long[] Value={ 20L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040399Inst : IEnumerable<long>
{
public static readonly long[] Value=A040399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040399.Bytes);
public long this[int i]=>Value[i];

public static A040399Inst Instance=new A040399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040398
{
public static readonly long[] Value={ 20L,2L,7L,1L,2L,3L,1L,2L,1L,19L,1L,2L,1L,3L,2L,1L,7L,2L,40L,2L,7L,1L,2L,3L,1L,2L,1L,19L,1L,2L,1L,3L,2L,1L,7L,2L,40L,2L,7L,1L,2L,3L,1L,2L,1L,19L,1L,2L,1L,3L,2L,1L,7L,2L,40L,2L,7L,1L,2L,3L,1L,2L,1L,19L,1L,2L,1L,3L,2L,1L,7L,2L,40L,2L,7L,1L,2L,3L,1L,2L,1L,19L,1L,2L,1L,3L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040398Inst : IEnumerable<long>
{
public static readonly long[] Value=A040398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040398.Bytes);
public long this[int i]=>Value[i];

public static A040398Inst Instance=new A040398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040397
{
public static readonly long[] Value={ 20L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040397Inst : IEnumerable<long>
{
public static readonly long[] Value=A040397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040397.Bytes);
public long this[int i]=>Value[i];

public static A040397Inst Instance=new A040397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040332
{
public static readonly long[] Value={ 18L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040332Inst : IEnumerable<long>
{
public static readonly long[] Value=A040332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040332.Bytes);
public long this[int i]=>Value[i];

public static A040332Inst Instance=new A040332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040331
{
public static readonly long[] Value={ 18L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040331Inst : IEnumerable<long>
{
public static readonly long[] Value=A040331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040331.Bytes);
public long this[int i]=>Value[i];

public static A040331Inst Instance=new A040331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040330
{
public static readonly long[] Value={ 18L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040330Inst : IEnumerable<long>
{
public static readonly long[] Value=A040330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040330.Bytes);
public long this[int i]=>Value[i];

public static A040330Inst Instance=new A040330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040329
{
public static readonly long[] Value={ 18L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040329Inst : IEnumerable<long>
{
public static readonly long[] Value=A040329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040329.Bytes);
public long this[int i]=>Value[i];

public static A040329Inst Instance=new A040329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040328
{
public static readonly long[] Value={ 18L,1L,1L,1L,2L,4L,1L,17L,1L,4L,2L,1L,1L,1L,36L,1L,1L,1L,2L,4L,1L,17L,1L,4L,2L,1L,1L,1L,36L,1L,1L,1L,2L,4L,1L,17L,1L,4L,2L,1L,1L,1L,36L,1L,1L,1L,2L,4L,1L,17L,1L,4L,2L,1L,1L,1L,36L,1L,1L,1L,2L,4L,1L,17L,1L,4L,2L,1L,1L,1L,36L,1L,1L,1L,2L,4L,1L,17L,1L,4L,2L,1L,1L,1L,36L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040328Inst : IEnumerable<long>
{
public static readonly long[] Value=A040328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040328.Bytes);
public long this[int i]=>Value[i];

public static A040328Inst Instance=new A040328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040327
{
public static readonly long[] Value={ 18L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040327Inst : IEnumerable<long>
{
public static readonly long[] Value=A040327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040327.Bytes);
public long this[int i]=>Value[i];

public static A040327Inst Instance=new A040327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040326
{
public static readonly long[] Value={ 18L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040326Inst : IEnumerable<long>
{
public static readonly long[] Value=A040326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040326.Bytes);
public long this[int i]=>Value[i];

public static A040326Inst Instance=new A040326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040325
{
public static readonly long[] Value={ 18L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040325Inst : IEnumerable<long>
{
public static readonly long[] Value=A040325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040325.Bytes);
public long this[int i]=>Value[i];

public static A040325Inst Instance=new A040325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040324
{
public static readonly long[] Value={ 18L,1L,1L,11L,1L,5L,3L,1L,17L,1L,3L,5L,1L,11L,1L,1L,36L,1L,1L,11L,1L,5L,3L,1L,17L,1L,3L,5L,1L,11L,1L,1L,36L,1L,1L,11L,1L,5L,3L,1L,17L,1L,3L,5L,1L,11L,1L,1L,36L,1L,1L,11L,1L,5L,3L,1L,17L,1L,3L,5L,1L,11L,1L,1L,36L,1L,1L,11L,1L,5L,3L,1L,17L,1L,3L,5L,1L,11L,1L,1L,36L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040324Inst : IEnumerable<long>
{
public static readonly long[] Value=A040324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040324.Bytes);
public long this[int i]=>Value[i];

public static A040324Inst Instance=new A040324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040323
{
public static readonly long[] Value={ 18L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040323Inst : IEnumerable<long>
{
public static readonly long[] Value=A040323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040323.Bytes);
public long this[int i]=>Value[i];

public static A040323Inst Instance=new A040323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040322
{
public static readonly long[] Value={ 18L,2L,6L,1L,8L,2L,1L,2L,1L,2L,8L,1L,6L,2L,36L,2L,6L,1L,8L,2L,1L,2L,1L,2L,8L,1L,6L,2L,36L,2L,6L,1L,8L,2L,1L,2L,1L,2L,8L,1L,6L,2L,36L,2L,6L,1L,8L,2L,1L,2L,1L,2L,8L,1L,6L,2L,36L,2L,6L,1L,8L,2L,1L,2L,1L,2L,8L,1L,6L,2L,36L,2L,6L,1L,8L,2L,1L,2L,1L,2L,8L,1L,6L,2L,36L,2L,6L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040322Inst : IEnumerable<long>
{
public static readonly long[] Value=A040322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040322.Bytes);
public long this[int i]=>Value[i];

public static A040322Inst Instance=new A040322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040321
{
public static readonly long[] Value={ 18L,2L,3L,1L,1L,1L,1L,8L,1L,1L,1L,1L,3L,2L,36L,2L,3L,1L,1L,1L,1L,8L,1L,1L,1L,1L,3L,2L,36L,2L,3L,1L,1L,1L,1L,8L,1L,1L,1L,1L,3L,2L,36L,2L,3L,1L,1L,1L,1L,8L,1L,1L,1L,1L,3L,2L,36L,2L,3L,1L,1L,1L,1L,8L,1L,1L,1L,1L,3L,2L,36L,2L,3L,1L,1L,1L,1L,8L,1L,1L,1L,1L,3L,2L,36L,2L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040321Inst : IEnumerable<long>
{
public static readonly long[] Value=A040321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040321.Bytes);
public long this[int i]=>Value[i];

public static A040321Inst Instance=new A040321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040320
{
public static readonly long[] Value={ 18L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040320Inst : IEnumerable<long>
{
public static readonly long[] Value=A040320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040320.Bytes);
public long this[int i]=>Value[i];

public static A040320Inst Instance=new A040320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040319
{
public static readonly long[] Value={ 18L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040319Inst : IEnumerable<long>
{
public static readonly long[] Value=A040319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040319.Bytes);
public long this[int i]=>Value[i];

public static A040319Inst Instance=new A040319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040318
{
public static readonly long[] Value={ 18L,2L,1L,3L,1L,11L,2L,4L,1L,3L,3L,1L,4L,2L,11L,1L,3L,1L,2L,36L,2L,1L,3L,1L,11L,2L,4L,1L,3L,3L,1L,4L,2L,11L,1L,3L,1L,2L,36L,2L,1L,3L,1L,11L,2L,4L,1L,3L,3L,1L,4L,2L,11L,1L,3L,1L,2L,36L,2L,1L,3L,1L,11L,2L,4L,1L,3L,3L,1L,4L,2L,11L,1L,3L,1L,2L,36L,2L,1L,3L,1L,11L,2L,4L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040318Inst : IEnumerable<long>
{
public static readonly long[] Value=A040318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040318.Bytes);
public long this[int i]=>Value[i];

public static A040318Inst Instance=new A040318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040317
{
public static readonly long[] Value={ 18L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040317Inst : IEnumerable<long>
{
public static readonly long[] Value=A040317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040317.Bytes);
public long this[int i]=>Value[i];

public static A040317Inst Instance=new A040317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040300
{
public static readonly long[] Value={ 17L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040300Inst : IEnumerable<long>
{
public static readonly long[] Value=A040300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040300.Bytes);
public long this[int i]=>Value[i];

public static A040300Inst Instance=new A040300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040299
{
public static readonly long[] Value={ 17L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040299Inst : IEnumerable<long>
{
public static readonly long[] Value=A040299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040299.Bytes);
public long this[int i]=>Value[i];

public static A040299Inst Instance=new A040299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040298
{
public static readonly long[] Value={ 17L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040298Inst : IEnumerable<long>
{
public static readonly long[] Value=A040298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040298.Bytes);
public long this[int i]=>Value[i];

public static A040298Inst Instance=new A040298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040297
{
public static readonly long[] Value={ 17L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040297Inst : IEnumerable<long>
{
public static readonly long[] Value=A040297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040297.Bytes);
public long this[int i]=>Value[i];

public static A040297Inst Instance=new A040297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040296
{
public static readonly long[] Value={ 17L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040296Inst : IEnumerable<long>
{
public static readonly long[] Value=A040296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040296.Bytes);
public long this[int i]=>Value[i];

public static A040296Inst Instance=new A040296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040295
{
public static readonly long[] Value={ 17L,1L,2L,4L,11L,1L,1L,3L,2L,2L,3L,1L,1L,11L,4L,2L,1L,34L,1L,2L,4L,11L,1L,1L,3L,2L,2L,3L,1L,1L,11L,4L,2L,1L,34L,1L,2L,4L,11L,1L,1L,3L,2L,2L,3L,1L,1L,11L,4L,2L,1L,34L,1L,2L,4L,11L,1L,1L,3L,2L,2L,3L,1L,1L,11L,4L,2L,1L,34L,1L,2L,4L,11L,1L,1L,3L,2L,2L,3L,1L,1L,11L,4L,2L,1L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040295Inst : IEnumerable<long>
{
public static readonly long[] Value=A040295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040295.Bytes);
public long this[int i]=>Value[i];

public static A040295Inst Instance=new A040295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040294
{
public static readonly long[] Value={ 17L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040294Inst : IEnumerable<long>
{
public static readonly long[] Value=A040294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040294.Bytes);
public long this[int i]=>Value[i];

public static A040294Inst Instance=new A040294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040293
{
public static readonly long[] Value={ 17L,1L,1L,1L,2L,1L,6L,3L,17L,3L,6L,1L,2L,1L,1L,1L,34L,1L,1L,1L,2L,1L,6L,3L,17L,3L,6L,1L,2L,1L,1L,1L,34L,1L,1L,1L,2L,1L,6L,3L,17L,3L,6L,1L,2L,1L,1L,1L,34L,1L,1L,1L,2L,1L,6L,3L,17L,3L,6L,1L,2L,1L,1L,1L,34L,1L,1L,1L,2L,1L,6L,3L,17L,3L,6L,1L,2L,1L,1L,1L,34L,1L,1L,1L,2L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040293Inst : IEnumerable<long>
{
public static readonly long[] Value=A040293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040293.Bytes);
public long this[int i]=>Value[i];

public static A040293Inst Instance=new A040293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040292
{
public static readonly long[] Value={ 17L,1L,1L,1L,1L,5L,3L,1L,2L,1L,3L,5L,1L,1L,1L,1L,34L,1L,1L,1L,1L,5L,3L,1L,2L,1L,3L,5L,1L,1L,1L,1L,34L,1L,1L,1L,1L,5L,3L,1L,2L,1L,3L,5L,1L,1L,1L,1L,34L,1L,1L,1L,1L,5L,3L,1L,2L,1L,3L,5L,1L,1L,1L,1L,34L,1L,1L,1L,1L,5L,3L,1L,2L,1L,3L,5L,1L,1L,1L,1L,34L,1L,1L,1L,1L,5L,3L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040292Inst : IEnumerable<long>
{
public static readonly long[] Value=A040292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040292.Bytes);
public long this[int i]=>Value[i];

public static A040292Inst Instance=new A040292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040291
{
public static readonly long[] Value={ 17L,1L,1L,2L,1L,2L,4L,1L,1L,1L,8L,6L,1L,10L,1L,6L,8L,1L,1L,1L,4L,2L,1L,2L,1L,1L,34L,1L,1L,2L,1L,2L,4L,1L,1L,1L,8L,6L,1L,10L,1L,6L,8L,1L,1L,1L,4L,2L,1L,2L,1L,1L,34L,1L,1L,2L,1L,2L,4L,1L,1L,1L,8L,6L,1L,10L,1L,6L,8L,1L,1L,1L,4L,2L,1L,2L,1L,1L,34L,1L,1L,2L,1L,2L,4L,1L,1L,1L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040291Inst : IEnumerable<long>
{
public static readonly long[] Value=A040291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040291.Bytes);
public long this[int i]=>Value[i];

public static A040291Inst Instance=new A040291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040290
{
public static readonly long[] Value={ 17L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040290Inst : IEnumerable<long>
{
public static readonly long[] Value=A040290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040290.Bytes);
public long this[int i]=>Value[i];

public static A040290Inst Instance=new A040290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040289
{
public static readonly long[] Value={ 17L,1L,1L,11L,5L,1L,3L,17L,3L,1L,5L,11L,1L,1L,34L,1L,1L,11L,5L,1L,3L,17L,3L,1L,5L,11L,1L,1L,34L,1L,1L,11L,5L,1L,3L,17L,3L,1L,5L,11L,1L,1L,34L,1L,1L,11L,5L,1L,3L,17L,3L,1L,5L,11L,1L,1L,34L,1L,1L,11L,5L,1L,3L,17L,3L,1L,5L,11L,1L,1L,34L,1L,1L,11L,5L,1L,3L,17L,3L,1L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040289Inst : IEnumerable<long>
{
public static readonly long[] Value=A040289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040289.Bytes);
public long this[int i]=>Value[i];

public static A040289Inst Instance=new A040289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040288
{
public static readonly long[] Value={ 17L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040288Inst : IEnumerable<long>
{
public static readonly long[] Value=A040288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040288.Bytes);
public long this[int i]=>Value[i];

public static A040288Inst Instance=new A040288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040287
{
public static readonly long[] Value={ 17L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040287Inst : IEnumerable<long>
{
public static readonly long[] Value=A040287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040287.Bytes);
public long this[int i]=>Value[i];

public static A040287Inst Instance=new A040287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040286
{
public static readonly long[] Value={ 17L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040286Inst : IEnumerable<long>
{
public static readonly long[] Value=A040286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040286.Bytes);
public long this[int i]=>Value[i];

public static A040286Inst Instance=new A040286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040285
{
public static readonly long[] Value={ 17L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040285Inst : IEnumerable<long>
{
public static readonly long[] Value=A040285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040285.Bytes);
public long this[int i]=>Value[i];

public static A040285Inst Instance=new A040285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040268
{
public static readonly long[] Value={ 16L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040268Inst : IEnumerable<long>
{
public static readonly long[] Value=A040268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040268.Bytes);
public long this[int i]=>Value[i];

public static A040268Inst Instance=new A040268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040267
{
public static readonly long[] Value={ 16L,1L,5L,1L,3L,2L,1L,4L,8L,4L,1L,2L,3L,1L,5L,1L,32L,1L,5L,1L,3L,2L,1L,4L,8L,4L,1L,2L,3L,1L,5L,1L,32L,1L,5L,1L,3L,2L,1L,4L,8L,4L,1L,2L,3L,1L,5L,1L,32L,1L,5L,1L,3L,2L,1L,4L,8L,4L,1L,2L,3L,1L,5L,1L,32L,1L,5L,1L,3L,2L,1L,4L,8L,4L,1L,2L,3L,1L,5L,1L,32L,1L,5L,1L,3L,2L,1L,4L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040267Inst : IEnumerable<long>
{
public static readonly long[] Value=A040267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040267.Bytes);
public long this[int i]=>Value[i];

public static A040267Inst Instance=new A040267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040266
{
public static readonly long[] Value={ 16L,1L,4L,1L,1L,1L,3L,10L,1L,15L,1L,10L,3L,1L,1L,1L,4L,1L,32L,1L,4L,1L,1L,1L,3L,10L,1L,15L,1L,10L,3L,1L,1L,1L,4L,1L,32L,1L,4L,1L,1L,1L,3L,10L,1L,15L,1L,10L,3L,1L,1L,1L,4L,1L,32L,1L,4L,1L,1L,1L,3L,10L,1L,15L,1L,10L,3L,1L,1L,1L,4L,1L,32L,1L,4L,1L,1L,1L,3L,10L,1L,15L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040266Inst : IEnumerable<long>
{
public static readonly long[] Value=A040266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040266.Bytes);
public long this[int i]=>Value[i];

public static A040266Inst Instance=new A040266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040265
{
public static readonly long[] Value={ 16L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040265Inst : IEnumerable<long>
{
public static readonly long[] Value=A040265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040265.Bytes);
public long this[int i]=>Value[i];

public static A040265Inst Instance=new A040265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040264
{
public static readonly long[] Value={ 16L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L,1L,32L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L,1L,32L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L,1L,32L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L,1L,32L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L,1L,32L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L,1L,32L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040264Inst : IEnumerable<long>
{
public static readonly long[] Value=A040264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040264.Bytes);
public long this[int i]=>Value[i];

public static A040264Inst Instance=new A040264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040263
{
public static readonly long[] Value={ 16L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040263Inst : IEnumerable<long>
{
public static readonly long[] Value=A040263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040263.Bytes);
public long this[int i]=>Value[i];

public static A040263Inst Instance=new A040263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040262
{
public static readonly long[] Value={ 16L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040262Inst : IEnumerable<long>
{
public static readonly long[] Value=A040262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040262.Bytes);
public long this[int i]=>Value[i];

public static A040262Inst Instance=new A040262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040261
{
public static readonly long[] Value={ 16L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040261Inst : IEnumerable<long>
{
public static readonly long[] Value=A040261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040261.Bytes);
public long this[int i]=>Value[i];

public static A040261Inst Instance=new A040261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040260
{
public static readonly long[] Value={ 16L,1L,1L,1L,4L,10L,1L,7L,2L,2L,3L,3L,2L,2L,7L,1L,10L,4L,1L,1L,1L,32L,1L,1L,1L,4L,10L,1L,7L,2L,2L,3L,3L,2L,2L,7L,1L,10L,4L,1L,1L,1L,32L,1L,1L,1L,4L,10L,1L,7L,2L,2L,3L,3L,2L,2L,7L,1L,10L,4L,1L,1L,1L,32L,1L,1L,1L,4L,10L,1L,7L,2L,2L,3L,3L,2L,2L,7L,1L,10L,4L,1L,1L,1L,32L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040260Inst : IEnumerable<long>
{
public static readonly long[] Value=A040260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040260.Bytes);
public long this[int i]=>Value[i];

public static A040260Inst Instance=new A040260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040259
{
public static readonly long[] Value={ 16L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040259Inst : IEnumerable<long>
{
public static readonly long[] Value=A040259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040259.Bytes);
public long this[int i]=>Value[i];

public static A040259Inst Instance=new A040259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040258
{
public static readonly long[] Value={ 16L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040258Inst : IEnumerable<long>
{
public static readonly long[] Value=A040258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040258.Bytes);
public long this[int i]=>Value[i];

public static A040258Inst Instance=new A040258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040257
{
public static readonly long[] Value={ 16L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040257Inst : IEnumerable<long>
{
public static readonly long[] Value=A040257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040257.Bytes);
public long this[int i]=>Value[i];

public static A040257Inst Instance=new A040257Inst();

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