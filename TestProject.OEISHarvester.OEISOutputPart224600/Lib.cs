using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A262982
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,1L,2L,3L,3L,2L,2L,4L,3L,2L,2L,3L,3L,4L,3L,1L,3L,4L,7L,4L,2L,1L,5L,4L,3L,5L,3L,2L,3L,5L,3L,3L,4L,5L,5L,1L,3L,5L,6L,3L,4L,5L,4L,5L,6L,3L,5L,4L,4L,5L,3L,5L,8L,7L,3L,3L,5L,4L,5L,7L,3L,2L,4L,6L,7L,4L,3L,3L,5L,2L,3L,6L,5L,3L,6L,3L,2L,1L,4L,6L,7L,6L,5L,6L,1L,6L,5L,5L,6L,6L,4L,3L,4L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262982Inst : IEnumerable<long>
{
public static readonly long[] Value=A262982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262982.Bytes);
public long this[int i]=>Value[i];

public static A262982Inst Instance=new A262982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262983
{
public static readonly long[] Value={ 1L,2L,12L,24L,36L,60L,180L,240L,360L,720L,1260L,1680L,3600L,6720L,5040L,10080L,32400L,15120L,20160L,25200L,60480L,55440L,810000L,100800L,181440L,110880L,226800L,221760L,277200L,907200L,665280L,1587600L,720720L,5670000L,1108800L,3548160L,1995840L,1441440L,2494800L,6350400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262983Inst : IEnumerable<long>
{
public static readonly long[] Value=A262983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262983.Bytes);
public long this[int i]=>Value[i];

public static A262983Inst Instance=new A262983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262984
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,16L,26L,40L,60L,90L,131L,188L,268L,376L,522L,720L,983L,1330L,1790L,2390L,3170L,4184L,5488L,7160L,9300L,12020L,15466L,19822L,25300L,32168L,40760L,51464L,64763L,81250L,101620L,126726L,157604L,195472L,241810L,298400L,367340L,451156L,552867L,676030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262984Inst : IEnumerable<long>
{
public static readonly long[] Value=A262984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262984.Bytes);
public long this[int i]=>Value[i];

public static A262984Inst Instance=new A262984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262985
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,2L,1L,3L,2L,5L,2L,5L,2L,5L,4L,4L,4L,5L,7L,3L,3L,5L,5L,8L,4L,5L,3L,5L,4L,8L,4L,3L,6L,5L,2L,9L,6L,8L,4L,5L,5L,8L,6L,8L,8L,4L,6L,8L,10L,7L,6L,7L,8L,9L,6L,7L,7L,12L,5L,9L,8L,6L,7L,12L,5L,9L,6L,9L,6L,11L,9L,11L,5L,6L,10L,8L,7L,9L,11L,5L,7L,7L,8L,7L,9L,8L,8L,9L,6L,7L,9L,7L,10L,9L,4L,6L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262985Inst : IEnumerable<long>
{
public static readonly long[] Value=A262985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262985.Bytes);
public long this[int i]=>Value[i];

public static A262985Inst Instance=new A262985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262986
{
public static readonly long[] Value={ 1L,2L,6L,12L,24L,39L,63L,91L,123L,168L,218L,273L,345L,423L,507L,597L,709L,828L,954L,1087L,1247L,1415L,1591L,1775L,1991L,2216L,2450L,2693L,2945L,3235L,3535L,3845L,4165L,4495L,4869L,5254L,5650L,6057L,6475L,6943L,7423L,7915L,8419L,8935L,9463L,10048L,10646L,11257L,11881L,12518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262986Inst : IEnumerable<long>
{
public static readonly long[] Value=A262986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262986.Bytes);
public long this[int i]=>Value[i];

public static A262986Inst Instance=new A262986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262987
{
public static readonly long[] Value={ 1L,1L,3L,6L,11L,19L,33L,53L,86L,134L,205L,309L,460L,672L,974L,1394L,1975L,2773L,3863L,5333L,7316L,9964L,13484L,18140L,24269L,32288L,42751L,56331L,73888L,96503L,125529L,162635L,209939L,270027L,346123L,442213L,563205L,715110L,905361L,1142998L,1439098L,1807175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262987Inst : IEnumerable<long>
{
public static readonly long[] Value=A262987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262987.Bytes);
public long this[int i]=>Value[i];

public static A262987Inst Instance=new A262987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262988
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,2L,1L,0L,1L,2L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,2L,1L,0L,1L,1L,0L,2L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,2L,1L,0L,1L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262988Inst : IEnumerable<long>
{
public static readonly long[] Value=A262988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262988.Bytes);
public long this[int i]=>Value[i];

public static A262988Inst Instance=new A262988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262989
{
public static readonly long[] Value={ 248665082L,248695370L,249063875L,253674980L,256175640L,257930648L,257938064L,260577504L,260817480L,263987504L,264713960L,267766632L,267953048L,269037548L,269045192L,269174192L,269307584L,269735900L,269937500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262989Inst : IEnumerable<long>
{
public static readonly long[] Value=A262989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262989.Bytes);
public long this[int i]=>Value[i];

public static A262989Inst Instance=new A262989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262990
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,10L,20L,22L,40L,51L,67L,114L,126L,203L,230L,354L,468L,571L,885L,908L,1486L,1674L,2250L,3045L,3586L,5418L,5322L,8186L,9560L,12234L,16341L,17976L,27912L,26970L,38435L,46383L,57024L,76794L,80805L,125205L,116376L,165914L,201580L,232352L,322980L,332388L,508710L,456154L,645661L,800495L,886018L,1241190L,1226382L,1916682L,1693454L,2290704L,2935492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262990Inst : IEnumerable<long>
{
public static readonly long[] Value=A262990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262990.Bytes);
public long this[int i]=>Value[i];

public static A262990Inst Instance=new A262990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262991
{
public static readonly long[] Value={ 0L,2L,2L,4L,3L,5L,5L,6L,6L,7L,7L,9L,8L,10L,10L,11L,11L,12L,12L,14L,13L,15L,15L,16L,16L,17L,17L,18L,17L,19L,19L,20L,20L,22L,22L,23L,23L,25L,25L,26L,26L,28L,28L,30L,29L,30L,30L,31L,31L,31L,31L,33L,32L,33L,33L,34L,34L,36L,36L,38L,37L,39L,39L,39L,39L,41L,41L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262991Inst : IEnumerable<long>
{
public static readonly long[] Value=A262991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262991.Bytes);
public long this[int i]=>Value[i];

public static A262991Inst Instance=new A262991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262992
{
public static readonly long[] Value={ 0L,2L,3L,8L,6L,14L,17L,24L,24L,29L,34L,51L,45L,65L,72L,87L,87L,104L,104L,133L,123L,155L,166L,189L,189L,202L,215L,229L,215L,259L,274L,305L,305L,355L,372L,407L,407L,463L,482L,521L,521L,583L,604L,669L,647L,670L,693L,740L,740L,740L,740L,817L,791L,844L,844L,899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262992Inst : IEnumerable<long>
{
public static readonly long[] Value=A262992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262992.Bytes);
public long this[int i]=>Value[i];

public static A262992Inst Instance=new A262992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262993
{
public static readonly long[] Value={ 6L,5L,8L,0L,8L,8L,5L,9L,9L,1L,0L,1L,7L,9L,2L,0L,9L,7L,0L,8L,5L,1L,5L,4L,2L,4L,0L,3L,8L,8L,6L,4L,8L,6L,4L,9L,1L,5L,7L,3L,0L,7L,7L,4L,3L,8L,3L,4L,8L,0L,7L,4L,0L,0L,5L,1L,2L,1L,5L,1L,2L,6L,6L,1L,0L,3L,1L,3L,0L,5L,0L,4L,0L,3L,9L,5L,8L,2L,0L,4L,0L,9L,8L,0L,1L,0L,2L,9L,9L,1L,4L,9L,2L,6L,1L,0L,7L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262993Inst : IEnumerable<long>
{
public static readonly long[] Value=A262993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262993.Bytes);
public long this[int i]=>Value[i];

public static A262993Inst Instance=new A262993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262994
{
public static readonly long[] Value={ 3L,3L,3L,3L,4L,3L,3L,5L,7L,5L,3L,5L,9L,5L,4L,8L,4L,3L,28L,14L,7L,26L,13L,39L,22L,11L,16L,8L,4L,20L,10L,5L,6L,3L,24L,12L,6L,3L,25L,24L,12L,6L,3L,14L,7L,20L,10L,5L,19L,11L,21L,20L,10L,5L,3L,32L,16L,8L,4L,17L,24L,12L,6L,3L,67L,63L,43L,63L,40L,20L,10L,5L,15L,12L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262994Inst : IEnumerable<long>
{
public static readonly long[] Value=A262994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262994.Bytes);
public long this[int i]=>Value[i];

public static A262994Inst Instance=new A262994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262995
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,3L,5L,3L,6L,3L,6L,4L,6L,4L,7L,4L,6L,6L,6L,4L,8L,5L,6L,6L,7L,5L,8L,4L,9L,5L,7L,9L,5L,7L,8L,6L,9L,5L,9L,7L,7L,8L,8L,6L,8L,8L,8L,6L,7L,10L,8L,4L,12L,6L,8L,7L,9L,6L,10L,6L,8L,10L,8L,6L,12L,4L,12L,6L,11L,6L,11L,6L,9L,10L,8L,7L,11L,7L,10L,8L,9L,7L,10L,7L,13L,5L,7L,11L,9L,6L,8L,12L,8L,7L,11L,7L,12L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262995Inst : IEnumerable<long>
{
public static readonly long[] Value=A262995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262995.Bytes);
public long this[int i]=>Value[i];

public static A262995Inst Instance=new A262995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262996
{
public static readonly long[] Value={ 1223444433L,1224343443L,1233444243L,1233444423L,1234424343L,1234442343L,1243344243L,1243442433L,1244332443L,1244343423L,1244344323L,1244442333L,1323442443L,1324244433L,1324344423L,1324443243L,1324443423L,1324444323L,1332244443L,1334244243L,1334244423L,1334424243L,1342443243L,1343242443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262996Inst : IEnumerable<long>
{
public static readonly long[] Value=A262996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262996.Bytes);
public long this[int i]=>Value[i];

public static A262996Inst Instance=new A262996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262997
{
public static readonly long[] Value={ 0L,5L,19L,40L,69L,107L,152L,205L,267L,336L,413L,499L,592L,693L,803L,920L,1045L,1179L,1320L,1469L,1627L,1792L,1965L,2147L,2336L,2533L,2739L,2952L,3173L,3403L,3640L,3885L,4139L,4400L,4669L,4947L,5232L,5525L,5827L,6136L,6453L,6779L,7112L,7453L,7803L,8160L,8525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262997Inst : IEnumerable<long>
{
public static readonly long[] Value=A262997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262997.Bytes);
public long this[int i]=>Value[i];

public static A262997Inst Instance=new A262997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262998
{
public static readonly long[] Value={ 10L,26L,34L,58L,74L,82L,106L,122L,146L,178L,194L,202L,218L,226L,274L,298L,314L,320L,346L,362L,386L,394L,458L,466L,480L,482L,514L,538L,554L,562L,586L,626L,634L,674L,698L,706L,746L,778L,794L,802L,818L,842L,866L,898L,914L,922L,1018L,1042L,1082L,1114L,1138L,1154L,1186L,1202L,1226L,1234L,1282L,1306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262998Inst : IEnumerable<long>
{
public static readonly long[] Value=A262998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262998.Bytes);
public long this[int i]=>Value[i];

public static A262998Inst Instance=new A262998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262999
{
public static readonly long[] Value={ 0L,2L,1L,3L,1L,4L,1L,4L,3L,3L,4L,3L,4L,3L,5L,2L,4L,6L,2L,6L,3L,5L,3L,5L,5L,4L,6L,3L,5L,5L,4L,5L,6L,6L,1L,10L,1L,6L,7L,3L,6L,6L,6L,3L,6L,6L,4L,9L,2L,8L,4L,7L,3L,8L,5L,4L,8L,6L,2L,7L,6L,6L,4L,8L,5L,7L,3L,7L,7L,6L,4L,10L,3L,5L,8L,8L,4L,6L,4L,10L,7L,3L,5L,9L,6L,5L,5L,9L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262999Inst : IEnumerable<long>
{
public static readonly long[] Value=A262999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262999.Bytes);
public long this[int i]=>Value[i];

public static A262999Inst Instance=new A262999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263000
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,4L,4L,3L,3L,1L,1L,0L,1L,1L,1L,1L,2L,2L,1L,2L,3L,4L,3L,3L,2L,2L,4L,4L,4L,4L,3L,6L,9L,13L,17L,14L,11L,9L,10L,4L,6L,4L,3L,0L,2L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263000Inst : IEnumerable<long>
{
public static readonly long[] Value=A263000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263000.Bytes);
public long this[int i]=>Value[i];

public static A263000Inst Instance=new A263000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263001
{
public static readonly long[] Value={ 1L,0L,2L,1L,3L,1L,3L,2L,3L,3L,3L,4L,3L,4L,2L,5L,4L,2L,7L,2L,4L,5L,2L,7L,2L,5L,4L,4L,5L,3L,5L,6L,4L,5L,6L,3L,6L,6L,2L,9L,3L,5L,5L,5L,6L,5L,6L,5L,4L,7L,4L,7L,4L,5L,6L,7L,3L,5L,6L,7L,4L,7L,7L,5L,3L,9L,5L,7L,3L,8L,7L,5L,4L,8L,6L,6L,3L,10L,7L,3L,3L,11L,5L,7L,4L,8L,5L,4L,7L,7L,5L,8L,3L,8L,7L,4L,5L,9L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263001Inst : IEnumerable<long>
{
public static readonly long[] Value=A263001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263001.Bytes);
public long this[int i]=>Value[i];

public static A263001Inst Instance=new A263001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263002
{
public static readonly long[] Value={ 1L,2L,5L,10L,20L,34L,61L,100L,165L,260L,408L,620L,940L,1390L,2045L,2960L,4257L,6040L,8525L,11900L,16522L,22738L,31130L,42300L,57210L,76872L,102834L,136800L,181230L,238900L,313725L,410160L,534330L,693330L,896655L,1155420L,1484274L,1900420L,2426215L,3088100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263002Inst : IEnumerable<long>
{
public static readonly long[] Value=A263002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263002.Bytes);
public long this[int i]=>Value[i];

public static A263002Inst Instance=new A263002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263003
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,3L,6L,24L,8L,12L,8L,24L,120L,30L,24L,20L,24L,30L,120L,720L,144L,80L,144L,72L,45L,144L,72L,80L,144L,720L,5040L,840L,360L,360L,336L,144L,240L,240L,252L,144L,360L,336L,360L,840L,5040L,40320L,5760L,2016L,1440L,2880L,1920L,630L,576L,720L,960L,1152L,448L,720L,576L,2880L,1152L,630L,1440L,1920L,2016L,5760L,40320L,362880L,45360L,13440L,7560L,8640L,12960L,3456L,2240L,4320L,3024L,2160L,8640L,6480L,1920L,1680L,1680L,2160L,4320L,5184L,1920L,3024L,2240L,8640L,6480L,3456L,7560L,12960L,13440L,45360L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263003Inst : IEnumerable<long>
{
public static readonly long[] Value=A263003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263003.Bytes);
public long this[int i]=>Value[i];

public static A263003Inst Instance=new A263003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263004
{
public static readonly BigInteger[] Value={ 1L,1L,4L,15L,76L,368L,2365L,14892L,116236L,966064L,9256889L,96638496L,1129309316L,14261533248L,196315312964L,2900635720869L,45926240752560L,773725147192412L,13831256551416480L,261227089570409028L,5198858467673903360L,BigInteger.Parse("108706624576630569271") };
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
public class A263004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263004Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263004.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263004.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263004Inst Instance=new A263004Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263005
{
public static readonly long[] Value={ 3L,8L,10L,14L,15L,21L,21L,24L,28L,35L,36L,36L,45L,48L,55L,55L,57L,63L,66L,78L,78L,78L,80L,91L,99L,105L,105L,120L,120L,133L,136L,136L,143L,153L,168L,171L,171L,190L,195L,210L,210L,224L,231L,248L,253L,253L,255L,276L,288L,300L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263005Inst : IEnumerable<long>
{
public static readonly long[] Value=A263005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263005.Bytes);
public long this[int i]=>Value[i];

public static A263005Inst Instance=new A263005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263006
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,18L,1L,4L,2L,1L,3L,7L,5L,3L,70L,1L,1L,1L,6L,3L,2L,32L,1L,3L,4L,23L,7L,9L,182L,11L,2L,1L,5L,99L,1L,29718L,1L,8L,4L,2L,13L,5L,1L,1068L,43L,39L,5L,1L,9L,3L,378L,51L,500L,1L,5L,45L,151L,1L,5604L,1L,10L,5L,2L,4005L,5L,8890182L,1L,7L,3L,776L,16L,35L,6L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263006Inst : IEnumerable<long>
{
public static readonly long[] Value=A263006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263006.Bytes);
public long this[int i]=>Value[i];

public static A263006Inst Instance=new A263006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263007
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,5L,2L,1L,1L,1L,2L,3L,1L,4L,13L,1L,2L,3L,1L,1L,1L,5L,1L,5L,3L,78L,1L,5L,25L,3L,3L,1L,2L,13L,2L,3805L,4L,1L,1L,1L,36L,3L,1L,125L,5L,85L,4L,3L,1L,1L,41L,11L,53L,1L,12L,14L,732L,2L,569L,5L,1L,1L,1L,389L,13L,851525L,1L,2L,2L,73L,3L,13L,5L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263007Inst : IEnumerable<long>
{
public static readonly long[] Value=A263007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263007.Bytes);
public long this[int i]=>Value[i];

public static A263007Inst Instance=new A263007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263008
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,13L,1L,1L,5L,7L,1L,1L,3L,59L,1L,1L,7L,23L,1L,221L,7L,1L,1L,1L,9L,3L,7L,11L,1L,1L,47L,5L,31L,15L,1L,1L,11L,193L,3L,103L,3L,1L,8807L,1L,3383L,3L,21L,3L,8005L,1L,1L,13L,17L,3L,2047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263008Inst : IEnumerable<long>
{
public static readonly long[] Value=A263008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263008.Bytes);
public long this[int i]=>Value[i];

public static A263008Inst Instance=new A263008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263009
{
public static readonly long[] Value={ 1L,3L,1L,1L,1L,3L,5L,1L,1L,39L,3L,1L,1L,9L,7L,1L,1L,3L,1L,27L,59L,3L,9L,1L,1L,1L,3L,15L,5L,1L,477L,1L,3L,7L,11L,1L,1L,2175L,17L,9L,7L,3L,747L,1L,41571L,1L,5L,19L,627L,13L,1L,1L,9L,5L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263009Inst : IEnumerable<long>
{
public static readonly long[] Value=A263009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263009.Bytes);
public long this[int i]=>Value[i];

public static A263009Inst Instance=new A263009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263010
{
public static readonly long[] Value={ 791L,799L,943L,1271L,1351L,1631L,1751L,1967L,2159L,2303L,2359L,2567L,3143L,3199L,3503L,3703L,3983L,4063L,4439L,4471L,4559L,4607L,4711L,5047L,5183L,5207L,5359L,5663L,5911L,5983L,6511L,6671L,6839L,7063L,7231L,7663L,7871L,8183L,8407L,8711L,9143L,9271L,9751L,9863L,10183L,10367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263010Inst : IEnumerable<long>
{
public static readonly long[] Value=A263010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263010.Bytes);
public long this[int i]=>Value[i];

public static A263010Inst Instance=new A263010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263011
{
public static readonly long[] Value={ 17L,41L,73L,89L,97L,113L,137L,161L,193L,217L,233L,241L,257L,281L,313L,329L,337L,353L,401L,409L,433L,449L,457L,497L,521L,553L,569L,577L,593L,601L,617L,641L,673L,697L,713L,721L,761L,769L,809L,833L,857L,881L,889L,929L,937L,953L,977L,1009L,1033L,1049L,1057L,1081L,1097L,1129L,1153L,1169L,1193L,1201L,1217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263011Inst : IEnumerable<long>
{
public static readonly long[] Value=A263011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263011.Bytes);
public long this[int i]=>Value[i];

public static A263011Inst Instance=new A263011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263012
{
public static readonly long[] Value={ 17L,41L,73L,89L,97L,113L,137L,161L,193L,217L,233L,241L,281L,313L,329L,337L,353L,409L,433L,449L,457L,497L,521L,553L,569L,593L,601L,617L,641L,673L,713L,721L,769L,809L,833L,857L,881L,889L,929L,937L,953L,977L,1033L,1049L,1057L,1081L,1097L,1153L,1169L,1193L,1201L,1217L,1241L,1249L,1289L,1321L,1337L,1361L,1409L,1433L,1457L,1481L,1513L,1553L,1561L,1609L,1633L,1649L,1657L,1673L,1697L,1721L,1753L,1777L,1801L,1817L,1841L,1873L,1889L,1913L,1921L,1993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263012Inst : IEnumerable<long>
{
public static readonly long[] Value=A263012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263012.Bytes);
public long this[int i]=>Value[i];

public static A263012Inst Instance=new A263012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263013
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263013Inst : IEnumerable<long>
{
public static readonly long[] Value=A263013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263013.Bytes);
public long this[int i]=>Value[i];

public static A263013Inst Instance=new A263013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263014
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,32L,0L,0L,0L,0L,0L,0L,0L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,24L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,48L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,64L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263014Inst : IEnumerable<long>
{
public static readonly long[] Value=A263014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263014.Bytes);
public long this[int i]=>Value[i];

public static A263014Inst Instance=new A263014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263015
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,11L,12L,14L,15L,21L,25L,29L,35L,55L,58L,59L,64L,71L,85L,89L,93L,94L,95L,100L,101L,102L,108L,112L,114L,116L,122L,124L,130L,131L,133L,135L,141L,146L,147L,151L,159L,162L,165L,170L,171L,172L,177L,178L,183L,190L,192L,193L,194L,204L,205L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263015Inst : IEnumerable<long>
{
public static readonly long[] Value=A263015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263015.Bytes);
public long this[int i]=>Value[i];

public static A263015Inst Instance=new A263015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263016
{
public static readonly long[] Value={ 20L,24L,40L,48L,60L,80L,96L,120L,140L,156L,160L,180L,192L,240L,260L,272L,280L,312L,320L,336L,340L,360L,384L,408L,420L,460L,468L,480L,520L,540L,544L,560L,580L,600L,624L,640L,672L,680L,696L,720L,740L,768L,780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263016Inst : IEnumerable<long>
{
public static readonly long[] Value=A263016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263016.Bytes);
public long this[int i]=>Value[i];

public static A263016Inst Instance=new A263016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263017
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,1L,4L,4L,5L,2L,6L,3L,4L,1L,5L,7L,8L,5L,9L,6L,7L,2L,10L,8L,9L,3L,10L,4L,5L,1L,6L,11L,12L,11L,13L,12L,13L,6L,14L,14L,15L,7L,16L,8L,9L,2L,15L,17L,18L,10L,19L,11L,12L,3L,20L,13L,14L,4L,15L,5L,6L,1L,7L,16L,17L,21L,18L,22L,23L,16L,19L,24L,25L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263017Inst : IEnumerable<long>
{
public static readonly long[] Value=A263017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263017.Bytes);
public long this[int i]=>Value[i];

public static A263017Inst Instance=new A263017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263018
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,11L,4L,15L,23L,47L,6L,95L,13L,27L,8L,31L,191L,383L,55L,767L,111L,223L,9L,1535L,447L,895L,14L,1791L,29L,59L,16L,63L,3071L,6143L,3583L,12287L,7167L,14335L,119L,24575L,28671L,57343L,239L,114687L,479L,959L,10L,49151L,229375L,458751L,1919L,917503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263018Inst : IEnumerable<long>
{
public static readonly long[] Value=A263018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263018.Bytes);
public long this[int i]=>Value[i];

public static A263018Inst Instance=new A263018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263019
{
public static readonly long[] Value={ 1L,10L,100L,1000L,10000L,100000L,1000000L,10000000L,100000000L,2L,11L,20L,101L,110L,200L,1001L,1010L,1100L,1000000000L,12L,21L,30L,102L,111L,120L,201L,210L,2000L,10000000000L,22L,31L,40L,103L,112L,121L,130L,300L,10001L,100000000000L,32L,41L,50L,104L,113L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263019Inst : IEnumerable<long>
{
public static readonly long[] Value=A263019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263019.Bytes);
public long this[int i]=>Value[i];

public static A263019Inst Instance=new A263019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263020
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,2L,2L,3L,3L,1L,5L,2L,2L,5L,2L,3L,4L,2L,6L,1L,5L,3L,3L,5L,2L,4L,5L,2L,4L,5L,1L,6L,5L,2L,6L,4L,3L,5L,4L,5L,3L,6L,4L,4L,4L,5L,4L,5L,4L,5L,6L,2L,3L,7L,5L,3L,6L,5L,2L,3L,8L,5L,3L,5L,5L,6L,5L,1L,8L,8L,2L,4L,6L,6L,3L,5L,8L,4L,4L,5L,3L,9L,2L,6L,8L,3L,3L,6L,4L,7L,3L,6L,6L,5L,5L,5L,3L,7L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263020Inst : IEnumerable<long>
{
public static readonly long[] Value=A263020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263020.Bytes);
public long this[int i]=>Value[i];

public static A263020Inst Instance=new A263020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263021
{
public static readonly long[] Value={ 1L,2L,4L,4L,6L,8L,9L,10L,8L,14L,14L,16L,16L,16L,20L,18L,22L,24L,21L,26L,28L,28L,28L,24L,36L,34L,36L,38L,32L,32L,40L,42L,44L,36L,46L,56L,43L,50L,40L,52L,54L,56L,54L,42L,60L,62L,64L,64L,56L,66L,56L,72L,70L,56L,74L,74L,76L,72L,64L,80L,81L,84L,84L,64L,76L,88L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263021Inst : IEnumerable<long>
{
public static readonly long[] Value=A263021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263021.Bytes);
public long this[int i]=>Value[i];

public static A263021Inst Instance=new A263021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263022
{
public static readonly long[] Value={ 1L,1L,4L,1L,3L,1L,8L,3L,5L,1L,12L,1L,7L,5L,16L,1L,9L,1L,20L,7L,11L,1L,24L,5L,13L,9L,28L,1L,15L,1L,32L,11L,17L,35L,36L,1L,19L,13L,40L,1L,21L,1L,44L,3L,23L,1L,48L,7L,25L,17L,52L,1L,27L,55L,56L,19L,29L,1L,60L,1L,31L,21L,64L,13L,33L,1L,68L,23L,35L,1L,72L,1L,37L,25L,76L,77L,39L,1L,80L,27L,41L,1L,84L,17L,43L,29L,88L,1L,45L,13L,92L,31L,47L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263022Inst : IEnumerable<long>
{
public static readonly long[] Value=A263022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263022.Bytes);
public long this[int i]=>Value[i];

public static A263022Inst Instance=new A263022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263023
{
public static readonly long[] Value={ 1L,2L,4L,4L,14L,9L,25L,15L,13L,50L,19L,35L,77L,42L,32L,37L,122L,43L,72L,153L,54L,88L,63L,52L,113L,235L,121L,252L,130L,40L,156L,108L,339L,71L,375L,128L,134L,210L,144L,151L,466L,96L,504L,256L,523L,90L,96L,304L,618L,313L,214L,657L,134L,233L,240L,247L,755L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263023Inst : IEnumerable<long>
{
public static readonly long[] Value=A263023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263023.Bytes);
public long this[int i]=>Value[i];

public static A263023Inst Instance=new A263023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263024
{
public static readonly long[] Value={ 19131L,1909131L,14222539L,17654359L,51783947L,59724191L,628025227L,745058551L,938403959L,1637154151L,1834714151L,2369329447L,3871912651L,19090909131L,24934617431L,26450868967L,28346927071L,29730856667L,47968127851L,48264490991L,51096197231L,55762015591L,83490323671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263024Inst : IEnumerable<long>
{
public static readonly long[] Value=A263024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263024.Bytes);
public long this[int i]=>Value[i];

public static A263024Inst Instance=new A263024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263025
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,3L,1L,1L,1L,1L,2L,3L,1L,1L,1L,3L,1L,2L,1L,4L,2L,1L,2L,3L,1L,1L,2L,1L,1L,2L,1L,1L,1L,3L,2L,5L,1L,1L,1L,2L,1L,4L,2L,2L,1L,1L,2L,3L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263025Inst : IEnumerable<long>
{
public static readonly long[] Value=A263025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263025.Bytes);
public long this[int i]=>Value[i];

public static A263025Inst Instance=new A263025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263026
{
public static readonly BigInteger[] Value={ 1L,28L,1810L,226558L,48859606L,16717044358L,8536211225830L,6206816010688678L,6191950081736354086L,BigInteger.Parse("8223501207813329312038"),BigInteger.Parse("14182148054223247947725350"),BigInteger.Parse("31102596462109513014876988198"),BigInteger.Parse("85207893723061275473574262742566"),BigInteger.Parse("287156553366174285430392015701185318"),BigInteger.Parse("1174632657911183483067648902342293048870") };
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
public class A263026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263026Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263026.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263026.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263026Inst Instance=new A263026Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263027
{
public static readonly long[] Value={ 2L,2L,3L,3L,5L,3L,7L,3L,7L,5L,11L,3L,13L,7L,5L,5L,17L,7L,19L,5L,7L,11L,23L,3L,21L,13L,19L,7L,29L,5L,31L,9L,11L,17L,13L,7L,37L,19L,13L,5L,41L,7L,43L,11L,13L,23L,47L,5L,43L,21L,17L,13L,53L,19L,21L,7L,19L,29L,59L,5L,61L,31L,7L,17L,13L,11L,67L,17L,23L,13L,71L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263027Inst : IEnumerable<long>
{
public static readonly long[] Value=A263027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263027.Bytes);
public long this[int i]=>Value[i];

public static A263027Inst Instance=new A263027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263028
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263028Inst : IEnumerable<long>
{
public static readonly long[] Value=A263028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263028.Bytes);
public long this[int i]=>Value[i];

public static A263028Inst Instance=new A263028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263029
{
public static readonly long[] Value={ 25L,32L,50L,55L,75L,81L,96L,100L,110L,115L,119L,121L,128L,150L,153L,160L,162L,165L,176L,187L,200L,203L,209L,215L,220L,221L,224L,230L,235L,238L,242L,245L,253L,256L,261L,275L,287L,288L,289L,295L,297L,299L,300L,306L,319L,323L,324L,330L,335L,343L,345L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263029Inst : IEnumerable<long>
{
public static readonly long[] Value=A263029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263029.Bytes);
public long this[int i]=>Value[i];

public static A263029Inst Instance=new A263029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263030
{
public static readonly long[] Value={ 1L,8L,8L,7L,0L,8L,1L,9L,1L,9L,7L,9L,5L,2L,8L,5L,3L,2L,3L,7L,6L,4L,1L,0L,0L,9L,8L,6L,4L,9L,2L,0L,7L,9L,7L,3L,5L,9L,2L,1L,1L,4L,4L,6L,7L,2L,6L,8L,4L,2L,9L,2L,2L,1L,5L,0L,9L,4L,1L,7L,4L,3L,3L,7L,8L,2L,3L,2L,3L,7L,2L,1L,3L,7L,1L,8L,0L,6L,7L,4L,7L,1L,3L,9L,4L,6L,9L,7L,4L,1L,6L,1L,8L,7L,0L,1L,6L,2L,5L,8L,3L,2L,8L,1L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263030Inst : IEnumerable<long>
{
public static readonly long[] Value=A263030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263030.Bytes);
public long this[int i]=>Value[i];

public static A263030Inst Instance=new A263030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263031
{
public static readonly long[] Value={ 0L,1L,4L,5L,3L,7L,4L,2L,9L,1L,8L,3L,2L,8L,4L,0L,3L,3L,6L,0L,5L,0L,2L,0L,2L,9L,4L,5L,0L,2L,2L,6L,2L,0L,9L,0L,3L,6L,0L,5L,4L,1L,4L,9L,7L,5L,9L,3L,4L,6L,4L,4L,4L,1L,3L,8L,1L,5L,2L,2L,4L,7L,4L,0L,5L,5L,3L,4L,6L,9L,2L,7L,4L,4L,9L,5L,5L,0L,0L,8L,3L,1L,2L,5L,9L,0L,7L,2L,3L,8L,9L,0L,1L,2L,7L,7L,0L,9L,8L,8L,3L,6L,0L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263031Inst : IEnumerable<long>
{
public static readonly long[] Value=A263031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263031.Bytes);
public long this[int i]=>Value[i];

public static A263031Inst Instance=new A263031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263032
{
public static readonly long[] Value={ 98L,6928L,2840827L,4513054617L,23445293636576L,487724113265492752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263032Inst : IEnumerable<long>
{
public static readonly long[] Value=A263032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263032.Bytes);
public long this[int i]=>Value[i];

public static A263032Inst Instance=new A263032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263033
{
public static readonly long[] Value={ 98L,512L,3711L,24013L,142344L,839216L,5128489L,31001921L,185695082L,1111399040L,6683005863L,40131775549L,240734834880L,1443900139952L,8665852404001L,52000488541745L,311993105964146L,1871866398248960L,11231623403277711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263033Inst : IEnumerable<long>
{
public static readonly long[] Value=A263033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263033.Bytes);
public long this[int i]=>Value[i];

public static A263033Inst Instance=new A263033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263034
{
public static readonly long[] Value={ 512L,6928L,92472L,1198816L,14394128L,174159952L,2100720600L,25327918144L,303937235408L,3649959544336L,43807632440376L,525844497250336L,6310134549806480L,75726848781701584L,908720872928731032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263034Inst : IEnumerable<long>
{
public static readonly long[] Value=A263034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263034.Bytes);
public long this[int i]=>Value[i];

public static A263034Inst Instance=new A263034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263035
{
public static readonly BigInteger[] Value={ 3711L,92472L,2840827L,78521045L,1961083623L,49018256112L,1240713997903L,31213035514119L,780283360537095L,19506558164219160L,488050046254026595L,12206116159468778285UL,BigInteger.Parse("305151910178113506975"),BigInteger.Parse("7628779062764913949200") };
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
public class A263035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263035Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263035.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263035.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263035Inst Instance=new A263035Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263036
{
public static readonly BigInteger[] Value={ 24013L,1198816L,78521045L,4513054617L,229943416429L,11717714846408L,606552926150035L,31163234729146717L,1589244015988712269L,BigInteger.Parse("81047324503720747840"),BigInteger.Parse("4137267115190677686845"),BigInteger.Parse("211098297749906566609761") };
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
public class A263036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263036Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263036.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263036.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263036Inst Instance=new A263036Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263037
{
public static readonly BigInteger[] Value={ 142344L,14394128L,1961083623L,229943416429L,23445293636576L,2390537108662112L,248073875762917543L,BigInteger.Parse("25521562144224919147"),BigInteger.Parse("2603135875758705134760"),BigInteger.Parse("265513148026613622508592"),BigInteger.Parse("27111512145791650824811167") };
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
public class A263037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263037.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263037Inst Instance=new A263037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263038
{
public static readonly BigInteger[] Value={ 839216L,174159952L,49018256112L,11717714846408L,2390537108662112L,487724113265492752L,BigInteger.Parse("101460868472471077008"),BigInteger.Parse("20901286904037554662376"),BigInteger.Parse("4263862443275254696179104"),BigInteger.Parse("869828576175660687522350416") };
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
public class A263038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263038Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263038.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263038.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263038Inst Instance=new A263038Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263039
{
public static readonly BigInteger[] Value={ 5128489L,2100720600L,1240713997903L,606552926150035L,248073875762917543L,BigInteger.Parse("101460868472471077008") };
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
public class A263039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263039Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263039.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263039.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263039Inst Instance=new A263039Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263040
{
public static readonly long[] Value={ 98L,512L,512L,3711L,6928L,3711L,24013L,92472L,92472L,24013L,142344L,1198816L,2840827L,1198816L,142344L,839216L,14394128L,78521045L,78521045L,14394128L,839216L,5128489L,174159952L,1961083623L,4513054617L,1961083623L,174159952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263040Inst : IEnumerable<long>
{
public static readonly long[] Value=A263040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263040.Bytes);
public long this[int i]=>Value[i];

public static A263040Inst Instance=new A263040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263041
{
public static readonly long[] Value={ 1L,-3L,4L,-5L,8L,-14L,20L,-25L,37L,-54L,71L,-91L,121L,-164L,210L,-264L,343L,-443L,554L,-687L,863L,-1087L,1340L,-1637L,2021L,-2489L,3027L,-3659L,4442L,-5391L,6480L,-7755L,9306L,-11153L,13278L,-15752L,18711L,-22203L,26214L,-30860L,36354L,-42777L,50137L,-58628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263041Inst : IEnumerable<long>
{
public static readonly long[] Value=A263041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263041.Bytes);
public long this[int i]=>Value[i];

public static A263041Inst Instance=new A263041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263042
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,12L,14L,16L,18L,20L,22L,24L,26L,28L,30L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263042Inst : IEnumerable<long>
{
public static readonly long[] Value=A263042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263042.Bytes);
public long this[int i]=>Value[i];

public static A263042Inst Instance=new A263042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263043
{
public static readonly BigInteger[] Value={ 1L,2L,3L,4L,5L,7L,41L,587L,16231L,3323246L,13654552343L,9086706651503151L,BigInteger.Parse("17725851219520961162682469"),BigInteger.Parse("3928527920941441960398255684700870518131"),BigInteger.Parse("118631177920294161985904111240557003105520588984802122222460259") };
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
public class A263043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263043.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263043Inst Instance=new A263043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263044
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,10L,55L,826L,54340L,47921995L,2643710343286L,BigInteger.Parse("126835535679488180710"),BigInteger.Parse("335322495784116748418182251685105"),BigInteger.Parse("42530809264656915340847577048392358554130713446770436") };
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
public class A263044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263044Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263044.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263044.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263044Inst Instance=new A263044Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263045
{
public static readonly BigInteger[] Value={ 1L,1L,2L,1L,2L,4L,2L,10L,38L,58L,902L,35578L,2080262L,1906407418L,67898268271622L,BigInteger.Parse("141250085279900836858"),BigInteger.Parse("269280339671247778784817867782"),BigInteger.Parse("18283668752862244903904463537467802693858298"),BigInteger.Parse("2582569770571288306580588933602503511656010789600193877369998342") };
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
public class A263045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263045Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263045.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263045.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263045Inst Instance=new A263045Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263046
{
public static readonly long[] Value={ 4L,3L,3L,5L,6L,3L,3L,5L,3L,15L,12L,6L,3L,5L,4L,5L,12L,6L,3L,11L,7L,11L,25L,20L,10L,5L,7L,15L,12L,6L,3L,35L,18L,9L,12L,6L,3L,15L,10L,5L,6L,3L,9L,9L,15L,35L,19L,27L,15L,14L,7L,14L,7L,20L,10L,5L,27L,29L,54L,27L,31L,36L,18L,9L,12L,6L,3L,9L,31L,23L,39L,39L,40L,20L,10L,5L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263046Inst : IEnumerable<long>
{
public static readonly long[] Value=A263046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263046.Bytes);
public long this[int i]=>Value[i];

public static A263046Inst Instance=new A263046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263047
{
public static readonly BigInteger[] Value={ 0L,1L,2L,-1L,-3L,-5L,8L,-19L,87L,715L,-13672L,-1190179L,-850964313L,11634385277515L,BigInteger.Parse("-13847001034356560872"),BigInteger.Parse("11783303722311508585098883421"),BigInteger.Parse("137091495347348713307137824784782074139687"),BigInteger.Parse("-1898306077876225285447341619480271058010077969630158545410485") };
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
public class A263047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263047Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263047.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263047.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263047Inst Instance=new A263047Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263048
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,17L,129145076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263048Inst : IEnumerable<long>
{
public static readonly long[] Value=A263048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263048.Bytes);
public long this[int i]=>Value[i];

public static A263048Inst Instance=new A263048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263049
{
public static readonly long[] Value={ 3L,7L,31L,1979L,41203L,752251L,5647457L,32465047L,245333233L,245333213L,27797667517L,196559847120517L,3040284075731561L,253253149671986983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263049Inst : IEnumerable<long>
{
public static readonly long[] Value=A263049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263049.Bytes);
public long this[int i]=>Value[i];

public static A263049Inst Instance=new A263049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263050
{
public static readonly long[] Value={ 1L,-1L,-1L,2L,-1L,-2L,4L,-2L,-4L,8L,-4L,-7L,14L,-6L,-13L,24L,-10L,-21L,40L,-17L,-35L,63L,-26L,-55L,98L,-40L,-84L,150L,-61L,-127L,224L,-90L,-189L,330L,-131L,-275L,480L,-190L,-397L,687L,-270L,-565L,974L,-381L,-795L,1367L,-533L,-1109L,1898L,-737L,-1533L,2614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263050Inst : IEnumerable<long>
{
public static readonly long[] Value=A263050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263050.Bytes);
public long this[int i]=>Value[i];

public static A263050Inst Instance=new A263050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263051
{
public static readonly long[] Value={ 1L,-1L,0L,1L,-3L,1L,3L,-5L,2L,6L,-10L,4L,10L,-18L,7L,17L,-30L,12L,28L,-49L,19L,44L,-78L,31L,69L,-120L,47L,105L,-182L,71L,156L,-271L,106L,229L,-396L,154L,333L,-572L,222L,475L,-817L,317L,673L,-1151L,445L,943L,-1608L,620L,1307L,-2226L,857L,1798L,-3053L,1173L,2455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263051Inst : IEnumerable<long>
{
public static readonly long[] Value=A263051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263051.Bytes);
public long this[int i]=>Value[i];

public static A263051Inst Instance=new A263051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263052
{
public static readonly BigInteger[] Value={ 2L,33L,1666L,498597L,439260642L,1825928130193L,26380510465997186L,BigInteger.Parse("1607516667474074649381"),BigInteger.Parse("373842629115554331580791202"),BigInteger.Parse("353418497958270475251697468005873") };
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
public class A263052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263052Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263052.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263052.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263052Inst Instance=new A263052Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263053
{
public static readonly long[] Value={ 2L,2L,10L,10L,42L,42L,170L,170L,682L,682L,2730L,2730L,10922L,10922L,43690L,43690L,174762L,174762L,699050L,699050L,2796202L,2796202L,11184810L,11184810L,44739242L,44739242L,178956970L,178956970L,715827882L,715827882L,2863311530L,2863311530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263053Inst : IEnumerable<long>
{
public static readonly long[] Value=A263053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263053.Bytes);
public long this[int i]=>Value[i];

public static A263053Inst Instance=new A263053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263054
{
public static readonly long[] Value={ 2L,33L,142L,895L,4314L,22921L,113486L,577071L,2877562L,14455993L,72225582L,361607935L,1807659674L,9041669481L,45205690126L,226052092111L,1130241870522L,5651375017753L,28256745002222L,141284885366175L,706423516399834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263054Inst : IEnumerable<long>
{
public static readonly long[] Value=A263054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263054.Bytes);
public long this[int i]=>Value[i];

public static A263054Inst Instance=new A263054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263055
{
public static readonly long[] Value={ 10L,142L,1666L,18390L,188370L,1941702L,19499266L,196698070L,1968558130L,19732383462L,197355588066L,1974792933750L,19748600169490L,197518001324422L,1975194815632066L,19752765325169430L,197527991815422450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263055Inst : IEnumerable<long>
{
public static readonly long[] Value=A263055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263055.Bytes);
public long this[int i]=>Value[i];

public static A263055Inst Instance=new A263055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263056
{
public static readonly BigInteger[] Value={ 10L,895L,18390L,498597L,10416690L,232738767L,4880746710L,104100946101L,2185333961490L,46071984907935L,967423105276470L,20335923462641157L,427044510774483570L,8970161111918918127L,BigInteger.Parse("188372284635598141590") };
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
public class A263056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263056Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263056.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263056.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263056Inst Instance=new A263056Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263057
{
public static readonly BigInteger[] Value={ 42L,4314L,188370L,10416690L,439260642L,19763462754L,830550961170L,35491321238130L,1490799705490242L,62885673930539394L,2641262874276464370L,BigInteger.Parse("111053568381384471570"),BigInteger.Parse("4664277162998698135842"),BigInteger.Parse("195952869163413914931234") };
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
public class A263057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263057Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263057.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263057.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263057Inst Instance=new A263057Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263058
{
public static readonly BigInteger[] Value={ 42L,22921L,1941702L,232738767L,19763462754L,1825928130193L,155157177242886L,13464303796343791L,1144373527121975682L,BigInteger.Parse("97776065732064546321"),BigInteger.Parse("8310794250378741921702"),BigInteger.Parse("707331447947977777389487") };
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
public class A263058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263058Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263058.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263058.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263058Inst Instance=new A263058Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263059
{
public static readonly BigInteger[] Value={ 170L,113486L,19499266L,4880746710L,830550961170L,155157177242886L,26380510465997186L,4591006241105432150L,BigInteger.Parse("780492175300947773170"),BigInteger.Parse("133462112418824638334886"),BigInteger.Parse("22688696181791779887035106") };
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
public class A263059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263059.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263059Inst Instance=new A263059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263060
{
public static readonly long[] Value={ 2L,2L,2L,10L,33L,10L,10L,142L,142L,10L,42L,895L,1666L,895L,42L,42L,4314L,18390L,18390L,4314L,42L,170L,22921L,188370L,498597L,188370L,22921L,170L,170L,113486L,1941702L,10416690L,10416690L,1941702L,113486L,170L,682L,577071L,19499266L,232738767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263060Inst : IEnumerable<long>
{
public static readonly long[] Value=A263060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263060.Bytes);
public long this[int i]=>Value[i];

public static A263060Inst Instance=new A263060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263061
{
public static readonly BigInteger[] Value={ 1L,1L,1683L,32193253L,3147728203035L,1050740615666453461L,BigInteger.Parse("939073157252309315848923"),BigInteger.Parse("1909946024633189859690880523893"),BigInteger.Parse("7868854300758955660834916406038038395"),BigInteger.Parse("60169662022264019813634467045726478557798101"),BigInteger.Parse("797656368265147949572521540584234236944835806750363") };
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
public class A263061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263061Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263061.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263061.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263061Inst Instance=new A263061Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263062
{
public static readonly BigInteger[] Value={ 1L,1L,8989L,1538743249L,1887593866439485L,BigInteger.Parse("10169807398958450670001"),BigInteger.Parse("179349571255187154941191217629"),BigInteger.Parse("8508048612432263410111274212273801489"),BigInteger.Parse("943457762940832669626002608045124343895474045"),BigInteger.Parse("220079308019032269943223432841210561656944209845808241") };
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
public class A263062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263062Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263062.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263062.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263062Inst Instance=new A263062Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263063
{
public static readonly BigInteger[] Value={ 1L,1L,265729L,3776339263873L,BigInteger.Parse("756051015055329306625"),BigInteger.Parse("1100327453912286201909924526081"),BigInteger.Parse("7835213566547395052871069325808866414849"),BigInteger.Parse("209691630817770382144439647416526247292909726379393"),BigInteger.Parse("17469051230066445323872793284679234619523576313653708533767425") };
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
public class A263063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263063.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263063Inst Instance=new A263063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263064
{
public static readonly BigInteger[] Value={ 1L,75L,23917L,10681263L,5552351121L,3147728203035L,1887593866439485L,1177359342144641535L,BigInteger.Parse("756051015055329306625"),BigInteger.Parse("496505991344667030490635"),BigInteger.Parse("331910222316215755702672557"),BigInteger.Parse("225110028217225196478861017775"),BigInteger.Parse("154515942591851050758389232988689") };
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
public class A263064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263064Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263064.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263064.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263064Inst Instance=new A263064Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263065
{
public static readonly BigInteger[] Value={ 1L,541L,2244361L,14638956721L,117029959485121L,1050740615666453461L,BigInteger.Parse("10169807398958450670001"),BigInteger.Parse("103746115308050354021387521"),BigInteger.Parse("1100327453912286201909924526081"),BigInteger.Parse("12024609569670508078686022988554381"),BigInteger.Parse("134565509066155510620216211257550349401") };
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
public class A263065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263065.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263065Inst Instance=new A263065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263066
{
public static readonly BigInteger[] Value={ 1L,4683L,308682013L,35941784497263L,5402040231378569121L,BigInteger.Parse("939073157252309315848923"),BigInteger.Parse("179349571255187154941191217629"),BigInteger.Parse("36585008462723983824862891403150079"),BigInteger.Parse("7835213566547395052871069325808866414849"),BigInteger.Parse("1742079663955078309800553960117733249663480043") };
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
public class A263066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263066Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263066.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263066.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263066Inst Instance=new A263066Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263067
{
public static readonly BigInteger[] Value={ 1L,47293L,58514835289L,143743469278461361L,BigInteger.Parse("480086443888959812703121"),BigInteger.Parse("1909946024633189859690880523893"),BigInteger.Parse("8508048612432263410111274212273801489"),BigInteger.Parse("41020870889694863957061607086939138327565057"),BigInteger.Parse("209691630817770382144439647416526247292909726379393") };
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
public class A263067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263067.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263067Inst Instance=new A263067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263068
{
public static readonly BigInteger[] Value={ 1L,545835L,14623910308237L,BigInteger.Parse("874531783382503604463"),BigInteger.Parse("74896283763383392805211587121"),BigInteger.Parse("7868854300758955660834916406038038395"),BigInteger.Parse("943457762940832669626002608045124343895474045"),BigInteger.Parse("124069835911824710311393852646151897334844371419287295") };
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
public class A263068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263068Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263068.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263068.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263068Inst Instance=new A263068Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263069
{
public static readonly BigInteger[] Value={ 1L,7087261L,4659168491711401L,BigInteger.Parse("7687300579969605991710001"),BigInteger.Parse("19133358944433370977791260580721121"),BigInteger.Parse("60169662022264019813634467045726478557798101"),BigInteger.Parse("220079308019032269943223432841210561656944209845808241"),BigInteger.Parse("894709632166224106718347951886305028154659386016685862593012481") };
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
public class A263069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263069Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263069.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263069.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263069Inst Instance=new A263069Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263070
{
public static readonly BigInteger[] Value={ 1L,102247563L,1843200116875263613L,BigInteger.Parse("93777824804632275267836362863"),BigInteger.Parse("7581761490297442738124283591348762605121"),BigInteger.Parse("797656368265147949572521540584234236944835806750363"),BigInteger.Parse("99479717242433942914309980793245660313479486272546475327799069") };
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
public class A263070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263070.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263070Inst Instance=new A263070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263071
{
public static readonly BigInteger[] Value={ 1L,1L,1462563L,191731486403293L,BigInteger.Parse("496505991344667030490635"),BigInteger.Parse("12024609569670508078686022988554381"),BigInteger.Parse("1742079663955078309800553960117733249663480043"),BigInteger.Parse("1121241285685659360225420876424590015281785102622410968973") };
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
public class A263071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263071.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263071Inst Instance=new A263071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263072
{
public static readonly BigInteger[] Value={ 1L,1L,8097453L,9850349744182729L,BigInteger.Parse("331910222316215755702672557"),BigInteger.Parse("134565509066155510620216211257550349401"),BigInteger.Parse("399017534874989738901076297624977315332337599285373"),BigInteger.Parse("6213239693876579408708842528154872834110410698303331900339282569") };
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
public class A263072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263072.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263072Inst Instance=new A263072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263073
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,3L,2L,4L,4L,4L,5L,6L,6L,8L,9L,9L,12L,12L,13L,16L,18L,18L,22L,24L,25L,29L,32L,34L,40L,43L,45L,52L,56L,60L,68L,74L,78L,88L,95L,101L,113L,122L,130L,145L,156L,166L,184L,198L,209L,231L,249L,264L,290L,311L,331L,361L,388L,412L,448L,480L,510L,554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263073Inst : IEnumerable<long>
{
public static readonly long[] Value=A263073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263073.Bytes);
public long this[int i]=>Value[i];

public static A263073Inst Instance=new A263073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263074
{
public static readonly long[] Value={ 1L,-2L,0L,1L,0L,1L,-1L,0L,1L,0L,-1L,-1L,0L,1L,0L,1L,-3L,0L,2L,0L,1L,-1L,0L,2L,0L,0L,-3L,0L,1L,0L,2L,-4L,0L,2L,0L,1L,-3L,0L,3L,0L,1L,-4L,0L,2L,0L,3L,-6L,0L,4L,0L,4L,-6L,0L,4L,0L,1L,-7L,0L,4L,0L,3L,-9L,0L,5L,0L,4L,-8L,0L,6L,0L,3L,-10L,0L,6L,0L,6L,-13L,0L,8L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263074Inst : IEnumerable<long>
{
public static readonly long[] Value=A263074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263074.Bytes);
public long this[int i]=>Value[i];

public static A263074Inst Instance=new A263074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263075
{
public static readonly BigInteger[] Value={ 1L,1L,2L,31L,1150L,68713L,5914776L,692005074L,105932315154L,20617891510063L,4984425649932314L,1467604324373250545L,BigInteger.Parse("517561005098562714944"),BigInteger.Parse("215501019188749426210440"),BigInteger.Parse("104642607303457024105207408"),BigInteger.Parse("58625315029802441203026824094"),BigInteger.Parse("37541542090285460025870424920666") };
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
public class A263075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263075Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263075.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A263075.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263075Inst Instance=new A263075Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263076
{
public static readonly long[] Value={ 2L,1810L,2458L,240926L,317602L,757730L,771610L,23993994L,58292586L,172616042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263076Inst : IEnumerable<long>
{
public static readonly long[] Value=A263076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263076.Bytes);
public long this[int i]=>Value[i];

public static A263076Inst Instance=new A263076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263077
{
public static readonly long[] Value={ 0L,0L,2L,2L,6L,2L,12L,6L,6L,6L,12L,6L,18L,12L,18L,18L,22L,12L,30L,18L,30L,18L,34L,22L,22L,22L,42L,22L,48L,22L,60L,30L,60L,30L,72L,48L,84L,34L,84L,34L,96L,34L,108L,42L,96L,42L,108L,42L,48L,48L,120L,48L,132L,48L,132L,48L,140L,60L,140L,48L,140L,72L,140L,140L,140L,72L,140L,84L,140L,84L,140L,60L,140L,96L,140L,96L,150L,96L,156L,96L,108L,108L,120L,72L,120L,120L,132L,108L,140L,108L,140L,132L,140L,120L,140L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263077Inst : IEnumerable<long>
{
public static readonly long[] Value=A263077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263077.Bytes);
public long this[int i]=>Value[i];

public static A263077Inst Instance=new A263077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263078
{
public static readonly long[] Value={ -1L,-2L,-1L,-2L,1L,-4L,5L,-2L,-3L,-4L,1L,-6L,5L,-2L,3L,2L,5L,-6L,11L,-2L,9L,-4L,11L,-2L,-3L,-4L,15L,-6L,19L,-8L,29L,-2L,27L,-4L,37L,12L,47L,-4L,45L,-6L,55L,-8L,65L,-2L,51L,-4L,61L,-6L,-1L,-2L,69L,-4L,79L,-6L,77L,-8L,83L,2L,81L,-12L,79L,10L,77L,76L,75L,6L,73L,16L,71L,14L,69L,-12L,67L,22L,65L,20L,73L,18L,77L,16L,27L,26L,37L,-12L,35L,34L,45L,20L,51L,18L,49L,40L,47L,26L,45L,-12L,43L,42L,41L,40L,39L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263078Inst : IEnumerable<long>
{
public static readonly long[] Value=A263078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263078.Bytes);
public long this[int i]=>Value[i];

public static A263078Inst Instance=new A263078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263079
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,10L,12L,14L,18L,20L,22L,24L,25L,26L,28L,30L,32L,34L,38L,40L,42L,44L,46L,48L,49L,50L,52L,54L,56L,60L,72L,84L,96L,104L,108L,120L,128L,132L,136L,140L,142L,144L,150L,152L,156L,160L,162L,168L,170L,180L,182L,184L,186L,188L,190L,192L,194L,198L,200L,204L,208L,210L,216L,220L,225L,228L,240L,248L,252L,260L,264L,276L,280L,288L,296L,300L,308L,312L,320L,328L,340L,352L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263079Inst : IEnumerable<long>
{
public static readonly long[] Value=A263079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263079.Bytes);
public long this[int i]=>Value[i];

public static A263079Inst Instance=new A263079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263080
{
public static readonly long[] Value={ 5L,7L,11L,13L,15L,16L,17L,19L,21L,23L,27L,29L,31L,33L,35L,36L,37L,39L,41L,43L,45L,47L,51L,53L,55L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,97L,98L,99L,100L,101L,102L,103L,105L,106L,107L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263080Inst : IEnumerable<long>
{
public static readonly long[] Value=A263080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263080.Bytes);
public long this[int i]=>Value[i];

public static A263080Inst Instance=new A263080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263081
{
public static readonly long[] Value={ 124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,24684000L,24684000L,24684000L,24684000L,24684000L,24684000L,24684000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263081Inst : IEnumerable<long>
{
public static readonly long[] Value=A263081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263081.Bytes);
public long this[int i]=>Value[i];

public static A263081Inst Instance=new A263081Inst();

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