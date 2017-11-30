using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040596
{
public static readonly long[] Value={ 24L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040596Inst : IEnumerable<long>
{
public static readonly long[] Value=A040596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040596.Bytes);
public long this[int i]=>Value[i];

public static A040596Inst Instance=new A040596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040597
{
public static readonly long[] Value={ 24L,1L,15L,1L,1L,1L,4L,1L,7L,2L,24L,2L,7L,1L,4L,1L,1L,1L,15L,1L,48L,1L,15L,1L,1L,1L,4L,1L,7L,2L,24L,2L,7L,1L,4L,1L,1L,1L,15L,1L,48L,1L,15L,1L,1L,1L,4L,1L,7L,2L,24L,2L,7L,1L,4L,1L,1L,1L,15L,1L,48L,1L,15L,1L,1L,1L,4L,1L,7L,2L,24L,2L,7L,1L,4L,1L,1L,1L,15L,1L,48L,1L,15L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040597Inst : IEnumerable<long>
{
public static readonly long[] Value=A040597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040597.Bytes);
public long this[int i]=>Value[i];

public static A040597Inst Instance=new A040597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040598
{
public static readonly long[] Value={ 24L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040598Inst : IEnumerable<long>
{
public static readonly long[] Value=A040598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040598.Bytes);
public long this[int i]=>Value[i];

public static A040598Inst Instance=new A040598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040599
{
public static readonly long[] Value={ 24L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040599Inst : IEnumerable<long>
{
public static readonly long[] Value=A040599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040599.Bytes);
public long this[int i]=>Value[i];

public static A040599Inst Instance=new A040599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040600
{
public static readonly long[] Value={ 25L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040600Inst : IEnumerable<long>
{
public static readonly long[] Value=A040600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040600.Bytes);
public long this[int i]=>Value[i];

public static A040600Inst Instance=new A040600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040601
{
public static readonly long[] Value={ 25L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040601Inst : IEnumerable<long>
{
public static readonly long[] Value=A040601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040601.Bytes);
public long this[int i]=>Value[i];

public static A040601Inst Instance=new A040601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040602
{
public static readonly long[] Value={ 25L,16L,1L,2L,5L,4L,2L,1L,2L,2L,3L,1L,3L,12L,3L,1L,3L,2L,2L,1L,2L,4L,5L,2L,1L,16L,50L,16L,1L,2L,5L,4L,2L,1L,2L,2L,3L,1L,3L,12L,3L,1L,3L,2L,2L,1L,2L,4L,5L,2L,1L,16L,50L,16L,1L,2L,5L,4L,2L,1L,2L,2L,3L,1L,3L,12L,3L,1L,3L,2L,2L,1L,2L,4L,5L,2L,1L,16L,50L,16L,1L,2L,5L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040602Inst : IEnumerable<long>
{
public static readonly long[] Value=A040602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040602.Bytes);
public long this[int i]=>Value[i];

public static A040602Inst Instance=new A040602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040603
{
public static readonly long[] Value={ 25L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040603Inst : IEnumerable<long>
{
public static readonly long[] Value=A040603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040603.Bytes);
public long this[int i]=>Value[i];

public static A040603Inst Instance=new A040603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040604
{
public static readonly long[] Value={ 25L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040604Inst : IEnumerable<long>
{
public static readonly long[] Value=A040604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040604.Bytes);
public long this[int i]=>Value[i];

public static A040604Inst Instance=new A040604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040653
{
public static readonly long[] Value={ 26L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040653Inst : IEnumerable<long>
{
public static readonly long[] Value=A040653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040653.Bytes);
public long this[int i]=>Value[i];

public static A040653Inst Instance=new A040653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040654
{
public static readonly long[] Value={ 26L,10L,2L,2L,1L,1L,2L,6L,7L,3L,2L,1L,16L,1L,2L,3L,7L,6L,2L,1L,1L,2L,2L,10L,52L,10L,2L,2L,1L,1L,2L,6L,7L,3L,2L,1L,16L,1L,2L,3L,7L,6L,2L,1L,1L,2L,2L,10L,52L,10L,2L,2L,1L,1L,2L,6L,7L,3L,2L,1L,16L,1L,2L,3L,7L,6L,2L,1L,1L,2L,2L,10L,52L,10L,2L,2L,1L,1L,2L,6L,7L,3L,2L,1L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040654Inst : IEnumerable<long>
{
public static readonly long[] Value=A040654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040654.Bytes);
public long this[int i]=>Value[i];

public static A040654Inst Instance=new A040654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040655
{
public static readonly long[] Value={ 26L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040655Inst : IEnumerable<long>
{
public static readonly long[] Value=A040655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040655.Bytes);
public long this[int i]=>Value[i];

public static A040655Inst Instance=new A040655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040656
{
public static readonly long[] Value={ 26L,7L,2L,4L,3L,1L,1L,25L,1L,1L,3L,4L,2L,7L,52L,7L,2L,4L,3L,1L,1L,25L,1L,1L,3L,4L,2L,7L,52L,7L,2L,4L,3L,1L,1L,25L,1L,1L,3L,4L,2L,7L,52L,7L,2L,4L,3L,1L,1L,25L,1L,1L,3L,4L,2L,7L,52L,7L,2L,4L,3L,1L,1L,25L,1L,1L,3L,4L,2L,7L,52L,7L,2L,4L,3L,1L,1L,25L,1L,1L,3L,4L,2L,7L,52L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040656Inst : IEnumerable<long>
{
public static readonly long[] Value=A040656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040656.Bytes);
public long this[int i]=>Value[i];

public static A040656Inst Instance=new A040656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040657
{
public static readonly long[] Value={ 26L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040657Inst : IEnumerable<long>
{
public static readonly long[] Value=A040657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040657.Bytes);
public long this[int i]=>Value[i];

public static A040657Inst Instance=new A040657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040658
{
public static readonly long[] Value={ 26L,5L,1L,3L,1L,12L,3L,2L,2L,3L,12L,1L,3L,1L,5L,52L,5L,1L,3L,1L,12L,3L,2L,2L,3L,12L,1L,3L,1L,5L,52L,5L,1L,3L,1L,12L,3L,2L,2L,3L,12L,1L,3L,1L,5L,52L,5L,1L,3L,1L,12L,3L,2L,2L,3L,12L,1L,3L,1L,5L,52L,5L,1L,3L,1L,12L,3L,2L,2L,3L,12L,1L,3L,1L,5L,52L,5L,1L,3L,1L,12L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040658Inst : IEnumerable<long>
{
public static readonly long[] Value=A040658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040658.Bytes);
public long this[int i]=>Value[i];

public static A040658Inst Instance=new A040658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040659
{
public static readonly long[] Value={ 26L,5L,4L,1L,1L,3L,2L,10L,26L,10L,2L,3L,1L,1L,4L,5L,52L,5L,4L,1L,1L,3L,2L,10L,26L,10L,2L,3L,1L,1L,4L,5L,52L,5L,4L,1L,1L,3L,2L,10L,26L,10L,2L,3L,1L,1L,4L,5L,52L,5L,4L,1L,1L,3L,2L,10L,26L,10L,2L,3L,1L,1L,4L,5L,52L,5L,4L,1L,1L,3L,2L,10L,26L,10L,2L,3L,1L,1L,4L,5L,52L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040659Inst : IEnumerable<long>
{
public static readonly long[] Value=A040659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040659.Bytes);
public long this[int i]=>Value[i];

public static A040659Inst Instance=new A040659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040660
{
public static readonly long[] Value={ 26L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040660Inst : IEnumerable<long>
{
public static readonly long[] Value=A040660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040660.Bytes);
public long this[int i]=>Value[i];

public static A040660Inst Instance=new A040660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040661
{
public static readonly long[] Value={ 26L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040661Inst : IEnumerable<long>
{
public static readonly long[] Value=A040661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040661.Bytes);
public long this[int i]=>Value[i];

public static A040661Inst Instance=new A040661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040662
{
public static readonly long[] Value={ 26L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040662Inst : IEnumerable<long>
{
public static readonly long[] Value=A040662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040662.Bytes);
public long this[int i]=>Value[i];

public static A040662Inst Instance=new A040662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040663
{
public static readonly long[] Value={ 26L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040663Inst : IEnumerable<long>
{
public static readonly long[] Value=A040663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040663.Bytes);
public long this[int i]=>Value[i];

public static A040663Inst Instance=new A040663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040664
{
public static readonly long[] Value={ 26L,3L,2L,17L,10L,2L,5L,2L,1L,2L,1L,4L,1L,1L,8L,4L,1L,1L,1L,25L,1L,1L,1L,4L,8L,1L,1L,4L,1L,2L,1L,2L,5L,2L,10L,17L,2L,3L,52L,3L,2L,17L,10L,2L,5L,2L,1L,2L,1L,4L,1L,1L,8L,4L,1L,1L,1L,25L,1L,1L,1L,4L,8L,1L,1L,4L,1L,2L,1L,2L,5L,2L,10L,17L,2L,3L,52L,3L,2L,17L,10L,2L,5L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040664Inst : IEnumerable<long>
{
public static readonly long[] Value=A040664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040664.Bytes);
public long this[int i]=>Value[i];

public static A040664Inst Instance=new A040664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040665
{
public static readonly long[] Value={ 26L,3L,3L,1L,2L,1L,1L,12L,1L,1L,2L,1L,3L,3L,52L,3L,3L,1L,2L,1L,1L,12L,1L,1L,2L,1L,3L,3L,52L,3L,3L,1L,2L,1L,1L,12L,1L,1L,2L,1L,3L,3L,52L,3L,3L,1L,2L,1L,1L,12L,1L,1L,2L,1L,3L,3L,52L,3L,3L,1L,2L,1L,1L,12L,1L,1L,2L,1L,3L,3L,52L,3L,3L,1L,2L,1L,1L,12L,1L,1L,2L,1L,3L,3L,52L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040665Inst : IEnumerable<long>
{
public static readonly long[] Value=A040665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040665.Bytes);
public long this[int i]=>Value[i];

public static A040665Inst Instance=new A040665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040666
{
public static readonly long[] Value={ 26L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040666Inst : IEnumerable<long>
{
public static readonly long[] Value=A040666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040666.Bytes);
public long this[int i]=>Value[i];

public static A040666Inst Instance=new A040666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040667
{
public static readonly long[] Value={ 26L,2L,1L,9L,1L,6L,1L,1L,1L,1L,1L,2L,1L,8L,17L,2L,4L,3L,3L,2L,4L,1L,5L,26L,5L,1L,4L,2L,3L,3L,4L,2L,17L,8L,1L,2L,1L,1L,1L,1L,1L,6L,1L,9L,1L,2L,52L,2L,1L,9L,1L,6L,1L,1L,1L,1L,1L,2L,1L,8L,17L,2L,4L,3L,3L,2L,4L,1L,5L,26L,5L,1L,4L,2L,3L,3L,4L,2L,17L,8L,1L,2L,1L,1L,1L,1L,1L,6L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040667Inst : IEnumerable<long>
{
public static readonly long[] Value=A040667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040667.Bytes);
public long this[int i]=>Value[i];

public static A040667Inst Instance=new A040667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040668
{
public static readonly long[] Value={ 26L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040668Inst : IEnumerable<long>
{
public static readonly long[] Value=A040668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040668.Bytes);
public long this[int i]=>Value[i];

public static A040668Inst Instance=new A040668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040685
{
public static readonly long[] Value={ 26L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040685Inst : IEnumerable<long>
{
public static readonly long[] Value=A040685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040685.Bytes);
public long this[int i]=>Value[i];

public static A040685Inst Instance=new A040685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040686
{
public static readonly long[] Value={ 26L,1L,2L,2L,1L,4L,6L,2L,6L,4L,1L,2L,2L,1L,52L,1L,2L,2L,1L,4L,6L,2L,6L,4L,1L,2L,2L,1L,52L,1L,2L,2L,1L,4L,6L,2L,6L,4L,1L,2L,2L,1L,52L,1L,2L,2L,1L,4L,6L,2L,6L,4L,1L,2L,2L,1L,52L,1L,2L,2L,1L,4L,6L,2L,6L,4L,1L,2L,2L,1L,52L,1L,2L,2L,1L,4L,6L,2L,6L,4L,1L,2L,2L,1L,52L,1L,2L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040686Inst : IEnumerable<long>
{
public static readonly long[] Value=A040686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040686.Bytes);
public long this[int i]=>Value[i];

public static A040686Inst Instance=new A040686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040687
{
public static readonly long[] Value={ 26L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040687Inst : IEnumerable<long>
{
public static readonly long[] Value=A040687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040687.Bytes);
public long this[int i]=>Value[i];

public static A040687Inst Instance=new A040687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040688
{
public static readonly long[] Value={ 26L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040688Inst : IEnumerable<long>
{
public static readonly long[] Value=A040688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040688.Bytes);
public long this[int i]=>Value[i];

public static A040688Inst Instance=new A040688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040689
{
public static readonly long[] Value={ 26L,1L,3L,7L,2L,1L,1L,6L,10L,1L,1L,4L,2L,1L,12L,1L,2L,4L,1L,1L,10L,6L,1L,1L,2L,7L,3L,1L,52L,1L,3L,7L,2L,1L,1L,6L,10L,1L,1L,4L,2L,1L,12L,1L,2L,4L,1L,1L,10L,6L,1L,1L,2L,7L,3L,1L,52L,1L,3L,7L,2L,1L,1L,6L,10L,1L,1L,4L,2L,1L,12L,1L,2L,4L,1L,1L,10L,6L,1L,1L,2L,7L,3L,1L,52L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040689Inst : IEnumerable<long>
{
public static readonly long[] Value=A040689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040689.Bytes);
public long this[int i]=>Value[i];

public static A040689Inst Instance=new A040689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040690
{
public static readonly long[] Value={ 26L,1L,3L,2L,12L,1L,16L,1L,12L,2L,3L,1L,52L,1L,3L,2L,12L,1L,16L,1L,12L,2L,3L,1L,52L,1L,3L,2L,12L,1L,16L,1L,12L,2L,3L,1L,52L,1L,3L,2L,12L,1L,16L,1L,12L,2L,3L,1L,52L,1L,3L,2L,12L,1L,16L,1L,12L,2L,3L,1L,52L,1L,3L,2L,12L,1L,16L,1L,12L,2L,3L,1L,52L,1L,3L,2L,12L,1L,16L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040690Inst : IEnumerable<long>
{
public static readonly long[] Value=A040690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040690.Bytes);
public long this[int i]=>Value[i];

public static A040690Inst Instance=new A040690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040691
{
public static readonly long[] Value={ 26L,1L,3L,1L,8L,7L,1L,1L,5L,2L,2L,1L,2L,3L,1L,3L,17L,1L,1L,2L,26L,2L,1L,1L,17L,3L,1L,3L,2L,1L,2L,2L,5L,1L,1L,7L,8L,1L,3L,1L,52L,1L,3L,1L,8L,7L,1L,1L,5L,2L,2L,1L,2L,3L,1L,3L,17L,1L,1L,2L,26L,2L,1L,1L,17L,3L,1L,3L,2L,1L,2L,2L,5L,1L,1L,7L,8L,1L,3L,1L,52L,1L,3L,1L,8L,7L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040691Inst : IEnumerable<long>
{
public static readonly long[] Value=A040691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040691.Bytes);
public long this[int i]=>Value[i];

public static A040691Inst Instance=new A040691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040692
{
public static readonly long[] Value={ 26L,1L,4L,2L,1L,1L,1L,1L,1L,4L,3L,1L,9L,1L,25L,1L,9L,1L,3L,4L,1L,1L,1L,1L,1L,2L,4L,1L,52L,1L,4L,2L,1L,1L,1L,1L,1L,4L,3L,1L,9L,1L,25L,1L,9L,1L,3L,4L,1L,1L,1L,1L,1L,2L,4L,1L,52L,1L,4L,2L,1L,1L,1L,1L,1L,4L,3L,1L,9L,1L,25L,1L,9L,1L,3L,4L,1L,1L,1L,1L,1L,2L,4L,1L,52L,1L,4L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040692Inst : IEnumerable<long>
{
public static readonly long[] Value=A040692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040692.Bytes);
public long this[int i]=>Value[i];

public static A040692Inst Instance=new A040692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040693
{
public static readonly long[] Value={ 26L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040693Inst : IEnumerable<long>
{
public static readonly long[] Value=A040693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040693.Bytes);
public long this[int i]=>Value[i];

public static A040693Inst Instance=new A040693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040694
{
public static readonly long[] Value={ 26L,1L,5L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,17L,3L,1L,1L,10L,5L,1L,6L,1L,5L,10L,1L,1L,3L,17L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,5L,1L,52L,1L,5L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,17L,3L,1L,1L,10L,5L,1L,6L,1L,5L,10L,1L,1L,3L,17L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,5L,1L,52L,1L,5L,1L,2L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040694Inst : IEnumerable<long>
{
public static readonly long[] Value=A040694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040694.Bytes);
public long this[int i]=>Value[i];

public static A040694Inst Instance=new A040694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040695
{
public static readonly long[] Value={ 26L,1L,6L,1L,2L,3L,2L,26L,2L,3L,2L,1L,6L,1L,52L,1L,6L,1L,2L,3L,2L,26L,2L,3L,2L,1L,6L,1L,52L,1L,6L,1L,2L,3L,2L,26L,2L,3L,2L,1L,6L,1L,52L,1L,6L,1L,2L,3L,2L,26L,2L,3L,2L,1L,6L,1L,52L,1L,6L,1L,2L,3L,2L,26L,2L,3L,2L,1L,6L,1L,52L,1L,6L,1L,2L,3L,2L,26L,2L,3L,2L,1L,6L,1L,52L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040695Inst : IEnumerable<long>
{
public static readonly long[] Value=A040695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040695.Bytes);
public long this[int i]=>Value[i];

public static A040695Inst Instance=new A040695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040696
{
public static readonly long[] Value={ 26L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040696Inst : IEnumerable<long>
{
public static readonly long[] Value=A040696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040696.Bytes);
public long this[int i]=>Value[i];

public static A040696Inst Instance=new A040696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040697
{
public static readonly long[] Value={ 26L,1L,9L,1L,3L,1L,1L,2L,1L,4L,5L,1L,3L,3L,3L,17L,1L,1L,1L,2L,1L,12L,1L,2L,1L,1L,1L,17L,3L,3L,3L,1L,5L,4L,1L,2L,1L,1L,3L,1L,9L,1L,52L,1L,9L,1L,3L,1L,1L,2L,1L,4L,5L,1L,3L,3L,3L,17L,1L,1L,1L,2L,1L,12L,1L,2L,1L,1L,1L,17L,3L,3L,3L,1L,5L,4L,1L,2L,1L,1L,3L,1L,9L,1L,52L,1L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040697Inst : IEnumerable<long>
{
public static readonly long[] Value=A040697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040697.Bytes);
public long this[int i]=>Value[i];

public static A040697Inst Instance=new A040697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040698
{
public static readonly long[] Value={ 26L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040698Inst : IEnumerable<long>
{
public static readonly long[] Value=A040698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040698.Bytes);
public long this[int i]=>Value[i];

public static A040698Inst Instance=new A040698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040699
{
public static readonly long[] Value={ 26L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040699Inst : IEnumerable<long>
{
public static readonly long[] Value=A040699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040699.Bytes);
public long this[int i]=>Value[i];

public static A040699Inst Instance=new A040699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040700
{
public static readonly long[] Value={ 26L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040700Inst : IEnumerable<long>
{
public static readonly long[] Value=A040700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040700.Bytes);
public long this[int i]=>Value[i];

public static A040700Inst Instance=new A040700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040717
{
public static readonly long[] Value={ 27L,3L,2L,1L,1L,5L,2L,10L,2L,5L,1L,1L,2L,3L,54L,3L,2L,1L,1L,5L,2L,10L,2L,5L,1L,1L,2L,3L,54L,3L,2L,1L,1L,5L,2L,10L,2L,5L,1L,1L,2L,3L,54L,3L,2L,1L,1L,5L,2L,10L,2L,5L,1L,1L,2L,3L,54L,3L,2L,1L,1L,5L,2L,10L,2L,5L,1L,1L,2L,3L,54L,3L,2L,1L,1L,5L,2L,10L,2L,5L,1L,1L,2L,3L,54L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040717Inst : IEnumerable<long>
{
public static readonly long[] Value=A040717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040717.Bytes);
public long this[int i]=>Value[i];

public static A040717Inst Instance=new A040717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040718
{
public static readonly long[] Value={ 27L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L,3L,54L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L,3L,54L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L,3L,54L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L,3L,54L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L,3L,54L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L,3L,54L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040718Inst : IEnumerable<long>
{
public static readonly long[] Value=A040718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040718.Bytes);
public long this[int i]=>Value[i];

public static A040718Inst Instance=new A040718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040719
{
public static readonly long[] Value={ 27L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040719Inst : IEnumerable<long>
{
public static readonly long[] Value=A040719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040719.Bytes);
public long this[int i]=>Value[i];

public static A040719Inst Instance=new A040719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040720
{
public static readonly long[] Value={ 27L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040720Inst : IEnumerable<long>
{
public static readonly long[] Value=A040720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040720.Bytes);
public long this[int i]=>Value[i];

public static A040720Inst Instance=new A040720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040721
{
public static readonly long[] Value={ 27L,2L,1L,2L,1L,1L,4L,2L,1L,1L,13L,10L,1L,6L,1L,10L,13L,1L,1L,2L,4L,1L,1L,2L,1L,2L,54L,2L,1L,2L,1L,1L,4L,2L,1L,1L,13L,10L,1L,6L,1L,10L,13L,1L,1L,2L,4L,1L,1L,2L,1L,2L,54L,2L,1L,2L,1L,1L,4L,2L,1L,1L,13L,10L,1L,6L,1L,10L,13L,1L,1L,2L,4L,1L,1L,2L,1L,2L,54L,2L,1L,2L,1L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040721Inst : IEnumerable<long>
{
public static readonly long[] Value=A040721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040721.Bytes);
public long this[int i]=>Value[i];

public static A040721Inst Instance=new A040721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040722
{
public static readonly long[] Value={ 27L,2L,1L,1L,2L,3L,1L,1L,8L,1L,1L,3L,2L,1L,1L,2L,54L,2L,1L,1L,2L,3L,1L,1L,8L,1L,1L,3L,2L,1L,1L,2L,54L,2L,1L,1L,2L,3L,1L,1L,8L,1L,1L,3L,2L,1L,1L,2L,54L,2L,1L,1L,2L,3L,1L,1L,8L,1L,1L,3L,2L,1L,1L,2L,54L,2L,1L,1L,2L,3L,1L,1L,8L,1L,1L,3L,2L,1L,1L,2L,54L,2L,1L,1L,2L,3L,1L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040722Inst : IEnumerable<long>
{
public static readonly long[] Value=A040722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040722.Bytes);
public long this[int i]=>Value[i];

public static A040722Inst Instance=new A040722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040723
{
public static readonly long[] Value={ 27L,2L,2L,8L,1L,2L,1L,3L,5L,1L,4L,1L,1L,1L,3L,1L,1L,3L,10L,1L,2L,7L,2L,17L,1L,4L,27L,4L,1L,17L,2L,7L,2L,1L,10L,3L,1L,1L,3L,1L,1L,1L,4L,1L,5L,3L,1L,2L,1L,8L,2L,2L,54L,2L,2L,8L,1L,2L,1L,3L,5L,1L,4L,1L,1L,1L,3L,1L,1L,3L,10L,1L,2L,7L,2L,17L,1L,4L,27L,4L,1L,17L,2L,7L,2L,1L,10L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040723Inst : IEnumerable<long>
{
public static readonly long[] Value=A040723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040723.Bytes);
public long this[int i]=>Value[i];

public static A040723Inst Instance=new A040723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040724
{
public static readonly long[] Value={ 27L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040724Inst : IEnumerable<long>
{
public static readonly long[] Value=A040724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040724.Bytes);
public long this[int i]=>Value[i];

public static A040724Inst Instance=new A040724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040725
{
public static readonly long[] Value={ 27L,2L,3L,1L,2L,1L,1L,1L,7L,4L,1L,6L,18L,6L,1L,4L,7L,1L,1L,1L,2L,1L,3L,2L,54L,2L,3L,1L,2L,1L,1L,1L,7L,4L,1L,6L,18L,6L,1L,4L,7L,1L,1L,1L,2L,1L,3L,2L,54L,2L,3L,1L,2L,1L,1L,1L,7L,4L,1L,6L,18L,6L,1L,4L,7L,1L,1L,1L,2L,1L,3L,2L,54L,2L,3L,1L,2L,1L,1L,1L,7L,4L,1L,6L,18L,6L,1L,4L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040725Inst : IEnumerable<long>
{
public static readonly long[] Value=A040725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040725.Bytes);
public long this[int i]=>Value[i];

public static A040725Inst Instance=new A040725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040726
{
public static readonly long[] Value={ 27L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040726Inst : IEnumerable<long>
{
public static readonly long[] Value=A040726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040726.Bytes);
public long this[int i]=>Value[i];

public static A040726Inst Instance=new A040726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040727
{
public static readonly long[] Value={ 27L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040727Inst : IEnumerable<long>
{
public static readonly long[] Value=A040727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040727.Bytes);
public long this[int i]=>Value[i];

public static A040727Inst Instance=new A040727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040728
{
public static readonly long[] Value={ 27L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040728Inst : IEnumerable<long>
{
public static readonly long[] Value=A040728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040728.Bytes);
public long this[int i]=>Value[i];

public static A040728Inst Instance=new A040728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040729
{
public static readonly long[] Value={ 27L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040729Inst : IEnumerable<long>
{
public static readonly long[] Value=A040729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040729.Bytes);
public long this[int i]=>Value[i];

public static A040729Inst Instance=new A040729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040730
{
public static readonly long[] Value={ 27L,1L,1L,7L,2L,1L,3L,3L,1L,26L,1L,3L,3L,1L,2L,7L,1L,1L,54L,1L,1L,7L,2L,1L,3L,3L,1L,26L,1L,3L,3L,1L,2L,7L,1L,1L,54L,1L,1L,7L,2L,1L,3L,3L,1L,26L,1L,3L,3L,1L,2L,7L,1L,1L,54L,1L,1L,7L,2L,1L,3L,3L,1L,26L,1L,3L,3L,1L,2L,7L,1L,1L,54L,1L,1L,7L,2L,1L,3L,3L,1L,26L,1L,3L,3L,1L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040730Inst : IEnumerable<long>
{
public static readonly long[] Value=A040730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040730.Bytes);
public long this[int i]=>Value[i];

public static A040730Inst Instance=new A040730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040731
{
public static readonly long[] Value={ 27L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040731Inst : IEnumerable<long>
{
public static readonly long[] Value=A040731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040731.Bytes);
public long this[int i]=>Value[i];

public static A040731Inst Instance=new A040731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040732
{
public static readonly long[] Value={ 27L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040732Inst : IEnumerable<long>
{
public static readonly long[] Value=A040732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040732.Bytes);
public long this[int i]=>Value[i];

public static A040732Inst Instance=new A040732Inst();

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

public static class A040861
{
public static readonly long[] Value={ 29L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L,58L,1L,5L,1L,1L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040861Inst : IEnumerable<long>
{
public static readonly long[] Value=A040861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040861.Bytes);
public long this[int i]=>Value[i];

public static A040861Inst Instance=new A040861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040862
{
public static readonly long[] Value={ 29L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L,14L,2L,6L,1L,58L,1L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040862Inst : IEnumerable<long>
{
public static readonly long[] Value=A040862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040862.Bytes);
public long this[int i]=>Value[i];

public static A040862Inst Instance=new A040862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040863
{
public static readonly long[] Value={ 29L,1L,7L,1L,1L,4L,14L,1L,2L,1L,1L,2L,1L,1L,2L,1L,14L,4L,1L,1L,7L,1L,58L,1L,7L,1L,1L,4L,14L,1L,2L,1L,1L,2L,1L,1L,2L,1L,14L,4L,1L,1L,7L,1L,58L,1L,7L,1L,1L,4L,14L,1L,2L,1L,1L,2L,1L,1L,2L,1L,14L,4L,1L,1L,7L,1L,58L,1L,7L,1L,1L,4L,14L,1L,2L,1L,1L,2L,1L,1L,2L,1L,14L,4L,1L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040863Inst : IEnumerable<long>
{
public static readonly long[] Value=A040863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040863.Bytes);
public long this[int i]=>Value[i];

public static A040863Inst Instance=new A040863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040864
{
public static readonly long[] Value={ 29L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L,58L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040864Inst : IEnumerable<long>
{
public static readonly long[] Value=A040864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040864.Bytes);
public long this[int i]=>Value[i];

public static A040864Inst Instance=new A040864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040865
{
public static readonly long[] Value={ 29L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L,1L,58L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040865Inst : IEnumerable<long>
{
public static readonly long[] Value=A040865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040865.Bytes);
public long this[int i]=>Value[i];

public static A040865Inst Instance=new A040865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040866
{
public static readonly long[] Value={ 29L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L,1L,58L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040866Inst : IEnumerable<long>
{
public static readonly long[] Value=A040866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040866.Bytes);
public long this[int i]=>Value[i];

public static A040866Inst Instance=new A040866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040867
{
public static readonly long[] Value={ 29L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L,1L,58L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040867Inst : IEnumerable<long>
{
public static readonly long[] Value=A040867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040867.Bytes);
public long this[int i]=>Value[i];

public static A040867Inst Instance=new A040867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040868
{
public static readonly long[] Value={ 29L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L,1L,58L,1L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040868Inst : IEnumerable<long>
{
public static readonly long[] Value=A040868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040868.Bytes);
public long this[int i]=>Value[i];

public static A040868Inst Instance=new A040868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040869
{
public static readonly long[] Value={ 29L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L,1L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040869Inst : IEnumerable<long>
{
public static readonly long[] Value=A040869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040869.Bytes);
public long this[int i]=>Value[i];

public static A040869Inst Instance=new A040869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040870
{
public static readonly long[] Value={ 30L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040870Inst : IEnumerable<long>
{
public static readonly long[] Value=A040870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040870.Bytes);
public long this[int i]=>Value[i];

public static A040870Inst Instance=new A040870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040871
{
public static readonly long[] Value={ 30L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L,30L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040871Inst : IEnumerable<long>
{
public static readonly long[] Value=A040871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040871.Bytes);
public long this[int i]=>Value[i];

public static A040871Inst Instance=new A040871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040872
{
public static readonly long[] Value={ 30L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L,20L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040872Inst : IEnumerable<long>
{
public static readonly long[] Value=A040872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040872.Bytes);
public long this[int i]=>Value[i];

public static A040872Inst Instance=new A040872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040873
{
public static readonly long[] Value={ 30L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L,15L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040873Inst : IEnumerable<long>
{
public static readonly long[] Value=A040873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040873.Bytes);
public long this[int i]=>Value[i];

public static A040873Inst Instance=new A040873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040874
{
public static readonly long[] Value={ 30L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L,12L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040874Inst : IEnumerable<long>
{
public static readonly long[] Value=A040874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040874.Bytes);
public long this[int i]=>Value[i];

public static A040874Inst Instance=new A040874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040875
{
public static readonly long[] Value={ 30L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L,10L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040875Inst : IEnumerable<long>
{
public static readonly long[] Value=A040875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040875.Bytes);
public long this[int i]=>Value[i];

public static A040875Inst Instance=new A040875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040876
{
public static readonly long[] Value={ 30L,8L,1L,1L,2L,2L,1L,19L,2L,1L,2L,5L,9L,1L,5L,1L,3L,1L,3L,1L,1L,29L,1L,1L,3L,1L,3L,1L,5L,1L,9L,5L,2L,1L,2L,19L,1L,2L,2L,1L,1L,8L,60L,8L,1L,1L,2L,2L,1L,19L,2L,1L,2L,5L,9L,1L,5L,1L,3L,1L,3L,1L,1L,29L,1L,1L,3L,1L,3L,1L,5L,1L,9L,5L,2L,1L,2L,19L,1L,2L,2L,1L,1L,8L,60L,8L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040876Inst : IEnumerable<long>
{
public static readonly long[] Value=A040876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040876.Bytes);
public long this[int i]=>Value[i];

public static A040876Inst Instance=new A040876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040893
{
public static readonly long[] Value={ 30L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L,14L,1L,1L,2L,60L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040893Inst : IEnumerable<long>
{
public static readonly long[] Value=A040893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040893.Bytes);
public long this[int i]=>Value[i];

public static A040893Inst Instance=new A040893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040894
{
public static readonly long[] Value={ 30L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L,60L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040894Inst : IEnumerable<long>
{
public static readonly long[] Value=A040894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040894.Bytes);
public long this[int i]=>Value[i];

public static A040894Inst Instance=new A040894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040895
{
public static readonly long[] Value={ 30L,2L,3L,11L,1L,7L,1L,3L,2L,5L,1L,1L,1L,4L,30L,4L,1L,1L,1L,5L,2L,3L,1L,7L,1L,11L,3L,2L,60L,2L,3L,11L,1L,7L,1L,3L,2L,5L,1L,1L,1L,4L,30L,4L,1L,1L,1L,5L,2L,3L,1L,7L,1L,11L,3L,2L,60L,2L,3L,11L,1L,7L,1L,3L,2L,5L,1L,1L,1L,4L,30L,4L,1L,1L,1L,5L,2L,3L,1L,7L,1L,11L,3L,2L,60L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040895Inst : IEnumerable<long>
{
public static readonly long[] Value=A040895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040895.Bytes);
public long this[int i]=>Value[i];

public static A040895Inst Instance=new A040895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040896
{
public static readonly long[] Value={ 30L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L,60L,2L,4L,5L,3L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040896Inst : IEnumerable<long>
{
public static readonly long[] Value=A040896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040896.Bytes);
public long this[int i]=>Value[i];

public static A040896Inst Instance=new A040896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040897
{
public static readonly long[] Value={ 30L,2L,6L,3L,1L,1L,1L,8L,15L,8L,1L,1L,1L,3L,6L,2L,60L,2L,6L,3L,1L,1L,1L,8L,15L,8L,1L,1L,1L,3L,6L,2L,60L,2L,6L,3L,1L,1L,1L,8L,15L,8L,1L,1L,1L,3L,6L,2L,60L,2L,6L,3L,1L,1L,1L,8L,15L,8L,1L,1L,1L,3L,6L,2L,60L,2L,6L,3L,1L,1L,1L,8L,15L,8L,1L,1L,1L,3L,6L,2L,60L,2L,6L,3L,1L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040897Inst : IEnumerable<long>
{
public static readonly long[] Value=A040897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040897.Bytes);
public long this[int i]=>Value[i];

public static A040897Inst Instance=new A040897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040898
{
public static readonly long[] Value={ 30L,2L,11L,1L,2L,3L,2L,7L,5L,2L,2L,5L,7L,2L,3L,2L,1L,11L,2L,60L,2L,11L,1L,2L,3L,2L,7L,5L,2L,2L,5L,7L,2L,3L,2L,1L,11L,2L,60L,2L,11L,1L,2L,3L,2L,7L,5L,2L,2L,5L,7L,2L,3L,2L,1L,11L,2L,60L,2L,11L,1L,2L,3L,2L,7L,5L,2L,2L,5L,7L,2L,3L,2L,1L,11L,2L,60L,2L,11L,1L,2L,3L,2L,7L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040898Inst : IEnumerable<long>
{
public static readonly long[] Value=A040898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040898.Bytes);
public long this[int i]=>Value[i];

public static A040898Inst Instance=new A040898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040899
{
public static readonly long[] Value={ 30L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L,2L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040899Inst : IEnumerable<long>
{
public static readonly long[] Value=A040899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040899.Bytes);
public long this[int i]=>Value[i];

public static A040899Inst Instance=new A040899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040900
{
public static readonly long[] Value={ 30L,1L,1L,19L,1L,5L,6L,1L,1L,1L,1L,2L,1L,1L,1L,1L,6L,5L,1L,19L,1L,1L,60L,1L,1L,19L,1L,5L,6L,1L,1L,1L,1L,2L,1L,1L,1L,1L,6L,5L,1L,19L,1L,1L,60L,1L,1L,19L,1L,5L,6L,1L,1L,1L,1L,2L,1L,1L,1L,1L,6L,5L,1L,19L,1L,1L,60L,1L,1L,19L,1L,5L,6L,1L,1L,1L,1L,2L,1L,1L,1L,1L,6L,5L,1L,19L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040900Inst : IEnumerable<long>
{
public static readonly long[] Value=A040900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040900.Bytes);
public long this[int i]=>Value[i];

public static A040900Inst Instance=new A040900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040901
{
public static readonly long[] Value={ 30L,1L,1L,8L,4L,1L,1L,2L,1L,1L,1L,14L,1L,1L,1L,2L,1L,1L,4L,8L,1L,1L,60L,1L,1L,8L,4L,1L,1L,2L,1L,1L,1L,14L,1L,1L,1L,2L,1L,1L,4L,8L,1L,1L,60L,1L,1L,8L,4L,1L,1L,2L,1L,1L,1L,14L,1L,1L,1L,2L,1L,1L,4L,8L,1L,1L,60L,1L,1L,8L,4L,1L,1L,2L,1L,1L,1L,14L,1L,1L,1L,2L,1L,1L,4L,8L,1L,1L,60L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040901Inst : IEnumerable<long>
{
public static readonly long[] Value=A040901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040901.Bytes);
public long this[int i]=>Value[i];

public static A040901Inst Instance=new A040901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040902
{
public static readonly long[] Value={ 30L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L,20L,5L,1L,1L,60L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040902Inst : IEnumerable<long>
{
public static readonly long[] Value=A040902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040902.Bytes);
public long this[int i]=>Value[i];

public static A040902Inst Instance=new A040902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040903
{
public static readonly long[] Value={ 30L,1L,1L,3L,1L,1L,3L,30L,3L,1L,1L,3L,1L,1L,60L,1L,1L,3L,1L,1L,3L,30L,3L,1L,1L,3L,1L,1L,60L,1L,1L,3L,1L,1L,3L,30L,3L,1L,1L,3L,1L,1L,60L,1L,1L,3L,1L,1L,3L,30L,3L,1L,1L,3L,1L,1L,60L,1L,1L,3L,1L,1L,3L,30L,3L,1L,1L,3L,1L,1L,60L,1L,1L,3L,1L,1L,3L,30L,3L,1L,1L,3L,1L,1L,60L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040903Inst : IEnumerable<long>
{
public static readonly long[] Value=A040903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040903.Bytes);
public long this[int i]=>Value[i];

public static A040903Inst Instance=new A040903Inst();

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