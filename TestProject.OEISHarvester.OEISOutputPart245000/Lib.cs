using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040800
{
public static readonly long[] Value={ 28L,1L,3L,1L,4L,2L,3L,2L,1L,1L,2L,3L,2L,4L,1L,3L,1L,56L,1L,3L,1L,4L,2L,3L,2L,1L,1L,2L,3L,2L,4L,1L,3L,1L,56L,1L,3L,1L,4L,2L,3L,2L,1L,1L,2L,3L,2L,4L,1L,3L,1L,56L,1L,3L,1L,4L,2L,3L,2L,1L,1L,2L,3L,2L,4L,1L,3L,1L,56L,1L,3L,1L,4L,2L,3L,2L,1L,1L,2L,3L,2L,4L,1L,3L,1L,56L,1L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040800Inst : IEnumerable<long>
{
public static readonly long[] Value=A040800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040800.Bytes);
public long this[int i]=>Value[i];

public static A040800Inst Instance=new A040800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040801
{
public static readonly long[] Value={ 28L,1L,4L,3L,1L,10L,1L,3L,4L,1L,56L,1L,4L,3L,1L,10L,1L,3L,4L,1L,56L,1L,4L,3L,1L,10L,1L,3L,4L,1L,56L,1L,4L,3L,1L,10L,1L,3L,4L,1L,56L,1L,4L,3L,1L,10L,1L,3L,4L,1L,56L,1L,4L,3L,1L,10L,1L,3L,4L,1L,56L,1L,4L,3L,1L,10L,1L,3L,4L,1L,56L,1L,4L,3L,1L,10L,1L,3L,4L,1L,56L,1L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040801Inst : IEnumerable<long>
{
public static readonly long[] Value=A040801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040801.Bytes);
public long this[int i]=>Value[i];

public static A040801Inst Instance=new A040801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040802
{
public static readonly long[] Value={ 28L,1L,4L,1L,3L,1L,1L,1L,1L,18L,1L,1L,1L,1L,3L,1L,4L,1L,56L,1L,4L,1L,3L,1L,1L,1L,1L,18L,1L,1L,1L,1L,3L,1L,4L,1L,56L,1L,4L,1L,3L,1L,1L,1L,1L,18L,1L,1L,1L,1L,3L,1L,4L,1L,56L,1L,4L,1L,3L,1L,1L,1L,1L,18L,1L,1L,1L,1L,3L,1L,4L,1L,56L,1L,4L,1L,3L,1L,1L,1L,1L,18L,1L,1L,1L,1L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040802Inst : IEnumerable<long>
{
public static readonly long[] Value=A040802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040802.Bytes);
public long this[int i]=>Value[i];

public static A040802Inst Instance=new A040802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040803
{
public static readonly long[] Value={ 28L,1L,5L,2L,2L,1L,13L,1L,2L,2L,5L,1L,56L,1L,5L,2L,2L,1L,13L,1L,2L,2L,5L,1L,56L,1L,5L,2L,2L,1L,13L,1L,2L,2L,5L,1L,56L,1L,5L,2L,2L,1L,13L,1L,2L,2L,5L,1L,56L,1L,5L,2L,2L,1L,13L,1L,2L,2L,5L,1L,56L,1L,5L,2L,2L,1L,13L,1L,2L,2L,5L,1L,56L,1L,5L,2L,2L,1L,13L,1L,2L,2L,5L,1L,56L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040803Inst : IEnumerable<long>
{
public static readonly long[] Value=A040803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040803.Bytes);
public long this[int i]=>Value[i];

public static A040803Inst Instance=new A040803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040804
{
public static readonly long[] Value={ 28L,1L,6L,4L,3L,2L,1L,2L,1L,2L,3L,4L,6L,1L,56L,1L,6L,4L,3L,2L,1L,2L,1L,2L,3L,4L,6L,1L,56L,1L,6L,4L,3L,2L,1L,2L,1L,2L,3L,4L,6L,1L,56L,1L,6L,4L,3L,2L,1L,2L,1L,2L,3L,4L,6L,1L,56L,1L,6L,4L,3L,2L,1L,2L,1L,2L,3L,4L,6L,1L,56L,1L,6L,4L,3L,2L,1L,2L,1L,2L,3L,4L,6L,1L,56L,1L,6L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040804Inst : IEnumerable<long>
{
public static readonly long[] Value=A040804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040804.Bytes);
public long this[int i]=>Value[i];

public static A040804Inst Instance=new A040804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040805
{
public static readonly long[] Value={ 28L,1L,7L,3L,1L,2L,1L,1L,1L,3L,2L,28L,2L,3L,1L,1L,1L,2L,1L,3L,7L,1L,56L,1L,7L,3L,1L,2L,1L,1L,1L,3L,2L,28L,2L,3L,1L,1L,1L,2L,1L,3L,7L,1L,56L,1L,7L,3L,1L,2L,1L,1L,1L,3L,2L,28L,2L,3L,1L,1L,1L,2L,1L,3L,7L,1L,56L,1L,7L,3L,1L,2L,1L,1L,1L,3L,2L,28L,2L,3L,1L,1L,1L,2L,1L,3L,7L,1L,56L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040805Inst : IEnumerable<long>
{
public static readonly long[] Value=A040805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040805.Bytes);
public long this[int i]=>Value[i];

public static A040805Inst Instance=new A040805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040806
{
public static readonly long[] Value={ 28L,1L,8L,1L,1L,1L,5L,1L,3L,3L,1L,1L,2L,5L,2L,1L,1L,3L,3L,1L,5L,1L,1L,1L,8L,1L,56L,1L,8L,1L,1L,1L,5L,1L,3L,3L,1L,1L,2L,5L,2L,1L,1L,3L,3L,1L,5L,1L,1L,1L,8L,1L,56L,1L,8L,1L,1L,1L,5L,1L,3L,3L,1L,1L,2L,5L,2L,1L,1L,3L,3L,1L,5L,1L,1L,1L,8L,1L,56L,1L,8L,1L,1L,1L,5L,1L,3L,3L,1L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040806Inst : IEnumerable<long>
{
public static readonly long[] Value=A040806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040806.Bytes);
public long this[int i]=>Value[i];

public static A040806Inst Instance=new A040806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040807
{
public static readonly long[] Value={ 28L,1L,10L,1L,1L,2L,1L,1L,10L,1L,56L,1L,10L,1L,1L,2L,1L,1L,10L,1L,56L,1L,10L,1L,1L,2L,1L,1L,10L,1L,56L,1L,10L,1L,1L,2L,1L,1L,10L,1L,56L,1L,10L,1L,1L,2L,1L,1L,10L,1L,56L,1L,10L,1L,1L,2L,1L,1L,10L,1L,56L,1L,10L,1L,1L,2L,1L,1L,10L,1L,56L,1L,10L,1L,1L,2L,1L,1L,10L,1L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040807Inst : IEnumerable<long>
{
public static readonly long[] Value=A040807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040807.Bytes);
public long this[int i]=>Value[i];

public static A040807Inst Instance=new A040807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040808
{
public static readonly long[] Value={ 28L,1L,13L,2L,13L,1L,56L,1L,13L,2L,13L,1L,56L,1L,13L,2L,13L,1L,56L,1L,13L,2L,13L,1L,56L,1L,13L,2L,13L,1L,56L,1L,13L,2L,13L,1L,56L,1L,13L,2L,13L,1L,56L,1L,13L,2L,13L,1L,56L,1L,13L,2L,13L,1L,56L,1L,13L,2L,13L,1L,56L,1L,13L,2L,13L,1L,56L,1L,13L,2L,13L,1L,56L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040808Inst : IEnumerable<long>
{
public static readonly long[] Value=A040808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040808.Bytes);
public long this[int i]=>Value[i];

public static A040808Inst Instance=new A040808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040809
{
public static readonly long[] Value={ 28L,1L,18L,3L,6L,9L,2L,28L,2L,9L,6L,3L,18L,1L,56L,1L,18L,3L,6L,9L,2L,28L,2L,9L,6L,3L,18L,1L,56L,1L,18L,3L,6L,9L,2L,28L,2L,9L,6L,3L,18L,1L,56L,1L,18L,3L,6L,9L,2L,28L,2L,9L,6L,3L,18L,1L,56L,1L,18L,3L,6L,9L,2L,28L,2L,9L,6L,3L,18L,1L,56L,1L,18L,3L,6L,9L,2L,28L,2L,9L,6L,3L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040809Inst : IEnumerable<long>
{
public static readonly long[] Value=A040809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040809.Bytes);
public long this[int i]=>Value[i];

public static A040809Inst Instance=new A040809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040810
{
public static readonly long[] Value={ 28L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L,1L,56L,1L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040810Inst : IEnumerable<long>
{
public static readonly long[] Value=A040810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040810.Bytes);
public long this[int i]=>Value[i];

public static A040810Inst Instance=new A040810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040811
{
public static readonly long[] Value={ 28L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L,1L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040811Inst : IEnumerable<long>
{
public static readonly long[] Value=A040811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040811.Bytes);
public long this[int i]=>Value[i];

public static A040811Inst Instance=new A040811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040812
{
public static readonly long[] Value={ 29L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040812Inst : IEnumerable<long>
{
public static readonly long[] Value=A040812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040812.Bytes);
public long this[int i]=>Value[i];

public static A040812Inst Instance=new A040812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040829
{
public static readonly long[] Value={ 29L,3L,4L,5L,1L,1L,1L,2L,2L,3L,2L,19L,9L,1L,2L,1L,1L,4L,1L,3L,11L,2L,6L,29L,6L,2L,11L,3L,1L,4L,1L,1L,2L,1L,9L,19L,2L,3L,2L,2L,1L,1L,1L,5L,4L,3L,58L,3L,4L,5L,1L,1L,1L,2L,2L,3L,2L,19L,9L,1L,2L,1L,1L,4L,1L,3L,11L,2L,6L,29L,6L,2L,11L,3L,1L,4L,1L,1L,2L,1L,9L,19L,2L,3L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040829Inst : IEnumerable<long>
{
public static readonly long[] Value=A040829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040829.Bytes);
public long this[int i]=>Value[i];

public static A040829Inst Instance=new A040829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040830
{
public static readonly long[] Value={ 29L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L,3L,58L,3L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040830Inst : IEnumerable<long>
{
public static readonly long[] Value=A040830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040830.Bytes);
public long this[int i]=>Value[i];

public static A040830Inst Instance=new A040830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040831
{
public static readonly long[] Value={ 29L,2L,1L,11L,14L,1L,1L,2L,2L,2L,1L,1L,14L,11L,1L,2L,58L,2L,1L,11L,14L,1L,1L,2L,2L,2L,1L,1L,14L,11L,1L,2L,58L,2L,1L,11L,14L,1L,1L,2L,2L,2L,1L,1L,14L,11L,1L,2L,58L,2L,1L,11L,14L,1L,1L,2L,2L,2L,1L,1L,14L,11L,1L,2L,58L,2L,1L,11L,14L,1L,1L,2L,2L,2L,1L,1L,14L,11L,1L,2L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040831Inst : IEnumerable<long>
{
public static readonly long[] Value=A040831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040831.Bytes);
public long this[int i]=>Value[i];

public static A040831Inst Instance=new A040831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040832
{
public static readonly long[] Value={ 29L,2L,1L,3L,1L,1L,9L,4L,2L,2L,2L,1L,5L,1L,4L,2L,19L,8L,2L,1L,28L,1L,2L,8L,19L,2L,4L,1L,5L,1L,2L,2L,2L,4L,9L,1L,1L,3L,1L,2L,58L,2L,1L,3L,1L,1L,9L,4L,2L,2L,2L,1L,5L,1L,4L,2L,19L,8L,2L,1L,28L,1L,2L,8L,19L,2L,4L,1L,5L,1L,2L,2L,2L,4L,9L,1L,1L,3L,1L,2L,58L,2L,1L,3L,1L,1L,9L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040832Inst : IEnumerable<long>
{
public static readonly long[] Value=A040832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040832.Bytes);
public long this[int i]=>Value[i];

public static A040832Inst Instance=new A040832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040833
{
public static readonly long[] Value={ 29L,2L,1L,1L,1L,7L,1L,3L,3L,5L,29L,5L,3L,3L,1L,7L,1L,1L,1L,2L,58L,2L,1L,1L,1L,7L,1L,3L,3L,5L,29L,5L,3L,3L,1L,7L,1L,1L,1L,2L,58L,2L,1L,1L,1L,7L,1L,3L,3L,5L,29L,5L,3L,3L,1L,7L,1L,1L,1L,2L,58L,2L,1L,1L,1L,7L,1L,3L,3L,5L,29L,5L,3L,3L,1L,7L,1L,1L,1L,2L,58L,2L,1L,1L,1L,7L,1L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040833Inst : IEnumerable<long>
{
public static readonly long[] Value=A040833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040833.Bytes);
public long this[int i]=>Value[i];

public static A040833Inst Instance=new A040833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040834
{
public static readonly long[] Value={ 29L,2L,1L,1L,5L,1L,13L,1L,5L,1L,1L,2L,58L,2L,1L,1L,5L,1L,13L,1L,5L,1L,1L,2L,58L,2L,1L,1L,5L,1L,13L,1L,5L,1L,1L,2L,58L,2L,1L,1L,5L,1L,13L,1L,5L,1L,1L,2L,58L,2L,1L,1L,5L,1L,13L,1L,5L,1L,1L,2L,58L,2L,1L,1L,5L,1L,13L,1L,5L,1L,1L,2L,58L,2L,1L,1L,5L,1L,13L,1L,5L,1L,1L,2L,58L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040834Inst : IEnumerable<long>
{
public static readonly long[] Value=A040834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040834.Bytes);
public long this[int i]=>Value[i];

public static A040834Inst Instance=new A040834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040835
{
public static readonly long[] Value={ 29L,2L,2L,3L,3L,1L,1L,1L,2L,6L,6L,2L,1L,1L,1L,3L,3L,2L,2L,58L,2L,2L,3L,3L,1L,1L,1L,2L,6L,6L,2L,1L,1L,1L,3L,3L,2L,2L,58L,2L,2L,3L,3L,1L,1L,1L,2L,6L,6L,2L,1L,1L,1L,3L,3L,2L,2L,58L,2L,2L,3L,3L,1L,1L,1L,2L,6L,6L,2L,1L,1L,1L,3L,3L,2L,2L,58L,2L,2L,3L,3L,1L,1L,1L,2L,6L,6L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040835Inst : IEnumerable<long>
{
public static readonly long[] Value=A040835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040835.Bytes);
public long this[int i]=>Value[i];

public static A040835Inst Instance=new A040835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040836
{
public static readonly long[] Value={ 29L,2L,2L,1L,28L,1L,2L,2L,58L,2L,2L,1L,28L,1L,2L,2L,58L,2L,2L,1L,28L,1L,2L,2L,58L,2L,2L,1L,28L,1L,2L,2L,58L,2L,2L,1L,28L,1L,2L,2L,58L,2L,2L,1L,28L,1L,2L,2L,58L,2L,2L,1L,28L,1L,2L,2L,58L,2L,2L,1L,28L,1L,2L,2L,58L,2L,2L,1L,28L,1L,2L,2L,58L,2L,2L,1L,28L,1L,2L,2L,58L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040836Inst : IEnumerable<long>
{
public static readonly long[] Value=A040836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040836.Bytes);
public long this[int i]=>Value[i];

public static A040836Inst Instance=new A040836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040837
{
public static readonly long[] Value={ 29L,2L,4L,29L,4L,2L,58L,2L,4L,29L,4L,2L,58L,2L,4L,29L,4L,2L,58L,2L,4L,29L,4L,2L,58L,2L,4L,29L,4L,2L,58L,2L,4L,29L,4L,2L,58L,2L,4L,29L,4L,2L,58L,2L,4L,29L,4L,2L,58L,2L,4L,29L,4L,2L,58L,2L,4L,29L,4L,2L,58L,2L,4L,29L,4L,2L,58L,2L,4L,29L,4L,2L,58L,2L,4L,29L,4L,2L,58L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040837Inst : IEnumerable<long>
{
public static readonly long[] Value=A040837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040837.Bytes);
public long this[int i]=>Value[i];

public static A040837Inst Instance=new A040837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040838
{
public static readonly long[] Value={ 29L,2L,6L,19L,2L,19L,6L,2L,58L,2L,6L,19L,2L,19L,6L,2L,58L,2L,6L,19L,2L,19L,6L,2L,58L,2L,6L,19L,2L,19L,6L,2L,58L,2L,6L,19L,2L,19L,6L,2L,58L,2L,6L,19L,2L,19L,6L,2L,58L,2L,6L,19L,2L,19L,6L,2L,58L,2L,6L,19L,2L,19L,6L,2L,58L,2L,6L,19L,2L,19L,6L,2L,58L,2L,6L,19L,2L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040838Inst : IEnumerable<long>
{
public static readonly long[] Value=A040838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040838.Bytes);
public long this[int i]=>Value[i];

public static A040838Inst Instance=new A040838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040839
{
public static readonly long[] Value={ 29L,2L,11L,3L,2L,1L,1L,1L,1L,1L,14L,8L,2L,1L,4L,1L,2L,8L,14L,1L,1L,1L,1L,1L,2L,3L,11L,2L,58L,2L,11L,3L,2L,1L,1L,1L,1L,1L,14L,8L,2L,1L,4L,1L,2L,8L,14L,1L,1L,1L,1L,1L,2L,3L,11L,2L,58L,2L,11L,3L,2L,1L,1L,1L,1L,1L,14L,8L,2L,1L,4L,1L,2L,8L,14L,1L,1L,1L,1L,1L,2L,3L,11L,2L,58L,2L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040839Inst : IEnumerable<long>
{
public static readonly long[] Value=A040839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040839.Bytes);
public long this[int i]=>Value[i];

public static A040839Inst Instance=new A040839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040840
{
public static readonly long[] Value={ 29L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L,2L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040840Inst : IEnumerable<long>
{
public static readonly long[] Value=A040840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040840.Bytes);
public long this[int i]=>Value[i];

public static A040840Inst Instance=new A040840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040841
{
public static readonly long[] Value={ 29L,1L,1L,19L,5L,1L,5L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,5L,1L,5L,19L,1L,1L,58L,1L,1L,19L,5L,1L,5L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,5L,1L,5L,19L,1L,1L,58L,1L,1L,19L,5L,1L,5L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,5L,1L,5L,19L,1L,1L,58L,1L,1L,19L,5L,1L,5L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040841Inst : IEnumerable<long>
{
public static readonly long[] Value=A040841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040841.Bytes);
public long this[int i]=>Value[i];

public static A040841Inst Instance=new A040841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040842
{
public static readonly long[] Value={ 29L,1L,1L,7L,1L,13L,1L,7L,1L,1L,58L,1L,1L,7L,1L,13L,1L,7L,1L,1L,58L,1L,1L,7L,1L,13L,1L,7L,1L,1L,58L,1L,1L,7L,1L,13L,1L,7L,1L,1L,58L,1L,1L,7L,1L,13L,1L,7L,1L,1L,58L,1L,1L,7L,1L,13L,1L,7L,1L,1L,58L,1L,1L,7L,1L,13L,1L,7L,1L,1L,58L,1L,1L,7L,1L,13L,1L,7L,1L,1L,58L,1L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040842Inst : IEnumerable<long>
{
public static readonly long[] Value=A040842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040842.Bytes);
public long this[int i]=>Value[i];

public static A040842Inst Instance=new A040842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040843
{
public static readonly long[] Value={ 29L,1L,1L,4L,1L,6L,1L,1L,3L,6L,3L,1L,1L,6L,1L,4L,1L,1L,58L,1L,1L,4L,1L,6L,1L,1L,3L,6L,3L,1L,1L,6L,1L,4L,1L,1L,58L,1L,1L,4L,1L,6L,1L,1L,3L,6L,3L,1L,1L,6L,1L,4L,1L,1L,58L,1L,1L,4L,1L,6L,1L,1L,3L,6L,3L,1L,1L,6L,1L,4L,1L,1L,58L,1L,1L,4L,1L,6L,1L,1L,3L,6L,3L,1L,1L,6L,1L,4L,1L,1L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040843Inst : IEnumerable<long>
{
public static readonly long[] Value=A040843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040843.Bytes);
public long this[int i]=>Value[i];

public static A040843Inst Instance=new A040843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040844
{
public static readonly long[] Value={ 29L,1L,1L,3L,2L,3L,1L,1L,58L,1L,1L,3L,2L,3L,1L,1L,58L,1L,1L,3L,2L,3L,1L,1L,58L,1L,1L,3L,2L,3L,1L,1L,58L,1L,1L,3L,2L,3L,1L,1L,58L,1L,1L,3L,2L,3L,1L,1L,58L,1L,1L,3L,2L,3L,1L,1L,58L,1L,1L,3L,2L,3L,1L,1L,58L,1L,1L,3L,2L,3L,1L,1L,58L,1L,1L,3L,2L,3L,1L,1L,58L,1L,1L,3L,2L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040844Inst : IEnumerable<long>
{
public static readonly long[] Value=A040844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040844.Bytes);
public long this[int i]=>Value[i];

public static A040844Inst Instance=new A040844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040877
{
public static readonly long[] Value={ 30L,7L,1L,1L,14L,1L,1L,7L,60L,7L,1L,1L,14L,1L,1L,7L,60L,7L,1L,1L,14L,1L,1L,7L,60L,7L,1L,1L,14L,1L,1L,7L,60L,7L,1L,1L,14L,1L,1L,7L,60L,7L,1L,1L,14L,1L,1L,7L,60L,7L,1L,1L,14L,1L,1L,7L,60L,7L,1L,1L,14L,1L,1L,7L,60L,7L,1L,1L,14L,1L,1L,7L,60L,7L,1L,1L,14L,1L,1L,7L,60L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040877Inst : IEnumerable<long>
{
public static readonly long[] Value=A040877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040877.Bytes);
public long this[int i]=>Value[i];

public static A040877Inst Instance=new A040877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040878
{
public static readonly long[] Value={ 30L,6L,1L,2L,6L,2L,1L,6L,60L,6L,1L,2L,6L,2L,1L,6L,60L,6L,1L,2L,6L,2L,1L,6L,60L,6L,1L,2L,6L,2L,1L,6L,60L,6L,1L,2L,6L,2L,1L,6L,60L,6L,1L,2L,6L,2L,1L,6L,60L,6L,1L,2L,6L,2L,1L,6L,60L,6L,1L,2L,6L,2L,1L,6L,60L,6L,1L,2L,6L,2L,1L,6L,60L,6L,1L,2L,6L,2L,1L,6L,60L,6L,1L,2L,6L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040878Inst : IEnumerable<long>
{
public static readonly long[] Value=A040878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040878.Bytes);
public long this[int i]=>Value[i];

public static A040878Inst Instance=new A040878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040879
{
public static readonly long[] Value={ 30L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L,6L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040879Inst : IEnumerable<long>
{
public static readonly long[] Value=A040879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040879.Bytes);
public long this[int i]=>Value[i];

public static A040879Inst Instance=new A040879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040880
{
public static readonly long[] Value={ 30L,5L,2L,8L,5L,1L,11L,4L,4L,2L,1L,1L,29L,1L,1L,2L,4L,4L,11L,1L,5L,8L,2L,5L,60L,5L,2L,8L,5L,1L,11L,4L,4L,2L,1L,1L,29L,1L,1L,2L,4L,4L,11L,1L,5L,8L,2L,5L,60L,5L,2L,8L,5L,1L,11L,4L,4L,2L,1L,1L,29L,1L,1L,2L,4L,4L,11L,1L,5L,8L,2L,5L,60L,5L,2L,8L,5L,1L,11L,4L,4L,2L,1L,1L,29L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040880Inst : IEnumerable<long>
{
public static readonly long[] Value=A040880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040880.Bytes);
public long this[int i]=>Value[i];

public static A040880Inst Instance=new A040880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040881
{
public static readonly long[] Value={ 30L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L,5L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040881Inst : IEnumerable<long>
{
public static readonly long[] Value=A040881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040881.Bytes);
public long this[int i]=>Value[i];

public static A040881Inst Instance=new A040881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040882
{
public static readonly long[] Value={ 30L,4L,1L,1L,1L,2L,1L,1L,6L,7L,2L,2L,19L,1L,2L,1L,4L,1L,2L,1L,19L,2L,2L,7L,6L,1L,1L,2L,1L,1L,1L,4L,60L,4L,1L,1L,1L,2L,1L,1L,6L,7L,2L,2L,19L,1L,2L,1L,4L,1L,2L,1L,19L,2L,2L,7L,6L,1L,1L,2L,1L,1L,1L,4L,60L,4L,1L,1L,1L,2L,1L,1L,6L,7L,2L,2L,19L,1L,2L,1L,4L,1L,2L,1L,19L,2L,2L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040882Inst : IEnumerable<long>
{
public static readonly long[] Value=A040882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040882.Bytes);
public long this[int i]=>Value[i];

public static A040882Inst Instance=new A040882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040883
{
public static readonly long[] Value={ 30L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L,60L,4L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040883Inst : IEnumerable<long>
{
public static readonly long[] Value=A040883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040883.Bytes);
public long this[int i]=>Value[i];

public static A040883Inst Instance=new A040883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040884
{
public static readonly long[] Value={ 30L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L,4L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040884Inst : IEnumerable<long>
{
public static readonly long[] Value=A040884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040884.Bytes);
public long this[int i]=>Value[i];

public static A040884Inst Instance=new A040884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040885
{
public static readonly long[] Value={ 30L,3L,1L,3L,3L,1L,1L,14L,1L,1L,3L,3L,1L,3L,60L,3L,1L,3L,3L,1L,1L,14L,1L,1L,3L,3L,1L,3L,60L,3L,1L,3L,3L,1L,1L,14L,1L,1L,3L,3L,1L,3L,60L,3L,1L,3L,3L,1L,1L,14L,1L,1L,3L,3L,1L,3L,60L,3L,1L,3L,3L,1L,1L,14L,1L,1L,3L,3L,1L,3L,60L,3L,1L,3L,3L,1L,1L,14L,1L,1L,3L,3L,1L,3L,60L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040885Inst : IEnumerable<long>
{
public static readonly long[] Value=A040885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040885.Bytes);
public long this[int i]=>Value[i];

public static A040885Inst Instance=new A040885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040886
{
public static readonly long[] Value={ 30L,3L,1L,1L,4L,1L,14L,3L,8L,3L,14L,1L,4L,1L,1L,3L,60L,3L,1L,1L,4L,1L,14L,3L,8L,3L,14L,1L,4L,1L,1L,3L,60L,3L,1L,1L,4L,1L,14L,3L,8L,3L,14L,1L,4L,1L,1L,3L,60L,3L,1L,1L,4L,1L,14L,3L,8L,3L,14L,1L,4L,1L,1L,3L,60L,3L,1L,1L,4L,1L,14L,3L,8L,3L,14L,1L,4L,1L,1L,3L,60L,3L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040886Inst : IEnumerable<long>
{
public static readonly long[] Value=A040886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040886.Bytes);
public long this[int i]=>Value[i];

public static A040886Inst Instance=new A040886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040887
{
public static readonly long[] Value={ 30L,3L,2L,1L,6L,30L,6L,1L,2L,3L,60L,3L,2L,1L,6L,30L,6L,1L,2L,3L,60L,3L,2L,1L,6L,30L,6L,1L,2L,3L,60L,3L,2L,1L,6L,30L,6L,1L,2L,3L,60L,3L,2L,1L,6L,30L,6L,1L,2L,3L,60L,3L,2L,1L,6L,30L,6L,1L,2L,3L,60L,3L,2L,1L,6L,30L,6L,1L,2L,3L,60L,3L,2L,1L,6L,30L,6L,1L,2L,3L,60L,3L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040887Inst : IEnumerable<long>
{
public static readonly long[] Value=A040887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040887.Bytes);
public long this[int i]=>Value[i];

public static A040887Inst Instance=new A040887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040888
{
public static readonly long[] Value={ 30L,3L,5L,1L,2L,1L,2L,1L,1L,1L,2L,3L,1L,19L,2L,3L,1L,1L,4L,9L,1L,7L,1L,3L,6L,2L,11L,1L,1L,1L,29L,1L,1L,1L,11L,2L,6L,3L,1L,7L,1L,9L,4L,1L,1L,3L,2L,19L,1L,3L,2L,1L,1L,1L,2L,1L,2L,1L,5L,3L,60L,3L,5L,1L,2L,1L,2L,1L,1L,1L,2L,3L,1L,19L,2L,3L,1L,1L,4L,9L,1L,7L,1L,3L,6L,2L,11L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040888Inst : IEnumerable<long>
{
public static readonly long[] Value=A040888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040888.Bytes);
public long this[int i]=>Value[i];

public static A040888Inst Instance=new A040888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040889
{
public static readonly long[] Value={ 30L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L,3L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040889Inst : IEnumerable<long>
{
public static readonly long[] Value=A040889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040889.Bytes);
public long this[int i]=>Value[i];

public static A040889Inst Instance=new A040889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040890
{
public static readonly long[] Value={ 30L,2L,1L,6L,1L,11L,3L,1L,2L,2L,3L,1L,1L,1L,1L,1L,8L,20L,8L,1L,1L,1L,1L,1L,3L,2L,2L,1L,3L,11L,1L,6L,1L,2L,60L,2L,1L,6L,1L,11L,3L,1L,2L,2L,3L,1L,1L,1L,1L,1L,8L,20L,8L,1L,1L,1L,1L,1L,3L,2L,2L,1L,3L,11L,1L,6L,1L,2L,60L,2L,1L,6L,1L,11L,3L,1L,2L,2L,3L,1L,1L,1L,1L,1L,8L,20L,8L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040890Inst : IEnumerable<long>
{
public static readonly long[] Value=A040890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040890.Bytes);
public long this[int i]=>Value[i];

public static A040890Inst Instance=new A040890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040891
{
public static readonly long[] Value={ 30L,2L,1L,2L,1L,9L,2L,1L,1L,6L,6L,1L,1L,2L,9L,1L,2L,1L,2L,60L,2L,1L,2L,1L,9L,2L,1L,1L,6L,6L,1L,1L,2L,9L,1L,2L,1L,2L,60L,2L,1L,2L,1L,9L,2L,1L,1L,6L,6L,1L,1L,2L,9L,1L,2L,1L,2L,60L,2L,1L,2L,1L,9L,2L,1L,1L,6L,6L,1L,1L,2L,9L,1L,2L,1L,2L,60L,2L,1L,2L,1L,9L,2L,1L,1L,6L,6L,1L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040891Inst : IEnumerable<long>
{
public static readonly long[] Value=A040891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040891.Bytes);
public long this[int i]=>Value[i];

public static A040891Inst Instance=new A040891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040892
{
public static readonly long[] Value={ 30L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L,1L,1L,2L,60L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040892Inst : IEnumerable<long>
{
public static readonly long[] Value=A040892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040892.Bytes);
public long this[int i]=>Value[i];

public static A040892Inst Instance=new A040892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041581
{
public static readonly long[] Value={ 1L,1L,2L,9L,11L,20L,691L,711L,1402L,6319L,7721L,14040L,485081L,499121L,984202L,4435929L,5420131L,9856060L,340526171L,350382231L,690908402L,3114015839L,3804924241L,6918940080L,239048886961L,245967827041L,485016714002L,2186034683049L,2671051397051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041581Inst : IEnumerable<long>
{
public static readonly long[] Value=A041581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041581.Bytes);
public long this[int i]=>Value[i];

public static A041581Inst Instance=new A041581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041582
{
public static readonly long[] Value={ 17L,18L,35L,88L,123L,334L,1459L,1793L,3252L,5045L,43612L,266717L,310329L,3370007L,3680336L,25452023L,207296520L,232748543L,440045063L,672793606L,3131219487L,6935232580L,10066452067L,27068136714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041582Inst : IEnumerable<long>
{
public static readonly long[] Value=A041582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041582.Bytes);
public long this[int i]=>Value[i];

public static A041582Inst Instance=new A041582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041583
{
public static readonly long[] Value={ 1L,1L,2L,5L,7L,19L,83L,102L,185L,287L,2481L,15173L,17654L,191713L,209367L,1447915L,11792687L,13240602L,25033289L,38273891L,178128853L,394531597L,572660450L,1539852497L,2112512947L,3652365444L,126292938043L,129945303487L,256238241530L,642421786547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041583Inst : IEnumerable<long>
{
public static readonly long[] Value=A041583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041583.Bytes);
public long this[int i]=>Value[i];

public static A041583Inst Instance=new A041583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041584
{
public static readonly long[] Value={ 17L,18L,35L,53L,88L,493L,1567L,2060L,5687L,7747L,28928L,152387L,181315L,333702L,515017L,848719L,29371463L,30220182L,59591645L,89811827L,149403472L,836829187L,2659891033L,3496720220L,9653331473L,13150051693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041584Inst : IEnumerable<long>
{
public static readonly long[] Value=A041584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041584.Bytes);
public long this[int i]=>Value[i];

public static A041584Inst Instance=new A041584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041585
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,28L,89L,117L,323L,440L,1643L,8655L,10298L,18953L,29251L,48204L,1668187L,1716391L,3384578L,5100969L,8485547L,47528704L,151071659L,198600363L,548272385L,746872748L,2788890629L,14691325893L,17480216522L,32171542415L,49651758937L,81823301352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041585Inst : IEnumerable<long>
{
public static readonly long[] Value=A041585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041585.Bytes);
public long this[int i]=>Value[i];

public static A041585Inst Instance=new A041585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041586
{
public static readonly long[] Value={ 17L,18L,35L,53L,141L,194L,1305L,4109L,71158L,217583L,1376656L,1594239L,4565134L,6159373L,10724507L,16883880L,584776427L,601660307L,1186436734L,1788097041L,4762630816L,6550727857L,44066997958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041586Inst : IEnumerable<long>
{
public static readonly long[] Value=A041586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041586.Bytes);
public long this[int i]=>Value[i];

public static A041586Inst Instance=new A041586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041587
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,11L,74L,233L,4035L,12338L,78063L,90401L,258865L,349266L,608131L,957397L,33159629L,34117026L,67276655L,101393681L,270064017L,371457698L,2498810205L,7867888313L,136252911526L,416626622891L,2636012648872L,3052639271763L,8741291192398L,11793930464161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041587Inst : IEnumerable<long>
{
public static readonly long[] Value=A041587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041587.Bytes);
public long this[int i]=>Value[i];

public static A041587Inst Instance=new A041587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041588
{
public static readonly long[] Value={ 17L,18L,35L,53L,1837L,1890L,3727L,5617L,194705L,200322L,395027L,595349L,20636893L,21232242L,41869135L,63101377L,2187315953L,2250417330L,4437733283L,6688150613L,231834854125L,238523004738L,470357858863L,708880863601L,24572307221297L,25281188084898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041588Inst : IEnumerable<long>
{
public static readonly long[] Value=A041588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041588.Bytes);
public long this[int i]=>Value[i];

public static A041588Inst Instance=new A041588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041589
{
public static readonly long[] Value={ 1L,1L,2L,3L,104L,107L,211L,318L,11023L,11341L,22364L,33705L,1168334L,1202039L,2370373L,3572412L,123832381L,127404793L,251237174L,378641967L,13125064052L,13503706019L,26628770071L,40132476090L,1391132957131L,1431265433221L,2822398390352L,4253663823573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041589Inst : IEnumerable<long>
{
public static readonly long[] Value=A041589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041589.Bytes);
public long this[int i]=>Value[i];

public static A041589Inst Instance=new A041589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041590
{
public static readonly long[] Value={ 17L,18L,53L,230L,2583L,2813L,5396L,19001L,43398L,105797L,360789L,466586L,827375L,9567711L,39098219L,87764149L,126862368L,4401084661L,4527947029L,13456978719L,58355861905L,655371459674L,713727321579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041590Inst : IEnumerable<long>
{
public static readonly long[] Value=A041590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041590.Bytes);
public long this[int i]=>Value[i];

public static A041590Inst Instance=new A041590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041591
{
public static readonly long[] Value={ 1L,1L,3L,13L,146L,159L,305L,1074L,2453L,5980L,20393L,26373L,46766L,540799L,2209962L,4960723L,7170685L,248764013L,255934698L,760633409L,3298468334L,37043785083L,40342253417L,77386038500L,272500368917L,622386776334L,1517273921585L,5174208541089L,6691482462674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041591Inst : IEnumerable<long>
{
public static readonly long[] Value=A041591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041591.Bytes);
public long this[int i]=>Value[i];

public static A041591Inst Instance=new A041591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041592
{
public static readonly long[] Value={ 17L,18L,53L,71L,124L,319L,443L,15381L,15824L,47029L,62853L,109882L,282617L,392499L,13627583L,14020082L,41667747L,55687829L,97355576L,250398981L,347754557L,12074053919L,12421808476L,36917670871L,49339479347L,86257150218L,221853779783L,308110930001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041592Inst : IEnumerable<long>
{
public static readonly long[] Value=A041592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041592.Bytes);
public long this[int i]=>Value[i];

public static A041592Inst Instance=new A041592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041593
{
public static readonly long[] Value={ 1L,1L,3L,4L,7L,18L,25L,868L,893L,2654L,3547L,6201L,15949L,22150L,769049L,791199L,2351447L,3142646L,5494093L,14130832L,19624925L,681378282L,701003207L,2083384696L,2784387903L,4867772599L,12519933101L,17387705700L,603701926901L,621089632601L,1845881192103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041593Inst : IEnumerable<long>
{
public static readonly long[] Value=A041593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041593.Bytes);
public long this[int i]=>Value[i];

public static A041593Inst Instance=new A041593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041594
{
public static readonly long[] Value={ 17L,18L,53L,71L,2467L,2538L,7543L,10081L,350297L,360378L,1071053L,1431431L,49739707L,51171138L,152081983L,203253121L,7062688097L,7265941218L,21594570533L,28860511751L,1002851970067L,1031712481818L,3066276933703L,4097989415521L,142397917061417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041594Inst : IEnumerable<long>
{
public static readonly long[] Value=A041594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041594.Bytes);
public long this[int i]=>Value[i];

public static A041594Inst Instance=new A041594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041595
{
public static readonly long[] Value={ 1L,1L,3L,4L,139L,143L,425L,568L,19737L,20305L,60347L,80652L,2802515L,2883167L,8568849L,11452016L,397937393L,409389409L,1216716211L,1626105620L,56504307291L,58130412911L,172765133113L,230895546024L,8023213697929L,8254109243953L,24531432185835L,32785541429788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041595Inst : IEnumerable<long>
{
public static readonly long[] Value=A041595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041595.Bytes);
public long this[int i]=>Value[i];

public static A041595Inst Instance=new A041595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041596
{
public static readonly long[] Value={ 17L,18L,71L,160L,1351L,2862L,9937L,12799L,445103L,457902L,1818809L,4095520L,34582969L,73261458L,254367343L,327628801L,11393746577L,11721375378L,46557872711L,104837120800L,885254839111L,1875346799022L,6511295236177L,8386642035199L,291657124432943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041596Inst : IEnumerable<long>
{
public static readonly long[] Value=A041596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041596.Bytes);
public long this[int i]=>Value[i];

public static A041596Inst Instance=new A041596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041613
{
public static readonly BigInteger[] Value={ 1L,36L,1297L,46728L,1683505L,60652908L,2185188193L,78727427856L,2836372591009L,102188140704180L,3681609437941489L,132640127906597784L,4778726214075461713L,BigInteger.Parse("172166783834623219452"),BigInteger.Parse("6202782944260511361985"),BigInteger.Parse("223472352777213032250912") };
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
public class A041613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041613Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041613.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041613Inst Instance=new A041613Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041614
{
public static readonly BigInteger[] Value={ 18L,325L,11718L,211249L,7616682L,137311525L,4950831582L,89252280001L,3218032911618L,58013844689125L,2091716441720118L,37708909795651249L,1359612469085165082L,BigInteger.Parse("24510733353328622725"),BigInteger.Parse("883746013188915583182"),BigInteger.Parse("15931938970753809120001"),BigInteger.Parse("574433548960326043903218") };
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
public class A041614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041614Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041614.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041614Inst Instance=new A041614Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041615
{
public static readonly BigInteger[] Value={ 1L,18L,649L,11700L,421849L,7604982L,274201201L,4943226600L,178230358801L,3213089685018L,115849459019449L,2088503352035100L,75301970132283049L,1357523965733129982L,BigInteger.Parse("48946164736524962401"),BigInteger.Parse("882388489223182453200"),BigInteger.Parse("31814931776771093277601") };
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
public class A041615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041615Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041615.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041615Inst Instance=new A041615Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041616
{
public static readonly BigInteger[] Value={ 18L,217L,7830L,94177L,3398202L,40872601L,1474811838L,17738614657L,640064939490L,7698517888537L,277786708926822L,3341139025010401L,120558791609301258L,1450046638336625497L,BigInteger.Parse("52322237771727819150"),BigInteger.Parse("629316899899070455297"),BigInteger.Parse("22707730634138264209842") };
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
public class A041616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041616Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041616.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041616Inst Instance=new A041616Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041617
{
public static readonly BigInteger[] Value={ 1L,12L,433L,5208L,187921L,2260260L,81557281L,980947632L,35395672033L,425729012028L,15361640105041L,184765410272520L,6666916409915761L,80187762329261652L,2893426360263335233L,BigInteger.Parse("34801304085489284448"),BigInteger.Parse("1255740373437877575361") };
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
public class A041617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041617Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041617.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041617Inst Instance=new A041617Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041618
{
public static readonly long[] Value={ 18L,163L,5886L,53137L,1918818L,17322499L,625528782L,5647081537L,203920464114L,1840931258563L,66477445772382L,600137943210001L,21671443401332418L,195643128555201763L,7064824071388595886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041618Inst : IEnumerable<long>
{
public static readonly long[] Value=A041618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041618.Bytes);
public long this[int i]=>Value[i];

public static A041618Inst Instance=new A041618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041619
{
public static readonly long[] Value={ 1L,9L,325L,2934L,105949L,956475L,34539049L,311807916L,11259624025L,101648424141L,3670602893101L,33137074462050L,1196605283526901L,10802584626204159L,390089651826876625L,3521609451068093784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041619Inst : IEnumerable<long>
{
public static readonly long[] Value=A041619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041619.Bytes);
public long this[int i]=>Value[i];

public static A041619Inst Instance=new A041619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041620
{
public static readonly long[] Value={ 18L,127L,526L,1179L,1705L,2884L,13241L,16125L,29366L,74857L,328794L,2376415L,85879734L,603534553L,2500017946L,5603570445L,8103588391L,13707158836L,62932223735L,76639382571L,139571606306L,355782595183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041620Inst : IEnumerable<long>
{
public static readonly long[] Value=A041620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041620.Bytes);
public long this[int i]=>Value[i];

public static A041620Inst Instance=new A041620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041621
{
public static readonly long[] Value={ 1L,7L,29L,65L,94L,159L,730L,889L,1619L,4127L,18127L,131016L,4734703L,33273937L,137830451L,308934839L,446765290L,755700129L,3469565806L,4225265935L,7694831741L,19614929417L,86154549409L,622696775280L,22503238459489L,158145365991703L,655084702426301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041621Inst : IEnumerable<long>
{
public static readonly long[] Value=A041621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041621.Bytes);
public long this[int i]=>Value[i];

public static A041621Inst Instance=new A041621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041622
{
public static readonly BigInteger[] Value={ 18L,109L,3942L,23761L,859338L,5179789L,187331742L,1129170241L,40837460418L,246153932749L,8902379039382L,53660428169041L,1940677793124858L,11697727186918189L,423058856522179662L,2550050866319996161L,BigInteger.Parse("92224890044042041458"),BigInteger.Parse("555899391130572244909") };
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
public class A041622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041622Inst Instance=new A041622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041623
{
public static readonly BigInteger[] Value={ 1L,6L,217L,1308L,47305L,285138L,10312273L,62158776L,2248028209L,13550328030L,490059837289L,2953909351764L,106830796500793L,643938688356522L,23288623577335585L,140375680152370032L,5076813109062656737L,BigInteger.Parse("30601254334528310454"),BigInteger.Parse("1106721969152081833081") };
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
public class A041623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041623Inst Instance=new A041623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041624
{
public static readonly long[] Value={ 18L,91L,473L,564L,3857L,8278L,28691L,36969L,65660L,168289L,233949L,636187L,870136L,10207683L,21285502L,31493185L,52778687L,928730864L,981509551L,1910240415L,4801990381L,54732134606L,59534124987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041624Inst : IEnumerable<long>
{
public static readonly long[] Value=A041624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041624.Bytes);
public long this[int i]=>Value[i];

public static A041624Inst Instance=new A041624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041625
{
public static readonly long[] Value={ 1L,5L,26L,31L,212L,455L,1577L,2032L,3609L,9250L,12859L,34968L,47827L,561065L,1169957L,1731022L,2900979L,51047665L,53948644L,104996309L,263941262L,3008350191L,3272291453L,9552933097L,12825224550L,35203382197L,48028606747L,83231988944L,297724573579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041625Inst : IEnumerable<long>
{
public static readonly long[] Value=A041625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041625.Bytes);
public long this[int i]=>Value[i];

public static A041625Inst Instance=new A041625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041626
{
public static readonly long[] Value={ 18L,73L,91L,164L,1403L,1567L,2970L,13447L,487062L,1961695L,2448757L,4410452L,37732373L,42142825L,79875198L,361643617L,13099045410L,52757825257L,65856870667L,118614695924L,1014774438059L,1133389133983L,2148163572042L,9726043422151L,352285726769478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041626Inst : IEnumerable<long>
{
public static readonly long[] Value=A041626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041626.Bytes);
public long this[int i]=>Value[i];

public static A041626Inst Instance=new A041626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041627
{
public static readonly long[] Value={ 1L,4L,5L,9L,77L,86L,163L,738L,26731L,107662L,134393L,242055L,2070833L,2312888L,4383721L,19847772L,718903513L,2895461824L,3614365337L,6509827161L,55692982625L,62202809786L,117895792411L,533785979430L,19334191051891L,77870550186994L,97204741238885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041627Inst : IEnumerable<long>
{
public static readonly long[] Value=A041627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041627.Bytes);
public long this[int i]=>Value[i];

public static A041627Inst Instance=new A041627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041628
{
public static readonly BigInteger[] Value={ 18L,73L,2646L,10657L,386298L,1555849L,56396862L,227143297L,8233555554L,33161365513L,1202042714022L,4841332221601L,175490002691658L,706801342988233L,25620338350268046L,103188154744060417L,3740393909136443058L,15064763791289832649UL,BigInteger.Parse("546071890395570418422") };
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
public class A041628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041628Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041628.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041628Inst Instance=new A041628Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041677
{
public static readonly long[] Value={ 1L,1L,9L,19L,161L,180L,6641L,6821L,61209L,129239L,1095121L,1224360L,45172081L,46396441L,416343609L,879083659L,7449012881L,8328096540L,307260488321L,315588584861L,2831969167209L,5979526919279L,50668184521441L,56647711440720L,2089985796387361L,2146633507828081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041677Inst : IEnumerable<long>
{
public static readonly long[] Value=A041677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041677.Bytes);
public long this[int i]=>Value[i];

public static A041677Inst Instance=new A041677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041678
{
public static readonly long[] Value={ 18L,19L,227L,246L,473L,719L,2630L,3349L,5979L,27265L,33244L,193485L,420214L,7757337L,15934888L,87431777L,103366665L,500898437L,604265102L,1105163539L,3919755719L,5024919258L,8944674977L,13969594235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041678Inst : IEnumerable<long>
{
public static readonly long[] Value=A041678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041678.Bytes);
public long this[int i]=>Value[i];

public static A041678Inst Instance=new A041678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041679
{
public static readonly long[] Value={ 1L,1L,12L,13L,25L,38L,139L,177L,316L,1441L,1757L,10226L,22209L,409988L,842185L,4620913L,5463098L,26473305L,31936403L,58409708L,207165527L,265575235L,472740762L,738315997L,8594216729L,9332532726L,344565394865L,353897927591L,4237442598366L,4591340525957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041679Inst : IEnumerable<long>
{
public static readonly long[] Value=A041679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041679.Bytes);
public long this[int i]=>Value[i];

public static A041679Inst Instance=new A041679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041680
{
public static readonly long[] Value={ 18L,19L,341L,360L,13301L,13661L,245538L,259199L,9576702L,9835901L,176787019L,186622920L,6895212139L,7081835059L,127286408142L,134368243201L,4964543163378L,5098911406579L,91646037075221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041680Inst : IEnumerable<long>
{
public static readonly long[] Value=A041680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041680.Bytes);
public long this[int i]=>Value[i];

public static A041680Inst Instance=new A041680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041681
{
public static readonly long[] Value={ 1L,1L,18L,19L,702L,721L,12959L,13680L,505439L,519119L,9330462L,9849581L,363915378L,373764959L,6717919681L,7091684640L,262018566721L,269110251361L,4836892839858L,5106003091219L,188653004123742L,193759007214961L,3482556126778079L,3676315133993040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041681Inst : IEnumerable<long>
{
public static readonly long[] Value=A041681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041681.Bytes);
public long this[int i]=>Value[i];

public static A041681Inst Instance=new A041681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041682
{
public static readonly long[] Value={ 18L,19L,702L,721L,26658L,27379L,1012302L,1039681L,38440818L,39480499L,1459738782L,1499219281L,55431632898L,56930852179L,2104942311342L,2161873163521L,79932376198098L,82094249361619L,3035325353216382L,3117419602578001L,115262431046024418L,118379850648602419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041682Inst : IEnumerable<long>
{
public static readonly long[] Value=A041682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041682.Bytes);
public long this[int i]=>Value[i];

public static A041682Inst Instance=new A041682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041683
{
public static readonly long[] Value={ 1L,1L,37L,38L,1405L,1443L,53353L,54796L,2026009L,2080805L,76934989L,79015794L,2921503573L,3000519367L,110940200785L,113940720152L,4212806126257L,4326746846409L,159975692596981L,164302439443390L,6074863512559021L,6239165952002411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041683Inst : IEnumerable<long>
{
public static readonly long[] Value=A041683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041683.Bytes);
public long this[int i]=>Value[i];

public static A041683Inst Instance=new A041683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041684
{
public static readonly BigInteger[] Value={ 19L,723L,27493L,1045457L,39754859L,1511730099L,57485498621L,2185960677697L,83123991251107L,3160897628219763L,120197233863602101L,4570655784445099601L,BigInteger.Parse("173805117042777386939"),BigInteger.Parse("6609165103409985803283"),BigInteger.Parse("251322079046622237911693"),BigInteger.Parse("9556848168875055026447617") };
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
public class A041684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041684Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041684.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041684Inst Instance=new A041684Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041685
{
public static readonly BigInteger[] Value={ 1L,38L,1445L,54948L,2089469L,79454770L,3021370729L,114891542472L,4368899984665L,166133090959742L,6317426356454861L,240228334636244460L,9134994142533744341L,BigInteger.Parse("347370005750918529418"),BigInteger.Parse("13209195212677437862225"),BigInteger.Parse("502296788087493557293968") };
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
public class A041685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041685Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041685.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041685Inst Instance=new A041685Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041686
{
public static readonly BigInteger[] Value={ 19L,362L,13775L,262087L,9973081L,189750626L,7220496869L,137379191137L,5227629760075L,99462344632562L,3784796725797431L,72010600134783751L,2740187601847579969L,BigInteger.Parse("52135575035238803162"),BigInteger.Parse("1983892038940922100125"),BigInteger.Parse("37746084314912758705537"),BigInteger.Parse("1436335096005625752910531") };
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
public class A041686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041686Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041686.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041686Inst Instance=new A041686Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041687
{
public static readonly BigInteger[] Value={ 1L,19L,723L,13756L,523451L,9959325L,378977801L,7210537544L,274379404473L,5220419222531L,198650309860651L,3779576306574900L,143822549959706851L,2736408025541005069L,BigInteger.Parse("104127327520517899473"),BigInteger.Parse("1981155630915381095056"),BigInteger.Parse("75388041302304999511601") };
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
public class A041687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A041687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A041687Inst Instance=new A041687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041688
{
public static readonly long[] Value={ 19L,229L,248L,725L,2423L,3148L,27607L,30755L,119872L,270499L,390371L,4954951L,188678509L,2269097059L,2457775568L,7184648195L,24011720153L,31196368348L,273582666937L,304779035285L,1187919772792L,2680618580869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041688Inst : IEnumerable<long>
{
public static readonly long[] Value=A041688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041688.Bytes);
public long this[int i]=>Value[i];

public static A041688Inst Instance=new A041688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041689
{
public static readonly long[] Value={ 1L,12L,13L,38L,127L,165L,1447L,1612L,6283L,14178L,20461L,259710L,9889441L,118933002L,128822443L,376577888L,1258556107L,1635133995L,14339628067L,15974762062L,62263914253L,140502590568L,202766504821L,2573700648420L,98003391144781L,1178614394385792L,1276617785530573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041689Inst : IEnumerable<long>
{
public static readonly long[] Value=A041689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041689.Bytes);
public long this[int i]=>Value[i];

public static A041689Inst Instance=new A041689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041690
{
public static readonly long[] Value={ 19L,172L,191L,363L,3458L,131767L,1189361L,1321128L,2510489L,23915529L,911300591L,8225620848L,9136921439L,17362542287L,165399802022L,6302555019123L,56888394974129L,63190949993252L,120079344967381L,1143905054699681L,43588471423555259L,393440147866697012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041690Inst : IEnumerable<long>
{
public static readonly long[] Value=A041690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041690.Bytes);
public long this[int i]=>Value[i];

public static A041690Inst Instance=new A041690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041691
{
public static readonly long[] Value={ 1L,9L,10L,19L,181L,6897L,62254L,69151L,131405L,1251796L,47699653L,430548673L,478248326L,908796999L,8657421317L,329890807045L,2977674684722L,3307565491767L,6285240176489L,59874727080168L,2281524869222873L,20593598550086025L,22875123419308898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041691Inst : IEnumerable<long>
{
public static readonly long[] Value=A041691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041691.Bytes);
public long this[int i]=>Value[i];

public static A041691Inst Instance=new A041691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041692
{
public static readonly long[] Value={ 19L,134L,153L,287L,440L,1167L,14444L,30055L,44499L,74554L,119053L,907925L,34620203L,243249346L,277869549L,521118895L,798988444L,2119095783L,26228137840L,54575371463L,80803509303L,135378880766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041692Inst : IEnumerable<long>
{
public static readonly long[] Value=A041692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041692.Bytes);
public long this[int i]=>Value[i];

public static A041692Inst Instance=new A041692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041693
{
public static readonly long[] Value={ 1L,7L,8L,15L,23L,61L,755L,1571L,2326L,3897L,6223L,47458L,1809627L,12714847L,14524474L,27239321L,41763795L,110766911L,1370966727L,2852700365L,4223667092L,7076367457L,11300034549L,86176609300L,3286011187949L,23088254924943L,26374266112892L,49462521037835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041693Inst : IEnumerable<long>
{
public static readonly long[] Value=A041693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041693.Bytes);
public long this[int i]=>Value[i];

public static A041693Inst Instance=new A041693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041694
{
public static readonly long[] Value={ 19L,115L,249L,364L,1341L,1705L,3046L,7797L,10843L,137913L,2631190L,31712193L,34343383L,100398959L,134742342L,235141301L,840166245L,1075307546L,2990781337L,19019995568L,725750612921L,4373523673094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041694Inst : IEnumerable<long>
{
public static readonly long[] Value=A041694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041694.Bytes);
public long this[int i]=>Value[i];

public static A041694Inst Instance=new A041694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041695
{
public static readonly long[] Value={ 1L,6L,13L,19L,70L,89L,159L,407L,566L,7199L,137347L,1655363L,1792710L,5240783L,7033493L,12274276L,43856321L,56130597L,156117515L,992835687L,37883873621L,228296077413L,494476028447L,722772105860L,2662792346027L,3385564451887L,6048356797914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041695Inst : IEnumerable<long>
{
public static readonly long[] Value=A041695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041695.Bytes);
public long this[int i]=>Value[i];

public static A041695Inst Instance=new A041695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041696
{
public static readonly long[] Value={ 19L,96L,211L,1151L,43949L,220896L,485741L,2649601L,101170579L,508502496L,1118175571L,6099380351L,232894628909L,1170572524896L,2574039678701L,14040770918401L,536123334577939L,2694657443808096L,5925438222194131L,32321848554778751L,1234155683303786669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041696Inst : IEnumerable<long>
{
public static readonly long[] Value=A041696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041696.Bytes);
public long this[int i]=>Value[i];

public static A041696Inst Instance=new A041696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041697
{
public static readonly long[] Value={ 1L,5L,11L,60L,2291L,11515L,25321L,138120L,5273881L,26507525L,58288931L,317952180L,12140471771L,61020311035L,134181093841L,731925780240L,27947360742961L,140468729495045L,308884819733051L,1684892828160300L,64334812289824451L,323358954277282555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041697Inst : IEnumerable<long>
{
public static readonly long[] Value=A041697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041697.Bytes);
public long this[int i]=>Value[i];

public static A041697Inst Instance=new A041697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041698
{
public static readonly long[] Value={ 19L,77L,96L,365L,826L,6147L,25414L,184045L,393504L,1364557L,1758061L,8396801L,320836499L,1291742797L,1612579296L,6129480685L,13871540666L,103230265347L,426792602054L,3090778479725L,6608349561504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041698Inst : IEnumerable<long>
{
public static readonly long[] Value=A041698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041698.Bytes);
public long this[int i]=>Value[i];

public static A041698Inst Instance=new A041698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041699
{
public static readonly long[] Value={ 1L,4L,5L,19L,43L,320L,1323L,9581L,20485L,71036L,91521L,437120L,16702081L,67245444L,83947525L,319088019L,722123563L,5373952960L,22217935403L,160899500781L,344016936965L,1192950311676L,1536967248641L,7340819306240L,280488100885761L,1129293222849284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041699Inst : IEnumerable<long>
{
public static readonly long[] Value=A041699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041699.Bytes);
public long this[int i]=>Value[i];

public static A041699Inst Instance=new A041699Inst();

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