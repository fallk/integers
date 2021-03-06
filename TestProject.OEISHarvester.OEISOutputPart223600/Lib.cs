using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A261982
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,11L,21L,51L,109L,229L,455L,959L,1947L,3963L,7999L,16033L,32333L,64919L,130221L,260967L,522733L,1045825L,2093855L,4189547L,8382315L,16768455L,33543127L,67093261L,134193413L,268404995L,536829045L,1073686083L,2147408773L,4294869253L,8589803783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261982Inst : IEnumerable<long>
{
public static readonly long[] Value=A261982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261982.Bytes);
public long this[int i]=>Value[i];

public static A261982Inst Instance=new A261982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261983
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,9L,18L,41L,89L,185L,388L,810L,1670L,3435L,7040L,14360L,29226L,59347L,120229L,243166L,491086L,990446L,1995410L,4016259L,8076960L,16231746L,32599774L,65437945L,131293192L,263316897L,527912140L,1058061751L,2120039885L,4246934012L,8505864640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261983Inst : IEnumerable<long>
{
public static readonly long[] Value=A261983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261983.Bytes);
public long this[int i]=>Value[i];

public static A261983Inst Instance=new A261983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261984
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,8L,16L,34L,57L,113L,213L,396L,733L,1333L,2419L,4400L,7934L,14321L,25687L,45947L,82085L,146410L,260547L,463021L,821669L,1456296L,2578051L,4559972L,8057373L,14225124L,25096606L,44246087L,77958821L,137283534L,241626535L,425079358L,747501363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261984Inst : IEnumerable<long>
{
public static readonly long[] Value=A261984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261984.Bytes);
public long this[int i]=>Value[i];

public static A261984Inst Instance=new A261984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261985
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,4L,3L,6L,5L,8L,6L,14L,11L,11L,8L,17L,18L,16L,13L,32L,25L,27L,19L,39L,32L,39L,35L,58L,40L,47L,32L,61L,47L,65L,41L,93L,58L,67L,54L,95L,73L,80L,89L,130L,109L,94L,87L,142L,110L,106L,102L,203L,129L,130L,115L,189L,148L,151L,137L,232L,170L,165L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261985Inst : IEnumerable<long>
{
public static readonly long[] Value=A261985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261985.Bytes);
public long this[int i]=>Value[i];

