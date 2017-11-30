using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A071911
{
public static readonly long[] Value={ 0L,5L,7L,10L,14L,20L,28L,33L,35L,40L,45L,47L,49L,51L,56L,61L,63L,66L,70L,73L,75L,80L,85L,87L,90L,94L,98L,102L,105L,107L,112L,117L,119L,122L,126L,132L,140L,146L,150L,153L,155L,160L,165L,167L,170L,174L,180L,188L,196L,204L,210L,214L,217L,219L,224L,229L,231L,234L,238L,244L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071911Inst : IEnumerable<long>
{
public static readonly long[] Value=A071911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071911.Bytes);
public long this[int i]=>Value[i];

public static A071911Inst Instance=new A071911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071912
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,2L,3L,1L,4L,3L,4L,1L,5L,4L,5L,3L,5L,2L,5L,1L,6L,5L,6L,1L,7L,6L,7L,5L,7L,4L,7L,3L,7L,2L,7L,1L,8L,7L,8L,5L,8L,3L,8L,1L,9L,8L,9L,7L,9L,5L,9L,4L,9L,2L,9L,1L,10L,9L,10L,7L,10L,3L,10L,1L,11L,10L,11L,9L,11L,8L,11L,7L,11L,6L,11L,5L,11L,4L,11L,3L,11L,2L,11L,1L,12L,11L,12L,7L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071912Inst : IEnumerable<long>
{
public static readonly long[] Value=A071912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071912.Bytes);
public long this[int i]=>Value[i];

public static A071912Inst Instance=new A071912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071913
{
public static readonly long[] Value={ 1L,4L,9L,27L,81L,256L,1024L,4096L,16384L,78125L,390625L,1953125L,10077696L,60466176L,362797056L,2176782336L,13841287201L,96889010407L,678223072849L,4747561509943L,35184372088832L,281474976710656L,2251799813685248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071913Inst : IEnumerable<long>
{
public static readonly long[] Value=A071913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071913.Bytes);
public long this[int i]=>Value[i];

public static A071913Inst Instance=new A071913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071914
{
public static readonly long[] Value={ 33L,176L,303L,323L,343L,363L,383L,403L,423L,443L,463L,483L,1221L,1616L,1636L,1656L,1676L,1696L,1716L,1736L,1756L,1776L,1796L,2761L,3003L,4983L,12021L,12421L,12621L,12821L,13021L,13221L,13421L,13621L,13821L,16016L,17996L,18238L,19778L,26161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071914Inst : IEnumerable<long>
{
public static readonly long[] Value=A071914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071914.Bytes);
public long this[int i]=>Value[i];

public static A071914Inst Instance=new A071914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071915
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,3L,3L,6L,3L,5L,1L,2L,8L,2L,3L,5L,2L,3L,3L,6L,10L,8L,6L,4L,2L,3L,6L,5L,2L,9L,12L,7L,17L,10L,7L,9L,8L,10L,13L,13L,10L,12L,14L,9L,11L,10L,11L,6L,9L,5L,3L,13L,13L,19L,18L,13L,8L,12L,15L,14L,18L,7L,19L,19L,17L,15L,13L,14L,16L,13L,20L,16L,10L,20L,25L,17L,19L,14L,19L,14L,18L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071915Inst : IEnumerable<long>
{
public static readonly long[] Value=A071915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071915.Bytes);
public long this[int i]=>Value[i];

public static A071915Inst Instance=new A071915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071916
{
public static readonly long[] Value={ 3L,11L,19L,23L,43L,59L,61L,83L,107L,127L,227L,277L,281L,283L,293L,307L,359L,457L,541L,557L,617L,653L,929L,941L,967L,1087L,1223L,1283L,1319L,1381L,1439L,1451L,1481L,1511L,1549L,1597L,1709L,1789L,1867L,1873L,1889L,1901L,1999L,2017L,2027L,2063L,2179L,2221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071916Inst : IEnumerable<long>
{
public static readonly long[] Value=A071916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071916.Bytes);
public long this[int i]=>Value[i];

public static A071916Inst Instance=new A071916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071917
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,9L,11L,14L,18L,21L,25L,28L,31L,35L,40L,44L,48L,52L,56L,61L,67L,72L,78L,84L,90L,97L,104L,110L,117L,124L,131L,138L,146L,154L,163L,172L,181L,190L,200L,209L,219L,228L,237L,247L,257L,266L,275L,285L,295L,306L,318L,329L,341L,354L,367L,381L,395L,408L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071917Inst : IEnumerable<long>
{
public static readonly long[] Value=A071917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071917.Bytes);
public long this[int i]=>Value[i];

public static A071917Inst Instance=new A071917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071918
{
public static readonly long[] Value={ 7L,29L,242L,11707L,28025L,33790L,1526801L,73154828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071918Inst : IEnumerable<long>
{
public static readonly long[] Value=A071918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071918.Bytes);
public long this[int i]=>Value[i];

public static A071918Inst Instance=new A071918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071919
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,1L,0L,1L,4L,6L,4L,1L,0L,1L,5L,10L,10L,5L,1L,0L,1L,6L,15L,20L,15L,6L,1L,0L,1L,7L,21L,35L,35L,21L,7L,1L,0L,1L,8L,28L,56L,70L,56L,28L,8L,1L,0L,1L,9L,36L,84L,126L,126L,84L,36L,9L,1L,0L,1L,10L,45L,120L,210L,252L,210L,120L,45L,10L,1L,0L,1L,11L,55L,165L,330L,462L,462L,330L,165L,55L,11L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071919Inst : IEnumerable<long>
{
public static readonly long[] Value=A071919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071919.Bytes);
public long this[int i]=>Value[i];

public static A071919Inst Instance=new A071919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071920
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,2L,1L,0L,0L,3L,4L,1L,0L,0L,4L,9L,7L,1L,0L,0L,5L,16L,22L,11L,1L,0L,0L,6L,25L,50L,46L,16L,1L,0L,0L,7L,36L,95L,130L,86L,22L,1L,0L,0L,8L,49L,161L,295L,296L,148L,29L,1L,0L,0L,9L,64L,252L,581L,791L,610L,239L,37L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071920Inst : IEnumerable<long>
{
public static readonly long[] Value=A071920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071920.Bytes);
public long this[int i]=>Value[i];

public static A071920Inst Instance=new A071920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071921
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,4L,1L,0L,1L,4L,9L,7L,1L,0L,1L,5L,16L,22L,11L,1L,0L,1L,6L,25L,50L,46L,16L,1L,0L,1L,7L,36L,95L,130L,86L,22L,1L,0L,1L,8L,49L,161L,295L,296L,148L,29L,1L,0L,1L,9L,64L,252L,581L,791L,610L,239L,37L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071921Inst : IEnumerable<long>
{
public static readonly long[] Value=A071921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071921.Bytes);
public long this[int i]=>Value[i];

public static A071921Inst Instance=new A071921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071922
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,9L,7L,1L,1L,5L,16L,22L,11L,1L,1L,6L,25L,50L,46L,16L,1L,1L,7L,36L,95L,130L,86L,22L,1L,1L,8L,49L,161L,295L,296L,148L,29L,1L,1L,9L,64L,252L,581L,791L,610L,239L,37L,1L,1L,10L,81L,372L,1036L,1792L,1897L,1163L,367L,46L,1L,1L,11L,100L,525L,1716L,3612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071922Inst : IEnumerable<long>
{
public static readonly long[] Value=A071922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071922.Bytes);
public long this[int i]=>Value[i];

public static A071922Inst Instance=new A071922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071923
{
public static readonly long[] Value={ 7L,13L,19L,37L,41L,67L,73L,101L,107L,149L,163L,193L,227L,239L,281L,337L,353L,397L,433L,479L,523L,577L,607L,677L,733L,769L,829L,907L,953L,1013L,1091L,1151L,1229L,1289L,1373L,1439L,1489L,1601L,1667L,1777L,1867L,1907L,2027L,2099L,2237L,2281L,2389L,2543L,2591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071923Inst : IEnumerable<long>
{
public static readonly long[] Value=A071923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071923.Bytes);
public long this[int i]=>Value[i];

public static A071923Inst Instance=new A071923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071924
{
public static readonly long[] Value={ 749L,208L,6503705L,1831L,657L,1045880L,6503711L,239879L,375325L,7864L,45075L,7064L,2313602L,6503717L,59L,1766468L,78975L,840L,1046L,33355L,2133L,109L,107390L,56057L,6503758L,3386573L,6503759L,2044L,3386575L,158964L,2313623L,9463L,2313625L,36081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071924Inst : IEnumerable<long>
{
public static readonly long[] Value=A071924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071924.Bytes);
public long this[int i]=>Value[i];

public static A071924Inst Instance=new A071924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071925
{
public static readonly long[] Value={ 10L,1001L,1010L,1100L,100011L,100101L,100110L,101001L,101010L,101100L,110001L,110010L,110100L,111000L,10000111L,10001011L,10001101L,10001110L,10010011L,10010101L,10010110L,10011001L,10011010L,10011100L,10100011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071925Inst : IEnumerable<long>
{
public static readonly long[] Value=A071925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071925.Bytes);
public long this[int i]=>Value[i];

public static A071925Inst Instance=new A071925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071926
{
public static readonly long[] Value={ 1L,2L,1L,10L,34L,2L,2L,10L,1L,46234L,771L,10L,2L,2L,34L,11L,8L,2L,15L,46236L,2L,773L,49L,10L,42L,2L,1L,62L,41L,46234L,15L,18L,771L,8L,58L,10L,270L,50L,2L,46266L,15L,2L,48L,773L,34L,52L,35L,11L,71L,46386L,8L,11L,22L,5L,2238L,71L,15L,69L,10L,46236L,18L,102L,2L,53L,46L,773L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071926Inst : IEnumerable<long>
{
public static readonly long[] Value=A071926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071926.Bytes);
public long this[int i]=>Value[i];

public static A071926Inst Instance=new A071926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071927
{
public static readonly long[] Value={ 12L,18L,20L,70L,88L,104L,464L,650L,1888L,1952L,4030L,5830L,8925L,17816L,26742L,26778L,26886L,26898L,26958L,27042L,27078L,27102L,27114L,27138L,27282L,27294L,27366L,27402L,27498L,27546L,27582L,27618L,27726L,27822L,27834L,27858L,27894L,27906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071927Inst : IEnumerable<long>
{
public static readonly long[] Value=A071927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071927.Bytes);
public long this[int i]=>Value[i];

public static A071927Inst Instance=new A071927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071928
{
public static readonly long[] Value={ 2L,2L,4L,4L,2L,2L,2L,2L,4L,4L,4L,4L,2L,2L,4L,4L,2L,2L,4L,4L,2L,2L,2L,2L,4L,4L,4L,4L,2L,2L,2L,2L,4L,4L,4L,4L,2L,2L,4L,4L,2L,2L,2L,2L,4L,4L,4L,4L,2L,2L,4L,4L,2L,2L,2L,2L,4L,4L,4L,4L,2L,2L,4L,4L,2L,2L,4L,4L,2L,2L,2L,2L,4L,4L,4L,4L,2L,2L,2L,2L,4L,4L,4L,4L,2L,2L,4L,4L,2L,2L,4L,4L,2L,2L,2L,2L,4L,4L,4L,4L,2L,2L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071928Inst : IEnumerable<long>
{
public static readonly long[] Value=A071928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071928.Bytes);
public long this[int i]=>Value[i];

public static A071928Inst Instance=new A071928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071929
{
public static readonly long[] Value={ 1L,4L,12L,18L,27L,80L,120L,180L,200L,270L,300L,405L,448L,450L,500L,672L,675L,750L,1008L,1120L,1125L,1250L,1512L,1568L,1680L,1875L,2268L,2352L,2520L,2800L,3125L,3402L,3528L,3780L,3920L,4200L,5103L,5292L,5488L,5670L,5880L,6300L,7000L,7938L,8232L,8505L,8820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071929Inst : IEnumerable<long>
{
public static readonly long[] Value=A071929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071929.Bytes);
public long this[int i]=>Value[i];

public static A071929Inst Instance=new A071929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071930
{
public static readonly long[] Value={ 0L,6L,12L,72L,240L,1056L,4032L,16512L,65280L,262656L,1047552L,4196352L,16773120L,67117056L,268419072L,1073774592L,4294901760L,17180000256L,68719214592L,274878431232L,1099510579200L,4398048608256L,17592181850112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071930Inst : IEnumerable<long>
{
public static readonly long[] Value=A071930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071930.Bytes);
public long this[int i]=>Value[i];

public static A071930Inst Instance=new A071930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071931
{
public static readonly long[] Value={ 8L,30L,32L,38L,46L,50L,55L,57L,75L,76L,99L,100L,111L,122L,128L,132L,133L,142L,174L,177L,183L,185L,200L,203L,212L,213L,228L,237L,242L,253L,254L,265L,266L,268L,274L,278L,302L,305L,319L,322L,327L,334L,342L,348L,360L,377L,380L,381L,394L,395L,411L,413L,418L,437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071931Inst : IEnumerable<long>
{
public static readonly long[] Value=A071931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071931.Bytes);
public long this[int i]=>Value[i];

public static A071931Inst Instance=new A071931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071932
{
public static readonly long[] Value={ 1L,4L,7L,2L,5L,8L,11L,6L,1L,4L,7L,2L,5L,8L,11L,6L,9L,12L,15L,10L,5L,8L,11L,6L,1L,4L,7L,2L,5L,8L,11L,6L,9L,12L,15L,10L,13L,16L,19L,14L,9L,12L,15L,10L,5L,8L,11L,6L,9L,12L,15L,10L,5L,8L,11L,6L,1L,4L,7L,2L,5L,8L,11L,6L,9L,12L,15L,10L,13L,16L,19L,14L,9L,12L,15L,10L,13L,16L,19L,14L,17L,20L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071932Inst : IEnumerable<long>
{
public static readonly long[] Value=A071932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071932.Bytes);
public long this[int i]=>Value[i];

public static A071932Inst Instance=new A071932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071933
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,3L,4L,5L,4L,3L,4L,5L,4L,5L,6L,7L,6L,7L,8L,9L,8L,7L,8L,9L,8L,7L,8L,9L,8L,9L,10L,11L,10L,11L,12L,13L,12L,13L,14L,15L,14L,13L,14L,15L,14L,13L,14L,15L,14L,15L,16L,17L,16L,15L,16L,17L,16L,15L,16L,17L,16L,17L,18L,19L,18L,19L,20L,21L,20L,21L,22L,23L,22L,21L,22L,23L,22L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071933Inst : IEnumerable<long>
{
public static readonly long[] Value=A071933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071933.Bytes);
public long this[int i]=>Value[i];

public static A071933Inst Instance=new A071933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071934
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,4L,5L,6L,7L,6L,7L,8L,9L,10L,11L,12L,13L,12L,13L,14L,15L,16L,17L,18L,19L,18L,19L,20L,21L,22L,23L,24L,25L,24L,25L,26L,27L,28L,29L,30L,31L,30L,31L,32L,33L,34L,35L,36L,37L,36L,37L,38L,39L,40L,41L,42L,43L,42L,43L,44L,45L,46L,47L,48L,49L,48L,49L,50L,51L,52L,53L,54L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071934Inst : IEnumerable<long>
{
public static readonly long[] Value=A071934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071934.Bytes);
public long this[int i]=>Value[i];

public static A071934Inst Instance=new A071934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071935
{
public static readonly long[] Value={ 1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071935Inst : IEnumerable<long>
{
public static readonly long[] Value=A071935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071935.Bytes);
public long this[int i]=>Value[i];

public static A071935Inst Instance=new A071935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071936
{
public static readonly long[] Value={ 1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071936Inst : IEnumerable<long>
{
public static readonly long[] Value=A071936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071936.Bytes);
public long this[int i]=>Value[i];

public static A071936Inst Instance=new A071936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071937
{
public static readonly BigInteger[] Value={ 1L,2L,6L,24L,120L,720L,5040L,40320L,362880L,1L,39916800L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("8222838654177922817725562880000000"),BigInteger.Parse("33452526613163807108170062053440751665152000000000") };
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
public class A071937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071937Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071937.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071937Inst Instance=new A071937Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071938
{
public static readonly ulong[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,1L,293930L,206253075L,35240152720L,3188675231420L,202802465047245L,10358022441395860L,456703981505085600L,18150420051920130975UL,190L,293930L,1L,28048800L,353697121050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071938Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A071938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071938.Bytes);
public ulong this[int i]=>Value[i];

public static A071938Inst Instance=new A071938Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071939
{
public static readonly long[] Value={ 0L,2L,2L,5L,3L,8L,6L,9L,9L,12L,8L,18L,16L,16L,16L,19L,15L,23L,21L,24L,24L,24L,20L,38L,38L,38L,38L,38L,32L,44L,42L,42L,42L,42L,42L,61L,55L,55L,55L,55L,51L,56L,54L,54L,54L,54L,50L,78L,78L,78L,78L,78L,72L,72L,72L,72L,72L,72L,66L,110L,108L,108L,108L,108L,108L,108L,102L,102L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071939Inst : IEnumerable<long>
{
public static readonly long[] Value=A071939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071939.Bytes);
public long this[int i]=>Value[i];

public static A071939Inst Instance=new A071939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071940
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,3L,4L,4L,5L,5L,6L,6L,6L,7L,8L,8L,8L,8L,8L,9L,9L,9L,10L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,15L,15L,15L,16L,16L,17L,17L,17L,17L,18L,18L,19L,20L,20L,21L,22L,23L,23L,24L,25L,25L,26L,27L,27L,28L,28L,29L,30L,30L,30L,30L,30L,31L,31L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071940Inst : IEnumerable<long>
{
public static readonly long[] Value=A071940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071940.Bytes);
public long this[int i]=>Value[i];

public static A071940Inst Instance=new A071940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071941
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,10L,14L,15L,16L,20L,21L,22L,24L,26L,27L,28L,30L,32L,33L,34L,35L,38L,39L,40L,44L,46L,49L,50L,51L,52L,54L,56L,57L,58L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,81L,82L,84L,85L,86L,87L,88L,90L,92L,93L,94L,96L,102L,104L,105L,106L,111L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071941Inst : IEnumerable<long>
{
public static readonly long[] Value=A071941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071941.Bytes);
public long this[int i]=>Value[i];

public static A071941Inst Instance=new A071941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071942
{
public static readonly long[] Value={ 3L,3L,3L,4L,4L,4L,3L,3L,3L,4L,4L,4L,4L,3L,3L,3L,3L,4L,4L,4L,4L,3L,3L,3L,4L,4L,4L,3L,3L,3L,4L,4L,4L,4L,3L,3L,3L,3L,4L,4L,4L,4L,3L,3L,3L,3L,4L,4L,4L,3L,3L,3L,4L,4L,4L,3L,3L,3L,4L,4L,4L,4L,3L,3L,3L,3L,4L,4L,4L,4L,3L,3L,3L,3L,4L,4L,4L,3L,3L,3L,4L,4L,4L,3L,3L,3L,3L,4L,4L,4L,4L,3L,3L,3L,3L,4L,4L,4L,3L,3L,3L,4L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071942Inst : IEnumerable<long>
{
public static readonly long[] Value=A071942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071942.Bytes);
public long this[int i]=>Value[i];

public static A071942Inst Instance=new A071942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071943
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,7L,9L,1L,4L,12L,24L,31L,1L,5L,18L,46L,89L,113L,1L,6L,25L,76L,183L,342L,431L,1L,7L,33L,115L,323L,741L,1355L,1697L,1L,8L,42L,164L,520L,1376L,3054L,5492L,6847L,1L,9L,52L,224L,786L,2326L,5900L,12768L,22669L,28161L,1L,10L,63L,296L,1134L,3684L,10370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071943Inst : IEnumerable<long>
{
public static readonly long[] Value=A071943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071943.Bytes);
public long this[int i]=>Value[i];

public static A071943Inst Instance=new A071943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071944
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,5L,6L,1L,4L,9L,16L,19L,1L,5L,14L,31L,54L,63L,1L,6L,20L,52L,111L,188L,219L,1L,7L,27L,80L,197L,405L,676L,787L,1L,8L,35L,116L,320L,752L,1508L,2492L,2897L,1L,9L,44L,161L,489L,1276L,2900L,5712L,9361L,10869L,1L,10L,54L,216L,714L,2034L,5095L,11296L,21933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071944Inst : IEnumerable<long>
{
public static readonly long[] Value=A071944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071944.Bytes);
public long this[int i]=>Value[i];

public static A071944Inst Instance=new A071944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071945
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,1L,5L,9L,9L,1L,7L,19L,31L,31L,1L,9L,33L,73L,113L,113L,1L,11L,51L,143L,287L,431L,431L,1L,13L,73L,249L,609L,1153L,1697L,1697L,1L,15L,99L,399L,1151L,2591L,4719L,6847L,6847L,1L,17L,129L,601L,2001L,5201L,11073L,19617L,28161L,28161L,1L,19L,163L,863L,3263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071945Inst : IEnumerable<long>
{
public static readonly long[] Value=A071945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071945.Bytes);
public long this[int i]=>Value[i];

public static A071945Inst Instance=new A071945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071946
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,4L,6L,6L,1L,6L,13L,19L,19L,1L,8L,23L,44L,63L,63L,1L,10L,37L,87L,156L,219L,219L,1L,12L,55L,155L,330L,568L,787L,787L,1L,14L,77L,255L,629L,1260L,2110L,2897L,2897L,1L,16L,103L,395L,1111L,2527L,4856L,7972L,10869L,10869L,1L,18L,133L,583L,1849L,4706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071946Inst : IEnumerable<long>
{
public static readonly long[] Value=A071946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071946.Bytes);
public long this[int i]=>Value[i];

public static A071946Inst Instance=new A071946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071947
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,2L,3L,1L,1L,3L,6L,6L,3L,1L,4L,10L,15L,15L,6L,1L,5L,15L,29L,40L,36L,15L,1L,6L,21L,49L,84L,105L,91L,36L,1L,7L,28L,76L,154L,238L,280L,232L,91L,1L,8L,36L,111L,258L,468L,672L,750L,603L,232L,1L,9L,45L,155L,405L,837L,1398L,1890L,2025L,1585L,603L,1L,10L,55L,209L,605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071947Inst : IEnumerable<long>
{
public static readonly long[] Value=A071947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071947.Bytes);
public long this[int i]=>Value[i];

public static A071947Inst Instance=new A071947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071948
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,7L,1L,6L,18L,30L,1L,8L,33L,88L,143L,1L,10L,52L,182L,455L,728L,1L,12L,75L,320L,1020L,2448L,3876L,1L,14L,102L,510L,1938L,5814L,13566L,21318L,1L,16L,133L,760L,3325L,11704L,33649L,76912L,120175L,1L,18L,168L,1078L,5313L,21252L,70840L,197340L,444015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071948Inst : IEnumerable<long>
{
public static readonly long[] Value=A071948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071948.Bytes);
public long this[int i]=>Value[i];

public static A071948Inst Instance=new A071948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071949
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,10L,1L,6L,24L,66L,1L,8L,42L,172L,498L,1L,10L,64L,326L,1360L,4066L,1L,12L,90L,536L,2706L,11444L,34970L,1L,14L,120L,810L,4672L,23526L,100520L,312066L,1L,16L,154L,1156L,7410L,42024L,211546L,911068L,2862562L,1L,18L,192L,1582L,11088L,69002L,387456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071949Inst : IEnumerable<long>
{
public static readonly long[] Value=A071949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071949.Bytes);
public long this[int i]=>Value[i];

public static A071949Inst Instance=new A071949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071950
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,5L,1L,5L,12L,3L,14L,31L,1L,9L,38L,83L,4L,28L,106L,227L,1L,14L,84L,301L,634L,5L,48L,252L,864L,1799L,1L,20L,157L,758L,2508L,5171L,6L,75L,504L,2283L,7348L,15027L,1L,27L,265L,1602L,6897L,21699L,44074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071950Inst : IEnumerable<long>
{
public static readonly long[] Value=A071950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071950.Bytes);
public long this[int i]=>Value[i];

public static A071950Inst Instance=new A071950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071951
{
public static readonly long[] Value={ 1L,2L,1L,4L,8L,1L,8L,52L,20L,1L,16L,320L,292L,40L,1L,32L,1936L,3824L,1092L,70L,1L,64L,11648L,47824L,25664L,3192L,112L,1L,128L,69952L,585536L,561104L,121424L,7896L,168L,1L,256L,419840L,7096384L,11807616L,4203824L,453056L,17304L,240L,1L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071951Inst : IEnumerable<long>
{
public static readonly long[] Value=A071951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071951.Bytes);
public long this[int i]=>Value[i];

public static A071951Inst Instance=new A071951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071952
{
public static readonly BigInteger[] Value={ 1L,40L,1092L,25664L,561104L,11807616L,243248704L,4950550528L,100040447232L,2013177300992L,40412056994816L,810023815790592L,16221871691714560L,324694197936160768L,6496965245491888128L,BigInteger.Parse("129976281056339296256") };
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
public class A071952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071952.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071952Inst Instance=new A071952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071953
{
public static readonly long[] Value={ 4L,52L,292L,1092L,3192L,7896L,17304L,34584L,64284L,112684L,188188L,301756L,467376L,702576L,1028976L,1472880L,2065908L,2845668L,3856468L,5150068L,6786472L,8834760L,11373960L,14493960L,18296460L,22895964L,28420812L,35014252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071953Inst : IEnumerable<long>
{
public static readonly long[] Value=A071953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071953.Bytes);
public long this[int i]=>Value[i];

public static A071953Inst Instance=new A071953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071954
{
public static readonly long[] Value={ 2L,4L,10L,32L,114L,420L,1562L,5824L,21730L,81092L,302634L,1129440L,4215122L,15731044L,58709050L,219105152L,817711554L,3051741060L,11389252682L,42505269664L,158631825970L,592022034212L,2209456310874L,8245803209280L,30773756526242L,114849222895684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071954Inst : IEnumerable<long>
{
public static readonly long[] Value=A071954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071954.Bytes);
public long this[int i]=>Value[i];

public static A071954Inst Instance=new A071954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071955
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,12L,13L,14L,15L,16L,17L,18L,19L,0L,9L,0L,23L,24L,25L,26L,27L,28L,29L,0L,5L,9L,0L,34L,35L,36L,37L,38L,39L,0L,13L,18L,9L,0L,45L,46L,47L,48L,49L,0L,6L,2L,18L,9L,0L,56L,57L,58L,59L,0L,13L,10L,27L,18L,9L,0L,67L,68L,69L,0L,3L,18L,36L,27L,18L,9L,0L,78L,79L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071955Inst : IEnumerable<long>
{
public static readonly long[] Value=A071955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071955.Bytes);
public long this[int i]=>Value[i];

public static A071955Inst Instance=new A071955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071956
{
public static readonly long[] Value={ 2L,1L,2L,1L,3L,1L,2L,3L,3L,1L,5L,1L,2L,4L,3L,2L,5L,1L,7L,1L,2L,8L,3L,4L,5L,2L,7L,1L,11L,1L,2L,10L,3L,5L,5L,2L,7L,1L,11L,1L,13L,1L,2L,15L,3L,6L,5L,3L,7L,2L,11L,1L,13L,1L,17L,1L,2L,16L,3L,8L,5L,3L,7L,2L,11L,1L,13L,1L,17L,1L,19L,1L,2L,19L,3L,9L,5L,4L,7L,3L,11L,2L,13L,1L,17L,1L,19L,1L,23L,1L,2L,25L,3L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071956Inst : IEnumerable<long>
{
public static readonly long[] Value=A071956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071956.Bytes);
public long this[int i]=>Value[i];

public static A071956Inst Instance=new A071956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071957
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,2L,0L,0L,6L,2L,0L,0L,0L,4L,0L,8L,0L,0L,0L,0L,0L,2L,0L,0L,20L,6L,0L,0L,0L,4L,0L,0L,0L,4L,0L,12L,0L,6L,0L,0L,0L,4L,0L,0L,0L,4L,0L,0L,42L,2L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,8L,0L,32L,0L,8L,0L,0L,0L,4L,0L,0L,0L,10L,0L,0L,0L,4L,0L,0L,54L,4L,0L,0L,0L,10L,0L,0L,0L,4L,0L,0L,0L,8L,0L,0L,0L,2L,0L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071957Inst : IEnumerable<long>
{
public static readonly long[] Value=A071957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071957.Bytes);
public long this[int i]=>Value[i];

public static A071957Inst Instance=new A071957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071958
{
public static readonly long[] Value={ 67L,99L,115L,147L,163L,187L,267L,275L,283L,307L,315L,355L,379L,403L,427L,475L,507L,523L,531L,595L,619L,643L,675L,747L,763L,787L,883L,907L,931L,947L,955L,975L,1003L,1027L,1107L,1123L,1147L,1179L,1203L,1267L,1275L,1347L,1363L,1387L,1395L,1435L,1467L,1475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071958Inst : IEnumerable<long>
{
public static readonly long[] Value=A071958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071958.Bytes);
public long this[int i]=>Value[i];

public static A071958Inst Instance=new A071958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071959
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,13L,14L,16L,17L,18L,20L,21L,22L,24L,25L,26L,27L,28L,29L,30L,32L,33L,34L,36L,37L,38L,40L,41L,42L,43L,44L,45L,46L,48L,49L,50L,52L,53L,54L,56L,57L,58L,60L,61L,62L,64L,65L,66L,68L,69L,70L,72L,73L,74L,76L,77L,78L,80L,81L,82L,84L,85L,86L,88L,89L,90L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071959Inst : IEnumerable<long>
{
public static readonly long[] Value=A071959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071959.Bytes);
public long this[int i]=>Value[i];

public static A071959Inst Instance=new A071959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071960
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,3L,2L,1L,0L,1L,0L,3L,2L,1L,0L,1L,0L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,1L,0L,5L,4L,3L,2L,1L,0L,3L,2L,1L,0L,1L,0L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,1L,0L,5L,4L,3L,2L,1L,0L,3L,2L,1L,0L,1L,0L,5L,4L,3L,2L,1L,0L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,7L,6L,5L,4L,3L,2L,1L,0L,3L,2L,1L,0L,1L,0L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071960Inst : IEnumerable<long>
{
public static readonly long[] Value=A071960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071960.Bytes);
public long this[int i]=>Value[i];

public static A071960Inst Instance=new A071960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071961
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,2L,4L,0L,6L,2L,2L,0L,0L,4L,6L,8L,0L,0L,2L,0L,0L,2L,6L,0L,20L,6L,0L,0L,0L,4L,12L,0L,0L,4L,4L,12L,0L,6L,12L,0L,0L,4L,0L,0L,0L,4L,10L,0L,42L,2L,4L,0L,0L,2L,18L,0L,0L,2L,6L,0L,0L,8L,2L,32L,0L,8L,-2L,0L,0L,4L,14L,0L,0L,10L,4L,0L,0L,4L,22L,0L,54L,4L,4L,0L,0L,10L,14L,0L,0L,4L,2L,0L,0L,8L,14L,0L,0L,2L,-2L,40L,0L,4L,22L,0L,0L,6L,4L,0L,0L,12L,22L,0L,0L,8L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071961Inst : IEnumerable<long>
{
public static readonly long[] Value=A071961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071961.Bytes);
public long this[int i]=>Value[i];

public static A071961Inst Instance=new A071961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071962
{
public static readonly long[] Value={ 1L,2L,4L,10L,26L,70L,216L,682L,2264L,7960L,29262L,113256L,452586L,1886306L,8109828L,36274448L,167157176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071962Inst : IEnumerable<long>
{
public static readonly long[] Value=A071962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071962.Bytes);
public long this[int i]=>Value[i];

public static A071962Inst Instance=new A071962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071963
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,5L,11L,5L,7L,7L,11L,101L,5L,11L,11L,11L,11L,7L,19L,11L,167L,251L,7L,89L,29L,43L,13L,83L,467L,311L,23L,23L,1231L,41L,17977L,281L,43L,11L,127L,193L,2417L,71L,97L,1087L,241L,67L,7013L,631L,9283L,661L,53L,5237L,59L,227L,1019L,102359L,3251L,199L,409L,971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071963Inst : IEnumerable<long>
{
public static readonly long[] Value=A071963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071963.Bytes);
public long this[int i]=>Value[i];

public static A071963Inst Instance=new A071963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071964
{
public static readonly long[] Value={ 4L,6L,9L,10L,21L,25L,34L,39L,49L,55L,57L,111L,121L,155L,169L,203L,205L,219L,253L,289L,291L,301L,305L,327L,361L,489L,497L,505L,514L,529L,579L,689L,737L,755L,791L,841L,889L,905L,961L,979L,1027L,1081L,1205L,1255L,1299L,1355L,1369L,1379L,1461L,1477L,1681L,1703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071964Inst : IEnumerable<long>
{
public static readonly long[] Value=A071964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071964.Bytes);
public long this[int i]=>Value[i];

public static A071964Inst Instance=new A071964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071965
{
public static readonly long[] Value={ 15L,33L,51L,69L,91L,95L,141L,145L,159L,213L,287L,295L,321L,395L,445L,473L,573L,581L,679L,703L,745L,895L,973L,995L,1139L,1149L,1169L,1195L,1199L,1293L,1339L,1345L,1441L,1561L,1717L,1757L,1795L,1891L,1941L,2051L,2147L,2167L,2245L,2353L,2395L,2443L,2495L,2589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071965Inst : IEnumerable<long>
{
public static readonly long[] Value=A071965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071965.Bytes);
public long this[int i]=>Value[i];

public static A071965Inst Instance=new A071965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071966
{
public static readonly long[] Value={ 4L,16L,20L,25L,30L,32L,52L,65L,78L,80L,90L,130L,145L,148L,156L,164L,169L,174L,200L,238L,240L,244L,250L,256L,265L,270L,272L,286L,289L,290L,300L,306L,318L,320L,340L,348L,360L,388L,400L,408L,436L,442L,450L,452L,455L,464L,480L,481L,505L,512L,522L,540L,546L,574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071966Inst : IEnumerable<long>
{
public static readonly long[] Value=A071966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071966.Bytes);
public long this[int i]=>Value[i];

public static A071966Inst Instance=new A071966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071967
{
public static readonly long[] Value={ 1L,2L,240L,480L,2162L,4320L,7200L,13440L,21840L,35042L,43680L,60960L,95520L,125280L,143040L,178560L,261362L,315840L,347280L,423840L,557280L,665280L,696480L,804480L,1069920L,1261922L,1227360L,1418880L,1845120L,2034720L,2066880L,2346240L,2890320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071967Inst : IEnumerable<long>
{
public static readonly long[] Value=A071967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071967.Bytes);
public long this[int i]=>Value[i];

public static A071967Inst Instance=new A071967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071968
{
public static readonly long[] Value={ 1L,1L,3L,45L,105L,1575L,10395L,315315L,45045L,6891885L,72747675L,160044885L,1003917915L,21751554825L,35137127025L,2183521465125L,4512611027925L,76714387474725L,40613499251325L,3172365552631275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071968Inst : IEnumerable<long>
{
public static readonly long[] Value=A071968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071968.Bytes);
public long this[int i]=>Value[i];

public static A071968Inst Instance=new A071968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071969
{
public static readonly long[] Value={ 1L,1L,2L,6L,19L,63L,219L,787L,2897L,10869L,41414L,159822L,623391L,2453727L,9733866L,38877318L,156206233L,630947421L,2560537092L,10435207116L,42689715279L,175243923783L,721649457417L,2980276087005L,12340456995177L,51222441676513L,213090270498764L,888321276659112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071969Inst : IEnumerable<long>
{
public static readonly long[] Value=A071969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071969.Bytes);
public long this[int i]=>Value[i];

public static A071969Inst Instance=new A071969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071970
{
public static readonly long[] Value={ 1L,2L,4L,3L,18L,12L,9L,8L,48L,45L,50L,20L,75L,72L,16L,5L,200L,112L,147L,288L,320L,175L,98L,28L,245L,800L,192L,63L,392L,80L,25L,6L,180L,675L,648L,176L,847L,490L,300L,99L,3872L,832L,845L,600L,1008L,1323L,162L,108L,567L,1176L,720L,325L,5408L,704L,363L,90L,700L,539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071970Inst : IEnumerable<long>
{
public static readonly long[] Value=A071970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071970.Bytes);
public long this[int i]=>Value[i];

public static A071970Inst Instance=new A071970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071971
{
public static readonly long[] Value={ 1L,7L,45L,401L,719L,1136L,5613L,6358L,12448L,24739L,28082L,42850L,59604L,78928L,81119L,169213L,214725L,309015L,432821L,496399L,706170L,725188L,1163780L,2284457L,2941839L,3857806L,4133465L,5890433L,6190258L,6286719L,6888119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071971Inst : IEnumerable<long>
{
public static readonly long[] Value=A071971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071971.Bytes);
public long this[int i]=>Value[i];

public static A071971Inst Instance=new A071971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071988
{
public static readonly long[] Value={ 2L,2L,2L,3L,4L,4L,5L,11L,15L,7L,22L,42L,11L,56L,176L,13L,79L,299L,17L,137L,697L,19L,172L,988L,23L,254L,1794L,29L,407L,3683L,31L,466L,4526L,37L,667L,7807L,41L,821L,10701L,43L,904L,12384L,47L,1082L,16262L,53L,1379L,23479L,59L,1712L,32568L,61L,1831L,36051L,67L,2212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071988Inst : IEnumerable<long>
{
public static readonly long[] Value=A071988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071988.Bytes);
public long this[int i]=>Value[i];

public static A071988Inst Instance=new A071988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071989
{
public static readonly long[] Value={ 4L,3L,6L,4L,5L,7L,6L,9L,5L,4L,7L,7L,6L,8L,3L,3L,0L,4L,5L,9L,8L,3L,3L,0L,8L,9L,6L,2L,4L,1L,0L,4L,4L,0L,6L,7L,9L,5L,1L,7L,4L,1L,3L,5L,7L,5L,7L,7L,4L,8L,8L,9L,5L,0L,5L,0L,6L,5L,1L,7L,3L,3L,9L,9L,7L,7L,6L,1L,4L,9L,9L,2L,7L,8L,5L,8L,4L,9L,4L,5L,4L,2L,8L,0L,2L,1L,7L,7L,4L,7L,4L,8L,1L,8L,4L,5L,7L,5L,8L,0L,0L,0L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071989Inst : IEnumerable<long>
{
public static readonly long[] Value=A071989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071989.Bytes);
public long this[int i]=>Value[i];

public static A071989Inst Instance=new A071989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071990
{
public static readonly BigInteger[] Value={ 1L,12L,191L,4084L,135249L,6083702L,382629607L,28634912196L,3000711370793L,332363027120752L,46774578929554863L,7143041842570860878L,BigInteger.Parse("1304982717560745380233"),BigInteger.Parse("254050342563254798982984") };
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
public class A071990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071990Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071990.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071990.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071990Inst Instance=new A071990Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071991
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,5L,5L,6L,7L,7L,8L,9L,10L,11L,11L,12L,12L,13L,14L,15L,16L,16L,16L,17L,17L,18L,19L,20L,21L,22L,23L,23L,23L,23L,24L,25L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,34L,34L,34L,35L,35L,36L,36L,37L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,49L,50L,50L,50L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071991Inst : IEnumerable<long>
{
public static readonly long[] Value=A071991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071991.Bytes);
public long this[int i]=>Value[i];

public static A071991Inst Instance=new A071991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071992
{
public static readonly long[] Value={ 1L,0L,1L,4L,5L,4L,1L,0L,1L,0L,1L,4L,5L,8L,13L,16L,17L,16L,17L,20L,21L,20L,17L,16L,17L,16L,13L,8L,5L,4L,1L,0L,1L,0L,1L,4L,5L,4L,1L,0L,1L,0L,1L,4L,5L,8L,13L,16L,17L,16L,17L,20L,21L,24L,29L,32L,37L,44L,49L,52L,53L,56L,61L,64L,65L,64L,65L,68L,69L,68L,65L,64L,65L,64L,65L,68L,69L,72L,77L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071992Inst : IEnumerable<long>
{
public static readonly long[] Value=A071992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071992.Bytes);
public long this[int i]=>Value[i];

public static A071992Inst Instance=new A071992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071993
{
public static readonly long[] Value={ 1L,0L,1L,2L,1L,0L,-1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,1L,0L,1L,2L,1L,0L,-1L,0L,1L,0L,-1L,-2L,-1L,0L,-1L,0L,1L,0L,1L,2L,1L,0L,-1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,1L,0L,1L,2L,1L,2L,3L,2L,3L,4L,3L,2L,1L,2L,3L,2L,1L,0L,1L,2L,1L,0L,-1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,1L,0L,1L,2L,1L,0L,-1L,0L,1L,0L,-1L,-2L,-1L,0L,-1L,0L,1L,0L,1L,2L,1L,0L,-1L,0L,1L,0L,-1L,-2L,-1L,0L,-1L,-2L,-3L,-2L,-1L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071993Inst : IEnumerable<long>
{
public static readonly long[] Value=A071993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071993.Bytes);
public long this[int i]=>Value[i];

public static A071993Inst Instance=new A071993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071994
{
public static readonly long[] Value={ 1L,4L,8L,13L,20L,29L,40L,52L,65L,80L,96L,113L,132L,152L,173L,196L,221L,248L,276L,305L,336L,369L,404L,440L,477L,516L,557L,600L,644L,689L,736L,784L,833L,884L,936L,989L,1044L,1101L,1160L,1220L,1281L,1344L,1408L,1473L,1540L,1608L,1677L,1748L,1821L,1896L,1972L,2049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071994Inst : IEnumerable<long>
{
public static readonly long[] Value=A071994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071994.Bytes);
public long this[int i]=>Value[i];

public static A071994Inst Instance=new A071994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071995
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,3L,4L,5L,6L,7L,6L,7L,6L,7L,8L,9L,10L,9L,8L,9L,8L,9L,10L,11L,12L,13L,14L,13L,12L,11L,12L,13L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,20L,19L,18L,19L,18L,19L,18L,19L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,29L,30L,29L,28L,27L,26L,27L,28L,27L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071995Inst : IEnumerable<long>
{
public static readonly long[] Value=A071995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071995.Bytes);
public long this[int i]=>Value[i];

public static A071995Inst Instance=new A071995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071996
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,6L,6L,6L,6L,6L,7L,8L,8L,9L,9L,9L,9L,9L,9L,9L,10L,11L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,14L,15L,16L,16L,17L,17L,18L,18L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,20L,20L,21L,22L,23L,24L,24L,24L,25L,26L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071996Inst : IEnumerable<long>
{
public static readonly long[] Value=A071996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071996.Bytes);
public long this[int i]=>Value[i];

public static A071996Inst Instance=new A071996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071997
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,19L,27L,43L,75L,115L,171L,307L,555L,691L,1383L,2467L,3627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071997Inst : IEnumerable<long>
{
public static readonly long[] Value=A071997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071997.Bytes);
public long this[int i]=>Value[i];

public static A071997Inst Instance=new A071997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071998
{
public static readonly long[] Value={ 0L,1L,1010L,1011L,1100100L,1100101L,1101110L,1101111L,1111101000L,1111101001L,1111110010L,1111110011L,10001001100L,10001001101L,10001010110L,10001010111L,10011100010000L,10011100010001L,10011100011010L,10011100011011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071998Inst : IEnumerable<long>
{
public static readonly long[] Value=A071998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071998.Bytes);
public long this[int i]=>Value[i];

public static A071998Inst Instance=new A071998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071999
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-2L,15L,28L,-495L,-924L,29393L,55200L,-2755377L,-5206760L,374909535L,712318464L,-69864169375L,-133355433456L,17088978269025L,32747341496320L,-5311777786094241L,-10212994682100000L,2045230826019387119L,3943711514611814400L,BigInteger.Parse("-955583772509043759375") };
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
public class A071999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071999Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071999.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071999.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071999Inst Instance=new A071999Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072000
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,2L,2L,3L,4L,4L,4L,4L,5L,6L,6L,6L,6L,6L,6L,7L,8L,8L,8L,9L,10L,10L,10L,10L,10L,10L,10L,11L,12L,13L,13L,13L,14L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,17L,17L,18L,18L,18L,18L,19L,19L,20L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,23L,24L,24L,24L,24L,24L,25L,25L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072000Inst : IEnumerable<long>
{
public static readonly long[] Value=A072000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072000.Bytes);
public long this[int i]=>Value[i];

public static A072000Inst Instance=new A072000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072001
{
public static readonly long[] Value={ 1L,11L,101L,111L,201L,211L,1001L,1011L,1101L,1111L,1201L,1211L,2001L,2011L,2101L,2111L,2201L,2211L,3001L,3011L,3101L,3111L,3201L,3211L,10001L,10011L,10101L,10111L,10201L,10211L,11001L,11011L,11101L,11111L,11201L,11211L,12001L,12011L,12101L,12111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072001Inst : IEnumerable<long>
{
public static readonly long[] Value=A072001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072001.Bytes);
public long this[int i]=>Value[i];

public static A072001Inst Instance=new A072001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072002
{
public static readonly long[] Value={ 3L,5L,7L,19L,257L,599479L,649657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072002Inst : IEnumerable<long>
{
public static readonly long[] Value=A072002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072002.Bytes);
public long this[int i]=>Value[i];

public static A072002Inst Instance=new A072002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072003
{
public static readonly long[] Value={ 8L,7L,5L,3L,9L,7L,3L,1L,7L,1L,9L,3L,9L,7L,3L,7L,1L,9L,3L,9L,7L,1L,7L,1L,3L,9L,7L,3L,1L,7L,3L,9L,3L,1L,1L,9L,3L,7L,3L,7L,1L,9L,9L,7L,3L,1L,9L,7L,3L,1L,7L,1L,9L,9L,3L,7L,1L,9L,3L,9L,7L,7L,3L,9L,7L,3L,9L,3L,3L,1L,7L,1L,3L,7L,1L,7L,1L,3L,9L,1L,1L,9L,9L,7L,1L,7L,1L,3L,9L,7L,3L,1L,3L,9L,1L,7L,1L,9L,7L,9L,3L,3L,7L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072003Inst : IEnumerable<long>
{
public static readonly long[] Value=A072003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072003.Bytes);
public long this[int i]=>Value[i];

public static A072003Inst Instance=new A072003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072004
{
public static readonly long[] Value={ 0L,1L,3L,3L,10L,0L,3L,1L,15L,19L,10L,28L,12L,1L,32L,25L,0L,42L,42L,45L,4L,23L,77L,50L,30L,45L,86L,43L,64L,100L,23L,105L,89L,41L,87L,54L,133L,2L,59L,47L,147L,64L,174L,102L,65L,104L,7L,127L,107L,28L,210L,194L,106L,60L,159L,95L,119L,116L,104L,230L,224L,110L,183L,212L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072004Inst : IEnumerable<long>
{
public static readonly long[] Value=A072004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072004.Bytes);
public long this[int i]=>Value[i];

public static A072004Inst Instance=new A072004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072005
{
public static readonly long[] Value={ 1L,3L,9L,2889L,2899999989L,4899999987L,19899999972L,29898999693L,49989958299L,49999917897L,99884394999L,372797889885L,1989767716659L,2678052898989L,17902896898419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072005Inst : IEnumerable<long>
{
public static readonly long[] Value=A072005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072005.Bytes);
public long this[int i]=>Value[i];

public static A072005Inst Instance=new A072005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072006
{
public static readonly long[] Value={ 3L,4L,5L,4L,2L,7L,5L,2L,2L,2L,2L,6L,10L,2L,2L,2L,2L,7L,4L,2L,16L,4L,2L,8L,19L,5L,2L,2L,2L,13L,2L,2L,2L,4L,5L,4L,2L,4L,2L,5L,2L,14L,2L,21L,2L,2L,2L,2L,2L,5L,5L,2L,28L,2L,2L,2L,2L,2L,8L,8L,2L,2L,2L,2L,4L,5L,2L,14L,2L,7L,5L,2L,2L,5L,4L,2L,2L,11L,7L,17L,2L,11L,2L,26L,2L,2L,12L,4L,5L,2L,2L,2L,2L,2L,2L,2L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072006Inst : IEnumerable<long>
{
public static readonly long[] Value=A072006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072006.Bytes);
public long this[int i]=>Value[i];

public static A072006Inst Instance=new A072006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072007
{
public static readonly long[] Value={ 0L,1L,3L,6L,2L,7L,13L,4L,12L,21L,5L,16L,28L,8L,22L,37L,9L,26L,44L,10L,30L,51L,11L,34L,58L,14L,40L,67L,15L,45L,75L,17L,49L,82L,18L,53L,89L,19L,57L,96L,20L,61L,103L,23L,68L,113L,24L,71L,119L,25L,76L,127L,27L,80L,134L,29L,85L,142L,31L,90L,150L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072007Inst : IEnumerable<long>
{
public static readonly long[] Value=A072007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072007.Bytes);
public long this[int i]=>Value[i];

public static A072007Inst Instance=new A072007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072008
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,10L,11L,14L,15L,17L,18L,19L,20L,23L,24L,25L,27L,29L,31L,32L,33L,35L,36L,38L,39L,41L,42L,43L,46L,47L,48L,50L,52L,54L,55L,56L,59L,60L,62L,63L,64L,65L,66L,69L,70L,72L,73L,74L,77L,78L,79L,81L,83L,84L,86L,87L,88L,91L,92L,93L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072008Inst : IEnumerable<long>
{
public static readonly long[] Value=A072008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072008.Bytes);
public long this[int i]=>Value[i];

public static A072008Inst Instance=new A072008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072009
{
public static readonly long[] Value={ 0L,1L,4L,2L,7L,10L,3L,5L,13L,16L,19L,22L,8L,6L,25L,28L,11L,31L,34L,37L,40L,9L,14L,43L,46L,49L,17L,52L,12L,55L,20L,58L,61L,64L,23L,67L,70L,15L,73L,76L,26L,79L,82L,85L,18L,29L,88L,91L,94L,32L,97L,21L,100L,35L,103L,106L,109L,38L,24L,112L,115L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072009Inst : IEnumerable<long>
{
public static readonly long[] Value=A072009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072009.Bytes);
public long this[int i]=>Value[i];

public static A072009Inst Instance=new A072009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072010
{
public static readonly long[] Value={ 1L,2L,1L,4L,7L,2L,5L,8L,1L,14L,9L,4L,15L,10L,7L,16L,19L,2L,17L,28L,5L,18L,21L,8L,49L,30L,1L,20L,31L,14L,29L,32L,9L,38L,35L,4L,39L,34L,15L,56L,43L,10L,41L,36L,7L,42L,45L,16L,25L,98L,19L,60L,55L,2L,63L,40L,17L,62L,57L,28L,63L,58L,5L,64L,105L,18L,65L,76L,21L,70L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072010Inst : IEnumerable<long>
{
public static readonly long[] Value=A072010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072010.Bytes);
public long this[int i]=>Value[i];

public static A072010Inst Instance=new A072010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072011
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,35L,64L,70L,128L,140L,256L,280L,323L,512L,560L,646L,899L,1024L,1120L,1225L,1292L,1763L,1798L,2048L,2240L,2450L,2584L,3526L,3596L,4096L,4480L,4900L,5168L,7052L,7192L,8192L,8960L,9800L,10336L,10403L,11305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072011Inst : IEnumerable<long>
{
public static readonly long[] Value=A072011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072011.Bytes);
public long this[int i]=>Value[i];

public static A072011Inst Instance=new A072011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072012
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,2L,7L,8L,1L,10L,1L,4L,7L,14L,5L,16L,17L,2L,19L,20L,7L,2L,5L,8L,25L,14L,1L,28L,29L,10L,31L,32L,1L,34L,35L,4L,15L,38L,7L,40L,41L,14L,43L,4L,5L,10L,7L,16L,49L,50L,17L,28L,63L,2L,5L,56L,19L,58L,17L,20L,5L,62L,7L,64L,35L,2L,105L,68L,5L,70L,21L,8L,49L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072012Inst : IEnumerable<long>
{
public static readonly long[] Value=A072012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072012.Bytes);
public long this[int i]=>Value[i];

public static A072012Inst Instance=new A072012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072013
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,14L,16L,17L,19L,20L,25L,28L,29L,31L,32L,34L,35L,38L,40L,41L,43L,49L,50L,56L,58L,62L,64L,68L,70L,76L,80L,82L,85L,86L,95L,98L,100L,101L,103L,112L,116L,119L,124L,125L,128L,133L,136L,137L,139L,140L,145L,149L,151L,152L,155L,160L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072013Inst : IEnumerable<long>
{
public static readonly long[] Value=A072013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072013.Bytes);
public long this[int i]=>Value[i];

public static A072013Inst Instance=new A072013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072014
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,2L,5L,8L,1L,10L,1L,4L,5L,10L,5L,16L,17L,2L,17L,20L,5L,2L,5L,8L,25L,10L,1L,20L,29L,10L,29L,32L,1L,34L,35L,4L,5L,34L,5L,40L,41L,10L,41L,4L,5L,10L,5L,16L,25L,50L,17L,20L,5L,2L,5L,40L,17L,58L,17L,20L,5L,58L,5L,64L,35L,2L,35L,68L,5L,70L,5L,8L,25L,10L,25L,68L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072014Inst : IEnumerable<long>
{
public static readonly long[] Value=A072014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072014.Bytes);
public long this[int i]=>Value[i];

public static A072014Inst Instance=new A072014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072015
{
public static readonly long[] Value={ 1L,2L,1L,4L,7L,2L,7L,8L,1L,14L,9L,4L,15L,14L,7L,16L,19L,2L,19L,28L,7L,18L,21L,8L,49L,30L,1L,28L,31L,14L,31L,32L,9L,38L,35L,4L,39L,38L,15L,56L,43L,14L,43L,36L,7L,42L,45L,16L,49L,98L,19L,60L,63L,2L,63L,56L,19L,62L,57L,28L,63L,62L,7L,64L,105L,18L,105L,76L,21L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072015Inst : IEnumerable<long>
{
public static readonly long[] Value=A072015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072015.Bytes);
public long this[int i]=>Value[i];

public static A072015Inst Instance=new A072015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072016
{
public static readonly long[] Value={ 2889L,3699L,3888L,3969L,4779L,4887L,5589L,5697L,5778L,5859L,5886L,5967L,6399L,6669L,6777L,6885L,6939L,7398L,7479L,7587L,7668L,7695L,7749L,7776L,7857L,7884L,7938L,7965L,8289L,8397L,8559L,8667L,8775L,8829L,8883L,8937L,9099L,9288L,9369L,9396L,9477L,9558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072016Inst : IEnumerable<long>
{
public static readonly long[] Value=A072016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072016.Bytes);
public long this[int i]=>Value[i];

public static A072016Inst Instance=new A072016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072017
{
public static readonly long[] Value={ 2899999989L,2989999899L,2999889999L,3799999899L,3898989999L,3899799999L,3899999988L,3979989999L,3988899999L,3989999898L,3989999979L,3998999889L,3999889998L,3999898989L,3999899799L,3999979989L,3999988899L,4699998999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072017Inst : IEnumerable<long>
{
public static readonly long[] Value=A072017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072017.Bytes);
public long this[int i]=>Value[i];

public static A072017Inst Instance=new A072017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072018
{
public static readonly long[] Value={ 4899999987L,4989999897L,4999889997L,4999997889L,5889998997L,5889999969L,5898989997L,5898998988L,5899899789L,5899979979L,5899987998L,5899989699L,5899996989L,5979999879L,5988899997L,5988998898L,5989889979L,5989897998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072018Inst : IEnumerable<long>
{
public static readonly long[] Value=A072018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072018.Bytes);
public long this[int i]=>Value[i];

public static A072018Inst Instance=new A072018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072019
{
public static readonly BigInteger[] Value={ 1L,31L,2481L,371881L,89281461L,31274052351L,15020526041221L,9461707887414161L,7560380738419084201L,BigInteger.Parse("7466459670646734124671"),BigInteger.Parse("8925493084998518977531001"),BigInteger.Parse("12696331763378714706289411961"),BigInteger.Parse("21186586117648690791837844061341"),BigInteger.Parse("40976310644118022811682503135528671"),BigInteger.Parse("90905327647146969025291153908894514381"),BigInteger.Parse("229256189615621846477632508681520371943201") };
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
public class A072019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072019Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072019.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072019.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072019Inst Instance=new A072019Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072036
{
public static readonly long[] Value={ 1L,30L,2L,29L,3L,28L,4L,567L,888L,887L,886L,1253L,5L,24L,376L,23L,575L,22L,374L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072036Inst : IEnumerable<long>
{
public static readonly long[] Value=A072036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072036.Bytes);
public long this[int i]=>Value[i];

public static A072036Inst Instance=new A072036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072037
{
public static readonly BigInteger[] Value={ 4L,8L,9L,121L,343L,1331L,10201L,14641L,94249L,1030301L,104060401L,900075181570009L,10022212521222001L,12124434743442121L,12323244744232321L,12341234943214321L,BigInteger.Parse("1022321210249420121232201"),BigInteger.Parse("1210024420147410244200121"),BigInteger.Parse("1210222232227222322220121") };
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
public class A072037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072037.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072037Inst Instance=new A072037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072038
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,2L,2L,2L,1L,1L,1L,3L,2L,1L,1L,1L,1L,3L,2L,3L,4L,1L,1L,2L,1L,3L,1L,1L,2L,2L,2L,1L,1L,1L,4L,2L,3L,2L,1L,1L,1L,1L,4L,2L,1L,1L,1L,3L,1L,1L,4L,2L,2L,1L,1L,2L,1L,3L,1L,2L,5L,1L,1L,3L,2L,3L,1L,4L,1L,2L,2L,3L,1L,1L,1L,1L,1L,2L,3L,1L,1L,1L,5L,2L,1L,1L,3L,2L,1L,4L,2L,2L,1L,1L,1L,2L,1L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072038Inst : IEnumerable<long>
{
public static readonly long[] Value=A072038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072038.Bytes);
public long this[int i]=>Value[i];

public static A072038Inst Instance=new A072038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072039
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,6L,3L,7L,4L,5L,6L,8L,9L,11L,4L,7L,10L,12L,13L,14L,5L,8L,6L,4L,15L,17L,9L,16L,7L,19L,18L,10L,11L,12L,21L,20L,22L,5L,13L,8L,14L,23L,24L,26L,27L,6L,15L,35L,25L,30L,9L,28L,29L,7L,16L,17L,31L,33L,18L,32L,10L,34L,19L,5L,36L,40L,11L,20L,12L,37L,8L,39L,21L,22L,13L,38L,45L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072039Inst : IEnumerable<long>
{
public static readonly long[] Value=A072039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072039.Bytes);
public long this[int i]=>Value[i];

public static A072039Inst Instance=new A072039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072040
{
public static readonly long[] Value={ 22L,187L,202L,222L,242L,262L,282L,302L,322L,342L,362L,382L,1717L,1737L,1757L,1777L,1797L,1817L,1837L,1857L,1877L,1897L,2002L,2871L,3982L,11211L,11411L,11611L,11811L,12011L,12211L,12411L,12611L,12811L,17017L,18128L,18997L,19888L,20002L,20202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072040Inst : IEnumerable<long>
{
public static readonly long[] Value=A072040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072040.Bytes);
public long this[int i]=>Value[i];

public static A072040Inst Instance=new A072040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072041
{
public static readonly long[] Value={ 1L,0L,22L,33L,44L,55L,66L,77L,88L,99L,1111L,-1L,2552L,-1L,2662L,3443L,2772L,-1L,2882L,-1L,2992L,3663L,-1L,-1L,3773L,5445L,-1L,3883L,4664L,-1L,3993L,-1L,4774L,-1L,-1L,5665L,4884L,-1L,-1L,-1L,4994L,-1L,6666L,-1L,-1L,5885L,-1L,-1L,6776L,7667L,5995L,-1L,-1L,-1L,6886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072041Inst : IEnumerable<long>
{
public static readonly long[] Value=A072041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072041.Bytes);
public long this[int i]=>Value[i];

public static A072041Inst Instance=new A072041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072042
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,8L,30L,288L,10080L,3317760L,37623398400L,138694895861760000L,BigInteger.Parse("5739990655358858585702400000"),BigInteger.Parse("868480806755424464755519466250436608000000000") };
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
public class A072042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072042Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072042.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072042.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072042Inst Instance=new A072042Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}