using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A187445
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,1L,2L,1L,3L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,3L,2L,1L,6L,5L,4L,3L,3L,2L,1L,7L,5L,4L,3L,3L,2L,1L,7L,6L,5L,5L,3L,4L,3L,3L,2L,1L,8L,7L,6L,5L,5L,3L,4L,3L,3L,2L,1L,8L,7L,6L,5L,5L,3L,4L,3L,3L,2L,1L,10L,8L,6L,7L,6L,5L,5L,3L,5L,3L,4L,3L,3L,2L,1L,11L,9L,8L,8L,6L,7L,6L,5L,5L,3L,5L,3L,4L,3L,3L,2L,1L,11L,9L,8L,8L,6L,7L,6L,5L,5L,3L,5L,3L,4L,3L,3L,2L,1L,12L,11L,9L,6L,8L,6L,8L,6L,5L,7L,6L,5L,3L,5L,3L,5L,3L,4L,3L,3L,2L,1L,12L,11L,9L,9L,8L,6L,8L,6L,8L,6L,5L,7L,6L,5L,3L,5L,3L,5L,3L,4L,3L,3L,2L,1L,10L,12L,11L,9L,9L,8L,6L,8L,6L,8L,6L,5L,7L,6L,5L,3L,5L,3L,5L,3L,4L,3L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187445Inst : IEnumerable<long>
{
public static readonly long[] Value=A187445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187445.Bytes);
public long this[int i]=>Value[i];

public static A187445Inst Instance=new A187445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187446
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,5L,3L,4L,5L,6L,4L,5L,6L,7L,5L,6L,7L,8L,5L,6L,6L,7L,8L,9L,4L,6L,7L,7L,8L,9L,10L,5L,7L,8L,8L,9L,10L,11L,6L,6L,7L,8L,8L,9L,9L,10L,11L,12L,6L,7L,7L,8L,9L,9L,10L,10L,11L,12L,13L,7L,8L,8L,9L,10L,10L,11L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187446Inst : IEnumerable<long>
{
public static readonly long[] Value=A187446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187446.Bytes);
public long this[int i]=>Value[i];

public static A187446Inst Instance=new A187446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187447
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,2L,3L,2L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,4L,3L,1L,1L,2L,3L,3L,2L,1L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,4L,4L,3L,1L,1L,2L,3L,3L,3L,2L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,5L,5L,3L,1L,1L,3L,4L,4L,4L,3L,1L,1L,2L,3L,4L,3L,2L,1L,1L,2L,3L,3L,3L,3L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,6L,4L,1L,1L,3L,5L,6L,5L,3L,1L,1L,3L,4L,4L,4L,4L,3L,1L,1L,2L,3L,4L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187447Inst : IEnumerable<long>
{
public static readonly long[] Value=A187447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187447.Bytes);
public long this[int i]=>Value[i];

public static A187447Inst Instance=new A187447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187448
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,12L,16L,15L,18L,24L,32L,30L,36L,48L,64L,60L,72L,96L,128L,90L,120L,108L,144L,192L,256L,105L,180L,240L,216L,288L,384L,512L,210L,360L,480L,432L,576L,768L,1024L,420L,450L,540L,720L,648L,960L,864L,1152L,1536L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187448Inst : IEnumerable<long>
{
public static readonly long[] Value=A187448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187448.Bytes);
public long this[int i]=>Value[i];

public static A187448Inst Instance=new A187448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187449
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,1L,1L,2L,2L,1L,3L,3L,2L,1L,4L,3L,2L,1L,5L,4L,4L,3L,2L,1L,4L,6L,4L,4L,3L,2L,1L,7L,6L,4L,4L,3L,2L,1L,8L,7L,7L,6L,4L,4L,4L,3L,2L,1L,10L,8L,8L,7L,6L,4L,4L,4L,3L,2L,1L,11L,8L,8L,7L,6L,4L,4L,4L,3L,2L,1L,10L,11L,9L,8L,8L,7L,7L,4L,6L,4L,4L,4L,3L,2L,1L,14L,13L,12L,11L,9L,8L,8L,7L,7L,4L,6L,4L,4L,4L,3L,2L,1L,15L,14L,12L,11L,9L,8L,8L,7L,7L,4L,6L,4L,4L,4L,3L,2L,1L,18L,15L,14L,10L,12L,9L,11L,9L,7L,8L,8L,7L,4L,7L,4L,6L,4L,4L,4L,3L,2L,1L,19L,15L,15L,14L,12L,10L,12L,9L,11L,9L,7L,8L,8L,7L,4L,7L,4L,6L,4L,4L,4L,3L,2L,1L,16L,19L,15L,15L,14L,12L,10L,12L,9L,11L,9L,7L,8L,8L,7L,4L,7L,4L,6L,4L,4L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187449Inst : IEnumerable<long>
{
public static readonly long[] Value=A187449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187449.Bytes);
public long this[int i]=>Value[i];

public static A187449Inst Instance=new A187449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187450
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,2L,1L,1L,2L,2L,1L,3L,3L,2L,1L,3L,4L,3L,3L,2L,1L,1L,5L,4L,4L,3L,2L,1L,4L,6L,4L,4L,3L,2L,1L,7L,6L,7L,6L,5L,4L,4L,3L,2L,1L,8L,8L,8L,8L,6L,5L,4L,4L,3L,2L,1L,11L,8L,9L,8L,6L,5L,4L,4L,3L,2L,1L,5L,12L,10L,8L,9L,9L,8L,5L,6L,5L,4L,4L,3L,2L,1L,11L,13L,14L,12L,11L,8L,9L,9L,8L,5L,6L,5L,4L,4L,3L,2L,1L,15L,16L,15L,12L,11L,8L,9L,9L,8L,5L,6L,5L,4L,4L,3L,2L,1L,18L,16L,17L,12L,15L,12L,12L,11L,9L,8L,9L,9L,5L,8L,5L,6L,5L,4L,4L,3L,2L,1L,22L,16L,19L,17L,16L,13L,15L,12L,12L,11L,9L,8L,9L,9L,5L,8L,5L,6L,5L,4L,4L,3L,2L,1L,19L,23L,16L,20L,17L,16L,13L,15L,12L,12L,11L,9L,8L,9L,9L,5L,8L,5L,6L,5L,4L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187450Inst : IEnumerable<long>
{
public static readonly long[] Value=A187450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187450.Bytes);
public long this[int i]=>Value[i];

public static A187450Inst Instance=new A187450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187451
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,2L,1L,1L,2L,2L,1L,1L,3L,2L,3L,2L,1L,0L,3L,4L,3L,3L,2L,1L,1L,5L,4L,4L,3L,2L,1L,4L,3L,5L,6L,4L,4L,4L,3L,2L,1L,4L,7L,6L,7L,6L,5L,4L,4L,3L,2L,1L,8L,8L,8L,8L,6L,5L,4L,4L,3L,2L,1L,1L,11L,9L,8L,9L,9L,8L,6L,6L,5L,4L,4L,3L,2L,1L,5L,9L,12L,12L,11L,8L,9L,10L,8L,6L,6L,5L,4L,4L,3L,2L,1L,11L,14L,15L,12L,12L,8L,9L,10L,8L,6L,6L,5L,4L,4L,3L,2L,1L,12L,15L,17L,12L,16L,13L,12L,12L,11L,8L,9L,10L,6L,8L,6L,6L,5L,4L,4L,3L,2L,1L,19L,16L,19L,18L,18L,14L,16L,14L,12L,12L,11L,8L,9L,10L,6L,8L,6L,6L,5L,4L,4L,3L,2L,1L,16L,23L,16L,22L,18L,19L,15L,16L,14L,12L,12L,11L,8L,9L,10L,6L,8L,6L,6L,5L,4L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187451Inst : IEnumerable<long>
{
public static readonly long[] Value=A187451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187451.Bytes);
public long this[int i]=>Value[i];

