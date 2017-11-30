using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A260182
{
public static readonly BigInteger[] Value={ 4L,64L,225L,5329L,38025L,314721L,3111696L,61058596L,1026753849L,31529329225L,892067027049L,307197306432025L,803752551280900L,29501156485626049L,1163446635475467225L,BigInteger.Parse("830482914641378019961"),BigInteger.Parse("2200667320658951859841"),BigInteger.Parse("104753558229986901966129"),BigInteger.Parse("5272187100814113874556176") };
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
public class A260182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260182Inst Instance=new A260182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260183
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,8L,10L,14L,18L,23L,30L,38L,47L,60L,74L,91L,114L,139L,169L,207L,250L,301L,364L,436L,520L,622L,739L,875L,1038L,1224L,1439L,1694L,1985L,2321L,2714L,3162L,3677L,4275L,4956L,5735L,6634L,7655L,8819L,10155L,11669L,13389L,15354L,17575L,20091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260183Inst : IEnumerable<long>
{
public static readonly long[] Value=A260183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260183.Bytes);
public long this[int i]=>Value[i];

public static A260183Inst Instance=new A260183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260184
{
public static readonly long[] Value={ 9L,10L,21L,40L,55L,80L,85L,100L,130L,154L,164L,178L,191L,203L,235L,242L,255L,257L,273L,282L,292L,300L,328L,400L,455L,585L,656L,819L,910L,2709L,6643L,8200L,14762L,32152L,53235L,74647L,428585L,532900L,1181729L,1405397L,4210945L,5259525L,27711772L,719848917L,43253138565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260184Inst : IEnumerable<long>
{
public static readonly long[] Value=A260184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260184.Bytes);
public long this[int i]=>Value[i];

public static A260184Inst Instance=new A260184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260185
{
public static readonly long[] Value={ 1L,3L,9L,21L,63L,111L,333L,693L,1521L,2577L,7731L,13491L,40473L,67833L,119241L,239481L,718443L,1340523L,4021569L,7494849L,13356657L,22271409L,66814227L,130266387L,268286823L,447212583L,896472063L,1684872063L,5054616189L,9566769789L,28700309367L,57402497367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260185Inst : IEnumerable<long>
{
public static readonly long[] Value=A260185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260185.Bytes);
public long this[int i]=>Value[i];

public static A260185Inst Instance=new A260185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260186
{
public static readonly long[] Value={ 1L,-4L,12L,-32L,80L,-184L,400L,-832L,1664L,-3220L,6056L,-11104L,19904L,-34968L,60320L,-102336L,171008L,-281800L,458428L,-736928L,1171552L,-1843328L,2872368L,-4435392L,6790656L,-10313180L,15544136L,-23259968L,34568576L,-51042392L,74901984L,-109268224L,158507008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260186Inst : IEnumerable<long>
{
public static readonly long[] Value=A260186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260186.Bytes);
public long this[int i]=>Value[i];

public static A260186Inst Instance=new A260186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260187
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260187Inst : IEnumerable<long>
{
public static readonly long[] Value=A260187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260187.Bytes);
public long this[int i]=>Value[i];

public static A260187Inst Instance=new A260187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260188
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260188Inst : IEnumerable<long>
{
public static readonly long[] Value=A260188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260188.Bytes);
public long this[int i]=>Value[i];

public static A260188Inst Instance=new A260188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260189
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,4L,8L,0L,0L,15L,22L,0L,0L,52L,51L,0L,0L,257L,342L,0L,0L,1589L,2609L,0L,0L,11417L,16896L,0L,0L,75375L,99114L,0L,0L,616010L,876579L,0L,0L,5253278L,8551800L,0L,0L,49667373L,79595269L,0L,0L,525731268L,764804085L,0L,0L,5932910966L,8905825760L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260189Inst : IEnumerable<long>
{
public static readonly long[] Value=A260189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260189.Bytes);
public long this[int i]=>Value[i];

public static A260189Inst Instance=new A260189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260190
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260190Inst : IEnumerable<long>
{
public static readonly long[] Value=A260190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260190.Bytes);
public long this[int i]=>Value[i];

public static A260190Inst Instance=new A260190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260191
{
public static readonly long[] Value={ 3L,5L,13L,17L,21L,29L,37L,45L,49L,53L,61L,65L,69L,77L,81L,85L,93L,101L,109L,113L,117L,125L,133L,141L,145L,149L,157L,165L,173L,177L,181L,189L,193L,197L,205L,209L,213L,221L,229L,237L,241L,245L,253L,257L,261L,269L,273L,277L,285L,293L,301L,305L,309L,317L,321L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260191Inst : IEnumerable<long>
{
public static readonly long[] Value=A260191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260191.Bytes);
public long this[int i]=>Value[i];

public static A260191Inst Instance=new A260191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260192
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260192Inst : IEnumerable<long>
{
public static readonly long[] Value=A260192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260192.Bytes);
public long this[int i]=>Value[i];

public static A260192Inst Instance=new A260192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260193
{
public static readonly long[] Value={ 198L,220L,221L,287L,352L,364L,484L,562L,627L,638L,672L,715L,716L,780L,793L,858L,901L,1095L,1233L,2328L,8905L,18183L,39753L,60248L,85207L,336734L,2727274L,5893504L,8620777L,17769557L,52818678L,70710735L,76470590L,82230444L,101318734L,101636206L,104263158L,105262158L,109891110L,109942690L,117883117L,119722383L,120826541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260193Inst : IEnumerable<long>
{
public static readonly long[] Value=A260193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260193.Bytes);
public long this[int i]=>Value[i];

public static A260193Inst Instance=new A260193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260194
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,9L,10L,12L,15L,20L,24L,27L,28L,32L,33L,34L,36L,39L,40L,44L,45L,50L,52L,53L,54L,56L,57L,60L,64L,65L,70L,72L,73L,74L,76L,77L,78L,80L,81L,84L,88L,89L,90L,92L,93L,96L,100L,101L,102L,104L,105L,108L,112L,119L,120L,128L,129L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260194Inst : IEnumerable<long>
{
public static readonly long[] Value=A260194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260194.Bytes);
public long this[int i]=>Value[i];

public static A260194Inst Instance=new A260194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260195
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,3L,3L,4L,3L,6L,4L,3L,5L,6L,4L,9L,5L,3L,7L,7L,5L,9L,6L,6L,8L,9L,5L,9L,8L,6L,10L,6L,5L,15L,8L,9L,10L,7L,7L,12L,10L,3L,11L,15L,7L,15L,8L,6L,13L,12L,9L,12L,9L,9L,14L,12L,7L,15L,12L,6L,15L,13L,6L,21L,12L,12L,13L,6L,11L,15L,15L,9L,14L,12L,8L,24L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260195Inst : IEnumerable<long>
{
public static readonly long[] Value=A260195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260195.Bytes);
public long this[int i]=>Value[i];

public static A260195Inst Instance=new A260195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260196
{
public static readonly long[] Value={ 1L,-3L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260196Inst : IEnumerable<long>
{
public static readonly long[] Value=A260196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260196.Bytes);
public long this[int i]=>Value[i];

public static A260196Inst Instance=new A260196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260197
{
public static readonly long[] Value={ 5L,277L,29L,17L,43L,103L,53L,31L,1571L,3089L,37L,593L,881L,3023L,277L,9257L,47L,1949L,9137L,311L,17011L,1039L,53L,59L,2153L,15331L,3617L,631L,44867L,61L,17351L,661L,821L,2339L,683L,1201L,34759L,62687L,20327L,59369L,71L,883L,40189L,9187L,1879L,7669L,2767L,3931L,8867L,8081L,79L,12401L,139L,4787L,6367L,277L,2903L,23671L,32839L,3659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260197Inst : IEnumerable<long>
{
public static readonly long[] Value=A260197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260197.Bytes);
public long this[int i]=>Value[i];

public static A260197Inst Instance=new A260197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260198
{
public static readonly long[] Value={ 49L,242L,1681L,2645L,4374L,18490L,23762L,39325L,48734L,57121L,158949L,182182L,410669L,453870L,601425L,656914L,843637L,912950L,1143449L,1228122L,1275125L,1608574L,1940449L,2328482L,2948406L,3041577L,3203050L,3721549L,4495985L,4705074L,5371029L,5606230L,6352825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260198Inst : IEnumerable<long>
{
public static readonly long[] Value=A260198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260198.Bytes);
public long this[int i]=>Value[i];

public static A260198Inst Instance=new A260198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260199
{
public static readonly BigInteger[] Value={ 26L,80L,685L,5998L,85168L,1819901L,52387329L,2215046304L,135612260310L,11765856260556L,1472760725659628L,265025410670672753L,BigInteger.Parse("68284272657868130731"),BigInteger.Parse("25283346051613072580257"),BigInteger.Parse("13443004796046817010848968") };
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
public class A260199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260199Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260199.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260199.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260199Inst Instance=new A260199Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260200
{
public static readonly long[] Value={ 26L,44L,106L,220L,478L,1044L,2274L,4940L,10758L,23412L,50946L,110876L,241302L,525140L,1142866L,2487228L,5412966L,11780276L,25637506L,55795100L,121427318L,264263252L,575118258L,1251634556L,2723942534L,5928138484L,12901456482L,28077545820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260200Inst : IEnumerable<long>
{
public static readonly long[] Value=A260200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260200.Bytes);
public long this[int i]=>Value[i];

public static A260200Inst Instance=new A260200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260201
{
public static readonly long[] Value={ 44L,80L,207L,479L,1163L,2864L,6895L,16690L,40598L,98367L,238383L,578373L,1402450L,3400311L,8246174L,19996576L,48488613L,117582381L,285129777L,691413726L,1676626449L,4065695950L,9858990214L,23907290449L,57973356043L,140580903753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260201Inst : IEnumerable<long>
{
public static readonly long[] Value=A260201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260201.Bytes);
public long this[int i]=>Value[i];

public static A260201Inst Instance=new A260201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260202
{
public static readonly long[] Value={ 106L,207L,685L,1857L,5291L,15715L,45181L,129853L,377479L,1091843L,3153331L,9128061L,26409885L,76369661L,220928809L,639119931L,1848648749L,5347522963L,15468867253L,44745801211L,129434159209L,374410717115L,1083042439267L,3132872536335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260202Inst : IEnumerable<long>
{
public static readonly long[] Value=A260202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260202.Bytes);
public long this[int i]=>Value[i];

public static A260202Inst Instance=new A260202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260203
{
public static readonly long[] Value={ 220L,479L,1857L,5998L,20408L,71846L,245486L,841296L,2905978L,9992478L,34348500L,118254574L,406871094L,1399624310L,4816056622L,16570641810L,57011471540L,196158495144L,674916008534L,2322129167778L,7989626498572L,27489503304114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260203Inst : IEnumerable<long>
{
public static readonly long[] Value=A260203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260203.Bytes);
public long this[int i]=>Value[i];

public static A260203Inst Instance=new A260203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260204
{
public static readonly long[] Value={ 478L,1163L,5291L,20408L,85168L,359112L,1473681L,6100163L,25364416L,104948864L,434706199L,1802333006L,7466572837L,30934888195L,128194824496L,531166886817L,2200852469405L,9119511470498L,37786992254965L,156570849928658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260204Inst : IEnumerable<long>
{
public static readonly long[] Value=A260204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260204.Bytes);
public long this[int i]=>Value[i];

public static A260204Inst Instance=new A260204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260205
{
public static readonly long[] Value={ 1044L,2864L,15715L,71846L,359112L,1819901L,8929505L,44267361L,220591626L,1093197469L,5423252998L,26935491998L,133662286873L,663325778447L,3292652533635L,16341908119400L,81107178453353L,402565198408300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260205Inst : IEnumerable<long>
{
public static readonly long[] Value=A260205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260205.Bytes);
public long this[int i]=>Value[i];

public static A260205Inst Instance=new A260205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260206
{
public static readonly long[] Value={ 2274L,6895L,45181L,245486L,1473681L,8929505L,52387329L,310875809L,1853180549L,10985801208L,65210933996L,387468307116L,2300272363175L,13657703384145L,81107425137672L,481596599130729L,2859640528315173L,16980696305470301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260206Inst : IEnumerable<long>
{
public static readonly long[] Value=A260206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260206.Bytes);
public long this[int i]=>Value[i];

public static A260206Inst Instance=new A260206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260207
{
public static readonly long[] Value={ 26L,44L,44L,106L,80L,106L,220L,207L,207L,220L,478L,479L,685L,479L,478L,1044L,1163L,1857L,1857L,1163L,1044L,2274L,2864L,5291L,5998L,5291L,2864L,2274L,4940L,6895L,15715L,20408L,20408L,15715L,6895L,4940L,10758L,16690L,45181L,71846L,85168L,71846L,45181L,16690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260207Inst : IEnumerable<long>
{
public static readonly long[] Value=A260207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260207.Bytes);
public long this[int i]=>Value[i];

public static A260207Inst Instance=new A260207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260208
{
public static readonly long[] Value={ 2L,3L,2L,107L,271L,3L,3L,523L,17L,191L,73L,2707L,587L,2017L,19L,233L,57193L,7583L,9791L,7L,2111L,1373L,43L,109L,1283L,463L,8179L,25583L,7489L,1733L,9011L,7753L,7853L,887L,10141L,71L,1373L,7927L,509L,1433L,4513L,2399L,4211L,26407L,307L,2843L,58579L,3121L,5519L,38371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260208Inst : IEnumerable<long>
{
public static readonly long[] Value=A260208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260208.Bytes);
public long this[int i]=>Value[i];

public static A260208Inst Instance=new A260208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260209
{
public static readonly long[] Value={ 1L,3L,25L,245L,121L,169L,867L,3249L,6877L,9251L,961L,15059L,57154L,61017L,68479L,106742L,201898L,208376L,107736L,176435L,330398L,237158L,158447L,213867L,903264L,856884L,21218L,755634L,1259386L,944906L,161290L,531991L,150152L,656914L,1287658L,592826L,640874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260209Inst : IEnumerable<long>
{
public static readonly long[] Value=A260209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260209.Bytes);
public long this[int i]=>Value[i];

public static A260209Inst Instance=new A260209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260210
{
public static readonly long[] Value={ 1L,5L,1L,1L,3L,9L,13L,11L,1L,11L,34L,33L,31L,38L,58L,56L,24L,35L,62L,38L,23L,27L,96L,84L,2L,66L,106L,74L,10L,31L,8L,34L,58L,26L,26L,144L,150L,140L,167L,137L,31L,107L,78L,157L,1L,103L,165L,97L,111L,60L,196L,48L,97L,259L,155L,175L,244L,13L,269L,34L,184L,222L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260210Inst : IEnumerable<long>
{
public static readonly long[] Value=A260210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260210.Bytes);
public long this[int i]=>Value[i];

public static A260210Inst Instance=new A260210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260211
{
public static readonly long[] Value={ 0L,1L,0L,3L,0L,2L,5L,7L,0L,6L,9L,15L,0L,4L,10L,14L,17L,21L,27L,31L,0L,12L,18L,30L,33L,45L,51L,63L,0L,8L,20L,28L,34L,42L,54L,62L,65L,73L,85L,93L,99L,107L,119L,127L,0L,24L,36L,60L,66L,90L,102L,126L,129L,153L,165L,189L,195L,219L,231L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260211Inst : IEnumerable<long>
{
public static readonly long[] Value=A260211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260211.Bytes);
public long this[int i]=>Value[i];

public static A260211Inst Instance=new A260211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260212
{
public static readonly long[] Value={ 48L,9800L,31211L,32798L,48373L,59534L,63000L,118579L,373827L,488187L,629693L,830464L,1294298L,3815174L,8388223L,9235520L,9516680L,9841094L,11121382L,12708359L,14325848L,15407171L,18966023L,19890624L,24737542L,28140000L,29320000L,29445038L,34032190L,38033406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260212Inst : IEnumerable<long>
{
public static readonly long[] Value=A260212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260212.Bytes);
public long this[int i]=>Value[i];

public static A260212Inst Instance=new A260212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260213
{
public static readonly long[] Value={ 114L,120L,147L,198L,264L,420L,500L,506L,513L,525L,533L,550L,558L,568L,581L,648L,1102L,1116L,1168L,1302L,1320L,1377L,1680L,1692L,1710L,1720L,1734L,1755L,1771L,1872L,2106L,2132L,2310L,2332L,2380L,2664L,2714L,2736L,2790L,2914L,2940L,3312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260213Inst : IEnumerable<long>
{
public static readonly long[] Value=A260213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260213.Bytes);
public long this[int i]=>Value[i];

public static A260213Inst Instance=new A260213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260214
{
public static readonly long[] Value={ 0L,10L,105L,1035L,10296L,102378L,1024596L,10348975L,102738945L,1062489753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260214Inst : IEnumerable<long>
{
public static readonly long[] Value=A260214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260214.Bytes);
public long this[int i]=>Value[i];

public static A260214Inst Instance=new A260214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260215
{
public static readonly long[] Value={ 1L,-2L,2L,-4L,6L,-8L,12L,-16L,22L,-28L,36L,-48L,60L,-76L,96L,-120L,150L,-184L,228L,-280L,340L,-416L,504L,-608L,732L,-878L,1052L,-1252L,1488L,-1768L,2088L,-2464L,2902L,-3408L,3996L,-4672L,5460L,-6364L,7400L,-8600L,9972L,-11544L,13344L,-15400L,17752L,-20424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260215Inst : IEnumerable<long>
{
public static readonly long[] Value=A260215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260215.Bytes);
public long this[int i]=>Value[i];

public static A260215Inst Instance=new A260215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260216
{
public static readonly BigInteger[] Value={ 1L,0L,1L,2L,9L,44L,265L,1854L,14833L,133496L,1334961L,14684570L,176214841L,2290792932L,32071101049L,481066515734L,7697064251745L,130850092279664L,2355301661033953L,44750731559645106L,895014631192902121L,BigInteger.Parse("18795307255050944540"),BigInteger.Parse("145060238642780180480"),BigInteger.Parse("1118480911876659396600") };
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
public class A260216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260216Inst Instance=new A260216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260217
{
public static readonly long[] Value={ 0L,0L,4L,24L,100L,360L,1204L,3864L,12100L,37320L,114004L,346104L,1046500L,3155880L,9500404L,28566744L,85831300L,257756040L,773792404L,2322425784L,6969374500L,20912317800L,62745342004L,188252803224L,564791964100L,1694443001160L,5083463221204L,15250658099064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260217Inst : IEnumerable<long>
{
public static readonly long[] Value=A260217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260217.Bytes);
public long this[int i]=>Value[i];

public static A260217Inst Instance=new A260217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260218
{
public static readonly long[] Value={ 2L,3L,2L,5L,2L,3L,2L,17L,2L,3L,2L,5L,2L,3L,2L,257L,2L,3L,2L,5L,2L,3L,2L,17L,2L,3L,2L,5L,2L,3L,2L,65537L,2L,3L,2L,5L,2L,3L,2L,17L,2L,3L,2L,5L,2L,3L,2L,97L,2L,3L,2L,5L,2L,3L,2L,17L,2L,3L,2L,5L,2L,3L,2L,641L,2L,3L,2L,5L,2L,3L,2L,17L,2L,3L,2L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260218Inst : IEnumerable<long>
{
public static readonly long[] Value=A260218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260218.Bytes);
public long this[int i]=>Value[i];

public static A260218Inst Instance=new A260218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260219
{
public static readonly long[] Value={ 3L,47L,229L,379L,11L,2687L,1181L,24547L,5L,509L,5L,16619L,877L,22543L,3L,9067L,60337L,10667L,997L,24061L,18329L,56099L,1787L,58757L,108883L,416881L,157141L,11003L,14939L,113167L,101957L,77969L,613L,27947L,52153L,158551L,6197L,36607L,25237L,27179L,330689L,203617L,77419L,708269L,87649L,340381L,267601L,67153L,123377L,21617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260219Inst : IEnumerable<long>
{
public static readonly long[] Value=A260219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260219.Bytes);
public long this[int i]=>Value[i];

public static A260219Inst Instance=new A260219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260220
{
public static readonly long[] Value={ 1L,1L,3L,2L,6L,4L,10L,6L,15L,9L,21L,12L,28L,16L,36L,20L,45L,25L,55L,30L,66L,36L,78L,42L,91L,49L,105L,56L,120L,64L,136L,72L,153L,81L,171L,90L,190L,100L,210L,110L,231L,121L,253L,132L,276L,144L,300L,156L,325L,169L,351L,182L,378L,196L,406L,210L,435L,225L,465L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260220Inst : IEnumerable<long>
{
public static readonly long[] Value=A260220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260220.Bytes);
public long this[int i]=>Value[i];

public static A260220Inst Instance=new A260220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260221
{
public static readonly long[] Value={ 1L,-1L,2L,1L,1L,1L,3L,1L,2L,2L,2L,4L,5L,3L,7L,8L,7L,7L,9L,10L,11L,12L,14L,17L,19L,18L,24L,26L,26L,31L,36L,38L,41L,45L,50L,57L,61L,63L,75L,83L,86L,93L,106L,115L,123L,134L,146L,162L,173L,183L,206L,225L,237L,257L,283L,304L,327L,350L,380L,416L,443L,471L,516L,557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260221Inst : IEnumerable<long>
{
public static readonly long[] Value=A260221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260221.Bytes);
public long this[int i]=>Value[i];

public static A260221Inst Instance=new A260221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260222
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,1L,3L,2L,11L,1L,1L,1L,1L,2L,1L,1L,19L,1L,3L,2L,1L,1L,1L,1L,1L,2L,29L,1L,31L,1L,3L,2L,1L,1L,1L,1L,1L,2L,41L,1L,1L,1L,3L,2L,1L,1L,7L,1L,1L,2L,1L,1L,1L,1L,3L,2L,59L,1L,61L,1L,1L,2L,1L,1L,1L,1L,3L,2L,71L,1L,1L,1L,1L,2L,1L,13L,79L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260222Inst : IEnumerable<long>
{
public static readonly long[] Value=A260222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260222.Bytes);
public long this[int i]=>Value[i];

public static A260222Inst Instance=new A260222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260223
{
public static readonly long[] Value={ 3L,5L,53L,353L,503L,3533L,5003L,5303L,5333L,5503L,30553L,33053L,33353L,33503L,33533L,35053L,35353L,35533L,50033L,50053L,50333L,50503L,53003L,53353L,53503L,55333L,303053L,303553L,305033L,305353L,305533L,330053L,333503L,333533L,335033L,350003L,350033L,350503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260223Inst : IEnumerable<long>
{
public static readonly long[] Value=A260223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260223.Bytes);
public long this[int i]=>Value[i];

public static A260223Inst Instance=new A260223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260224
{
public static readonly long[] Value={ 3L,5L,11L,13L,31L,53L,113L,131L,151L,311L,313L,331L,353L,1151L,1153L,1511L,1531L,1553L,3313L,3331L,3511L,3533L,5113L,5153L,5333L,5351L,5531L,11113L,11131L,11311L,11351L,11353L,11551L,13151L,13313L,13331L,13513L,13553L,15131L,15313L,15331L,15511L,15551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260224Inst : IEnumerable<long>
{
public static readonly long[] Value=A260224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260224.Bytes);
public long this[int i]=>Value[i];

public static A260224Inst Instance=new A260224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260225
{
public static readonly long[] Value={ 3L,5L,53L,353L,563L,653L,3533L,5333L,5563L,5653L,6353L,6553L,6563L,6653L,33353L,33533L,33563L,35353L,35363L,35533L,36353L,36563L,36653L,53353L,53633L,53653L,55333L,55633L,55663L,56333L,56533L,56633L,56663L,63353L,63533L,65353L,65563L,65633L,66533L,66553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260225Inst : IEnumerable<long>
{
public static readonly long[] Value=A260225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260225.Bytes);
public long this[int i]=>Value[i];

public static A260225Inst Instance=new A260225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260226
{
public static readonly long[] Value={ 3L,5L,53L,83L,353L,383L,853L,883L,3533L,3583L,3833L,3853L,5333L,8353L,33353L,33533L,35353L,35533L,38333L,38833L,53353L,55333L,83383L,83833L,85333L,85853L,88853L,88883L,333383L,333533L,335383L,335833L,338383L,353333L,353833L,355853L,383533L,383833L,533353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260226Inst : IEnumerable<long>
{
public static readonly long[] Value=A260226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260226.Bytes);
public long this[int i]=>Value[i];

public static A260226Inst Instance=new A260226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260227
{
public static readonly long[] Value={ 3L,5L,53L,59L,353L,359L,593L,599L,953L,3359L,3533L,3539L,3559L,3593L,5333L,5393L,5399L,5939L,5953L,9533L,9539L,33353L,33359L,33533L,33599L,35339L,35353L,35393L,35533L,35593L,35933L,35993L,35999L,39359L,39953L,53353L,53359L,53593L,53939L,53959L,53993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260227Inst : IEnumerable<long>
{
public static readonly long[] Value=A260227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260227.Bytes);
public long this[int i]=>Value[i];

public static A260227Inst Instance=new A260227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260228
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,1L,7L,2L,3L,2L,11L,1L,13L,2L,3L,2L,17L,1L,19L,2L,3L,2L,23L,1L,1L,2L,3L,2L,29L,1L,31L,2L,3L,2L,1L,1L,37L,2L,3L,2L,41L,1L,43L,2L,3L,2L,47L,1L,7L,2L,3L,2L,53L,1L,1L,2L,3L,2L,59L,1L,61L,2L,21L,2L,1L,1L,67L,2L,3L,2L,71L,1L,73L,2L,3L,2L,1L,13L,79L,2L,3L,2L,83L,1L,1L,2L,3L,2L,89L,1L,1L,2L,3L,2L,1L,1L,97L,2L,33L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260228Inst : IEnumerable<long>
{
public static readonly long[] Value=A260228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260228.Bytes);
public long this[int i]=>Value[i];

public static A260228Inst Instance=new A260228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260229
{
public static readonly BigInteger[] Value={ 2L,7L,403L,26489122129L,BigInteger.Parse("13041808783936322797338790280986488113446079415755132") };
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
public class A260229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260229Inst Instance=new A260229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260230
{
public static readonly long[] Value={ 6L,9L,6L,8L,8L,5L,5L,7L,0L,7L,3L,8L,2L,8L,5L,2L,0L,0L,4L,3L,1L,4L,1L,5L,2L,6L,0L,9L,1L,1L,1L,2L,7L,9L,5L,6L,0L,5L,1L,7L,3L,6L,6L,0L,0L,1L,5L,2L,5L,8L,1L,4L,5L,0L,3L,5L,9L,3L,2L,7L,4L,3L,4L,4L,2L,4L,6L,5L,1L,1L,3L,9L,8L,7L,3L,4L,5L,8L,5L,1L,2L,0L,0L,6L,1L,3L,8L,3L,0L,2L,6L,3L,9L,4L,5L,7L,5L,1L,6L,5L,4L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260230Inst : IEnumerable<long>
{
public static readonly long[] Value=A260230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260230.Bytes);
public long this[int i]=>Value[i];

public static A260230Inst Instance=new A260230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260231
{
public static readonly BigInteger[] Value={ 2L,10L,280L,71960L,224946960L,10495350312720L,8643382777938679680L,BigInteger.Parse("145011908479540041684850560"),BigInteger.Parse("56180584638978557924165229531974400"),BigInteger.Parse("561805846445966163880630853243909229531974400"),BigInteger.Parse("160289764609087349005207761687490741791453382934816332800") };
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
public class A260231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260231Inst Instance=new A260231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260232
{
public static readonly long[] Value={ 2L,5L,13L,67L,23L,19L,433L,443L,107L,41L,61L,251L,239L,1987L,541L,491L,1093L,499L,421L,179L,2137L,1297L,1097L,101L,103L,2411L,1283L,1847L,379L,4993L,8329L,5563L,4297L,5639L,9587L,1867L,5113L,6691L,3691L,1193L,4663L,2971L,27733L,7121L,593L,2273L,607L,6047L,4217L,2609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260232Inst : IEnumerable<long>
{
public static readonly long[] Value=A260232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260232.Bytes);
public long this[int i]=>Value[i];

public static A260232Inst Instance=new A260232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260233
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,19L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,31L,2L,3L,2L,3L,2L,37L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,11L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,79L,2L,3L,2L,3L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260233Inst : IEnumerable<long>
{
public static readonly long[] Value=A260233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260233.Bytes);
public long this[int i]=>Value[i];

public static A260233Inst Instance=new A260233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260234
{
public static readonly long[] Value={ 3L,5L,7L,5L,11L,13L,5L,17L,19L,11L,23L,13L,7L,29L,31L,17L,7L,37L,13L,41L,43L,23L,47L,7L,17L,53L,11L,29L,59L,61L,7L,13L,67L,23L,71L,73L,19L,13L,79L,41L,83L,43L,29L,89L,23L,47L,19L,97L,11L,101L,103L,53L,107L,109L,37L,113L,29L,59L,17L,61L,41L,7L,127L,43L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260234Inst : IEnumerable<long>
{
public static readonly long[] Value=A260234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260234.Bytes);
public long this[int i]=>Value[i];

public static A260234Inst Instance=new A260234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260235
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,4L,2L,4L,3L,3L,3L,3L,2L,4L,2L,4L,3L,4L,2L,3L,4L,3L,4L,3L,2L,4L,4L,3L,2L,4L,3L,4L,3L,4L,3L,4L,2L,4L,3L,3L,4L,3L,3L,4L,3L,4L,3L,5L,2L,4L,3L,2L,4L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,3L,4L,5L,2L,4L,3L,3L,4L,4L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260235Inst : IEnumerable<long>
{
public static readonly long[] Value=A260235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260235.Bytes);
public long this[int i]=>Value[i];

public static A260235Inst Instance=new A260235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260236
{
public static readonly long[] Value={ 2L,2L,3L,3L,3L,2L,5L,3L,3L,3L,4L,3L,5L,3L,5L,3L,5L,2L,5L,3L,3L,4L,5L,4L,4L,4L,5L,3L,4L,2L,8L,4L,3L,4L,5L,2L,5L,4L,5L,5L,4L,3L,5L,4L,4L,3L,7L,3L,6L,3L,4L,4L,5L,3L,6L,3L,4L,4L,6L,3L,4L,6L,7L,4L,4L,3L,7L,3L,4L,3L,7L,3L,5L,4L,4L,5L,5L,2L,7L,6L,3L,4L,5L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260236Inst : IEnumerable<long>
{
public static readonly long[] Value=A260236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260236.Bytes);
public long this[int i]=>Value[i];

public static A260236Inst Instance=new A260236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260237
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,-1L,1L,1L,11L,-1L,-1L,0L,-3L,-9L,5L,1L,0L,3L,81L,7L,-73L,-1L,0L,3L,73L,-1261L,-1183L,53L,1L,0L,-3L,-1231L,5251L,8989L,1451L,-731L,-1L,0L,0L,7L,397L,-12491L,-19877L,-15047L,1567L,1L,0L,0L,0L,-7L,-1483L,50111L,69761L,45959L,-5261L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260237Inst : IEnumerable<long>
{
public static readonly long[] Value=A260237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260237.Bytes);
public long this[int i]=>Value[i];

public static A260237Inst Instance=new A260237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260238
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,6L,6L,1L,1L,2L,4L,12L,1L,1L,2L,20L,3L,60L,1L,1L,2L,60L,360L,360L,60L,1L,1L,2L,420L,2520L,1260L,504L,420L,1L,1L,1L,4L,120L,5040L,2520L,5040L,840L,1L,1L,1L,1L,3L,360L,15120L,7560L,15120L,2520L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260238Inst : IEnumerable<long>
{
public static readonly long[] Value=A260238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260238.Bytes);
public long this[int i]=>Value[i];

public static A260238Inst Instance=new A260238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260239
{
public static readonly long[] Value={ 1L,3L,5L,11L,23L,45L,91L,183L,365L,731L,1461L,2923L,5847L,11693L,23387L,46775L,93549L,187099L,374197L,748395L,1496791L,2993581L,5987163L,11974327L,23948653L,47897307L,95794615L,191589229L,383178459L,766356917L,1532713835L,3065427671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260239Inst : IEnumerable<long>
{
public static readonly long[] Value=A260239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260239.Bytes);
public long this[int i]=>Value[i];

public static A260239Inst Instance=new A260239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260240
{
public static readonly long[] Value={ 48L,213L,1476L,5733L,38280L,416911L,1606456L,7479479L,103497076L,746247122L,2383760912L,25616797423L,351265905756L,1400540744283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260240Inst : IEnumerable<long>
{
public static readonly long[] Value=A260240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260240.Bytes);
public long this[int i]=>Value[i];

public static A260240Inst Instance=new A260240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260241
{
public static readonly long[] Value={ 48L,99L,256L,635L,1598L,4027L,10110L,25421L,63884L,160475L,403392L,1013853L,2547460L,6402009L,16089526L,40433015L,101609368L,255352867L,641716970L,1612668111L,4052732014L,10184756245L,25594885072L,64321450263L,161643568800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260241Inst : IEnumerable<long>
{
public static readonly long[] Value=A260241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260241.Bytes);
public long this[int i]=>Value[i];

public static A260241Inst Instance=new A260241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260242
{
public static readonly long[] Value={ 99L,213L,551L,1235L,3026L,7822L,18837L,45114L,113177L,278981L,673881L,1658848L,4103482L,10010581L,24491986L,60359993L,148047597L,362209985L,889739556L,2185247654L,5354240443L,13133074594L,32246360727L,79089150691L,193945475731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260242Inst : IEnumerable<long>
{
public static readonly long[] Value=A260242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260242.Bytes);
public long this[int i]=>Value[i];

public static A260242Inst Instance=new A260242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260243
{
public static readonly long[] Value={ 256L,551L,1476L,3287L,8242L,22944L,56634L,134576L,355620L,930398L,2243778L,5643712L,14874838L,37124894L,91485986L,236607962L,604605716L,1496818690L,3791471588L,9741618048L,24444280948L,61293997138L,156547740090L,396868734430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260243Inst : IEnumerable<long>
{
public static readonly long[] Value=A260243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260243.Bytes);
public long this[int i]=>Value[i];

public static A260243Inst Instance=new A260243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260244
{
public static readonly long[] Value={ 635L,1235L,3287L,5733L,14045L,42143L,85491L,178543L,492457L,1191315L,2445353L,5956161L,15293067L,33742487L,75896973L,191097599L,450742619L,1002739961L,2404247583L,5842913003L,13329225455L,30884432185L,74706438775L,175270605465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260244Inst : IEnumerable<long>
{
public static readonly long[] Value=A260244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260244.Bytes);
public long this[int i]=>Value[i];

public static A260244Inst Instance=new A260244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260245
{
public static readonly long[] Value={ 1598L,3026L,8242L,14045L,38280L,122048L,238852L,523742L,1565104L,3971668L,8022956L,20813200L,57401848L,128904402L,294881048L,796376738L,1970767384L,4434114134L,11116178928L,28746082714L,67430459184L,160189504544L,409946518912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260245Inst : IEnumerable<long>
{
public static readonly long[] Value=A260245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260245.Bytes);
public long this[int i]=>Value[i];

public static A260245Inst Instance=new A260245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260246
{
public static readonly long[] Value={ 4027L,7822L,22944L,42143L,122048L,416911L,906498L,2164027L,6912900L,19008695L,42243368L,118693767L,351663576L,862455845L,2149354562L,6271021751L,16817997488L,41248933871L,112144132366L,314044473839L,801369177620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260246Inst : IEnumerable<long>
{
public static readonly long[] Value=A260246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260246.Bytes);
public long this[int i]=>Value[i];

public static A260246Inst Instance=new A260246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260247
{
public static readonly long[] Value={ 10110L,18837L,56634L,85491L,238852L,906498L,1606456L,3601412L,12214696L,29652462L,59024564L,170234202L,476307636L,1016593000L,2509402408L,7209266008L,17002833240L,39321041096L,107511503760L,273221762146L,633085054356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260247Inst : IEnumerable<long>
{
public static readonly long[] Value=A260247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260247.Bytes);
public long this[int i]=>Value[i];

public static A260247Inst Instance=new A260247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260248
{
public static readonly long[] Value={ 48L,99L,99L,256L,213L,256L,635L,551L,551L,635L,1598L,1235L,1476L,1235L,1598L,4027L,3026L,3287L,3287L,3026L,4027L,10110L,7822L,8242L,5733L,8242L,7822L,10110L,25421L,18837L,22944L,14045L,14045L,22944L,18837L,25421L,63884L,45114L,56634L,42143L,38280L,42143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260248Inst : IEnumerable<long>
{
public static readonly long[] Value=A260248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260248.Bytes);
public long this[int i]=>Value[i];

public static A260248Inst Instance=new A260248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260249
{
public static readonly long[] Value={ 4L,8L,12L,2L,1L,7L,6L,3L,5L,11L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260249Inst : IEnumerable<long>
{
public static readonly long[] Value=A260249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260249.Bytes);
public long this[int i]=>Value[i];

public static A260249Inst Instance=new A260249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260250
{
public static readonly BigInteger[] Value={ 1300000000031L,713000000000317L,1471300000000031741L,BigInteger.Parse("12147130000000003174121"),BigInteger.Parse("3121471300000000031741213"),BigInteger.Parse("1213121471300000000031741213121"),BigInteger.Parse("33121312147130000000003174121312133"),BigInteger.Parse("323312131214713000000000317412131213323") };
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
public class A260250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260250Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260250.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260250.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260250Inst Instance=new A260250Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260251
{
public static readonly long[] Value={ 24L,26L,39L,41L,78L,80L,82L,84L,86L,112L,113L,125L,127L,130L,132L,137L,186L,188L,197L,199L,201L,203L,205L,207L,209L,211L,213L,215L,217L,219L,221L,223L,224L,236L,238L,240L,242L,244L,246L,310L,312L,314L,316L,318L,320L,322L,324L,326L,328L,330L,332L,334L,336L,338L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260251Inst : IEnumerable<long>
{
public static readonly long[] Value=A260251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260251.Bytes);
public long this[int i]=>Value[i];

public static A260251Inst Instance=new A260251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260252
{
public static readonly long[] Value={ 2L,18253L,3L,19L,2L,41L,43L,1087L,263L,29L,2L,281L,83L,8941L,613L,827L,7L,1867L,811L,139L,919L,13L,59L,11551L,10303L,10903L,2707L,3019L,1297L,5L,7333L,1609L,541L,701L,2281L,499L,2713L,6691L,41L,79L,1447L,1409L,263L,2129L,641L,2467L,7741L,1229L,523L,6781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260252Inst : IEnumerable<long>
{
public static readonly long[] Value=A260252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260252.Bytes);
public long this[int i]=>Value[i];

public static A260252Inst Instance=new A260252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260253
{
public static readonly long[] Value={ 1L,0L,4L,1L,9L,2L,16L,4L,25L,7L,36L,10L,49L,14L,64L,19L,81L,24L,100L,30L,121L,37L,144L,44L,169L,52L,196L,61L,225L,70L,256L,80L,289L,91L,324L,102L,361L,114L,400L,127L,441L,140L,484L,154L,529L,169L,576L,184L,625L,200L,676L,217L,729L,234L,784L,252L,841L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260253Inst : IEnumerable<long>
{
public static readonly long[] Value=A260253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260253.Bytes);
public long this[int i]=>Value[i];

public static A260253Inst Instance=new A260253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260254
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,5L,5L,5L,4L,4L,3L,3L,2L,2L,1L,1L,0L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,4L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260254Inst : IEnumerable<long>
{
public static readonly long[] Value=A260254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260254.Bytes);
public long this[int i]=>Value[i];

public static A260254Inst Instance=new A260254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260255
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260255Inst : IEnumerable<long>
{
public static readonly long[] Value=A260255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260255.Bytes);
public long this[int i]=>Value[i];

public static A260255Inst Instance=new A260255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260256
{
public static readonly long[] Value={ 5L,8L,9L,12L,15L,21L,24L,30L,36L,37L,39L,45L,53L,60L,67L,68L,69L,81L,84L,89L,93L,99L,105L,111L,112L,113L,117L,120L,121L,127L,129L,131L,143L,144L,157L,158L,165L,172L,173L,184L,185L,188L,195L,202L,203L,204L,207L,211L,215L,216L,217L,219L,222L,225L,226L,231L,248L,251L,276L,277L,279L,284L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260256Inst : IEnumerable<long>
{
public static readonly long[] Value=A260256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260256.Bytes);
public long this[int i]=>Value[i];

public static A260256Inst Instance=new A260256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260257
{
public static readonly long[] Value={ 4L,12L,14L,23L,29L,30L,35L,37L,45L,54L,58L,59L,60L,61L,62L,75L,77L,78L,79L,80L,87L,88L,92L,98L,115L,116L,117L,118L,119L,122L,123L,125L,127L,144L,147L,154L,155L,158L,159L,160L,163L,171L,175L,179L,183L,184L,190L,192L,206L,207L,217L,221L,222L,225L,228L,232L,234L,236L,238L,242L,249L,255L,256L,257L,258L,260L,268L,269L,270L,271L,272L,278L,281L,284L,288L,294L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260257Inst : IEnumerable<long>
{
public static readonly long[] Value=A260257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260257.Bytes);
public long this[int i]=>Value[i];

public static A260257Inst Instance=new A260257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260258
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,1L,1L,4L,3L,4L,2L,5L,1L,1L,6L,1L,5L,1L,7L,6L,2L,1L,8L,1L,1L,9L,7L,2L,8L,3L,10L,1L,1L,11L,4L,3L,9L,1L,12L,10L,1L,1L,13L,1L,1L,14L,11L,1L,12L,1L,15L,1L,4L,2L,16L,5L,2L,13L,2L,17L,14L,1L,6L,1L,18L,1L,1L,19L,15L,1L,16L,5L,20L,1L,1L,21L,3L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260258Inst : IEnumerable<long>
{
public static readonly long[] Value=A260258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260258.Bytes);
public long this[int i]=>Value[i];

public static A260258Inst Instance=new A260258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260259
{
public static readonly long[] Value={ -1L,2L,1L,7L,14L,41L,103L,274L,713L,1871L,4894L,12817L,33551L,87842L,229969L,602071L,1576238L,4126649L,10803703L,28284466L,74049689L,193864607L,507544126L,1328767777L,3478759199L,9107509826L,23843770273L,62423800999L,163427632718L,427859097161L,1120149658759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260259Inst : IEnumerable<long>
{
public static readonly long[] Value=A260259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260259.Bytes);
public long this[int i]=>Value[i];

public static A260259Inst Instance=new A260259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260260
{
public static readonly long[] Value={ 0L,1L,29L,132L,358L,755L,1371L,2254L,3452L,5013L,6985L,9416L,12354L,15847L,19943L,24690L,30136L,36329L,43317L,51148L,59870L,69531L,80179L,91862L,104628L,118525L,133601L,149904L,167482L,186383L,206655L,228346L,251504L,276177L,302413L,330260L,359766L,390979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260260Inst : IEnumerable<long>
{
public static readonly long[] Value=A260260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260260.Bytes);
public long this[int i]=>Value[i];

public static A260260Inst Instance=new A260260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260261
{
public static readonly long[] Value={ 0L,1L,12L,24L,48L,97L,188L,199L,211L,233L,255L,277L,299L,322L,355L,388L,422L,466L,511L,566L,622L,688L,755L,833L,922L,1013L,1024L,1035L,1046L,1057L,1068L,1079L,1090L,1101L,1112L,1123L,1134L,1145L,1156L,1167L,1178L,1189L,1200L,1211L,1222L,1233L,1244L,1255L,1266L,1277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260261Inst : IEnumerable<long>
{
public static readonly long[] Value=A260261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260261.Bytes);
public long this[int i]=>Value[i];

public static A260261Inst Instance=new A260261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260262
{
public static readonly BigInteger[] Value={ 1L,1L,5L,10703L,1614696745L,28812381422477890L,BigInteger.Parse("100652205682053466439353073"),BigInteger.Parse("100862590668529143951825397261798321446"),BigInteger.Parse("39596172587764149886638486692811308322476202830248047"),BigInteger.Parse("7942534398808419809836601901425429825855063583537701822391757140131840") };
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
public class A260262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260262Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260262.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260262.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260262Inst Instance=new A260262Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260263
{
public static readonly long[] Value={ 1L,10L,19L,27L,36L,45L,54L,63L,72L,81L,90L,98L,105L,114L,123L,132L,141L,150L,159L,167L,176L,185L,194L,202L,211L,220L,229L,237L,246L,255L,264L,273L,282L,291L,299L,307L,316L,325L,334L,343L,352L,361L,370L,379L,387L,396L,404L,413L,422L,431L,440L,449L,457L,466L,475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260263Inst : IEnumerable<long>
{
public static readonly long[] Value=A260263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260263.Bytes);
public long this[int i]=>Value[i];

public static A260263Inst Instance=new A260263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260264
{
public static readonly long[] Value={ 0L,9L,17L,26L,35L,44L,53L,62L,71L,80L,89L,96L,104L,113L,122L,131L,140L,149L,157L,166L,175L,184L,193L,201L,210L,219L,227L,236L,245L,254L,263L,272L,281L,290L,298L,305L,314L,323L,332L,341L,350L,359L,367L,376L,385L,394L,402L,411L,420L,429L,437L,446L,455L,464L,473L,482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260264Inst : IEnumerable<long>
{
public static readonly long[] Value=A260264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260264.Bytes);
public long this[int i]=>Value[i];

public static A260264Inst Instance=new A260264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260265
{
public static readonly long[] Value={ 180L,205L,223L,258L,297L,326L,350L,424L,502L,514L,521L,548L,666L,757L,765L,796L,804L,861L,909L,1006L,1098L,1150L,1264L,1317L,1348L,1349L,1400L,1416L,1592L,1613L,1663L,1757L,1821L,1914L,1939L,2034L,2048L,2073L,2085L,2109L,2164L,2276L,2316L,2360L,2380L,2398L,2655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260265Inst : IEnumerable<long>
{
public static readonly long[] Value=A260265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260265.Bytes);
public long this[int i]=>Value[i];

public static A260265Inst Instance=new A260265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260266
{
public static readonly long[] Value={ 11L,41L,101L,401L,4001L,4111L,4441L,10111L,10141L,11411L,14011L,14401L,14411L,40111L,41011L,41141L,41411L,44041L,44101L,44111L,100411L,101111L,101141L,101411L,110441L,114001L,114041L,140111L,140401L,140411L,141041L,141101L,400441L,401101L,401411L,404011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260266Inst : IEnumerable<long>
{
public static readonly long[] Value=A260266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260266.Bytes);
public long this[int i]=>Value[i];

public static A260266Inst Instance=new A260266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260267
{
public static readonly long[] Value={ 2L,11L,41L,211L,241L,421L,2111L,2141L,2221L,2411L,2441L,4111L,4211L,4241L,4421L,4441L,11411L,12211L,12241L,12421L,14221L,14411L,21121L,21211L,21221L,22111L,22441L,24121L,24421L,41141L,41221L,41411L,42221L,44111L,44221L,111121L,111211L,112111L,112121L,112241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260267Inst : IEnumerable<long>
{
public static readonly long[] Value=A260267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260267.Bytes);
public long this[int i]=>Value[i];

public static A260267Inst Instance=new A260267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260268
{
public static readonly long[] Value={ 5L,11L,41L,151L,541L,1151L,1451L,1511L,4111L,4441L,4451L,5441L,11411L,11551L,14411L,14551L,15451L,15511L,15541L,15551L,41141L,41411L,44111L,45541L,51151L,51511L,51551L,54151L,54541L,55411L,55441L,55511L,55541L,114451L,115151L,141511L,141551L,144451L,144511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260268Inst : IEnumerable<long>
{
public static readonly long[] Value=A260268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260268.Bytes);
public long this[int i]=>Value[i];

public static A260268Inst Instance=new A260268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260269
{
public static readonly long[] Value={ 11L,41L,61L,461L,641L,661L,4111L,4441L,6661L,11161L,11411L,14411L,14461L,16111L,16141L,16411L,16661L,41141L,41161L,41411L,41611L,41641L,44111L,44641L,46141L,46411L,46441L,61141L,61441L,64661L,66161L,111611L,111641L,114161L,114641L,114661L,116141L,116411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260269Inst : IEnumerable<long>
{
public static readonly long[] Value=A260269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260269.Bytes);
public long this[int i]=>Value[i];

public static A260269Inst Instance=new A260269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260270
{
public static readonly long[] Value={ 11L,41L,181L,811L,881L,1181L,1481L,1811L,4111L,4441L,4481L,8111L,11411L,14411L,18181L,18481L,41141L,41411L,44111L,48481L,81181L,84181L,84481L,84811L,88411L,88811L,118411L,141181L,141481L,141811L,144481L,148411L,181141L,184111L,184181L,184441L,411841L,418181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260270Inst : IEnumerable<long>
{
public static readonly long[] Value=A260270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260270.Bytes);
public long this[int i]=>Value[i];

public static A260270Inst Instance=new A260270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260271
{
public static readonly long[] Value={ 11L,19L,41L,149L,191L,199L,419L,449L,491L,499L,911L,919L,941L,991L,1499L,1949L,1999L,4111L,4441L,4919L,4999L,9199L,9419L,9491L,9941L,9949L,11119L,11149L,11411L,11491L,11941L,14149L,14411L,14419L,14449L,19141L,19441L,19919L,19949L,19991L,41141L,41149L,41411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260271Inst : IEnumerable<long>
{
public static readonly long[] Value=A260271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260271.Bytes);
public long this[int i]=>Value[i];

public static A260271Inst Instance=new A260271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260272
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,3L,0L,8L,8L,7L,9L,2L,3L,9L,1L,5L,2L,3L,1L,4L,6L,1L,9L,6L,7L,2L,9L,6L,2L,0L,6L,8L,1L,3L,1L,9L,9L,9L,8L,2L,3L,3L,2L,2L,4L,7L,0L,3L,4L,2L,7L,2L,3L,3L,7L,0L,8L,9L,4L,5L,8L,6L,1L,7L,7L,4L,7L,6L,1L,5L,9L,2L,5L,0L,9L,1L,6L,4L,3L,2L,3L,9L,3L,6L,4L,1L,6L,7L,8L,4L,1L,3L,6L,7L,2L,4L,2L,4L,0L,5L,7L,4L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260272Inst : IEnumerable<long>
{
public static readonly long[] Value=A260272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260272.Bytes);
public long this[int i]=>Value[i];

public static A260272Inst Instance=new A260272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260273
{
public static readonly long[] Value={ 1L,3L,5L,8L,11L,15L,17L,20L,23L,27L,31L,33L,36L,39L,44L,51L,56L,61L,65L,68L,71L,76L,81L,84L,87L,91L,95L,99L,104L,111L,115L,120L,125L,129L,132L,135L,140L,145L,148L,151L,157L,165L,168L,171L,175L,179L,186L,190L,194L,199L,204L,209L,216L,223L,227L,232L,241L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260273Inst : IEnumerable<long>
{
public static readonly long[] Value=A260273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260273.Bytes);
public long this[int i]=>Value[i];

public static A260273Inst Instance=new A260273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260274
{
public static readonly long[] Value={ 1L,2413L,3142L,25314L,41352L,28463517L,28536417L,34872156L,35827146L,43781265L,46281735L,53718264L,56218734L,64172853L,65127843L,71463582L,71536482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260274Inst : IEnumerable<long>
{
public static readonly long[] Value=A260274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260274.Bytes);
public long this[int i]=>Value[i];

public static A260274Inst Instance=new A260274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260275
{
public static readonly long[] Value={ 1L,12L,21L,123L,231L,312L,321L,1234L,1324L,2143L,2341L,3412L,3421L,4123L,4231L,4312L,4321L,12345L,13425L,14235L,14325L,21354L,23451L,24153L,24351L,31524L,32541L,34512L,34521L,45123L,45231L,45312L,45321L,51234L,51324L,52143L,52341L,53412L,53421L,54123L,54231L,54312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260275Inst : IEnumerable<long>
{
public static readonly long[] Value=A260275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260275.Bytes);
public long this[int i]=>Value[i];

public static A260275Inst Instance=new A260275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260276
{
public static readonly BigInteger[] Value={ 34L,85L,747L,6044L,65907L,1271212L,28517537L,866931786L,41412466296L,2594607954501L,217632708449176L,26820265742576644L,4556787104721551797L,BigInteger.Parse("1048460617788126795330"),BigInteger.Parse("341811609666627431538479") };
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
public class A260276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A260276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260276Inst Instance=new A260276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260277
{
public static readonly long[] Value={ 34L,46L,99L,202L,366L,714L,1428L,2750L,5291L,10334L,20111L,38936L,75595L,146976L,285323L,553794L,1075608L,2088887L,4055703L,7875257L,15293121L,29696093L,57662890L,111971304L,217428312L,422201962L,819834467L,1591965964L,3091293283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260277Inst : IEnumerable<long>
{
public static readonly long[] Value=A260277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260277.Bytes);
public long this[int i]=>Value[i];

public static A260277Inst Instance=new A260277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260278
{
public static readonly long[] Value={ 46L,85L,230L,525L,1150L,2726L,6351L,14393L,33241L,77098L,177043L,407486L,941020L,2167955L,4992417L,11510489L,26530166L,61125209L,140873214L,324678646L,748199483L,1724247325L,3973747017L,9157675382L,21104202919L,48636225966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260278Inst : IEnumerable<long>
{
public static readonly long[] Value=A260278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260278.Bytes);
public long this[int i]=>Value[i];

public static A260278Inst Instance=new A260278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260279
{
public static readonly long[] Value={ 99L,230L,747L,2027L,5420L,15306L,42175L,114513L,316679L,874845L,2397776L,6596755L,18184634L,50001731L,137513534L,378580791L,1041706050L,2865675286L,7885936120L,21700245925L,59706090387L,164287119004L,452064660346L,1243881032722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260279Inst : IEnumerable<long>
{
public static readonly long[] Value=A260279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260279.Bytes);
public long this[int i]=>Value[i];

public static A260279Inst Instance=new A260279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260280
{
public static readonly long[] Value={ 202L,525L,2027L,6044L,18380L,60955L,192277L,595506L,1903722L,6052530L,19003962L,60149738L,190824807L,602506945L,1904270753L,6029330442L,19066139003L,60275105360L,190686505791L,603143941550L,1907284297095L,6032465100205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260280Inst : IEnumerable<long>
{
public static readonly long[] Value=A260280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260280.Bytes);
public long this[int i]=>Value[i];

public static A260280Inst Instance=new A260280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260281
{
public static readonly long[] Value={ 366L,1150L,5420L,18380L,65907L,264502L,984644L,3594132L,13692107L,51665854L,191960166L,721121125L,2715359102L,10162545149L,38093817256L,143095709741L,536645505853L,2012038271487L,7550226421387L,28325095890229L,106233154740268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260281Inst : IEnumerable<long>
{
public static readonly long[] Value=A260281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260281.Bytes);
public long this[int i]=>Value[i];

public static A260281Inst Instance=new A260281Inst();

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