public static A261985Inst Instance=new A261985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261986
{
public static readonly long[] Value={ 30958077L,55670941L,61487077L,111031197L,112710897L,113180303L,114523591L,121275479L,121963055L,122830789L,215074411L,215182221L,220162873L,222034845L,222254557L,222661789L,223538781L,225298237L,225414385L,225545245L,225695631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261986Inst : IEnumerable<long>
{
public static readonly long[] Value=A261986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261986.Bytes);
public long this[int i]=>Value[i];

public static A261986Inst Instance=new A261986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261987
{
public static readonly long[] Value={ 4L,8L,9L,25L,26L,27L,91L,92L,93L,95L,115L,116L,117L,119L,121L,527L,529L,531L,532L,533L,535L,527L,529L,531L,533L,535L,536L,539L,1331L,1333L,1334L,1337L,1339L,1341L,1343L,1345L,1331L,1333L,1334L,1337L,1339L,1341L,1343L,1345L,1349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261987Inst : IEnumerable<long>
{
public static readonly long[] Value=A261987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261987.Bytes);
public long this[int i]=>Value[i];

public static A261987Inst Instance=new A261987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261988
{
public static readonly long[] Value={ 1L,-2L,4L,-8L,14L,-24L,40L,-64L,100L,-152L,228L,-336L,488L,-700L,992L,-1392L,1934L,-2664L,3640L,-4936L,6648L,-8896L,11832L,-15648L,20584L,-26942L,35096L,-45512L,58768L,-75576L,96816L,-123568L,157156L,-199200L,251676L,-316992L,398072L,-498460L,622448L,-775216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261988Inst : IEnumerable<long>
{
public static readonly long[] Value=A261988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261988.Bytes);
public long this[int i]=>Value[i];

public static A261988Inst Instance=new A261988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261989
{
public static readonly long[] Value={ 1L,65L,175L,20737L,32045L,41474L,64090L,128180L,207370L,207553L,352529L,415106L,705058L,1264957L,1762645L,1824877L,2075530L,2529914L,3525290L,3628975L,3649754L,7050580L,7590250L,10223341L,12649570L,17626450L,20446682L,21504269L,23723401L,36321775L,40893364L,43008538L,45621925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261989Inst : IEnumerable<long>
{
public static readonly long[] Value=A261989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261989.Bytes);
public long this[int i]=>Value[i];

public static A261989Inst Instance=new A261989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261990
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261990Inst : IEnumerable<long>
{
public static readonly long[] Value=A261990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261990.Bytes);
public long this[int i]=>Value[i];

public static A261990Inst Instance=new A261990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261991
{
public static readonly long[] Value={ 18L,36L,48L,54L,60L,72L,84L,90L,96L,108L,120L,126L,132L,144L,162L,168L,180L,192L,198L,210L,216L,234L,240L,252L,264L,270L,288L,300L,306L,324L,330L,336L,342L,360L,378L,384L,390L,396L,414L,420L,432L,450L,462L,468L,480L,486L,504L,522L,528L,540L,546L,558L,576L,588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261991Inst : IEnumerable<long>
{
public static readonly long[] Value=A261991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261991.Bytes);
public long this[int i]=>Value[i];

public static A261991Inst Instance=new A261991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261992
{
public static readonly long[] Value={ 1L,1L,0L,6L,5L,0L,25L,19L,0L,84L,61L,0L,248L,174L,0L,666L,455L,0L,1662L,1112L,0L,3912L,2573L,0L,8774L,5689L,0L,18894L,12102L,0L,39289L,24900L,0L,79248L,49759L,0L,155612L,96902L,0L,298338L,184408L,0L,559812L,343722L,0L,1030224L,628717L,0L,1862647L,1130418L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261992Inst : IEnumerable<long>
{
public static readonly long[] Value=A261992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261992.Bytes);
public long this[int i]=>Value[i];

public static A261992Inst Instance=new A261992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261993
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,15L,21L,28L,36L,45L,55L,66L,78L,91L,105L,120L,136L,151L,169L,188L,208L,229L,251L,274L,298L,323L,349L,376L,404L,433L,463L,494L,526L,559L,593L,628L,664L,701L,739L,778L,818L,859L,901L,944L,988L,1033L,1079L,1126L,1174L,1223L,1273L,1324L,1376L,1429L,1483L,1538L,1594L,1651L,1709L,1768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261993Inst : IEnumerable<long>
{
public static readonly long[] Value=A261993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261993.Bytes);
public long this[int i]=>Value[i];

public static A261993Inst Instance=new A261993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261994
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,6L,18L,71L,307L,1594L,9446L,63461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261994Inst : IEnumerable<long>
{
public static readonly long[] Value=A261994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261994.Bytes);
public long this[int i]=>Value[i];

public static A261994Inst Instance=new A261994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261995
{
public static readonly long[] Value={ 42L,123L,315L,1827L,4659L,13650L,34794L,201114L,512610L,1501539L,3827187L,22120875L,56382603L,165155802L,420955938L,2433095298L,6201573882L,18165636843L,46301326155L,267618362067L,682116744579L,1998054897090L,5092724921274L,29435586732234L,75026640329970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261995Inst : IEnumerable<long>
{
public static readonly long[] Value=A261995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261995.Bytes);
public long this[int i]=>Value[i];

public static A261995Inst Instance=new A261995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261996
{
public static readonly long[] Value={ 8L,44L,128L,788L,2024L,5948L,15176L,87764L,223712L,655316L,1670312L,9654332L,24607376L,72079892L,183720224L,1061889836L,2706588728L,7928133884L,20207555408L,116798228708L,297700153784L,872022648428L,2222647375736L,12846743269124L,32744310328592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261996Inst : IEnumerable<long>
{
public static readonly long[] Value=A261996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261996.Bytes);
public long this[int i]=>Value[i];

public static A261996Inst Instance=new A261996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261997
{
public static readonly BigInteger[] Value={ 0L,3L,107L,4951L,39916141L,6227015357L,355687428046967L,121645100408347963L,BigInteger.Parse("25852016738884971417571"),BigInteger.Parse("8841761993739701954543554805353"),BigInteger.Parse("8222838654177922817725562105174617") };
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
public class A261997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261997Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261997.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261997.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261997Inst Instance=new A261997Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261998
{
public static readonly long[] Value={ 1L,3L,5L,10L,17L,26L,43L,65L,95L,140L,201L,283L,395L,545L,740L,1002L,1343L,1780L,2350L,3077L,4002L,5183L,6670L,8535L,10880L,13801L,17426L,21925L,27475L,34297L,42677L,52926L,65415L,80625L,99077L,121403L,148386L,180890L,219960L,266857L,323002L,390086L,470125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261998Inst : IEnumerable<long>
{
public static readonly long[] Value=A261998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261998.Bytes);
public long this[int i]=>Value[i];

public static A261998Inst Instance=new A261998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261999
{
public static readonly long[] Value={ 3L,2L,3L,9L,4L,3L,6L,3L,1L,1L,2L,1L,1L,5L,5L,6L,8L,5L,8L,9L,6L,1L,0L,4L,4L,6L,1L,9L,4L,9L,8L,3L,6L,9L,8L,7L,9L,3L,9L,7L,2L,5L,3L,0L,8L,6L,5L,6L,5L,9L,2L,8L,3L,0L,3L,6L,3L,9L,1L,8L,0L,6L,6L,7L,8L,3L,6L,9L,4L,1L,3L,0L,6L,1L,3L,6L,3L,2L,9L,1L,9L,1L,3L,8L,1L,9L,5L,3L,1L,0L,2L,5L,2L,3L,7L,2L,1L,8L,5L,1L,6L,9L,5L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261999Inst : IEnumerable<long>
{
public static readonly long[] Value=A261999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261999.Bytes);
public long this[int i]=>Value[i];

public static A261999Inst Instance=new A261999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262000
{
public static readonly long[] Value={ 0L,1L,18L,72L,184L,375L,666L,1078L,1632L,2349L,3250L,4356L,5688L,7267L,9114L,11250L,13696L,16473L,19602L,23104L,27000L,31311L,36058L,41262L,46944L,53125L,59826L,67068L,74872L,83259L,92250L,101866L,112128L,123057L,134674L,147000L,160056L,173863L,188442L,203814L,220000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262000Inst : IEnumerable<long>
{
public static readonly long[] Value=A262000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262000.Bytes);
public long this[int i]=>Value[i];

public static A262000Inst Instance=new A262000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262001
{
public static readonly BigInteger[] Value={ 1L,2L,10L,60L,400L,2900L,22700L,191600L,1746400L,17230000L,184348000L,2140118000L,26925784000L,366118706000L,5359236310000L,84077608400000L,1407341155720000L,25027454132360000L,471046698018440000L,9351091483806800000UL,BigInteger.Parse("195213433887227200000"),BigInteger.Parse("4274234604872786800000"),BigInteger.Parse("97924306054031604400000") };
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
public class A262001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262001Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262001.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262001.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262001Inst Instance=new A262001Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262002
{
public static readonly BigInteger[] Value={ 2L,6L,28L,164L,1132L,8916L,78608L,765904L,8170752L,94755776L,1187551088L,16004096144L,230910861872L,3553052000336L,58100442762368L,1006457051734784L,18415695160624192L,354980774078690496L,7190981550797464448L,BigInteger.Parse("152744987909458781824"),BigInteger.Parse("3395058926880381635712"),BigInteger.Parse("78814259879097446800256") };
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
public class A262002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262002Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262002.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262002.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262002Inst Instance=new A262002Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262003
{
public static readonly BigInteger[] Value={ 2L,14L,206L,4754L,156722L,7002926L,408890414L,30315895970L,2787655430690L,311698491417614L,41677029833666702L,6569530958412341810L,BigInteger.Parse("1205946558621750623186"),BigInteger.Parse("255076631360949322977710"),BigInteger.Parse("61594259272103652501480686"),BigInteger.Parse("16842210623928858086134293314"),BigInteger.Parse("5177422625829616613400965034818"),BigInteger.Parse("1777829320507196831744636014160654") };
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
public class A262003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262003Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262003.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262003.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262003Inst Instance=new A262003Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262004
{
public static readonly BigInteger[] Value={ 2L,30L,1300L,115380L,18362616L,4800297144L,1929066361136L,1131386990471376L,929148154976860592L,BigInteger.Parse("1033280101490424757200"),BigInteger.Parse("1513696127276317671503232"),BigInteger.Parse("2854591502346208585710465024"),BigInteger.Parse("6796099969466204436648991894784"),BigInteger.Parse("20087194984043555807709161038217856"),BigInteger.Parse("72648127998052140755125407470469776640") };
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
public class A262004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262004Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262004.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262004.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262004Inst Instance=new A262004Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262005
{
public static readonly BigInteger[] Value={ 2L,62L,7862L,2727962L,2142727322L,3338786909702L,9359997562264862L,BigInteger.Parse("43832263835648182562"),BigInteger.Parse("323596944389808203151362"),BigInteger.Parse("3595937015557095119026724222"),BigInteger.Parse("57916971628198473192636867273302"),BigInteger.Parse("1310203094399724255301396007844469562"),BigInteger.Parse("40540285568379172649032878682803332843162"),BigInteger.Parse("1677228560345389865386245848706087738381702662") };
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
public class A262005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262005Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262005.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262005.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262005Inst Instance=new A262005Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262006
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,11L,54L,224L,1221L,6506L,37982L,227853L,1436155L,9370157L,63478402L,444856819L,3224349732L,24142103099L,186635429502L,1488745035667L,12246510599338L,103825176789850L,906575491574389L,8147038046590526L,75291889506602676L,714968504199357010L,6970122084115034290L,BigInteger.Parse("69699196634887342192") };
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
public class A262006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262006Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262006.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262006.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262006Inst Instance=new A262006Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262007
{
public static readonly long[] Value={ 1L,2L,1L,8L,7L,27L,45L,102L,194L,439L,844L,1775L,3608L,7342L,14891L,30283L,61113L,123625L,249355L,502430L,1011305L,2034028L,4086860L,8206874L,16469851L,33035697L,66234208L,132746099L,265961186L,532718115L,1066778721L,2135822309L,4275459594L,8557335615L,17125445126L,34268966022L,68568212859L,137187104632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262007Inst : IEnumerable<long>
{
public static readonly long[] Value=A262007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262007.Bytes);
public long this[int i]=>Value[i];

public static A262007Inst Instance=new A262007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262008
{
public static readonly BigInteger[] Value={ 1L,2L,14L,202L,16858L,6746346L,11466918526L,80444425726274L,2306004013900856642L,BigInteger.Parse("268654794950929597256002"),BigInteger.Parse("126765597355485476411443388062"),BigInteger.Parse("241678070949320865028012988979962410"),BigInteger.Parse("1858395916568294857820278937430319959202010"),BigInteger.Parse("57560683587057503330693629888859064500206488317834") };
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
public class A262008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262008Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262008.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262008.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262008Inst Instance=new A262008Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262009
{
public static readonly BigInteger[] Value={ 2L,24L,530L,65632L,33554482L,68719479000L,562949953421410L,BigInteger.Parse("18446744073709814144"),BigInteger.Parse("2417851639229258349417122"),BigInteger.Parse("1267650600228229401496837423704"),BigInteger.Parse("2658455991569831745807614120560689394"),BigInteger.Parse("22300745198530623141535718272648636384486240"),BigInteger.Parse("748288838313422294120286634350736906063837462004050") };
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
public class A262009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262009Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262009.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262009.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262009Inst Instance=new A262009Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262010
{
public static readonly BigInteger[] Value={ 1L,24L,1944L,215808L,27736920L,3879912960L,573515224128L,88128590118912L,13937449300517592L,2253641284021079040L,BigInteger.Parse("370887799310890842816"),BigInteger.Parse("61919951199385511890944"),BigInteger.Parse("10461342569407280971842240"),BigInteger.Parse("1785259939840128008227676160"),BigInteger.Parse("307282893462557980175918292480"),BigInteger.Parse("53283529423650333161886781538304"),BigInteger.Parse("9299430498554929711121662876725720") };
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
public class A262010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262010Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262010.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262010.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262010Inst Instance=new A262010Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262011
{
public static readonly BigInteger[] Value={ 1L,2L,9L,84L,1365L,34398L,1244061L,61136712L,3920391657L,317987323290L,31830531061329L,3854387943062748L,555353062796290941L,BigInteger.Parse("93897387078942114486"),BigInteger.Parse("18410594823692578876005"),BigInteger.Parse("4143611208319076419026192"),BigInteger.Parse("1061023445030203505546894289"),BigInteger.Parse("306698188757554119191614031538"),BigInteger.Parse("99387251945711843180260258108953") };
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
public class A262011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262011Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262011.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262011.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262011Inst Instance=new A262011Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262012
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,31L,91L,211L,997L,5941L,27181L,97021L,369907L,1809211L,9180991L,40941031L,170062027L,753752971L,3645183691L,17473250251L,79444369189L,356738879533L,1662097580353L,7957682872873L,37696688946691L,175245959453491L,816849622436251L,3873243058472971L,18507865654295389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262012Inst : IEnumerable<long>
{
public static readonly long[] Value=A262012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262012.Bytes);
public long this[int i]=>Value[i];

public static A262012Inst Instance=new A262012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262013
{
public static readonly BigInteger[] Value={ 1L,6L,432L,45960L,5780034L,797957244L,116916528960L,17852845828752L,2810058672255120L,452703723158137776L,BigInteger.Parse("74282858140993920000"),BigInteger.Parse("12371608762947252317376"),BigInteger.Parse("2085965999078265151837416"),BigInteger.Parse("355369363809372393287259600"),BigInteger.Parse("61077516024443872565938037760"),BigInteger.Parse("10577549099569850669961138879936"),BigInteger.Parse("1844022794086994489463720605589954"),BigInteger.Parse("323353325204017719895246887849230460") };
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
public class A262013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262013Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262013.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262013.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262013Inst Instance=new A262013Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262014
{
public static readonly long[] Value={ 1L,1L,11L,11L,1L,1L,72L,603L,1168L,603L,72L,1L,1L,243L,6750L,49682L,128124L,128124L,49682L,6750L,243L,1L,1L,608L,40136L,724320L,4961755L,15018688L,21571984L,15018688L,4961755L,724320L,40136L,608L,1L,1L,1275L,167475L,6021225L,84646275L,554083761L,1858142825L,3363309675L,3363309675L,1858142825L,554083761L,84646275L,6021225L,167475L,1275L,1L,1L,2376L,554931L,35138736L,879018750L,10490842656L,66555527346L,239677178256L,509723668476L,654019630000L,509723668476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262014Inst : IEnumerable<long>
{
public static readonly long[] Value=A262014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262014.Bytes);
public long this[int i]=>Value[i];

public static A262014Inst Instance=new A262014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262015
{
public static readonly BigInteger[] Value={ 1L,11L,603L,49682L,4961755L,554083761L,66555527346L,8415759917268L,1105492743188955L,149552158117961225L,BigInteger.Parse("20710288432292240353"),BigInteger.Parse("2923132560874617706758"),BigInteger.Parse("419153950726771517250994"),BigInteger.Parse("60909593781491823719018822"),BigInteger.Parse("8952489587089165075007703060"),BigInteger.Parse("1328855554150146863702291235432"),BigInteger.Parse("198950469430034588049648664728027"),BigInteger.Parse("30012345078088728771497844274527081") };
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
public class A262015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262015.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262015Inst Instance=new A262015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262016
{
public static readonly BigInteger[] Value={ 0L,0L,2L,7L,15L,83L,91L,5163L,86315L,401323L,14725035L,65973803L,2562459691L,37695987243L,45627576875L,9183900142123L,39579412285995L,2598666482813483L,28017829467228715L,223446104928848427L,275288604322335275L,BigInteger.Parse("116723151945719253547"),BigInteger.Parse("12606804937123633465899") };
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
public class A262016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262016Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262016.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262016.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262016Inst Instance=new A262016Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262017
{
public static readonly BigInteger[] Value={ 61L,1381L,30361L,666601L,14634901L,321301261L,7053992881L,154866542161L,3400009934701L,74645352021301L,1638797734533961L,35978904807725881L,789897108035435461L,17341757471971854301UL,BigInteger.Parse("380728767275345359201"),BigInteger.Parse("8358691122585626048161"),BigInteger.Parse("183510475929608427700381") };
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
public class A262017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262017Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262017.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262017.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262017Inst Instance=new A262017Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262018
{
public static readonly BigInteger[] Value={ 28L,5308L,945148L,168231388L,29944242268L,5329906892668L,948693482652988L,168862110005339548L,BigInteger.Parse("30056506887467786908"),BigInteger.Parse("5349889363859260730428"),BigInteger.Parse("952250250260060942229628"),BigInteger.Parse("169495194656926988456143708"),BigInteger.Parse("30169192398682743884251350748"),BigInteger.Parse("5369946751770871484408284289788") };
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
public class A262018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262018Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262018.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262018.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262018Inst Instance=new A262018Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262019
{
public static readonly BigInteger[] Value={ 15L,3575L,637215L,113421575L,20188404015L,3593422493975L,639609015524415L,113846811340852775L,BigInteger.Parse("20264092809656270415"),BigInteger.Parse("3606894673307475281975"),BigInteger.Parse("642006987755920943922015"),BigInteger.Parse("114273636925880620542837575"),BigInteger.Parse("20340065365818994535681167215"),BigInteger.Parse("3620417361478855146730704927575") };
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
public class A262019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262019Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262019.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262019.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262019Inst Instance=new A262019Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262020
{
public static readonly long[] Value={ 1L,0L,1L,-1L,5L,-11L,43L,-127L,489L,-1693L,6771L,-26071L,109693L,-457757L,2028671L,-9039931L,42101329L,-198411489L,967906675L,-4791497559L,24401815141L,-126243354637L,669094876055L,-3603105436163L,19818039219577L,-110721426757801L,630419303537115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262020Inst : IEnumerable<long>
{
public static readonly long[] Value=A262020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262020.Bytes);
public long this[int i]=>Value[i];

public static A262020Inst Instance=new A262020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262021
{
public static readonly long[] Value={ 2L,3L,8L,13L,26L,35L,52L,59L,74L,99L,116L,145L,166L,177L,196L,225L,260L,265L,312L,333L,346L,379L,408L,437L,484L,521L,536L,559L,570L,587L,678L,707L,740L,763L,824L,841L,882L,929L,952L,991L,1022L,1045L,1110L,1127L,1156L,1171L,1250L,1361L,1384L,1397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262021Inst : IEnumerable<long>
{
public static readonly long[] Value=A262021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262021.Bytes);
public long this[int i]=>Value[i];

public static A262021Inst Instance=new A262021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262022
{
public static readonly long[] Value={ 1L,3L,6L,30L,210L,420L,1260L,13860L,13860L,180180L,180180L,360360L,6126120L,116396280L,23279256L,23279256L,535422888L,535422888L,13385572200L,40156716600L,40156716600L,1164544781400L,36100888223400L,72201776446800L,72201776446800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262022Inst : IEnumerable<long>
{
public static readonly long[] Value=A262022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262022.Bytes);
public long this[int i]=>Value[i];

public static A262022Inst Instance=new A262022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262023
{
public static readonly long[] Value={ 1L,0L,3L,9L,7L,2L,0L,7L,7L,0L,8L,3L,9L,9L,1L,7L,9L,6L,4L,1L,2L,5L,8L,4L,8L,1L,8L,2L,1L,8L,7L,2L,6L,4L,8L,5L,2L,1L,1L,3L,2L,5L,0L,2L,0L,1L,5L,4L,0L,3L,8L,2L,8L,8L,1L,1L,8L,1L,0L,2L,0L,0L,1L,4L,2L,4L,0L,0L,9L,0L,4L,3L,2L,9L,5L,4L,5L,4L,2L,0L,7L,3L,4L,0L,8L,7L,9L,4L,9L,9L,0L,4L,9L,4L,6L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262023Inst : IEnumerable<long>
{
public static readonly long[] Value=A262023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262023.Bytes);
public long this[int i]=>Value[i];

public static A262023Inst Instance=new A262023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262024
{
public static readonly long[] Value={ 3L,9L,5L,19L,7L,649L,15L,33L,17L,9L,55L,197L,51L,127L,9801L,11L,23L,35L,73L,37L,25L,2049L,13L,199L,161L,24335L,99L,649L,66249L,485L,89L,15L,151L,19603L,31L,1766319049L,63L,129L,65L,33L,7775L,251L,17L,2281249L,3699L,57799L,351L,53L,163L,55L,285769L,10405L,500001L,19L,1151L,12151L,2143295L,39L,62809633L,99L,201L,101L,41L,32080051L,1351L,158070671986249L,21L,295L,127L,1204353L,1025L,9801L,649L,306917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262024Inst : IEnumerable<long>
{
public static readonly long[] Value=A262024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262024.Bytes);
public long this[int i]=>Value[i];

public static A262024Inst Instance=new A262024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262025
{
public static readonly long[] Value={ 1L,4L,2L,9L,3L,324L,7L,16L,8L,4L,27L,98L,25L,63L,4900L,5L,11L,17L,36L,18L,12L,1024L,6L,99L,80L,12167L,49L,324L,33124L,242L,44L,7L,75L,9801L,15L,883159524L,31L,64L,32L,16L,3887L,125L,8L,1140624L,1849L,28899L,175L,26L,81L,27L,142884L,5202L,250000L,9L,575L,6075L,1071647L,19L,31404816L,49L,100L,50L,20L,16040025L,675L,79035335993124L,10L,147L,63L,602176L,512L,4900L,324L,153458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262025Inst : IEnumerable<long>
{
public static readonly long[] Value=A262025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262025.Bytes);
public long this[int i]=>Value[i];

public static A262025Inst Instance=new A262025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262026
{
public static readonly long[] Value={ 1L,3L,1L,3L,1L,39L,5L,1L,5L,273L,3L,1L,3L,531L,7L,1L,7L,69L,1L,5967L,413L,3L,9L,1L,9L,3L,21L,165L,5L,1L,22419L,5L,93L,105L,11L,1L,11L,419775L,51L,927L,21L,3L,6578829L,1L,140634693L,3L,105L,57L,5019135L,13L,1L,13L,153L,15L,313191L,123L,650783L,7L,1L,1153080099L,7L,45L,19162705353L,3L,33L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262026Inst : IEnumerable<long>
{
public static readonly long[] Value=A262026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262026.Bytes);
public long this[int i]=>Value[i];

public static A262026Inst Instance=new A262026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262027
{
public static readonly long[] Value={ 2L,8L,3L,10L,4L,170L,24L,5L,26L,1520L,17L,6L,19L,3482L,48L,7L,50L,530L,8L,48842L,3480L,26L,80L,9L,82L,28L,197L,1574L,49L,10L,227528L,51L,962L,1126L,120L,11L,122L,4730624L,577L,10610L,244L,35L,77563250L,12L,1728148040L,37L,1324L,721L,64080026L,168L,13L,170L,2024L,199L,4190210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262027Inst : IEnumerable<long>
{
public static readonly long[] Value=A262027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262027.Bytes);
public long this[int i]=>Value[i];

public static A262027Inst Instance=new A262027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262028
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,19L,2L,0L,2L,136L,1L,0L,1L,265L,3L,0L,3L,34L,0L,2983L,206L,1L,4L,0L,4L,1L,10L,82L,2L,0L,11209L,2L,46L,52L,5L,0L,5L,209887L,25L,463L,10L,1L,3289414L,0L,70317346L,1L,52L,28L,2509567L,6L,0L,6L,76L,7L,156595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262028Inst : IEnumerable<long>
{
public static readonly long[] Value=A262028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262028.Bytes);
public long this[int i]=>Value[i];

public static A262028Inst Instance=new A262028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262029
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,26L,20L,23L,16L,24L,21L,25L,13L,12L,11L,27L,10L,17L,22L,32L,15L,28L,18L,30L,14L,29L,19L,31L,8L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262029Inst : IEnumerable<long>
{
public static readonly long[] Value=A262029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262029.Bytes);
public long this[int i]=>Value[i];

public static A262029Inst Instance=new A262029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262030
{
public static readonly long[] Value={ 1L,3L,1L,10L,8L,1L,35L,45L,20L,15L,1L,126L,224L,175L,126L,75L,24L,1L,462L,1050L,1134L,490L,840L,896L,175L,280L,189L,35L,1L,1716L,4752L,6468L,4704L,4950L,7350L,3528L,2646L,2400L,2940L,784L,540L,392L,48L,1L,6435L,21021L,34320L,33264L,13860L,27027L,50688L,41580L,25872L,15876L,17325L,29700L,15120L,14700L,1764L,5775L,7680L,2352L,945L,720L,63L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262030Inst : IEnumerable<long>
{
public static readonly long[] Value=A262030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262030.Bytes);
public long this[int i]=>Value[i];

public static A262030Inst Instance=new A262030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262031
{
public static readonly long[] Value={ 1L,4L,5L,31L,247L,389L,1307L,15637L,13327L,187111L,199123L,353201L,6364777L,127056883L,23083451L,24191987L,579694957L,535076383L,13912332463L,43224283189L,40355946289L,1210479158981L,38689398709811L,72866186391697L,75054119011297L,77117026909777L,73105817107177L,2777117009412349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262031Inst : IEnumerable<long>
{
public static readonly long[] Value=A262031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262031.Bytes);
public long this[int i]=>Value[i];

public static A262031Inst Instance=new A262031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262032
{
public static readonly BigInteger[] Value={ 1L,2L,12L,6720L,871782912000L,BigInteger.Parse("2192756974447446084726816768000000"),BigInteger.Parse("176231850258172450143657485187724278892868772464646100276113742187798200320000000000000") };
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
public class A262032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262032Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262032.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262032.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262032Inst Instance=new A262032Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262033
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,20L,30L,210L,336L,3024L,5040L,55440L,95040L,1235520L,2162160L,32432400L,57657600L,980179200L,1764322560L,33522128640L,60949324800L,1279935820800L,2346549004800L,53970627110400L,99638080819200L,2490952020480000L,4626053752320000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262033Inst : IEnumerable<long>
{
public static readonly long[] Value=A262033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262033.Bytes);
public long this[int i]=>Value[i];

public static A262033Inst Instance=new A262033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262034
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,5L,30L,42L,336L,504L,5040L,7920L,95040L,154440L,2162160L,3603600L,57657600L,98017920L,1764322560L,3047466240L,60949324800L,106661318400L,2346549004800L,4151586700800L,99638080819200L,177925144320000L,4626053752320000L,8326896754176000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262034Inst : IEnumerable<long>
{
public static readonly long[] Value=A262034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262034.Bytes);
public long this[int i]=>Value[i];

public static A262034Inst Instance=new A262034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262035
{
public static readonly BigInteger[] Value={ 1L,2L,15L,168L,2520L,47520L,1081080L,28828800L,882161280L,30474662400L,1173274502400L,49819040409600L,2313026876160000L,116576554558464000L,6338850154116480000L,BigInteger.Parse("369890550169620480000"),BigInteger.Parse("23056510960573009920000"),BigInteger.Parse("1529010726859052236800000") };
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
public class A262035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262035Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262035.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262035.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262035Inst Instance=new A262035Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262036
{
public static readonly long[] Value={ 1L,3L,40L,61L,23L,170L,99L,54L,662L,30L,993L,880L,307L,877L,1007L,3523L,8562L,5039L,18757L,12724L,9819L,5602L,2512L,184L,10597L,33155L,43913L,8091L,16060L,59212L,169123L,155029L,198843L,103553L,16907L,169461L,20993L,97267L,719169L,484152L,264386L,427060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262036Inst : IEnumerable<long>
{
public static readonly long[] Value=A262036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262036.Bytes);
public long this[int i]=>Value[i];

public static A262036Inst Instance=new A262036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262037
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,33L,33L,33L,33L,33L,33L,33L,33L,33L,33L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L,77L,77L,77L,77L,77L,77L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262037Inst : IEnumerable<long>
{
public static readonly long[] Value=A262037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262037.Bytes);
public long this[int i]=>Value[i];

public static A262037Inst Instance=new A262037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262038
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,11L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,33L,33L,33L,33L,33L,33L,33L,33L,33L,33L,33L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L,77L,77L,77L,77L,77L,77L,77L,77L,77L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262038Inst : IEnumerable<long>
{
public static readonly long[] Value=A262038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262038.Bytes);
public long this[int i]=>Value[i];

public static A262038Inst Instance=new A262038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262039
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,11L,11L,11L,11L,11L,11L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,33L,33L,33L,33L,33L,33L,33L,33L,33L,33L,33L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L,77L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262039Inst : IEnumerable<long>
{
public static readonly long[] Value=A262039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262039.Bytes);
public long this[int i]=>Value[i];

public static A262039Inst Instance=new A262039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262040
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,9L,11L,11L,11L,11L,11L,11L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,33L,33L,33L,33L,33L,33L,33L,33L,33L,33L,33L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L,77L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262040Inst : IEnumerable<long>
{
public static readonly long[] Value=A262040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262040.Bytes);
public long this[int i]=>Value[i];

public static A262040Inst Instance=new A262040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262041
{
public static readonly long[] Value={ 6L,3L,9L,3L,8L,2L,5L,6L,0L,7L,1L,1L,9L,6L,2L,3L,0L,2L,7L,8L,5L,7L,7L,7L,7L,4L,1L,0L,1L,9L,3L,4L,1L,4L,1L,2L,3L,4L,8L,1L,1L,3L,7L,9L,8L,4L,8L,2L,4L,8L,1L,9L,9L,3L,3L,1L,8L,7L,7L,8L,8L,6L,7L,8L,6L,8L,9L,9L,9L,6L,9L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262041Inst : IEnumerable<long>
{
public static readonly long[] Value=A262041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262041.Bytes);
public long this[int i]=>Value[i];

public static A262041Inst Instance=new A262041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262042
{
public static readonly long[] Value={ 4L,8L,25L,91L,115L,527L,527L,1331L,1331L,4301L,15689L,14111L,19337L,31427L,175151L,175151L,175151L,175151L,175151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262042Inst : IEnumerable<long>
{
public static readonly long[] Value=A262042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262042.Bytes);
public long this[int i]=>Value[i];

public static A262042Inst Instance=new A262042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262043
{
public static readonly long[] Value={ 561L,1105L,2821L,6601L,8911L,10585L,29341L,52633L,62745L,63973L,101101L,115921L,126217L,188461L,252601L,278545L,294409L,314821L,334153L,340561L,410041L,512461L,552721L,658801L,748657L,825265L,852841L,1024651L,1033669L,1082809L,1152271L,1193221L,1461241L,1569457L,1909001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262043Inst : IEnumerable<long>
{
public static readonly long[] Value=A262043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262043.Bytes);
public long this[int i]=>Value[i];

public static A262043Inst Instance=new A262043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262044
{
public static readonly long[] Value={ 9L,24L,45L,70L,97L,130L,165L,204L,249L,298L,349L,404L,461L,524L,589L,658L,733L,810L,891L,976L,1063L,1154L,1247L,1342L,1441L,1546L,1657L,1772L,1889L,2008L,2129L,2252L,2377L,2506L,2639L,2774L,2915L,3058L,3203L,3350L,3503L,3658L,3817L,3978L,4143L,4312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262044Inst : IEnumerable<long>
{
public static readonly long[] Value=A262044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262044.Bytes);
public long this[int i]=>Value[i];

public static A262044Inst Instance=new A262044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262045
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,2L,2L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262045Inst : IEnumerable<long>
{
public static readonly long[] Value=A262045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262045.Bytes);
public long this[int i]=>Value[i];

public static A262045Inst Instance=new A262045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262046
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,54L,460L,3890L,42364L,512806L,6698724L,98496252L,1585046584L,27568171818L,520043947020L,10550553510016L,228796551051436L,5291441028244966L,129967582592816500L,3377869204044947060L,BigInteger.Parse("92652519380506887784"),BigInteger.Parse("2674716530794339146244") };
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
public class A262046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262046Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262046.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262046.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262046Inst Instance=new A262046Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262047
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,66L,510L,4280L,46536L,542962L,7074654L,101914512L,1621871196L,28087868160L,526841965260L,10641234260358L,230278335503586L,5315641087796562L,130370690653563150L,3385534274596691456L,BigInteger.Parse("92801584815121975452"),BigInteger.Parse("2677687776095609649256") };
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
public class A262047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262047Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262047.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262047.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262047Inst Instance=new A262047Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262048
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,0L,0L,2L,3L,1L,1L,3L,3L,0L,0L,3L,4L,1L,2L,2L,1L,4L,4L,0L,0L,0L,0L,4L,5L,2L,1L,1L,2L,5L,5L,0L,2L,2L,0L,5L,6L,2L,1L,0L,0L,1L,2L,6L,6L,0L,0L,0L,0L,0L,0L,6L,7L,2L,4L,2L,2L,4L,2L,7L,7L,0L,0L,0L,0L,0L,0L,7L,8L,3L,1L,0L,0L,1L,3L,8L,8L,0L,2L,1L,2L,2L,1L,2L,0L,8L,9L,3L,2L,1L,1L,1L,1L,2L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262048Inst : IEnumerable<long>
{
public static readonly long[] Value=A262048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262048.Bytes);
public long this[int i]=>Value[i];

public static A262048Inst Instance=new A262048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262049
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,5L,7L,6L,6L,7L,11L,7L,0L,9L,8L,8L,0L,8L,0L,9L,10L,13L,0L,9L,10L,2L,9L,11L,0L,10L,0L,10L,14L,2L,12L,10L,0L,2L,3L,11L,0L,12L,0L,15L,11L,2L,0L,11L,14L,12L,3L,4L,0L,11L,16L,13L,3L,2L,0L,12L,0L,2L,13L,12L,5L,16L,0L,4L,3L,14L,0L,12L,0L,2L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262049Inst : IEnumerable<long>
{
public static readonly long[] Value=A262049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262049.Bytes);
public long this[int i]=>Value[i];

public static A262049Inst Instance=new A262049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262050
{
public static readonly long[] Value={ 1L,4L,11L,28L,63L,132L,264L,504L,928L,1660L,2892L,4924L,8221L,13480L,21750L,34592L,54288L,84168L,129048L,195816L,294282L,438324L,647413L,948748L,1380107L,1993632L,2860984L,4080172L,5784560L,8154900L,11435142L,15953124L,22147824L,30604868L,42102636L,57672312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262050Inst : IEnumerable<long>
{
public static readonly long[] Value=A262050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262050.Bytes);
public long this[int i]=>Value[i];

public static A262050Inst Instance=new A262050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262051
{
public static readonly long[] Value={ 121L,703L,1541L,1729L,1891L,2465L,2821L,3281L,4961L,7381L,8401L,8911L,10585L,12403L,15457L,15841L,16531L,18721L,19345L,23521L,24661L,28009L,29341L,30857L,31621L,31697L,41041L,44287L,46657L,47197L,49141L,50881L,52633L,55969L,63139L,63973L,72041L,74593L,75361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262051Inst : IEnumerable<long>
{
public static readonly long[] Value=A262051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262051.Bytes);
public long this[int i]=>Value[i];

public static A262051Inst Instance=new A262051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262052
{
public static readonly long[] Value={ 217L,781L,1541L,1729L,5461L,5611L,6601L,7449L,7813L,11041L,12801L,13021L,13333L,14981L,15751L,15841L,16297L,21361L,23653L,24211L,25351L,29539L,30673L,38081L,40501L,41041L,44173L,44801L,46657L,47641L,48133L,53971L,56033L,67921L,75361L,79381L,90241L,98173L,100651L,102311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262052Inst : IEnumerable<long>
{
public static readonly long[] Value=A262052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262052.Bytes);
public long this[int i]=>Value[i];

public static A262052Inst Instance=new A262052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262053
{
public static readonly long[] Value={ 185L,217L,301L,481L,1111L,1261L,1333L,1729L,2465L,2701L,3421L,3565L,3589L,3913L,5713L,6533L,8365L,10585L,11041L,11137L,12209L,14701L,15841L,17329L,18361L,20017L,21049L,22049L,29341L,31021L,31621L,34441L,36301L,38081L,39305L,39493L,41041L,43621L,44801L,46657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262053Inst : IEnumerable<long>
{
public static readonly long[] Value=A262053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262053.Bytes);
public long this[int i]=>Value[i];

public static A262053Inst Instance=new A262053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262054
{
public static readonly long[] Value={ 25L,325L,703L,817L,1825L,2101L,2353L,2465L,3277L,4525L,6697L,8321L,10225L,11041L,11521L,12025L,13665L,14089L,19345L,20197L,20417L,20425L,25829L,29857L,29891L,35425L,38081L,39331L,46657L,49241L,49321L,50881L,58825L,64681L,75241L,75361L,76627L,78937L,79381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262054Inst : IEnumerable<long>
{
public static readonly long[] Value=A262054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262054.Bytes);
public long this[int i]=>Value[i];

public static A262054Inst Instance=new A262054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262055
{
public static readonly long[] Value={ 9L,21L,65L,105L,133L,273L,341L,481L,511L,561L,585L,1001L,1105L,1281L,1417L,1541L,1661L,1729L,1905L,2047L,2465L,2501L,3201L,3277L,3641L,4033L,4097L,4641L,4681L,4921L,5461L,6305L,6533L,6601L,7161L,8321L,8481L,9265L,9709L,10261L,10585L,10745L,11041L,12545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262055Inst : IEnumerable<long>
{
public static readonly long[] Value=A262055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262055.Bytes);
public long this[int i]=>Value[i];

public static A262055Inst Instance=new A262055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262056
{
public static readonly long[] Value={ 1L,0L,2L,2L,0L,4L,4L,0L,10L,8L,0L,20L,14L,0L,36L,24L,0L,64L,42L,0L,108L,68L,0L,176L,108L,0L,280L,170L,0L,436L,260L,0L,666L,392L,0L,1000L,584L,0L,1480L,856L,0L,2160L,1240L,0L,3116L,1780L,0L,4448L,2526L,0L,6286L,3552L,0L,8804L,4956L,0L,12228L,6856L,0L,16852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262056Inst : IEnumerable<long>
{
public static readonly long[] Value=A262056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262056.Bytes);
public long this[int i]=>Value[i];

public static A262056Inst Instance=new A262056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262057
{
public static readonly long[] Value={ 0L,2L,1L,7L,5L,3L,21L,8L,6L,4L,23L,22L,16L,11L,9L,64L,26L,24L,17L,14L,10L,69L,65L,50L,25L,19L,15L,12L,71L,70L,67L,53L,48L,20L,18L,13L,193L,80L,78L,68L,59L,49L,34L,29L,27L,207L,194L,152L,79L,73L,62L,51L,35L,32L,28L,209L,208L,196L,161L,150L,74L,63L,52L,43L,33L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262057Inst : IEnumerable<long>
{
public static readonly long[] Value=A262057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262057.Bytes);
public long this[int i]=>Value[i];

public static A262057Inst Instance=new A262057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262058
{
public static readonly long[] Value={ 2L,2L,289L,681L,1280L,2109L,3190L,4538L,6170L,8100L,10339L,12901L,15795L,19032L,22620L,26570L,30888L,35583L,40662L,46133L,52003L,58277L,64962L,72065L,79590L,87544L,95932L,104759L,114030L,123750L,133924L,144557L,155652L,167215L,179250L,191760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262058Inst : IEnumerable<long>
{
public static readonly long[] Value=A262058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262058.Bytes);
public long this[int i]=>Value[i];

public static A262058Inst Instance=new A262058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262059
{
public static readonly long[] Value={ 2L,4913L,29410L,96854L,236916L,484596L,879483L,1465239L,2289183L,3401984L,4857388L,6712006L,9025131L,11858570L,15276512L,19345406L,24133846L,29712478L,36153913L,43532644L,51924974L,61408954L,72064316L,83972419L,97216198L,111880113L,128050105L,145813554L,165259239L,186477301L,209559205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262059Inst : IEnumerable<long>
{
public static readonly long[] Value=A262059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262059.Bytes);
public long this[int i]=>Value[i];

public static A262059Inst Instance=new A262059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262060
{
public static readonly BigInteger[] Value={ 2L,2L,4913L,463584L,58571590L,9380523077L,1831736082750L,423908600424675L,113798703080610442L,BigInteger.Parse("34848887401383308294"),BigInteger.Parse("12011778862556061365985"),BigInteger.Parse("4609276407921507486293833"),BigInteger.Parse("1951202873990586514532224545"),BigInteger.Parse("904205931392036935959059378623") };
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
public class A262060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262060Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262060.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262060.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262060Inst Instance=new A262060Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262061
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,11L,17L,17L,23L,29L,29L,37L,41L,53L,59L,67L,79L,89L,97L,127L,127L,137L,163L,179L,211L,223L,251L,293L,307L,337L,373L,419L,479L,521L,541L,587L,691L,727L,797L,853L,929L,1009L,1151L,1201L,1277L,1399L,1523L,1693L,1777L,1931L,2053L,2203L,2333L,2521L,2647L,2953L,3119L,3299L,3527L,3847L,4127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262061Inst : IEnumerable<long>
{
public static readonly long[] Value=A262061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262061.Bytes);
public long this[int i]=>Value[i];

public static A262061Inst Instance=new A262061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262062
{
public static readonly BigInteger[] Value={ 85L,2269L,58969L,1530985L,39746701L,1031883301L,26789219185L,695487815569L,18055893985669L,468757755811885L,12169645757123401L,315942031929396601L,8202323184407188285L,BigInteger.Parse("212944460762657498869"),BigInteger.Parse("5528353656644687782369"),BigInteger.Parse("143524250611999224842785") };
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
public class A262062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262062Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262062.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262062.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262062Inst Instance=new A262062Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262063
{
public static readonly BigInteger[] Value={ 78L,2100L,54594L,1417416L,36798294L,955338300L,24801997578L,643896598800L,16716509571294L,433985352254916L,11266902649056594L,292505483523216600L,7593875668954575078L,BigInteger.Parse("197148261909295735500"),BigInteger.Parse("5118260933972734547994"),BigInteger.Parse("132877636021381802512416") };
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
public class A262063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262063.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262063Inst Instance=new A262063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262064
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,3L,0L,5L,1L,7L,1L,11L,2L,15L,4L,22L,6L,30L,9L,42L,14L,56L,20L,77L,29L,101L,41L,135L,57L,176L,78L,231L,107L,297L,143L,385L,191L,490L,253L,627L,332L,793L,432L,1003L,561L,1257L,721L,1578L,924L,1963L,1177L,2443L,1492L,3022L,1882L,3734L,2367L,4589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262064Inst : IEnumerable<long>
{
public static readonly long[] Value=A262064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262064.Bytes);
public long this[int i]=>Value[i];

public static A262064Inst Instance=new A262064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262065
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,122L,183L,244L,305L,366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262065Inst : IEnumerable<long>
{
public static readonly long[] Value=A262065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262065.Bytes);
public long this[int i]=>Value[i];

public static A262065Inst Instance=new A262065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262066
{
public static readonly long[] Value={ 1L,2L,1L,4L,9L,7L,25L,8L,13L,7L,17L,10L,121L,27L,169L,16L,29L,39L,289L,12L,37L,19L,41L,26L,529L,47L,19L,133L,53L,34L,841L,32L,61L,31L,43L,93L,29L,35L,73L,217L,81L,63L,23L,50L,21L,43L,89L,58L,2209L,75L,97L,77L,101L,40L,2809L,36L,109L,343L,113L,74L,3481L,65L,3721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262066Inst : IEnumerable<long>
{
public static readonly long[] Value=A262066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262066.Bytes);
public long this[int i]=>Value[i];

public static A262066Inst Instance=new A262066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262067
{
public static readonly BigInteger[] Value={ 2L,4L,26L,240L,2882L,42560L,745418L,15097600L,347066882L,8926258176L,253930611002L,7916100448256L,268352394448322L,9828088361009152L,386707997366768618L,16268790735900180480UL,BigInteger.Parse("728714136550643404802"),BigInteger.Parse("34624041592426892361728") };
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
public class A262067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262067.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262067Inst Instance=new A262067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262068
{
public static readonly long[] Value={ 1L,2L,6L,22L,76L,268L,926L,3250L,11328L,39658L,138534L,484364L,1693078L,5918780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262068Inst : IEnumerable<long>
{
public static readonly long[] Value=A262068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262068.Bytes);
public long this[int i]=>Value[i];

public static A262068Inst Instance=new A262068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262069
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,44L,55L,55155L,55455L,55755L,57075L,57375L,113311L,148841L,2796972L,8372738L,11166111L,14033041L,26233262L,28933982L,150050051L,151141151L,152070251L,152232251L,153161351L,153323351L,154252451L,154414451L,155343551L,155505551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262069Inst : IEnumerable<long>
{
public static readonly long[] Value=A262069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262069.Bytes);
public long this[int i]=>Value[i];

public static A262069Inst Instance=new A262069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262070
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262070Inst : IEnumerable<long>
{
public static readonly long[] Value=A262070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262070.Bytes);
public long this[int i]=>Value[i];

public static A262070Inst Instance=new A262070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262071
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,6L,3L,1L,0L,24L,18L,4L,1L,0L,120L,90L,30L,5L,1L,0L,720L,630L,200L,45L,6L,1L,0L,5040L,4410L,1610L,350L,63L,7L,1L,0L,40320L,37800L,13440L,3290L,560L,84L,8L,1L,0L,362880L,340200L,130200L,30870L,5922L,840L,108L,9L,1L,0L,3628800L,3515400L,1327200L,334950L,61992L,9870L,1200L,135L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262071Inst : IEnumerable<long>
{
public static readonly long[] Value=A262071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262071.Bytes);
public long this[int i]=>Value[i];

public static A262071Inst Instance=new A262071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262072
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,4L,1L,10L,5L,1L,60L,15L,6L,1L,140L,21L,7L,1L,280L,224L,28L,8L,1L,1260L,630L,336L,36L,9L,1L,12600L,3780L,1050L,480L,45L,10L,1L,34650L,7392L,1650L,660L,55L,11L,1L,110880L,74844L,12672L,2475L,880L,66L,12L,1L,360360L,276276L,140712L,20592L,3575L,1144L,78L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262072Inst : IEnumerable<long>
{
public static readonly long[] Value=A262072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262072.Bytes);
public long this[int i]=>Value[i];

public static A262072Inst Instance=new A262072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262073
{
public static readonly BigInteger[] Value={ 1L,1L,4L,75L,14301L,40870872L,2163410250576L,2525542278491543715L,BigInteger.Parse("75742007488274337351844747"),BigInteger.Parse("66712890687959224726994385259183993"),BigInteger.Parse("1942822997098466460791474215498474580001684381"),BigInteger.Parse("2080073366817374333366496031890682227244159986035768679984") };
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
public class A262073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262073.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262073Inst Instance=new A262073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262074
{
public static readonly BigInteger[] Value={ 113L,3473L,104161L,3121441L,93539153L,2803053233L,83998057921L,2517138684481L,75430162476593L,2260387735613393L,67736201905925281L,2029825669442145121L,BigInteger.Parse("60827033881358428433"),BigInteger.Parse("1822781190771310707953"),BigInteger.Parse("54622608689257962810241"),BigInteger.Parse("1636855479486967573599361") };
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
public class A262074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262074Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262074.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262074.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262074Inst Instance=new A262074Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262075
{
public static readonly BigInteger[] Value={ 105L,3248L,97433L,2919840L,87497865L,2622016208L,78572988473L,2354567638080L,70558456154025L,2114399116982768L,63361415053329113L,1898728052482890720L,BigInteger.Parse("56898480159433392585"),BigInteger.Parse("1705055676730518886928"),BigInteger.Parse("51094771821756133215353"),BigInteger.Parse("1531138098975953477573760") };
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
public class A262075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262075Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262075.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262075.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262075Inst Instance=new A262075Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262076
{
public static readonly BigInteger[] Value={ 26L,598L,90688L,1891916L,285495236L,5955760408L,898738921678L,18748731881906L,2829229839956546L,59021002008489118L,8906414637444294568L,BigInteger.Parse("185798095573991870996"),BigInteger.Parse("28037390449444799352956"),BigInteger.Parse("584892345845924401415728"),BigInteger.Parse("88261696228437590918820358") };
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
public class A262076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262076Inst Instance=new A262076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262077
{
public static readonly BigInteger[] Value={ 15L,435L,66543L,1388283L,209496225L,4370333325L,659494068633L,13757807937693L,2076087118579335L,43309575017543115L,6535521589793696823L,BigInteger.Parse("136338528397417807203"),BigInteger.Parse("20573819888583439038345"),BigInteger.Parse("429193644085496239550805"),BigInteger.Parse("64766378473739076299032113") };
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
public class A262077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262077Inst Instance=new A262077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262078
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,4L,10L,60L,1L,5L,15L,140L,280L,1260L,12600L,1L,6L,21L,224L,630L,3780L,34650L,110880L,360360L,2522520L,37837800L,1L,7L,28L,336L,1050L,7392L,74844L,276276L,1513512L,9459450L,131171040L,428828400L,2058376320L,9777287520L,97772875200L,2053230379200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262078Inst : IEnumerable<long>
{
public static readonly long[] Value=A262078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262078.Bytes);
public long this[int i]=>Value[i];

public static A262078Inst Instance=new A262078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262079
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,61L,61L,61L,61L,61L,61L,61L,61L,61L,61L,61L,61L,61L,61L,61L,61L,61L,61L,61L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262079Inst : IEnumerable<long>
{
public static readonly long[] Value=A262079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262079.Bytes);
public long this[int i]=>Value[i];

public static A262079Inst Instance=new A262079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262080
{
public static readonly long[] Value={ 8L,2L,1L,0L,2L,1L,0L,5L,3L,8L,7L,4L,2L,2L,8L,7L,5L,6L,5L,2L,4L,1L,4L,1L,3L,9L,3L,2L,2L,9L,1L,5L,4L,9L,0L,6L,4L,4L,7L,0L,1L,0L,1L,3L,4L,0L,3L,3L,7L,5L,2L,3L,4L,5L,9L,4L,8L,2L,4L,9L,3L,2L,6L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262080Inst : IEnumerable<long>
{
public static readonly long[] Value=A262080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262080.Bytes);
public long this[int i]=>Value[i];

public static A262080Inst Instance=new A262080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262081
{
public static readonly long[] Value={ 6L,10L,210L,34L,399L,58L,651L,82L,903L,795L,1281L,142L,1533L,2739L,2037L,214L,6213L,1965L,2919L,298L,5285L,3423L,2595L,3801L,382L,12545L,7385L,4683L,3495L,5061L,8785L,3945L,5691L,562L,5943L,9669L,6447L,10461L,12909L,694L,7329L,5385L,12845L,7959L,5835L,13895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262081Inst : IEnumerable<long>
{
public static readonly long[] Value=A262081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262081.Bytes);
public long this[int i]=>Value[i];

public static A262081Inst Instance=new A262081Inst();

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