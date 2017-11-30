using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040940
{
public static readonly long[] Value={ 31L,5L,1L,1L,1L,7L,6L,1L,3L,1L,14L,1L,3L,1L,6L,7L,1L,1L,1L,5L,62L,5L,1L,1L,1L,7L,6L,1L,3L,1L,14L,1L,3L,1L,6L,7L,1L,1L,1L,5L,62L,5L,1L,1L,1L,7L,6L,1L,3L,1L,14L,1L,3L,1L,6L,7L,1L,1L,1L,5L,62L,5L,1L,1L,1L,7L,6L,1L,3L,1L,14L,1L,3L,1L,6L,7L,1L,1L,1L,5L,62L,5L,1L,1L,1L,7L,6L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040940Inst : IEnumerable<long>
{
public static readonly long[] Value=A040940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040940.Bytes);
public long this[int i]=>Value[i];

public static A040940Inst Instance=new A040940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040939
{
public static readonly long[] Value={ 31L,6L,4L,1L,1L,1L,2L,5L,3L,2L,12L,31L,12L,2L,3L,5L,2L,1L,1L,1L,4L,6L,62L,6L,4L,1L,1L,1L,2L,5L,3L,2L,12L,31L,12L,2L,3L,5L,2L,1L,1L,1L,4L,6L,62L,6L,4L,1L,1L,1L,2L,5L,3L,2L,12L,31L,12L,2L,3L,5L,2L,1L,1L,1L,4L,6L,62L,6L,4L,1L,1L,1L,2L,5L,3L,2L,12L,31L,12L,2L,3L,5L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040939Inst : IEnumerable<long>
{
public static readonly long[] Value=A040939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040939.Bytes);
public long this[int i]=>Value[i];

public static A040939Inst Instance=new A040939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040938
{
public static readonly long[] Value={ 31L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L,6L,62L,6L,1L,9L,1L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040938Inst : IEnumerable<long>
{
public static readonly long[] Value=A040938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040938.Bytes);
public long this[int i]=>Value[i];

public static A040938Inst Instance=new A040938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040937
{
public static readonly long[] Value={ 31L,7L,1L,3L,3L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,7L,62L,7L,1L,3L,3L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,7L,62L,7L,1L,3L,3L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,7L,62L,7L,1L,3L,3L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,7L,62L,7L,1L,3L,3L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,7L,62L,7L,1L,3L,3L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040937Inst : IEnumerable<long>
{
public static readonly long[] Value=A040937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040937.Bytes);
public long this[int i]=>Value[i];

public static A040937Inst Instance=new A040937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040936
{
public static readonly long[] Value={ 31L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L,6L,1L,8L,62L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040936Inst : IEnumerable<long>
{
public static readonly long[] Value=A040936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040936.Bytes);
public long this[int i]=>Value[i];

public static A040936Inst Instance=new A040936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040935
{
public static readonly long[] Value={ 31L,10L,2L,1L,6L,4L,3L,2L,2L,1L,1L,8L,3L,2L,1L,20L,31L,20L,1L,2L,3L,8L,1L,1L,2L,2L,3L,4L,6L,1L,2L,10L,62L,10L,2L,1L,6L,4L,3L,2L,2L,1L,1L,8L,3L,2L,1L,20L,31L,20L,1L,2L,3L,8L,1L,1L,2L,2L,3L,4L,6L,1L,2L,10L,62L,10L,2L,1L,6L,4L,3L,2L,2L,1L,1L,8L,3L,2L,1L,20L,31L,20L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040935Inst : IEnumerable<long>
{
public static readonly long[] Value=A040935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040935.Bytes);
public long this[int i]=>Value[i];

public static A040935Inst Instance=new A040935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040934
{
public static readonly long[] Value={ 31L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L,2L,2L,12L,62L,12L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040934Inst : IEnumerable<long>
{
public static readonly long[] Value=A040934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040934.Bytes);
public long this[int i]=>Value[i];

public static A040934Inst Instance=new A040934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040933
{
public static readonly long[] Value={ 31L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L,1L,1L,15L,62L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040933Inst : IEnumerable<long>
{
public static readonly long[] Value=A040933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040933.Bytes);
public long this[int i]=>Value[i];

public static A040933Inst Instance=new A040933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040932
{
public static readonly long[] Value={ 31L,20L,1L,2L,6L,1L,1L,3L,1L,1L,1L,1L,11L,1L,4L,3L,1L,14L,1L,3L,4L,1L,11L,1L,1L,1L,1L,3L,1L,1L,6L,2L,1L,20L,62L,20L,1L,2L,6L,1L,1L,3L,1L,1L,1L,1L,11L,1L,4L,3L,1L,14L,1L,3L,4L,1L,11L,1L,1L,1L,1L,3L,1L,1L,6L,2L,1L,20L,62L,20L,1L,2L,6L,1L,1L,3L,1L,1L,1L,1L,11L,1L,4L,3L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040932Inst : IEnumerable<long>
{
public static readonly long[] Value=A040932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040932.Bytes);
public long this[int i]=>Value[i];

public static A040932Inst Instance=new A040932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040931
{
public static readonly long[] Value={ 31L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L,31L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040931Inst : IEnumerable<long>
{
public static readonly long[] Value=A040931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040931.Bytes);
public long this[int i]=>Value[i];

public static A040931Inst Instance=new A040931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040930
{
public static readonly long[] Value={ 31L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040930Inst : IEnumerable<long>
{
public static readonly long[] Value=A040930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040930.Bytes);
public long this[int i]=>Value[i];

public static A040930Inst Instance=new A040930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040929
{
public static readonly long[] Value={ 30L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L,1L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040929Inst : IEnumerable<long>
{
public static readonly long[] Value=A040929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040929.Bytes);
public long this[int i]=>Value[i];

public static A040929Inst Instance=new A040929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040928
{
public static readonly long[] Value={ 30L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L,1L,60L,1L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040928Inst : IEnumerable<long>
{
public static readonly long[] Value=A040928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040928.Bytes);
public long this[int i]=>Value[i];

public static A040928Inst Instance=new A040928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040927
{
public static readonly long[] Value={ 30L,1L,19L,1L,1L,1L,6L,4L,1L,1L,1L,1L,2L,1L,4L,1L,9L,2L,30L,2L,9L,1L,4L,1L,2L,1L,1L,1L,1L,4L,6L,1L,1L,1L,19L,1L,60L,1L,19L,1L,1L,1L,6L,4L,1L,1L,1L,1L,2L,1L,4L,1L,9L,2L,30L,2L,9L,1L,4L,1L,2L,1L,1L,1L,1L,4L,6L,1L,1L,1L,19L,1L,60L,1L,19L,1L,1L,1L,6L,4L,1L,1L,1L,1L,2L,1L,4L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040927Inst : IEnumerable<long>
{
public static readonly long[] Value=A040927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040927.Bytes);
public long this[int i]=>Value[i];

public static A040927Inst Instance=new A040927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040926
{
public static readonly long[] Value={ 30L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L,2L,14L,1L,60L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040926Inst : IEnumerable<long>
{
public static readonly long[] Value=A040926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040926.Bytes);
public long this[int i]=>Value[i];

public static A040926Inst Instance=new A040926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040925
{
public static readonly long[] Value={ 30L,1L,11L,2L,1L,1L,1L,1L,7L,8L,1L,2L,2L,1L,2L,1L,14L,1L,2L,1L,2L,2L,1L,8L,7L,1L,1L,1L,1L,2L,11L,1L,60L,1L,11L,2L,1L,1L,1L,1L,7L,8L,1L,2L,2L,1L,2L,1L,14L,1L,2L,1L,2L,2L,1L,8L,7L,1L,1L,1L,1L,2L,11L,1L,60L,1L,11L,2L,1L,1L,1L,1L,7L,8L,1L,2L,2L,1L,2L,1L,14L,1L,2L,1L,2L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040925Inst : IEnumerable<long>
{
public static readonly long[] Value=A040925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040925.Bytes);
public long this[int i]=>Value[i];

public static A040925Inst Instance=new A040925Inst();

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

public static class A040799
{
public static readonly long[] Value={ 28L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040799Inst : IEnumerable<long>
{
public static readonly long[] Value=A040799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040799.Bytes);
public long this[int i]=>Value[i];

public static A040799Inst Instance=new A040799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040798
{
public static readonly long[] Value={ 28L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040798Inst : IEnumerable<long>
{
public static readonly long[] Value=A040798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040798.Bytes);
public long this[int i]=>Value[i];

public static A040798Inst Instance=new A040798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040797
{
public static readonly long[] Value={ 28L,1L,2L,1L,5L,1L,1L,1L,3L,5L,2L,9L,8L,9L,2L,5L,3L,1L,1L,1L,5L,1L,2L,1L,56L,1L,2L,1L,5L,1L,1L,1L,3L,5L,2L,9L,8L,9L,2L,5L,3L,1L,1L,1L,5L,1L,2L,1L,56L,1L,2L,1L,5L,1L,1L,1L,3L,5L,2L,9L,8L,9L,2L,5L,3L,1L,1L,1L,5L,1L,2L,1L,56L,1L,2L,1L,5L,1L,1L,1L,3L,5L,2L,9L,8L,9L,2L,5L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040797Inst : IEnumerable<long>
{
public static readonly long[] Value=A040797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040797.Bytes);
public long this[int i]=>Value[i];

public static A040797Inst Instance=new A040797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040796
{
public static readonly long[] Value={ 28L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,56L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,56L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,56L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,56L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,56L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,2L,1L,56L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040796Inst : IEnumerable<long>
{
public static readonly long[] Value=A040796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040796.Bytes);
public long this[int i]=>Value[i];

public static A040796Inst Instance=new A040796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040795
{
public static readonly long[] Value={ 28L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L,6L,1L,1L,2L,2L,1L,56L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040795Inst : IEnumerable<long>
{
public static readonly long[] Value=A040795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040795.Bytes);
public long this[int i]=>Value[i];

public static A040795Inst Instance=new A040795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040794
{
public static readonly long[] Value={ 28L,1L,2L,4L,1L,7L,2L,1L,1L,1L,1L,8L,1L,18L,4L,2L,1L,3L,2L,2L,5L,1L,27L,1L,5L,2L,2L,3L,1L,2L,4L,18L,1L,8L,1L,1L,1L,1L,2L,7L,1L,4L,2L,1L,56L,1L,2L,4L,1L,7L,2L,1L,1L,1L,1L,8L,1L,18L,4L,2L,1L,3L,2L,2L,5L,1L,27L,1L,5L,2L,2L,3L,1L,2L,4L,18L,1L,8L,1L,1L,1L,1L,2L,7L,1L,4L,2L,1L,56L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040794Inst : IEnumerable<long>
{
public static readonly long[] Value=A040794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040794.Bytes);
public long this[int i]=>Value[i];

public static A040794Inst Instance=new A040794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040793
{
public static readonly long[] Value={ 28L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L,28L,2L,1L,56L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040793Inst : IEnumerable<long>
{
public static readonly long[] Value=A040793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040793.Bytes);
public long this[int i]=>Value[i];

public static A040793Inst Instance=new A040793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040792
{
public static readonly long[] Value={ 28L,1L,1L,1L,7L,1L,1L,10L,1L,13L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,13L,1L,10L,1L,1L,7L,1L,1L,1L,56L,1L,1L,1L,7L,1L,1L,10L,1L,13L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,13L,1L,10L,1L,1L,7L,1L,1L,1L,56L,1L,1L,1L,7L,1L,1L,10L,1L,13L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,13L,1L,10L,1L,1L,7L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040792Inst : IEnumerable<long>
{
public static readonly long[] Value=A040792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040792.Bytes);
public long this[int i]=>Value[i];

public static A040792Inst Instance=new A040792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040791
{
public static readonly long[] Value={ 28L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,56L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040791Inst : IEnumerable<long>
{
public static readonly long[] Value=A040791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040791.Bytes);
public long this[int i]=>Value[i];

public static A040791Inst Instance=new A040791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040790
{
public static readonly long[] Value={ 28L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L,56L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040790Inst : IEnumerable<long>
{
public static readonly long[] Value=A040790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040790.Bytes);
public long this[int i]=>Value[i];

public static A040790Inst Instance=new A040790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040789
{
public static readonly long[] Value={ 28L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L,56L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040789Inst : IEnumerable<long>
{
public static readonly long[] Value=A040789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040789.Bytes);
public long this[int i]=>Value[i];

public static A040789Inst Instance=new A040789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040788
{
public static readonly long[] Value={ 28L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L,2L,1L,1L,56L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040788Inst : IEnumerable<long>
{
public static readonly long[] Value=A040788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040788.Bytes);
public long this[int i]=>Value[i];

public static A040788Inst Instance=new A040788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040787
{
public static readonly long[] Value={ 28L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L,56L,1L,1L,3L,3L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040787Inst : IEnumerable<long>
{
public static readonly long[] Value=A040787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040787.Bytes);
public long this[int i]=>Value[i];

public static A040787Inst Instance=new A040787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040786
{
public static readonly long[] Value={ 28L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L,5L,2L,1L,4L,1L,1L,56L,1L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040786Inst : IEnumerable<long>
{
public static readonly long[] Value=A040786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040786.Bytes);
public long this[int i]=>Value[i];

public static A040786Inst Instance=new A040786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040785
{
public static readonly long[] Value={ 28L,1L,1L,7L,1L,1L,1L,5L,18L,1L,5L,2L,1L,1L,4L,1L,1L,2L,5L,1L,18L,5L,1L,1L,1L,7L,1L,1L,56L,1L,1L,7L,1L,1L,1L,5L,18L,1L,5L,2L,1L,1L,4L,1L,1L,2L,5L,1L,18L,5L,1L,1L,1L,7L,1L,1L,56L,1L,1L,7L,1L,1L,1L,5L,18L,1L,5L,2L,1L,1L,4L,1L,1L,2L,5L,1L,18L,5L,1L,1L,1L,7L,1L,1L,56L,1L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040785Inst : IEnumerable<long>
{
public static readonly long[] Value=A040785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040785.Bytes);
public long this[int i]=>Value[i];

public static A040785Inst Instance=new A040785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040784
{
public static readonly long[] Value={ 28L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040784Inst : IEnumerable<long>
{
public static readonly long[] Value=A040784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040784.Bytes);
public long this[int i]=>Value[i];

public static A040784Inst Instance=new A040784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040783
{
public static readonly long[] Value={ 28L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040783Inst : IEnumerable<long>
{
public static readonly long[] Value=A040783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040783.Bytes);
public long this[int i]=>Value[i];

public static A040783Inst Instance=new A040783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040782
{
public static readonly long[] Value={ 28L,2L,10L,1L,8L,1L,1L,2L,1L,1L,1L,3L,6L,18L,1L,4L,1L,2L,1L,27L,1L,2L,1L,4L,1L,18L,6L,3L,1L,1L,1L,2L,1L,1L,8L,1L,10L,2L,56L,2L,10L,1L,8L,1L,1L,2L,1L,1L,1L,3L,6L,18L,1L,4L,1L,2L,1L,27L,1L,2L,1L,4L,1L,18L,6L,3L,1L,1L,1L,2L,1L,1L,8L,1L,10L,2L,56L,2L,10L,1L,8L,1L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040782Inst : IEnumerable<long>
{
public static readonly long[] Value=A040782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040782.Bytes);
public long this[int i]=>Value[i];

public static A040782Inst Instance=new A040782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040781
{
public static readonly long[] Value={ 28L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040781Inst : IEnumerable<long>
{
public static readonly long[] Value=A040781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040781.Bytes);
public long this[int i]=>Value[i];

public static A040781Inst Instance=new A040781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040780
{
public static readonly long[] Value={ 28L,2L,3L,1L,7L,2L,1L,6L,2L,3L,11L,11L,3L,2L,6L,1L,2L,7L,1L,3L,2L,56L,2L,3L,1L,7L,2L,1L,6L,2L,3L,11L,11L,3L,2L,6L,1L,2L,7L,1L,3L,2L,56L,2L,3L,1L,7L,2L,1L,6L,2L,3L,11L,11L,3L,2L,6L,1L,2L,7L,1L,3L,2L,56L,2L,3L,1L,7L,2L,1L,6L,2L,3L,11L,11L,3L,2L,6L,1L,2L,7L,1L,3L,2L,56L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040780Inst : IEnumerable<long>
{
public static readonly long[] Value=A040780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040780.Bytes);
public long this[int i]=>Value[i];

public static A040780Inst Instance=new A040780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040779
{
public static readonly long[] Value={ 28L,2L,2L,1L,5L,1L,1L,1L,1L,13L,1L,1L,1L,1L,5L,1L,2L,2L,56L,2L,2L,1L,5L,1L,1L,1L,1L,13L,1L,1L,1L,1L,5L,1L,2L,2L,56L,2L,2L,1L,5L,1L,1L,1L,1L,13L,1L,1L,1L,1L,5L,1L,2L,2L,56L,2L,2L,1L,5L,1L,1L,1L,1L,13L,1L,1L,1L,1L,5L,1L,2L,2L,56L,2L,2L,1L,5L,1L,1L,1L,1L,13L,1L,1L,1L,1L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040779Inst : IEnumerable<long>
{
public static readonly long[] Value=A040779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040779.Bytes);
public long this[int i]=>Value[i];

public static A040779Inst Instance=new A040779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040778
{
public static readonly long[] Value={ 28L,2L,2L,4L,1L,3L,4L,9L,4L,3L,1L,4L,2L,2L,56L,2L,2L,4L,1L,3L,4L,9L,4L,3L,1L,4L,2L,2L,56L,2L,2L,4L,1L,3L,4L,9L,4L,3L,1L,4L,2L,2L,56L,2L,2L,4L,1L,3L,4L,9L,4L,3L,1L,4L,2L,2L,56L,2L,2L,4L,1L,3L,4L,9L,4L,3L,1L,4L,2L,2L,56L,2L,2L,4L,1L,3L,4L,9L,4L,3L,1L,4L,2L,2L,56L,2L,2L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040778Inst : IEnumerable<long>
{
public static readonly long[] Value=A040778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040778.Bytes);
public long this[int i]=>Value[i];

public static A040778Inst Instance=new A040778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040777
{
public static readonly long[] Value={ 28L,2L,1L,1L,3L,2L,5L,4L,5L,2L,3L,1L,1L,2L,56L,2L,1L,1L,3L,2L,5L,4L,5L,2L,3L,1L,1L,2L,56L,2L,1L,1L,3L,2L,5L,4L,5L,2L,3L,1L,1L,2L,56L,2L,1L,1L,3L,2L,5L,4L,5L,2L,3L,1L,1L,2L,56L,2L,1L,1L,3L,2L,5L,4L,5L,2L,3L,1L,1L,2L,56L,2L,1L,1L,3L,2L,5L,4L,5L,2L,3L,1L,1L,2L,56L,2L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040777Inst : IEnumerable<long>
{
public static readonly long[] Value=A040777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040777.Bytes);
public long this[int i]=>Value[i];

public static A040777Inst Instance=new A040777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040776
{
public static readonly long[] Value={ 28L,2L,1L,2L,5L,1L,13L,2L,1L,10L,1L,2L,13L,1L,5L,2L,1L,2L,56L,2L,1L,2L,5L,1L,13L,2L,1L,10L,1L,2L,13L,1L,5L,2L,1L,2L,56L,2L,1L,2L,5L,1L,13L,2L,1L,10L,1L,2L,13L,1L,5L,2L,1L,2L,56L,2L,1L,2L,5L,1L,13L,2L,1L,10L,1L,2L,13L,1L,5L,2L,1L,2L,56L,2L,1L,2L,5L,1L,13L,2L,1L,10L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040776Inst : IEnumerable<long>
{
public static readonly long[] Value=A040776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040776.Bytes);
public long this[int i]=>Value[i];

public static A040776Inst Instance=new A040776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040775
{
public static readonly long[] Value={ 28L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040775Inst : IEnumerable<long>
{
public static readonly long[] Value=A040775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040775.Bytes);
public long this[int i]=>Value[i];

public static A040775Inst Instance=new A040775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040774
{
public static readonly long[] Value={ 28L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040774Inst : IEnumerable<long>
{
public static readonly long[] Value=A040774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040774.Bytes);
public long this[int i]=>Value[i];

public static A040774Inst Instance=new A040774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040773
{
public static readonly long[] Value={ 28L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040773Inst : IEnumerable<long>
{
public static readonly long[] Value=A040773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040773.Bytes);
public long this[int i]=>Value[i];

public static A040773Inst Instance=new A040773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040772
{
public static readonly long[] Value={ 28L,3L,3L,4L,1L,5L,2L,10L,1L,6L,6L,6L,1L,10L,2L,5L,1L,4L,3L,3L,56L,3L,3L,4L,1L,5L,2L,10L,1L,6L,6L,6L,1L,10L,2L,5L,1L,4L,3L,3L,56L,3L,3L,4L,1L,5L,2L,10L,1L,6L,6L,6L,1L,10L,2L,5L,1L,4L,3L,3L,56L,3L,3L,4L,1L,5L,2L,10L,1L,6L,6L,6L,1L,10L,2L,5L,1L,4L,3L,3L,56L,3L,3L,4L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040772Inst : IEnumerable<long>
{
public static readonly long[] Value=A040772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040772.Bytes);
public long this[int i]=>Value[i];

public static A040772Inst Instance=new A040772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040771
{
public static readonly long[] Value={ 28L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040771Inst : IEnumerable<long>
{
public static readonly long[] Value=A040771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040771.Bytes);
public long this[int i]=>Value[i];

public static A040771Inst Instance=new A040771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040770
{
public static readonly long[] Value={ 28L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040770Inst : IEnumerable<long>
{
public static readonly long[] Value=A040770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040770.Bytes);
public long this[int i]=>Value[i];

public static A040770Inst Instance=new A040770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040769
{
public static readonly long[] Value={ 28L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040769Inst : IEnumerable<long>
{
public static readonly long[] Value=A040769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040769.Bytes);
public long this[int i]=>Value[i];

public static A040769Inst Instance=new A040769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040768
{
public static readonly long[] Value={ 28L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040768Inst : IEnumerable<long>
{
public static readonly long[] Value=A040768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040768.Bytes);
public long this[int i]=>Value[i];

public static A040768Inst Instance=new A040768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040767
{
public static readonly long[] Value={ 28L,4L,1L,2L,5L,1L,10L,2L,3L,1L,6L,3L,1L,1L,1L,1L,2L,4L,1L,2L,1L,18L,14L,18L,1L,2L,1L,4L,2L,1L,1L,1L,1L,3L,6L,1L,3L,2L,10L,1L,5L,2L,1L,4L,56L,4L,1L,2L,5L,1L,10L,2L,3L,1L,6L,3L,1L,1L,1L,1L,2L,4L,1L,2L,1L,18L,14L,18L,1L,2L,1L,4L,2L,1L,1L,1L,1L,3L,6L,1L,3L,2L,10L,1L,5L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040767Inst : IEnumerable<long>
{
public static readonly long[] Value=A040767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040767.Bytes);
public long this[int i]=>Value[i];

public static A040767Inst Instance=new A040767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040766
{
public static readonly long[] Value={ 28L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040766Inst : IEnumerable<long>
{
public static readonly long[] Value=A040766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040766.Bytes);
public long this[int i]=>Value[i];

public static A040766Inst Instance=new A040766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040765
{
public static readonly long[] Value={ 28L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040765Inst : IEnumerable<long>
{
public static readonly long[] Value=A040765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040765.Bytes);
public long this[int i]=>Value[i];

public static A040765Inst Instance=new A040765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040764
{
public static readonly long[] Value={ 28L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L,56L,6L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040764Inst : IEnumerable<long>
{
public static readonly long[] Value=A040764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040764.Bytes);
public long this[int i]=>Value[i];

public static A040764Inst Instance=new A040764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040763
{
public static readonly long[] Value={ 28L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L,7L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040763Inst : IEnumerable<long>
{
public static readonly long[] Value=A040763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040763.Bytes);
public long this[int i]=>Value[i];

public static A040763Inst Instance=new A040763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040762
{
public static readonly long[] Value={ 28L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L,8L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040762Inst : IEnumerable<long>
{
public static readonly long[] Value=A040762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040762.Bytes);
public long this[int i]=>Value[i];

public static A040762Inst Instance=new A040762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040761
{
public static readonly long[] Value={ 28L,9L,2L,1L,5L,1L,1L,3L,4L,1L,4L,1L,4L,3L,1L,1L,5L,1L,2L,9L,56L,9L,2L,1L,5L,1L,1L,3L,4L,1L,4L,1L,4L,3L,1L,1L,5L,1L,2L,9L,56L,9L,2L,1L,5L,1L,1L,3L,4L,1L,4L,1L,4L,3L,1L,1L,5L,1L,2L,9L,56L,9L,2L,1L,5L,1L,1L,3L,4L,1L,4L,1L,4L,3L,1L,1L,5L,1L,2L,9L,56L,9L,2L,1L,5L,1L,1L,3L,4L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040761Inst : IEnumerable<long>
{
public static readonly long[] Value=A040761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040761.Bytes);
public long this[int i]=>Value[i];

public static A040761Inst Instance=new A040761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040760
{
public static readonly long[] Value={ 28L,11L,4L,1L,1L,2L,3L,1L,13L,3L,1L,2L,18L,2L,1L,3L,13L,1L,3L,2L,1L,1L,4L,11L,56L,11L,4L,1L,1L,2L,3L,1L,13L,3L,1L,2L,18L,2L,1L,3L,13L,1L,3L,2L,1L,1L,4L,11L,56L,11L,4L,1L,1L,2L,3L,1L,13L,3L,1L,2L,18L,2L,1L,3L,13L,1L,3L,2L,1L,1L,4L,11L,56L,11L,4L,1L,1L,2L,3L,1L,13L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040760Inst : IEnumerable<long>
{
public static readonly long[] Value=A040760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040760.Bytes);
public long this[int i]=>Value[i];

public static A040760Inst Instance=new A040760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040759
{
public static readonly long[] Value={ 28L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040759Inst : IEnumerable<long>
{
public static readonly long[] Value=A040759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040759.Bytes);
public long this[int i]=>Value[i];

public static A040759Inst Instance=new A040759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040758
{
public static readonly long[] Value={ 28L,18L,1L,2L,5L,1L,8L,1L,1L,27L,1L,1L,8L,1L,5L,2L,1L,18L,56L,18L,1L,2L,5L,1L,8L,1L,1L,27L,1L,1L,8L,1L,5L,2L,1L,18L,56L,18L,1L,2L,5L,1L,8L,1L,1L,27L,1L,1L,8L,1L,5L,2L,1L,18L,56L,18L,1L,2L,5L,1L,8L,1L,1L,27L,1L,1L,8L,1L,5L,2L,1L,18L,56L,18L,1L,2L,5L,1L,8L,1L,1L,27L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040758Inst : IEnumerable<long>
{
public static readonly long[] Value=A040758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040758.Bytes);
public long this[int i]=>Value[i];

public static A040758Inst Instance=new A040758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040757
{
public static readonly long[] Value={ 28L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040757Inst : IEnumerable<long>
{
public static readonly long[] Value=A040757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040757.Bytes);
public long this[int i]=>Value[i];

public static A040757Inst Instance=new A040757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040756
{
public static readonly long[] Value={ 28L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040756Inst : IEnumerable<long>
{
public static readonly long[] Value=A040756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040756.Bytes);
public long this[int i]=>Value[i];

public static A040756Inst Instance=new A040756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040755
{
public static readonly long[] Value={ 27L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040755Inst : IEnumerable<long>
{
public static readonly long[] Value=A040755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040755.Bytes);
public long this[int i]=>Value[i];

public static A040755Inst Instance=new A040755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040754
{
public static readonly long[] Value={ 27L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040754Inst : IEnumerable<long>
{
public static readonly long[] Value=A040754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040754.Bytes);
public long this[int i]=>Value[i];

public static A040754Inst Instance=new A040754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040753
{
public static readonly long[] Value={ 27L,1L,17L,1L,1L,1L,5L,1L,1L,4L,1L,1L,5L,1L,1L,1L,17L,1L,54L,1L,17L,1L,1L,1L,5L,1L,1L,4L,1L,1L,5L,1L,1L,1L,17L,1L,54L,1L,17L,1L,1L,1L,5L,1L,1L,4L,1L,1L,5L,1L,1L,1L,17L,1L,54L,1L,17L,1L,1L,1L,5L,1L,1L,4L,1L,1L,5L,1L,1L,1L,17L,1L,54L,1L,17L,1L,1L,1L,5L,1L,1L,4L,1L,1L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040753Inst : IEnumerable<long>
{
public static readonly long[] Value=A040753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040753.Bytes);
public long this[int i]=>Value[i];

public static A040753Inst Instance=new A040753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040752
{
public static readonly long[] Value={ 27L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040752Inst : IEnumerable<long>
{
public static readonly long[] Value=A040752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040752.Bytes);
public long this[int i]=>Value[i];

public static A040752Inst Instance=new A040752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040751
{
public static readonly long[] Value={ 27L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040751Inst : IEnumerable<long>
{
public static readonly long[] Value=A040751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040751.Bytes);
public long this[int i]=>Value[i];

public static A040751Inst Instance=new A040751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040750
{
public static readonly long[] Value={ 27L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L,1L,54L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L,1L,54L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L,1L,54L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L,1L,54L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L,1L,54L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L,1L,54L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040750Inst : IEnumerable<long>
{
public static readonly long[] Value=A040750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040750.Bytes);
public long this[int i]=>Value[i];

public static A040750Inst Instance=new A040750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040749
{
public static readonly long[] Value={ 27L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040749Inst : IEnumerable<long>
{
public static readonly long[] Value=A040749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040749.Bytes);
public long this[int i]=>Value[i];

public static A040749Inst Instance=new A040749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040748
{
public static readonly long[] Value={ 27L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040748Inst : IEnumerable<long>
{
public static readonly long[] Value=A040748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040748.Bytes);
public long this[int i]=>Value[i];

public static A040748Inst Instance=new A040748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040747
{
public static readonly long[] Value={ 27L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040747Inst : IEnumerable<long>
{
public static readonly long[] Value=A040747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040747.Bytes);
public long this[int i]=>Value[i];

public static A040747Inst Instance=new A040747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040746
{
public static readonly long[] Value={ 27L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040746Inst : IEnumerable<long>
{
public static readonly long[] Value=A040746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040746.Bytes);
public long this[int i]=>Value[i];

public static A040746Inst Instance=new A040746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040745
{
public static readonly long[] Value={ 27L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040745Inst : IEnumerable<long>
{
public static readonly long[] Value=A040745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040745.Bytes);
public long this[int i]=>Value[i];

public static A040745Inst Instance=new A040745Inst();

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