public static A187451Inst Instance=new A187451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187500
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,2L,1L,2L,4L,3L,5L,9L,9L,12L,21L,24L,30L,51L,63L,75L,126L,162L,189L,315L,414L,477L,792L,1053L,1206L,1998L,2673L,3051L,5049L,6777L,7722L,12771L,17172L,19548L,32319L,43497L,49491L,81810L,110160L,125307L,207117L,278964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187500Inst : IEnumerable<long>
{
public static readonly long[] Value=A187500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187500.Bytes);
public long this[int i]=>Value[i];

public static A187500Inst Instance=new A187500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187501
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,1L,3L,2L,3L,6L,6L,9L,15L,15L,24L,36L,39L,63L,90L,99L,162L,225L,252L,414L,567L,639L,1053L,1431L,1620L,2673L,3618L,4104L,6777L,9153L,10395L,17172L,23166L,26325L,43497L,58644L,66663L,110160L,148473L,168804L,278964L,375921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187501Inst : IEnumerable<long>
{
public static readonly long[] Value=A187501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187501.Bytes);
public long this[int i]=>Value[i];

public static A187501Inst Instance=new A187501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187502
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,2L,3L,5L,6L,7L,12L,15L,18L,30L,39L,45L,75L,99L,114L,189L,252L,288L,477L,639L,729L,1206L,1620L,1845L,3051L,4104L,4671L,7722L,10395L,11826L,19548L,26325L,29943L,49491L,66663L,75816L,125307L,168804L,191970L,317277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187502Inst : IEnumerable<long>
{
public static readonly long[] Value=A187502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187502.Bytes);
public long this[int i]=>Value[i];

public static A187502Inst Instance=new A187502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187503
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,2L,3L,4L,7L,9L,10L,19L,26L,30L,56L,75L,85L,160L,216L,246L,462L,622L,707L,1329L,1791L,2037L,3828L,5157L,5864L,11021L,14849L,16886L,31735L,42756L,48620L,91376L,123111L,139997L,263108L,354484L,403104L,757588L,1020696L,1160693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187503Inst : IEnumerable<long>
{
public static readonly long[] Value=A187503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187503.Bytes);
public long this[int i]=>Value[i];

public static A187503Inst Instance=new A187503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187504
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,2L,2L,2L,4L,6L,7L,13L,17L,19L,36L,49L,56L,105L,141L,160L,301L,406L,462L,868L,1169L,1329L,2498L,3366L,3828L,7194L,9692L,11021L,20713L,27907L,31735L,59642L,80355L,91376L,171731L,231373L,263108L,494481L,666212L,757588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187504Inst : IEnumerable<long>
{
public static readonly long[] Value=A187504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187504.Bytes);
public long this[int i]=>Value[i];

public static A187504Inst Instance=new A187504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187505
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,2L,3L,3L,6L,8L,9L,17L,23L,26L,49L,66L,75L,141L,190L,216L,406L,547L,622L,1169L,1575L,1791L,3366L,4535L,5157L,9692L,13058L,14849L,27907L,37599L,42756L,80355L,108262L,123111L,231373L,311728L,354484L,666212L,897585L,1020696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187505Inst : IEnumerable<long>
{
public static readonly long[] Value=A187505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187505.Bytes);
public long this[int i]=>Value[i];

public static A187505Inst Instance=new A187505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187506
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,3L,4L,7L,9L,10L,19L,26L,30L,56L,75L,85L,160L,216L,246L,462L,622L,707L,1329L,1791L,2037L,3828L,5157L,5864L,11021L,14849L,16886L,31735L,42756L,48620L,91376L,123111L,139997L,263108L,354484L,403104L,757588L,1020696L,1160693L,2181389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187506Inst : IEnumerable<long>
{
public static readonly long[] Value=A187506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187506.Bytes);
public long this[int i]=>Value[i];

public static A187506Inst Instance=new A187506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187507
{
public static readonly long[] Value={ 1L,4L,0L,9L,5L,0L,16L,16L,6L,0L,25L,33L,31L,2L,0L,36L,56L,74L,36L,0L,0L,49L,85L,135L,115L,40L,0L,0L,64L,120L,214L,236L,184L,36L,0L,0L,81L,161L,311L,399L,435L,272L,20L,0L,0L,100L,208L,426L,604L,788L,772L,330L,12L,0L,0L,121L,261L,559L,851L,1243L,1525L,1224L,390L,6L,0L,0L,144L,320L,710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187507Inst : IEnumerable<long>
{
public static readonly long[] Value=A187507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187507.Bytes);
public long this[int i]=>Value[i];

public static A187507Inst Instance=new A187507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187508
{
public static readonly long[] Value={ 0L,6L,31L,74L,135L,214L,311L,426L,559L,710L,879L,1066L,1271L,1494L,1735L,1994L,2271L,2566L,2879L,3210L,3559L,3926L,4311L,4714L,5135L,5574L,6031L,6506L,6999L,7510L,8039L,8586L,9151L,9734L,10335L,10954L,11591L,12246L,12919L,13610L,14319L,15046L,15791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187508Inst : IEnumerable<long>
{
public static readonly long[] Value=A187508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187508.Bytes);
public long this[int i]=>Value[i];

public static A187508Inst Instance=new A187508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187509
{
public static readonly long[] Value={ 0L,2L,36L,115L,236L,399L,604L,851L,1140L,1471L,1844L,2259L,2716L,3215L,3756L,4339L,4964L,5631L,6340L,7091L,7884L,8719L,9596L,10515L,11476L,12479L,13524L,14611L,15740L,16911L,18124L,19379L,20676L,22015L,23396L,24819L,26284L,27791L,29340L,30931L,32564L,34239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187509Inst : IEnumerable<long>
{
public static readonly long[] Value=A187509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187509.Bytes);
public long this[int i]=>Value[i];

public static A187509Inst Instance=new A187509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187510
{
public static readonly long[] Value={ 0L,0L,40L,184L,435L,788L,1243L,1800L,2459L,3220L,4083L,5048L,6115L,7284L,8555L,9928L,11403L,12980L,14659L,16440L,18323L,20308L,22395L,24584L,26875L,29268L,31763L,34360L,37059L,39860L,42763L,45768L,48875L,52084L,55395L,58808L,62323L,65940L,69659L,73480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187510Inst : IEnumerable<long>
{
public static readonly long[] Value=A187510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187510.Bytes);
public long this[int i]=>Value[i];

public static A187510Inst Instance=new A187510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187511
{
public static readonly long[] Value={ 0L,0L,36L,272L,772L,1525L,2524L,3769L,5260L,6997L,8980L,11209L,13684L,16405L,19372L,22585L,26044L,29749L,33700L,37897L,42340L,47029L,51964L,57145L,62572L,68245L,74164L,80329L,86740L,93397L,100300L,107449L,114844L,122485L,130372L,138505L,146884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187511Inst : IEnumerable<long>
{
public static readonly long[] Value=A187511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187511.Bytes);
public long this[int i]=>Value[i];

public static A187511Inst Instance=new A187511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187512
{
public static readonly long[] Value={ 0L,0L,20L,330L,1224L,2726L,4807L,7458L,10679L,14470L,18831L,23762L,29263L,35334L,41975L,49186L,56967L,65318L,74239L,83730L,93791L,104422L,115623L,127394L,139735L,152646L,166127L,180178L,194799L,209990L,225751L,242082L,258983L,276454L,294495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187512Inst : IEnumerable<long>
{
public static readonly long[] Value=A187512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187512.Bytes);
public long this[int i]=>Value[i];

public static A187512Inst Instance=new A187512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187513
{
public static readonly long[] Value={ 0L,0L,12L,390L,1910L,4880L,9250L,14969L,22026L,30421L,40154L,51225L,63634L,77381L,92466L,108889L,126650L,145749L,166186L,187961L,211074L,235525L,261314L,288441L,316906L,346709L,377850L,410329L,444146L,479301L,515794L,553625L,592794L,633301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187513Inst : IEnumerable<long>
{
public static readonly long[] Value=A187513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187513.Bytes);
public long this[int i]=>Value[i];

public static A187513Inst Instance=new A187513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187514
{
public static readonly long[] Value={ 0L,0L,6L,450L,2872L,8522L,17564L,29834L,45255L,63814L,85511L,110346L,138319L,169430L,203679L,241066L,281591L,325254L,372055L,421994L,475071L,531286L,590639L,653130L,718759L,787526L,859431L,934474L,1012655L,1093974L,1178431L,1266026L,1356759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187514Inst : IEnumerable<long>
{
public static readonly long[] Value=A187514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187514.Bytes);
public long this[int i]=>Value[i];

public static A187514Inst Instance=new A187514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187515
{
public static readonly long[] Value={ 0L,0L,0L,398L,3868L,13796L,31548L,56952L,89684L,129637L,176796L,231161L,292732L,361509L,437492L,520681L,611076L,708677L,813484L,925497L,1044716L,1171141L,1304772L,1445609L,1593652L,1748901L,1911356L,2081017L,2257884L,2441957L,2633236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187515Inst : IEnumerable<long>
{
public static readonly long[] Value=A187515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187515.Bytes);
public long this[int i]=>Value[i];

public static A187515Inst Instance=new A187515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187532
{
public static readonly long[] Value={ 1L,4L,16L,7L,9L,17L,11L,6L,5L,1L,4L,16L,7L,9L,17L,11L,6L,5L,1L,4L,16L,7L,9L,17L,11L,6L,5L,1L,4L,16L,7L,9L,17L,11L,6L,5L,1L,4L,16L,7L,9L,17L,11L,6L,5L,1L,4L,16L,7L,9L,17L,11L,6L,5L,1L,4L,16L,7L,9L,17L,11L,6L,5L,1L,4L,16L,7L,9L,17L,11L,6L,5L,1L,4L,16L,7L,9L,17L,11L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187532Inst : IEnumerable<long>
{
public static readonly long[] Value=A187532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187532.Bytes);
public long this[int i]=>Value[i];

public static A187532Inst Instance=new A187532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187533
{
public static readonly long[] Value={ 27384L,29736L,36792L,37296L,37926L,38472L,46872L,73248L,73962L,78624L,79632L,84672L,92736L,123648L,123864L,123984L,124368L,126384L,129384L,132648L,132864L,132984L,134928L,136248L,136824L,138264L,138624L,139248L,139824L,142368L,143928L,146328L,146832L,148392L,148632L,149328L,149832L,162384L,163248L,163824L,164328L,164832L,167328L,167832L,168432L,172368L,183264L,183624L,184392L,184632L,186432L,189432L,192384L,193248L,193824L,194328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187533Inst : IEnumerable<long>
{
public static readonly long[] Value=A187533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187533.Bytes);
public long this[int i]=>Value[i];

public static A187533Inst Instance=new A187533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187534
{
public static readonly long[] Value={ 243768L,247968L,248976L,297864L,364728L,367248L,376824L,427896L,428736L,432768L,469728L,478296L,478632L,483672L,623784L,627984L,634872L,689472L,732648L,742896L,746928L,762384L,768432L,789264L,796824L,824376L,836472L,873264L,897624L,927864L,976248L,978264L,1289736L,1293768L,1369872L,1372896L,1376928L,1382976L,1679328L,1679832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187534Inst : IEnumerable<long>
{
public static readonly long[] Value=A187534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187534.Bytes);
public long this[int i]=>Value[i];

public static A187534Inst Instance=new A187534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187535
{
public static readonly BigInteger[] Value={ 1L,2L,36L,1200L,58800L,3810240L,307359360L,29682132480L,3339239904000L,428906814336000L,61934143990118400L,9931984545324441600UL,BigInteger.Parse("1751339941492209868800"),BigInteger.Parse("336796142594655744000000"),BigInteger.Parse("70149825129001153536000000") };
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
public class A187535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187535Inst Instance=new A187535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187536
{
public static readonly BigInteger[] Value={ 1L,3L,39L,1239L,60039L,3870279L,311229639L,29993362119L,3369233266119L,432276047602119L,62366420037720519L,9994350965362162119UL,BigInteger.Parse("1761334292457572030919"),BigInteger.Parse("338557476887113316030919"),BigInteger.Parse("70488382605888266852030919"),BigInteger.Parse("15802755831536546966525630919") };
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
public class A187536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187536Inst Instance=new A187536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187537
{
public static readonly long[] Value={ 1L,3L,1L,9L,6L,1L,31L,27L,9L,1L,113L,116L,54L,12L,1L,431L,493L,282L,90L,15L,1L,1697L,2098L,1383L,556L,135L,18L,1L,6847L,8975L,6567L,3107L,965L,189L,21L,1L,28161L,38640L,30636L,16376L,6070L,1536L,252L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187537Inst : IEnumerable<long>
{
public static readonly long[] Value=A187537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187537.Bytes);
public long this[int i]=>Value[i];

public static A187537Inst Instance=new A187537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187538
{
public static readonly BigInteger[] Value={ 1L,1L,35L,1165L,57635L,3752605L,303606755L,29378525725L,3309861378275L,425596952957725L,61508547037160675L,9870475998287280925UL,BigInteger.Parse("1741469465493922587875"),BigInteger.Parse("335054673129161821412125"),BigInteger.Parse("69814770455871991714587875"),BigInteger.Parse("15662452678474786707959012125"),BigInteger.Parse("3764014801927115965888623387875") };
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
public class A187538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187538Inst Instance=new A187538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187539
{
public static readonly BigInteger[] Value={ 1L,1L,33L,1097L,54209L,3527889L,285356449L,27608615257L,3110179582593L,399896866564001L,57791843384031521L,9273757516482276201UL,BigInteger.Parse("1636151050649025202753"),BigInteger.Parse("314786007405793614831217"),BigInteger.Parse("65590496972310741712688289"),BigInteger.Parse("14714600180590751334321307769") };
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
public class A187539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187539Inst Instance=new A187539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187540
{
public static readonly BigInteger[] Value={ 1L,3L,41L,1315L,63825L,4116611L,331127353L,31915763811L,3585520583585L,460054836028675L,66377105303195721L,10637410917472061603UL,BigInteger.Parse("1874707445757653437681"),BigInteger.Parse("360356280811211873453955"),BigInteger.Parse("75028021167256736753934425") };
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
public class A187540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187540Inst Instance=new A187540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187541
{
public static readonly long[] Value={ 0L,4L,1L,12L,16L,20L,3L,28L,32L,36L,5L,44L,48L,52L,7L,60L,64L,68L,9L,76L,80L,84L,11L,92L,96L,100L,13L,108L,112L,116L,15L,124L,128L,132L,17L,140L,144L,148L,19L,156L,160L,164L,21L,172L,176L,180L,23L,188L,192L,196L,25L,204L,208L,212L,27L,220L,224L,228L,29L,236L,240L,244L,31L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187541Inst : IEnumerable<long>
{
public static readonly long[] Value=A187541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187541.Bytes);
public long this[int i]=>Value[i];

public static A187541Inst Instance=new A187541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187542
{
public static readonly BigInteger[] Value={ 1L,4L,76L,2544L,123696L,7942080L,635633280L,61009159680L,6831940227840L,874493448514560L,125946241018214400L,BigInteger.Parse("20156433977646489600"),BigInteger.Parse("3548609812373223628800"),BigInteger.Parse("681555522002874494976000"),BigInteger.Parse("141810253720479017017344000") };
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
public class A187542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187542Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187542.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187542.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187542Inst Instance=new A187542Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187543
{
public static readonly BigInteger[] Value={ 1L,4L,80L,2832L,144576L,9660480L,798468480L,78670609920L,9002061573120L,1173384611804160L,171641216823552000L,BigInteger.Parse("27843893955582566400"),BigInteger.Parse("4961007038613633638400"),BigInteger.Parse("963075987422089673932800"),BigInteger.Parse("202333751987206944654950400") };
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
public class A187543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187543.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187543Inst Instance=new A187543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187544
{
public static readonly BigInteger[] Value={ 1L,2L,38L,1310L,66254L,4428782L,368444078L,36691056110L,4256199137774L,563672814445742L,83921091641375918L,13875375391723852910UL,BigInteger.Parse("2522552600160248918894"),BigInteger.Parse("500141581330626431059502"),BigInteger.Parse("107400097037199576065830958") };
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
public class A187544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187544.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187544Inst Instance=new A187544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187545
{
public static readonly BigInteger[] Value={ 1L,2L,38L,1312L,66408L,4442088L,369791064L,36848702784L,4277191653888L,566809715422464L,84441103242634176L,13970100487593468480UL,BigInteger.Parse("2541362625439551554880"),BigInteger.Parse("504185908064687887996800"),BigInteger.Parse("108336183242510523080868480") };
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
public class A187545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187545Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187545.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187545.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187545Inst Instance=new A187545Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187546
{
public static readonly BigInteger[] Value={ 1L,2L,34L,1096L,51984L,3262488L,254943384L,23853046656L,2600024557248L,323588157732096L,45276442446814656L,7035574740347812800L,BigInteger.Parse("1202158966644148296000"),BigInteger.Parse("224022356544364922931840"),BigInteger.Parse("45215509996613004825121920") };
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
public class A187546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187546.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187546Inst Instance=new A187546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187547
{
public static readonly BigInteger[] Value={ 1L,3L,66L,2500L,134260L,9335088L,796938912L,80671795776L,9446603680800L,1256254443100800L,187033518310129920L,BigInteger.Parse("30821040496874234880"),BigInteger.Parse("5569495264653352381440"),BigInteger.Parse("1095113648992295923200000"),BigInteger.Parse("232773183612995427763200000"),BigInteger.Parse("53186532693832607435089920000") };
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
public class A187547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187547Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187547.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187547.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187547Inst Instance=new A187547Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187580
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,29L,30L,32L,33L,35L,36L,39L,40L,42L,43L,45L,46L,48L,49L,51L,52L,55L,56L,58L,59L,61L,62L,64L,65L,67L,68L,71L,72L,74L,75L,77L,78L,81L,82L,84L,85L,87L,88L,90L,91L,93L,94L,97L,98L,100L,101L,103L,104L,107L,108L,110L,111L,113L,114L,116L,117L,119L,120L,123L,124L,126L,127L,129L,130L,132L,133L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187580Inst : IEnumerable<long>
{
public static readonly long[] Value=A187580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187580.Bytes);
public long this[int i]=>Value[i];

public static A187580Inst Instance=new A187580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187581
{
public static readonly long[] Value={ 2L,5L,8L,11L,12L,15L,18L,21L,24L,27L,28L,31L,34L,37L,38L,41L,44L,47L,50L,53L,54L,57L,60L,63L,66L,69L,70L,73L,76L,79L,80L,83L,86L,89L,92L,95L,96L,99L,102L,105L,106L,109L,112L,115L,118L,121L,122L,125L,128L,131L,134L,137L,138L,141L,144L,147L,148L,151L,154L,157L,160L,163L,164L,167L,170L,173L,176L,179L,180L,183L,186L,189L,190L,193L,196L,199L,202L,205L,206L,209L,212L,215L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187581Inst : IEnumerable<long>
{
public static readonly long[] Value=A187581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187581.Bytes);
public long this[int i]=>Value[i];

public static A187581Inst Instance=new A187581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187582
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,11L,12L,14L,15L,18L,19L,21L,22L,25L,26L,29L,30L,33L,34L,36L,37L,39L,40L,43L,44L,47L,48L,51L,52L,55L,56L,58L,59L,61L,62L,65L,66L,69L,70L,73L,74L,77L,78L,80L,81L,83L,84L,87L,88L,91L,92L,94L,95L,98L,99L,102L,103L,105L,106L,109L,110L,113L,114L,117L,118L,120L,121L,123L,124L,127L,128L,131L,132L,135L,136L,138L,139L,141L,142L,145L,146L,149L,150L,153L,154L,157L,158L,160L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187582Inst : IEnumerable<long>
{
public static readonly long[] Value=A187582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187582.Bytes);
public long this[int i]=>Value[i];

public static A187582Inst Instance=new A187582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187583
{
public static readonly long[] Value={ 2L,5L,6L,9L,10L,13L,16L,17L,20L,23L,24L,27L,28L,31L,32L,35L,38L,41L,42L,45L,46L,49L,50L,53L,54L,57L,60L,63L,64L,67L,68L,71L,72L,75L,76L,79L,82L,85L,86L,89L,90L,93L,96L,97L,100L,101L,104L,107L,108L,111L,112L,115L,116L,119L,122L,125L,126L,129L,130L,133L,134L,137L,140L,143L,144L,147L,148L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187583Inst : IEnumerable<long>
{
public static readonly long[] Value=A187583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187583.Bytes);
public long this[int i]=>Value[i];

public static A187583Inst Instance=new A187583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187584
{
public static readonly long[] Value={ 2L,24L,248L,2364L,27384L,243768L,23469768L,1523498760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187584Inst : IEnumerable<long>
{
public static readonly long[] Value=A187584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187584.Bytes);
public long this[int i]=>Value[i];

public static A187584Inst Instance=new A187584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187585
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,16L,0L,0L,4466L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187585Inst : IEnumerable<long>
{
public static readonly long[] Value=A187585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187585.Bytes);
public long this[int i]=>Value[i];

public static A187585Inst Instance=new A187585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187586
{
public static readonly long[] Value={ 1L,4L,0L,9L,6L,0L,16L,20L,8L,0L,25L,42L,48L,5L,0L,36L,72L,120L,84L,0L,0L,49L,110L,224L,286L,106L,0L,0L,64L,156L,360L,604L,578L,104L,0L,0L,81L,210L,528L,1038L,1484L,1069L,78L,0L,0L,100L,272L,728L,1588L,2794L,3514L,1708L,34L,0L,0L,121L,342L,960L,2254L,4508L,7480L,7666L,2309L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187586Inst : IEnumerable<long>
{
public static readonly long[] Value=A187586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187586.Bytes);
public long this[int i]=>Value[i];

public static A187586Inst Instance=new A187586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187587
{
public static readonly long[] Value={ 0L,5L,84L,286L,604L,1038L,1588L,2254L,3036L,3934L,4948L,6078L,7324L,8686L,10164L,11758L,13468L,15294L,17236L,19294L,21468L,23758L,26164L,28686L,31324L,34078L,36948L,39934L,43036L,46254L,49588L,53038L,56604L,60286L,64084L,67998L,72028L,76174L,80436L,84814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187587Inst : IEnumerable<long>
{
public static readonly long[] Value=A187587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187587.Bytes);
public long this[int i]=>Value[i];

public static A187587Inst Instance=new A187587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187588
{
public static readonly long[] Value={ 0L,0L,106L,578L,1484L,2794L,4508L,6626L,9148L,12074L,15404L,19138L,23276L,27818L,32764L,38114L,43868L,50026L,56588L,63554L,70924L,78698L,86876L,95458L,104444L,113834L,123628L,133826L,144428L,155434L,166844L,178658L,190876L,203498L,216524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187588Inst : IEnumerable<long>
{
public static readonly long[] Value=A187588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187588.Bytes);
public long this[int i]=>Value[i];

public static A187588Inst Instance=new A187588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187589
{
public static readonly long[] Value={ 0L,0L,104L,1069L,3514L,7480L,12874L,19696L,27946L,37624L,48730L,61264L,75226L,90616L,107434L,125680L,145354L,166456L,188986L,212944L,238330L,265144L,293386L,323056L,354154L,386680L,420634L,456016L,492826L,531064L,570730L,611824L,654346L,698296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187589Inst : IEnumerable<long>
{
public static readonly long[] Value=A187589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187589.Bytes);
public long this[int i]=>Value[i];

public static A187589Inst Instance=new A187589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187590
{
public static readonly long[] Value={ 0L,0L,78L,1708L,7666L,19104L,35832L,57592L,84384L,116208L,153064L,194952L,241872L,293824L,350808L,412824L,479872L,551952L,629064L,711208L,798384L,890592L,987832L,1090104L,1197408L,1309744L,1427112L,1549512L,1676944L,1809408L,1946904L,2089432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187590Inst : IEnumerable<long>
{
public static readonly long[] Value=A187590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187590.Bytes);
public long this[int i]=>Value[i];

public static A187590Inst Instance=new A187590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187591
{
public static readonly long[] Value={ 0L,0L,34L,2309L,15056L,45718L,95776L,164135L,250132L,353767L,475040L,613951L,770500L,944687L,1136512L,1345975L,1573076L,1817815L,2080192L,2360207L,2657860L,2973151L,3306080L,3656647L,4024852L,4410695L,4814176L,5235295L,5674052L,6130447L,6604480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187591Inst : IEnumerable<long>
{
public static readonly long[] Value=A187591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187591.Bytes);
public long this[int i]=>Value[i];

public static A187591Inst Instance=new A187591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187592
{
public static readonly long[] Value={ 0L,0L,13L,2792L,27252L,103108L,246792L,458018L,732810L,1069534L,1468190L,1928778L,2451298L,3035750L,3682134L,4390450L,5160698L,5992878L,6886990L,7843034L,8861010L,9940918L,11082758L,12286530L,13552234L,14879870L,16269438L,17720938L,19234370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187592Inst : IEnumerable<long>
{
public static readonly long[] Value=A187592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187592.Bytes);
public long this[int i]=>Value[i];

public static A187592Inst Instance=new A187592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187593
{
public static readonly long[] Value={ 0L,0L,0L,3108L,45960L,219432L,609070L,1243461L,2111652L,3201436L,4508924L,6034116L,7777012L,9737612L,11915916L,14311924L,16925636L,19757052L,22806172L,26072996L,29557524L,33259756L,37179692L,41317332L,45672676L,50245724L,55036476L,60044932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187593Inst : IEnumerable<long>
{
public static readonly long[] Value=A187593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187593.Bytes);
public long this[int i]=>Value[i];

public static A187593Inst Instance=new A187593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187594
{
public static readonly long[] Value={ 1L,-4L,14L,-40L,78L,0L,-836L,4224L,-11050L,0L,162564L,-905216L,2553740L,0L,-41941512L,243433472L,-711366810L,0L,12363548340L,-73437020160L,219033228260L,0L,-3940756420536L,23755279564800L,-71807057068292L,0L,1322443755038504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187594Inst : IEnumerable<long>
{
public static readonly long[] Value=A187594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187594.Bytes);
public long this[int i]=>Value[i];

public static A187594Inst Instance=new A187594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187595
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,28L,1L,2L,1L,992L,1L,1L,1L,8128L,1L,2L,1L,261632L,1L,2L,1L,1448424448L,1L,2L,1L,67100672L,1L,1L,1L,1941802827776L,1L,2L,1L,753623571759104L,1L,2L,1L,23998307331473408L,1L,2L,1L,341653284209033216L,1L,2L,1L,BigInteger.Parse("8316321134799694594048"),1L,2L,1L,BigInteger.Parse("740764429532373450752"),1L,2L,1L,BigInteger.Parse("30559446583872811817762816"),1L,2L,1L,BigInteger.Parse("496669433444154134078771167232"),1L,1L,1L,BigInteger.Parse("17776484020396435145889494859776") };
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
public class A187595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187595.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187595Inst Instance=new A187595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187676
{
public static readonly long[] Value={ 192960L,9136352L,9136352L,433713824L,1292583020L,433713824L,20581985952L,184351404608L,184351404608L,20581985952L,976666568320L,26257519475028L,79410378172576L,26257519475028L,976666568320L,46345923682624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187676Inst : IEnumerable<long>
{
public static readonly long[] Value=A187676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187676.Bytes);
public long this[int i]=>Value[i];

public static A187676Inst Instance=new A187676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187677
{
public static readonly long[] Value={ 13L,43L,89L,151L,229L,433L,701L,859L,1033L,1223L,1429L,1889L,2143L,2699L,3001L,3319L,4003L,4751L,5563L,7873L,10009L,11173L,11779L,12401L,13693L,17203L,18719L,19501L,21943L,25423L,27259L,28201L,30133L,31123L,33151L,36313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187677Inst : IEnumerable<long>
{
public static readonly long[] Value=A187677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187677.Bytes);
public long this[int i]=>Value[i];

public static A187677Inst Instance=new A187677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187678
{
public static readonly long[] Value={ 1L,6L,12L,24L,36L,48L,60L,192L,144L,120L,180L,240L,576L,3072L,360L,1296L,12288L,900L,960L,720L,840L,9216L,196608L,5184L,1260L,786432L,36864L,1680L,2880L,15360L,3600L,12582912L,2520L,46656L,6480L,589824L,61440L,6300L,82944L,6720L,2359296L,805306368L,5040L,3221225472L,14400L,7560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187678Inst : IEnumerable<long>
{
public static readonly long[] Value=A187678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187678.Bytes);
public long this[int i]=>Value[i];

public static A187678Inst Instance=new A187678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187679
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187679Inst : IEnumerable<long>
{
public static readonly long[] Value=A187679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187679.Bytes);
public long this[int i]=>Value[i];

public static A187679Inst Instance=new A187679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187680
{
public static readonly long[] Value={ 0L,2L,3L,1L,5L,0L,7L,4L,1L,10L,11L,20L,13L,4L,9L,1L,17L,21L,19L,20L,25L,16L,23L,36L,1L,4L,9L,0L,29L,0L,31L,8L,33L,22L,25L,83L,37L,4L,9L,40L,41L,48L,43L,8L,21L,28L,47L,88L,1L,8L,9L,76L,53L,96L,1L,16L,49L,34L,59L,120L,61L,4L,31L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187680Inst : IEnumerable<long>
{
public static readonly long[] Value=A187680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187680.Bytes);
public long this[int i]=>Value[i];

public static A187680Inst Instance=new A187680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187681
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,12L,13L,15L,16L,17L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,31L,32L,34L,35L,36L,38L,39L,40L,41L,42L,43L,45L,46L,47L,49L,50L,51L,53L,54L,55L,56L,57L,58L,60L,61L,62L,64L,65L,66L,68L,69L,70L,71L,72L,73L,75L,76L,77L,79L,80L,81L,83L,84L,85L,86L,87L,88L,90L,91L,92L,94L,95L,96L,98L,99L,100L,102L,103L,104L,106L,107L,108L,110L,111L,112L,113L,114L,115L,117L,118L,119L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187681Inst : IEnumerable<long>
{
public static readonly long[] Value=A187681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187681.Bytes);
public long this[int i]=>Value[i];

public static A187681Inst Instance=new A187681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187682
{
public static readonly long[] Value={ 6L,10L,14L,18L,22L,29L,33L,37L,44L,48L,52L,59L,63L,67L,74L,78L,82L,89L,93L,97L,101L,105L,109L,116L,120L,124L,131L,135L,139L,146L,150L,154L,158L,162L,166L,173L,177L,181L,188L,192L,196L,203L,207L,211L,215L,219L,223L,230L,234L,238L,245L,249L,253L,260L,264L,268L,272L,276L,280L,287L,291L,295L,302L,306L,310L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187682Inst : IEnumerable<long>
{
public static readonly long[] Value=A187682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187682.Bytes);
public long this[int i]=>Value[i];

public static A187682Inst Instance=new A187682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187683
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,9L,11L,13L,14L,15L,17L,18L,20L,22L,23L,24L,26L,27L,28L,30L,31L,33L,35L,36L,37L,39L,40L,42L,43L,44L,46L,47L,48L,50L,52L,53L,55L,56L,57L,59L,61L,62L,64L,65L,66L,68L,70L,71L,72L,74L,75L,76L,78L,79L,81L,83L,84L,85L,87L,88L,90L,91L,92L,94L,96L,97L,99L,100L,101L,103L,105L,106L,108L,109L,110L,112L,113L,114L,116L,118L,119L,120L,122L,123L,125L,127L,128L,129L,131L,132L,133L,135L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187683Inst : IEnumerable<long>
{
public static readonly long[] Value=A187683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187683.Bytes);
public long this[int i]=>Value[i];

public static A187683Inst Instance=new A187683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187684
{
public static readonly long[] Value={ 3L,6L,10L,12L,16L,19L,21L,25L,29L,32L,34L,38L,41L,45L,49L,51L,54L,58L,60L,63L,67L,69L,73L,77L,80L,82L,86L,89L,93L,95L,98L,102L,104L,107L,111L,115L,117L,121L,124L,126L,130L,134L,137L,141L,143L,146L,150L,154L,156L,159L,163L,165L,168L,172L,174L,178L,182L,185L,187L,191L,194L,198L,200L,203L,207L,211L,213L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187684Inst : IEnumerable<long>
{
public static readonly long[] Value=A187684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187684.Bytes);
public long this[int i]=>Value[i];

public static A187684Inst Instance=new A187684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187685
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,10L,12L,13L,15L,17L,19L,21L,22L,24L,26L,27L,29L,31L,33L,34L,37L,38L,40L,42L,43L,45L,47L,48L,50L,52L,54L,55L,58L,59L,61L,63L,65L,66L,68L,70L,71L,74L,75L,76L,79L,80L,82L,84L,85L,87L,89L,91L,92L,95L,96L,97L,100L,102L,103L,105L,107L,108L,110L,112L,114L,116L,117L,119L,121L,123L,124L,126L,128L,130L,131L,133L,134L,137L,138L,140L,142L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187685Inst : IEnumerable<long>
{
public static readonly long[] Value=A187685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187685.Bytes);
public long this[int i]=>Value[i];

public static A187685Inst Instance=new A187685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187686
{
public static readonly long[] Value={ 2L,4L,7L,9L,11L,14L,16L,18L,20L,23L,25L,28L,30L,32L,35L,36L,39L,41L,44L,46L,49L,51L,53L,56L,57L,60L,62L,64L,67L,69L,72L,73L,77L,78L,81L,83L,86L,88L,90L,93L,94L,98L,99L,101L,104L,106L,109L,111L,113L,115L,118L,120L,122L,125L,127L,129L,132L,135L,136L,139L,141L,143L,146L,148L,151L,153L,155L,157L,160L,162L,164L,167L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187686Inst : IEnumerable<long>
{
public static readonly long[] Value=A187686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187686.Bytes);
public long this[int i]=>Value[i];

public static A187686Inst Instance=new A187686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187687
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,12L,15L,16L,18L,20L,22L,24L,26L,28L,29L,31L,34L,35L,37L,39L,41L,43L,45L,46L,48L,50L,52L,54L,56L,58L,60L,62L,63L,65L,67L,69L,71L,73L,75L,77L,79L,80L,82L,84L,86L,88L,90L,92L,94L,96L,97L,99L,101L,103L,105L,107L,108L,111L,113L,114L,116L,118L,120L,122L,124L,125L,127L,130L,131L,133L,135L,137L,139L,141L,143L,145L,146L,148L,150L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187687Inst : IEnumerable<long>
{
public static readonly long[] Value=A187687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187687.Bytes);
public long this[int i]=>Value[i];

public static A187687Inst Instance=new A187687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187688
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,13L,14L,17L,19L,21L,23L,25L,27L,30L,32L,33L,36L,38L,40L,42L,44L,47L,49L,51L,53L,55L,57L,59L,61L,64L,66L,68L,70L,72L,74L,76L,78L,81L,83L,85L,87L,89L,91L,93L,95L,98L,100L,102L,104L,106L,109L,110L,112L,115L,117L,119L,121L,123L,126L,128L,129L,132L,134L,136L,138L,140L,142L,144L,147L,149L,151L,153L,155L,157L,160L,162L,164L,166L,168L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187688Inst : IEnumerable<long>
{
public static readonly long[] Value=A187688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187688.Bytes);
public long this[int i]=>Value[i];

public static A187688Inst Instance=new A187688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187689
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,10L,12L,13L,15L,16L,18L,19L,20L,22L,23L,25L,27L,28L,29L,31L,32L,34L,35L,37L,39L,40L,42L,43L,44L,46L,48L,49L,51L,52L,53L,55L,56L,58L,60L,61L,63L,64L,66L,67L,68L,70L,72L,73L,75L,76L,77L,79L,80L,82L,83L,85L,87L,88L,90L,91L,92L,94L,95L,97L,99L,100L,101L,103L,104L,106L,108L,109L,111L,112L,114L,115L,116L,118L,119L,121L,123L,124L,125L,127L,128L,130L,131L,133L,135L,136L,138L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187689Inst : IEnumerable<long>
{
public static readonly long[] Value=A187689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187689.Bytes);
public long this[int i]=>Value[i];

public static A187689Inst Instance=new A187689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187690
{
public static readonly long[] Value={ 2L,6L,9L,11L,14L,17L,21L,24L,26L,30L,33L,36L,38L,41L,45L,47L,50L,54L,57L,59L,62L,65L,69L,71L,74L,78L,81L,84L,86L,89L,93L,96L,98L,102L,105L,107L,110L,113L,117L,120L,122L,126L,129L,132L,134L,137L,141L,144L,146L,150L,153L,155L,158L,161L,165L,167L,170L,174L,177L,180L,182L,185L,189L,191L,194L,198L,201L,203L,206L,209L,213L,216L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187690Inst : IEnumerable<long>
{
public static readonly long[] Value=A187690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187690.Bytes);
public long this[int i]=>Value[i];

public static A187690Inst Instance=new A187690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187691
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,11L,12L,13L,15L,16L,17L,19L,20L,22L,23L,25L,27L,28L,29L,31L,33L,35L,36L,37L,39L,41L,42L,43L,45L,47L,48L,49L,51L,52L,53L,55L,57L,59L,60L,61L,63L,64L,65L,67L,68L,70L,71L,73L,75L,76L,77L,79L,80L,82L,83L,85L,87L,88L,89L,91L,92L,94L,95L,97L,99L,100L,101L,103L,105L,107L,108L,109L,111L,112L,113L,115L,116L,118L,119L,121L,123L,124L,125L,127L,129L,131L,132L,133L,135L,137L,138L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187691Inst : IEnumerable<long>
{
public static readonly long[] Value=A187691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187691.Bytes);
public long this[int i]=>Value[i];

public static A187691Inst Instance=new A187691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187756
{
public static readonly long[] Value={ 0L,1L,20L,105L,336L,825L,1716L,3185L,5440L,8721L,13300L,19481L,27600L,38025L,51156L,67425L,87296L,111265L,139860L,173641L,213200L,259161L,312180L,372945L,442176L,520625L,609076L,708345L,819280L,942761L,1079700L,1231041L,1397760L,1580865L,1781396L,2000425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187756Inst : IEnumerable<long>
{
public static readonly long[] Value=A187756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187756.Bytes);
public long this[int i]=>Value[i];

public static A187756Inst Instance=new A187756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187757
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,2L,2L,4L,3L,2L,2L,3L,4L,4L,2L,3L,2L,6L,6L,5L,4L,2L,6L,5L,4L,4L,2L,6L,4L,4L,4L,3L,5L,7L,5L,5L,3L,4L,9L,5L,6L,4L,5L,6L,4L,5L,5L,6L,7L,6L,6L,3L,7L,7L,6L,6L,4L,6L,6L,5L,6L,4L,7L,6L,7L,2L,3L,7L,7L,7L,5L,3L,5L,5L,7L,8L,5L,8L,8L,4L,5L,4L,10L,10L,6L,6L,2L,9L,6L,9L,7L,1L,8L,4L,5L,7L,3L,9L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187757Inst : IEnumerable<long>
{
public static readonly long[] Value=A187757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187757.Bytes);
public long this[int i]=>Value[i];

public static A187757Inst Instance=new A187757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187758
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,2L,2L,2L,3L,4L,2L,2L,3L,3L,3L,2L,3L,3L,4L,5L,3L,6L,5L,4L,6L,3L,5L,4L,3L,6L,2L,4L,5L,5L,4L,4L,6L,5L,4L,6L,5L,4L,5L,7L,5L,2L,3L,6L,4L,5L,4L,5L,7L,6L,9L,5L,4L,9L,5L,4L,5L,5L,4L,5L,6L,3L,8L,5L,8L,8L,3L,7L,5L,3L,5L,3L,5L,4L,9L,6L,4L,9L,7L,5L,8L,7L,8L,6L,9L,8L,2L,7L,7L,5L,6L,2L,10L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187758Inst : IEnumerable<long>
{
public static readonly long[] Value=A187758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187758.Bytes);
public long this[int i]=>Value[i];

public static A187758Inst Instance=new A187758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187759
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,2L,0L,2L,1L,3L,2L,1L,2L,1L,2L,2L,2L,2L,3L,1L,3L,1L,2L,3L,2L,6L,1L,3L,1L,2L,4L,3L,4L,4L,1L,3L,1L,3L,5L,2L,6L,1L,3L,2L,2L,5L,2L,5L,2L,3L,1L,2L,3L,5L,2L,4L,0L,0L,3L,1L,6L,2L,3L,3L,1L,5L,1L,5L,3L,3L,3L,1L,4L,2L,3L,3L,0L,3L,3L,3L,4L,1L,3L,1L,2L,3L,2L,4L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187759Inst : IEnumerable<long>
{
public static readonly long[] Value=A187759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187759.Bytes);
public long this[int i]=>Value[i];

public static A187759Inst Instance=new A187759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187760
{
public static readonly long[] Value={ 1L,3L,2L,4L,1L,3L,5L,3L,2L,4L,6L,4L,1L,3L,5L,7L,5L,3L,2L,4L,6L,8L,6L,4L,1L,3L,5L,7L,9L,7L,5L,3L,2L,4L,6L,8L,10L,8L,6L,4L,1L,3L,5L,7L,9L,11L,9L,7L,5L,3L,2L,4L,6L,8L,10L,12L,10L,8L,6L,4L,1L,3L,5L,7L,9L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187760Inst : IEnumerable<long>
{
public static readonly long[] Value=A187760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187760.Bytes);
public long this[int i]=>Value[i];

public static A187760Inst Instance=new A187760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187761
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,23L,106L,568L,3459L,23544L,176850L,1451253L,12904312L,123489888L,1264591561L,13790277294L,159466823794L,1948259002647L,25066729706582L,338670605492700L,4792623436607059L,70873649458154500L,1092969062435462254L,17543703470388927229UL,BigInteger.Parse("292600906102204630092") };
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
public class A187761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187761.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187761Inst Instance=new A187761Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187762
{
public static readonly long[] Value={ 2L,11L,17L,47L,71L,157L,157L,167L,203569L,203569L,2803083484951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187762Inst : IEnumerable<long>
{
public static readonly long[] Value=A187762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187762.Bytes);
public long this[int i]=>Value[i];

public static A187762Inst Instance=new A187762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187763
{
public static readonly long[] Value={ 1L,2L,3L,3L,6L,7L,4L,4L,7L,7L,7L,7L,10L,9L,5L,5L,13L,16L,8L,5L,5L,9L,7L,7L,11L,9L,9L,16L,9L,17L,5L,5L,14L,9L,9L,19L,16L,22L,9L,9L,5L,5L,16L,14L,9L,17L,7L,7L,16L,20L,12L,9L,12L,106L,9L,20L,16L,20L,9L,17L,20L,95L,5L,5L,16L,23L,14L,12L,9L,15L,9L,9L,9L,5L,5L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187763Inst : IEnumerable<long>
{
public static readonly long[] Value=A187763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187763.Bytes);
public long this[int i]=>Value[i];

public static A187763Inst Instance=new A187763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187764
{
public static readonly long[] Value={ 1L,1L,3L,11L,45L,198L,919L,4445L,22215L,114000L,597790L,3191070L,17289023L,94845796L,525838005L,2941748627L,16585870501L,94147448172L,537592229784L,3085816136840L,17795391949590L,103051160368120L,598997937352830L,3493575551891610L,20438727738501275L,119911429466179978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187764Inst : IEnumerable<long>
{
public static readonly long[] Value=A187764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187764.Bytes);
public long this[int i]=>Value[i];

public static A187764Inst Instance=new A187764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187765
{
public static readonly long[] Value={ 0L,4L,3L,0L,0L,8L,1L,1L,0L,0L,3L,3L,3L,9L,1L,0L,5L,4L,2L,8L,8L,5L,4L,6L,0L,1L,2L,7L,5L,0L,8L,7L,2L,3L,0L,0L,2L,2L,7L,9L,4L,0L,6L,0L,7L,3L,0L,4L,0L,7L,3L,2L,4L,8L,8L,6L,9L,0L,7L,4L,3L,5L,7L,0L,2L,3L,3L,9L,8L,7L,5L,7L,9L,6L,4L,6L,3L,4L,9L,5L,0L,3L,5L,0L,7L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187765Inst : IEnumerable<long>
{
public static readonly long[] Value=A187765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187765.Bytes);
public long this[int i]=>Value[i];

public static A187765Inst Instance=new A187765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187766
{
public static readonly long[] Value={ 12L,20L,36L,38L,40L,46L,52L,56L,58L,60L,62L,64L,74L,78L,80L,86L,88L,112L,118L,120L,122L,124L,128L,132L,134L,136L,138L,140L,142L,146L,156L,160L,162L,164L,166L,170L,176L,182L,184L,186L,188L,190L,194L,198L,208L,210L,212L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187766Inst : IEnumerable<long>
{
public static readonly long[] Value=A187766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187766.Bytes);
public long this[int i]=>Value[i];

public static A187766Inst Instance=new A187766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187767
{
public static readonly long[] Value={ 0L,2L,3L,10L,15L,35L,63L,138L,255L,527L,1023L,2083L,4095L,8255L,16383L,32906L,65535L,131327L,262143L,524815L,1048575L,2098175L,4194303L,8390691L,16777215L,33558527L,67108863L,134225983L,268435455L,536887295L,1073741823L,2147516554L,4294967295L,8590000127L,17179869183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187767Inst : IEnumerable<long>
{
public static readonly long[] Value=A187767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187767.Bytes);
public long this[int i]=>Value[i];

public static A187767Inst Instance=new A187767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187768
{
public static readonly long[] Value={ 1L,0L,1L,4L,8L,8L,9L,1L,5L,6L,5L,0L,9L,2L,2L,1L,9L,4L,6L,8L,6L,4L,8L,5L,2L,0L,1L,1L,8L,9L,3L,5L,8L,7L,4L,3L,8L,3L,5L,8L,1L,9L,2L,2L,5L,0L,1L,8L,8L,8L,4L,0L,6L,6L,5L,2L,2L,5L,3L,6L,5L,0L,9L,2L,0L,6L,1L,1L,4L,0L,3L,8L,2L,2L,7L,0L,0L,5L,1L,7L,5L,0L,5L,6L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187768Inst : IEnumerable<long>
{
public static readonly long[] Value=A187768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187768.Bytes);
public long this[int i]=>Value[i];

public static A187768Inst Instance=new A187768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187769
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,11L,13L,14L,15L,16L,17L,18L,20L,24L,19L,21L,22L,25L,26L,28L,23L,27L,29L,30L,31L,32L,33L,34L,36L,40L,48L,35L,37L,38L,41L,42L,44L,49L,50L,52L,56L,39L,43L,45L,46L,51L,53L,54L,57L,58L,60L,47L,55L,59L,61L,62L,63L,64L,65L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187769Inst : IEnumerable<long>
{
public static readonly long[] Value=A187769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187769.Bytes);
public long this[int i]=>Value[i];

public static A187769Inst Instance=new A187769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187770
{
public static readonly long[] Value={ 4L,3L,9L,9L,2L,4L,0L,1L,2L,5L,7L,1L,0L,2L,5L,3L,0L,4L,0L,4L,0L,9L,0L,3L,3L,9L,1L,4L,3L,4L,5L,4L,4L,7L,6L,4L,7L,9L,8L,0L,8L,5L,4L,0L,7L,9L,4L,0L,1L,1L,9L,8L,5L,7L,6L,5L,3L,4L,9L,3L,5L,4L,5L,0L,2L,2L,6L,3L,5L,4L,0L,0L,4L,2L,0L,4L,7L,6L,4L,6L,0L,5L,3L,7L,9L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187770Inst : IEnumerable<long>
{
public static readonly long[] Value=A187770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187770.Bytes);
public long this[int i]=>Value[i];

public static A187770Inst Instance=new A187770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187771
{
public static readonly long[] Value={ 245180L,612408L,639198L,1698862L,1721182L,5154168L,7824284L,15817596L,20441848L,25969788L,27688078L,28404862L,35860609L,67149432L,77378782L,91397838L,96462862L,179302264L,191550135L,289772221L,306901244L,311657084L,392802179L,441839706L,572673855L,652117774L,988918364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187771Inst : IEnumerable<long>
{
public static readonly long[] Value=A187771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187771.Bytes);
public long this[int i]=>Value[i];

public static A187771Inst Instance=new A187771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187804
{
public static readonly long[] Value={ 1L,0L,3L,0L,19L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187804Inst : IEnumerable<long>
{
public static readonly long[] Value=A187804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187804.Bytes);
public long this[int i]=>Value[i];

public static A187804Inst Instance=new A187804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187805
{
public static readonly long[] Value={ 3L,53L,83L,487L,743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187805Inst : IEnumerable<long>
{
public static readonly long[] Value=A187805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187805.Bytes);
public long this[int i]=>Value[i];

public static A187805Inst Instance=new A187805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187806
{
public static readonly BigInteger[] Value={ 1L,2L,7L,39L,314L,3388L,46409L,776267L,15406059L,354928082L,9330754204L,276092552520L,9092298247070L,330151121828252L,13114259187006717L,566025800996830823L,BigInteger.Parse("26391137839213285415"),BigInteger.Parse("1322515573450223865750"),BigInteger.Parse("70912312814053387968103"),BigInteger.Parse("4052279260763983306587339") };
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
public class A187806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187806.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187806Inst Instance=new A187806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187807
{
public static readonly long[] Value={ 4L,5L,6L,7L,27L,42L,43L,1310L,3125L,47058L,47059L,151747L,192382L,192383L,244419L,257614L,823543L,28170538L,28170539L,36861843L,48647587L,556429758L,2736456639L,26781610526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187807Inst : IEnumerable<long>
{
public static readonly long[] Value=A187807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187807.Bytes);
public long this[int i]=>Value[i];

public static A187807Inst Instance=new A187807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187808
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,1L,2L,1L,3L,2L,3L,1L,4L,1L,4L,1L,3L,2L,5L,4L,4L,2L,4L,1L,4L,2L,5L,1L,4L,2L,4L,2L,6L,2L,5L,4L,4L,2L,5L,1L,7L,1L,7L,5L,3L,2L,4L,2L,4L,3L,6L,3L,6L,4L,7L,4L,8L,2L,9L,2L,8L,3L,2L,3L,7L,4L,7L,1L,7L,4L,7L,1L,7L,4L,9L,7L,8L,2L,9L,3L,6L,2L,6L,3L,7L,2L,8L,3L,7L,4L,6L,8L,9L,4L,6L,3L,9L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187808Inst : IEnumerable<long>
{
public static readonly long[] Value=A187808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187808.Bytes);
public long this[int i]=>Value[i];

public static A187808Inst Instance=new A187808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187809
{
public static readonly long[] Value={ 5L,3L,17L,2L,2L,2L,41L,2L,2L,29L,2L,107L,137L,191L,179L,599L,239L,281L,857L,1427L,641L,809L,1061L,857L,1481L,1049L,1451L,1229L,1019L,1151L,3359L,3257L,2129L,2141L,1931L,1019L,4271L,4649L,2687L,4229L,16061L,4337L,16139L,6569L,9857L,4001L,4547L,17027L,40037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187809Inst : IEnumerable<long>
{
public static readonly long[] Value=A187809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187809.Bytes);
public long this[int i]=>Value[i];

public static A187809Inst Instance=new A187809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187810
{
public static readonly long[] Value={ 31L,7L,3L,3L,3L,3L,2L,17L,17L,2L,17L,2L,107L,59L,71L,107L,101L,179L,197L,431L,179L,521L,431L,431L,809L,179L,599L,641L,809L,2081L,1061L,827L,1949L,809L,2801L,2381L,1481L,1697L,2087L,1697L,4127L,2801L,3929L,4019L,3329L,4517L,17597L,5477L,6761L,13829L,12239L,5639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187810Inst : IEnumerable<long>
{
public static readonly long[] Value=A187810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187810.Bytes);
public long this[int i]=>Value[i];

public static A187810Inst Instance=new A187810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187811
{
public static readonly long[] Value={ 3L,6L,7L,9L,11L,12L,14L,15L,18L,19L,21L,22L,23L,24L,27L,28L,30L,31L,33L,35L,36L,38L,39L,42L,43L,44L,45L,46L,47L,48L,49L,51L,54L,55L,56L,57L,59L,60L,62L,63L,66L,67L,69L,70L,71L,72L,75L,76L,77L,78L,79L,81L,83L,84L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187811Inst : IEnumerable<long>
{
public static readonly long[] Value=A187811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187811.Bytes);
public long this[int i]=>Value[i];

public static A187811Inst Instance=new A187811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187812
{
public static readonly long[] Value={ 89L,23L,13L,23L,17L,5L,5L,5L,5L,11L,11L,71L,2L,2L,2L,2L,29L,2L,101L,59L,2L,107L,107L,239L,197L,71L,419L,107L,197L,347L,311L,179L,281L,827L,1277L,269L,827L,569L,1481L,1667L,1031L,1019L,617L,2081L,4337L,5651L,3767L,641L,3119L,2789L,2999L,11699L,4241L,8219L,4127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187812Inst : IEnumerable<long>
{
public static readonly long[] Value=A187812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187812.Bytes);
public long this[int i]=>Value[i];

public static A187812Inst Instance=new A187812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187813
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,14L,30L,32L,38L,42L,44L,54L,60L,62L,74L,84L,90L,98L,102L,104L,108L,110L,114L,128L,138L,140L,150L,152L,158L,164L,168L,174L,180L,182L,194L,198L,200L,212L,224L,228L,230L,234L,240L,242L,252L,270L,278L,282L,284L,294L,308L,312L,314L,318L,332L,338L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187813Inst : IEnumerable<long>
{
public static readonly long[] Value=A187813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187813.Bytes);
public long this[int i]=>Value[i];

public static A187813Inst Instance=new A187813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187814
{
public static readonly BigInteger[] Value={ 1L,1L,6L,41L,334L,2901L,26651L,253709L,2483395L,24829132L,252506507L,2603798287L,27161758393L,286118173600L,3039211373800L,32517513415886L,350122302629869L,3790909121211262L,41249405668333107L,450832515809731316L,4947009705400704588L,BigInteger.Parse("54479711308604703264"),BigInteger.Parse("601933495810972446631") };
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
public class A187814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187814Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187814.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187814Inst Instance=new A187814Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187815
{
public static readonly long[] Value={ 10L,2L,7L,4L,10L,17L,15L,15L,17L,11L,4L,23L,33L,24L,19L,16L,24L,16L,31L,39L,39L,30L,24L,11L,15L,39L,30L,52L,66L,41L,29L,23L,48L,43L,15L,15L,43L,48L,39L,30L,30L,52L,68L,64L,68L,34L,19L,27L,39L,35L,22L,36L,32L,20L,19L,32L,38L,72L,71L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187815Inst : IEnumerable<long>
{
public static readonly long[] Value=A187815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187815.Bytes);
public long this[int i]=>Value[i];

public static A187815Inst Instance=new A187815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187816
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,1L,8L,4L,2L,2L,1L,1L,1L,1L,16L,8L,4L,4L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,32L,16L,8L,8L,4L,4L,4L,4L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,64L,32L,16L,16L,8L,8L,8L,8L,4L,4L,4L,4L,4L,4L,4L,4L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187816Inst : IEnumerable<long>
{
public static readonly long[] Value=A187816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187816.Bytes);
public long this[int i]=>Value[i];

public static A187816Inst Instance=new A187816Inst();

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