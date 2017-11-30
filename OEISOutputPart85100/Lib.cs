using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A105779
{
public static readonly long[] Value={ 24L,48L,54L,144L,288L,384L,648L,972L,1260L,1728L,1792L,1936L,1944L,2304L,3584L,5184L,6250L,6912L,7168L,8748L,8788L,9216L,9604L,10000L,10125L,10816L,11760L,13122L,13824L,17640L,21632L,21952L,23328L,24255L,25088L,26244L,27648L,33264L,35937L,37752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105779Inst : IEnumerable<long>
{
public static readonly long[] Value=A105779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105779.Bytes);
public long this[int i]=>Value[i];

public static A105779Inst Instance=new A105779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105780
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,10L,14L,19L,26L,35L,46L,61L,79L,102L,131L,167L,211L,266L,333L,415L,515L,636L,782L,959L,1171L,1425L,1729L,2091L,2521L,3033L,3637L,4351L,5193L,6183L,7345L,8708L,10301L,12161L,14331L,16856L,19789L,23195L,27139L,31703L,36978L,43063L,50075L,58148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105780Inst : IEnumerable<long>
{
public static readonly long[] Value=A105780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105780.Bytes);
public long this[int i]=>Value[i];

public static A105780Inst Instance=new A105780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105781
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,9L,12L,17L,23L,30L,40L,53L,68L,88L,113L,143L,181L,228L,284L,354L,439L,541L,665L,815L,993L,1208L,1465L,1769L,2132L,2563L,3070L,3671L,4379L,5209L,6185L,7329L,8663L,10223L,12041L,14153L,16609L,19459L,22755L,26571L,30979L,36059L,41915L,48654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105781Inst : IEnumerable<long>
{
public static readonly long[] Value=A105781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105781.Bytes);
public long this[int i]=>Value[i];

public static A105781Inst Instance=new A105781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105782
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,8L,11L,15L,20L,26L,34L,44L,56L,72L,91L,114L,144L,179L,222L,275L,338L,414L,507L,617L,748L,906L,1093L,1314L,1578L,1888L,2253L,2685L,3190L,3782L,4477L,5286L,6230L,7331L,8609L,10091L,11812L,13801L,16099L,18755L,21813L,25332L,29383L,34031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105782Inst : IEnumerable<long>
{
public static readonly long[] Value=A105782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105782.Bytes);
public long this[int i]=>Value[i];

public static A105782Inst Instance=new A105782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105783
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,0L,1L,2L,2L,1L,2L,0L,3L,0L,2L,1L,3L,1L,1L,2L,1L,1L,3L,1L,3L,2L,2L,1L,3L,2L,3L,1L,3L,1L,1L,1L,3L,2L,3L,2L,3L,1L,3L,1L,3L,1L,2L,2L,3L,3L,3L,2L,4L,1L,1L,3L,4L,2L,1L,0L,2L,1L,2L,0L,1L,2L,2L,3L,2L,3L,3L,1L,3L,1L,1L,2L,4L,1L,3L,3L,1L,1L,1L,4L,3L,2L,4L,3L,3L,3L,4L,1L,1L,2L,1L,0L,2L,3L,2L,0L,2L,0L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105783Inst : IEnumerable<long>
{
public static readonly long[] Value=A105783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105783.Bytes);
public long this[int i]=>Value[i];

public static A105783Inst Instance=new A105783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105784
{
public static readonly BigInteger[] Value={ 0L,1L,3L,19L,155L,1641L,21427L,334377L,6085683L,126745435L,2975448641L,77779634571L,2241339267037L,70604384569005L,2414086713172695L,89049201691604881L,3525160713653081279L,BigInteger.Parse("149075374211881719939"),BigInteger.Parse("6707440248292609651513"),BigInteger.Parse("319946143503599791200675") };
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
public class A105784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105784Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105784.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105784Inst Instance=new A105784Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105785
{
public static readonly BigInteger[] Value={ 1L,0L,2L,9L,76L,805L,10626L,167839L,3091768L,65127465L,1544951350L,40770052411L,1184951084340L,37616775522781L,1295202587597842L,48080003446006575L,1914305438178286576L,BigInteger.Parse("81379323738092982097"),BigInteger.Parse("3679128029385789284718"),BigInteger.Parse("176267238847686913800547") };
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
public class A105785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105785Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105785.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105785.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105785Inst Instance=new A105785Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105786
{
public static readonly long[] Value={ 0L,1L,0L,3L,0L,0L,16L,3L,0L,0L,125L,30L,0L,0L,0L,1296L,330L,15L,0L,0L,0L,16807L,4305L,315L,0L,0L,0L,0L,262144L,66248L,5880L,105L,0L,0L,0L,0L,4782969L,1183644L,115290L,3780L,0L,0L,0L,0L,0L,100000000L,24170310L,2467080L,107100L,945L,0L,0L,0L,0L,0L,2357947691L,556409535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105786Inst : IEnumerable<long>
{
public static readonly long[] Value=A105786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105786.Bytes);
public long this[int i]=>Value[i];

public static A105786Inst Instance=new A105786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105787
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,28L,795L,632167L,399635138154L,BigInteger.Parse("159708243647367169100509"),BigInteger.Parse("25506723088926795724936617220833650734525459594"),BigInteger.Parse("650592922735191299575059973922272937442761432150679274453311138653498403940208837571053997389") };
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
public class A105787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105787.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105787Inst Instance=new A105787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105788
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,16L,192L,29984L,776474136L,582837534997525192L,BigInteger.Parse("334033256143852482501323872038100184"),BigInteger.Parse("111432026121971983026248175426087984579225579894344486903683496908882296") };
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
public class A105788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105788Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105788.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105788.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105788Inst Instance=new A105788Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105789
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,4L,3L,2L,3L,4L,2L,1L,4L,1L,2L,4L,3L,2L,3L,4L,1L,2L,3L,2L,1L,3L,4L,1L,4L,3L,2L,1L,4L,1L,2L,4L,3L,2L,3L,4L,2L,1L,4L,1L,2L,3L,4L,1L,4L,3L,4L,3L,2L,3L,4L,1L,2L,3L,2L,1L,3L,4L,1L,4L,3L,1L,2L,3L,2L,1L,4L,3L,2L,3L,4L,3L,4L,1L,4L,3L,2L,1L,4L,1L,2L,4L,3L,2L,3L,4L,2L,1L,4L,1L,2L,3L,4L,1L,4L,3L,1L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105789Inst : IEnumerable<long>
{
public static readonly long[] Value=A105789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105789.Bytes);
public long this[int i]=>Value[i];

public static A105789Inst Instance=new A105789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105790
{
public static readonly long[] Value={ 1L,4L,4L,6L,8L,9L,11L,13L,14L,16L,17L,19L,21L,23L,25L,26L,27L,30L,31L,33L,34L,36L,38L,40L,41L,43L,45L,46L,47L,49L,53L,53L,54L,56L,58L,60L,61L,62L,65L,66L,67L,70L,71L,72L,75L,76L,78L,80L,83L,83L,84L,87L,89L,89L,91L,93L,94L,96L,98L,99L,100L,103L,105L,107L,107L,109L,112L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105790Inst : IEnumerable<long>
{
public static readonly long[] Value=A105790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105790.Bytes);
public long this[int i]=>Value[i];

public static A105790Inst Instance=new A105790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105791
{
public static readonly long[] Value={ 1L,2L,4L,2L,1L,4L,3L,1L,3L,4L,3L,4L,2L,4L,3L,4L,3L,1L,3L,4L,1L,2L,4L,2L,1L,3L,4L,2L,4L,3L,2L,1L,3L,1L,2L,1L,2L,4L,2L,1L,2L,1L,3L,1L,2L,3L,4L,2L,4L,3L,2L,1L,3L,1L,2L,3L,4L,2L,4L,3L,4L,3L,1L,3L,4L,3L,4L,2L,4L,3L,2L,1L,3L,1L,2L,3L,4L,2L,4L,3L,2L,1L,3L,1L,2L,1L,2L,4L,2L,1L,2L,1L,3L,1L,2L,3L,4L,2L,4L,3L,1L,2L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105791Inst : IEnumerable<long>
{
public static readonly long[] Value=A105791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105791.Bytes);
public long this[int i]=>Value[i];

public static A105791Inst Instance=new A105791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105792
{
public static readonly long[] Value={ 2L,3L,7L,13L,19L,23L,31L,37L,43L,47L,53L,61L,67L,73L,79L,83L,89L,97L,103L,109L,113L,127L,131L,139L,151L,157L,163L,167L,173L,181L,193L,199L,211L,223L,229L,233L,241L,251L,257L,263L,271L,277L,283L,293L,307L,313L,317L,331L,337L,349L,353L,359L,367L,373L,379L,383L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105792Inst : IEnumerable<long>
{
public static readonly long[] Value=A105792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105792.Bytes);
public long this[int i]=>Value[i];

public static A105792Inst Instance=new A105792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105793
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,-1L,0L,1L,0L,2L,-1L,-2L,1L,0L,-6L,5L,5L,-5L,1L,0L,24L,-26L,-15L,25L,-9L,1L,0L,-120L,154L,49L,-140L,70L,-14L,1L,0L,720L,-1044L,-140L,889L,-560L,154L,-20L,1L,0L,-5040L,8028L,-64L,-6363L,4809L,-1638L,294L,-27L,1L,0L,40320L,-69264L,8540L,50840L,-44835L,17913L,-3990L,510L,-35L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105793Inst : IEnumerable<long>
{
public static readonly long[] Value=A105793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105793.Bytes);
public long this[int i]=>Value[i];

public static A105793Inst Instance=new A105793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105794
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,1L,-1L,1L,0L,1L,1L,-1L,1L,2L,1L,-1L,1L,0L,5L,5L,1L,1L,-1L,1L,10L,20L,9L,1L,-1L,1L,0L,21L,70L,56L,14L,1L,1L,-1L,1L,42L,231L,294L,126L,20L,1L,-1L,1L,0L,85L,735L,1407L,924L,246L,27L,1L,1L,-1L,1L,170L,2290L,6363L,6027L,2400L,435L,35L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105794Inst : IEnumerable<long>
{
public static readonly long[] Value=A105794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105794.Bytes);
public long this[int i]=>Value[i];

public static A105794Inst Instance=new A105794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105795
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,7L,21L,67L,237L,907L,3741L,16507L,77517L,385627L,2024301L,11174587L,64673997L,391392667L,2470864941L,16237279867L,110858862477L,784987938907L,5755734591981L,43636725010747L,341615028340557L,2758165832945947L,22940755633301421L,196354180631212027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105795Inst : IEnumerable<long>
{
public static readonly long[] Value=A105795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105795.Bytes);
public long this[int i]=>Value[i];

public static A105795Inst Instance=new A105795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105796
{
public static readonly BigInteger[] Value={ 0L,1L,1L,13L,25L,541L,1561L,47293L,181945L,7087261L,34082521L,1622632573L,9363855865L,526858348381L,3547114323481L,230283190977853L,1771884893993785L,130370767029135901L,1128511554418948441L,BigInteger.Parse("92801587319328411133") };
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
public class A105796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105796.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105796Inst Instance=new A105796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105797
{
public static readonly BigInteger[] Value={ 0L,1L,3L,19L,135L,1291L,14343L,188539L,2815095L,47412811L,886239783L,18231365659L,409053408855L,9943622273131L,260300948527623L,7300927107288379L,218426614502831415L,6943261704033434251L,BigInteger.Parse("233692323131307301863") };
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
public class A105797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105797Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105797.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105797.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105797Inst Instance=new A105797Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105798
{
public static readonly long[] Value={ 6L,8L,6L,1L,8L,9L,3L,2L,7L,3L,5L,5L,2L,3L,2L,9L,9L,3L,1L,3L,3L,2L,9L,1L,2L,9L,6L,9L,0L,6L,4L,8L,9L,5L,9L,1L,5L,1L,4L,7L,3L,0L,4L,2L,2L,5L,1L,2L,6L,8L,0L,7L,3L,2L,0L,0L,3L,1L,7L,1L,4L,8L,9L,8L,1L,5L,2L,5L,5L,0L,9L,1L,0L,1L,3L,3L,5L,2L,8L,7L,3L,5L,3L,7L,3L,7L,4L,8L,7L,9L,8L,7L,8L,4L,2L,5L,8L,1L,5L,6L,5L,8L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105798Inst : IEnumerable<long>
{
public static readonly long[] Value=A105798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105798.Bytes);
public long this[int i]=>Value[i];

public static A105798Inst Instance=new A105798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105799
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,11L,13L,17L,19L,20L,21L,22L,24L,25L,26L,29L,31L,37L,41L,43L,47L,53L,59L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,140L,141L,142L,143L,144L,145L,146L,147L,148L,150L,152L,153L,154L,155L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105799Inst : IEnumerable<long>
{
public static readonly long[] Value=A105799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105799.Bytes);
public long this[int i]=>Value[i];

public static A105799Inst Instance=new A105799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105800
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,2L,5L,1L,8L,1L,13L,5L,21L,1L,34L,1L,55L,13L,89L,1L,144L,5L,233L,34L,377L,1L,610L,1L,987L,89L,1597L,13L,2584L,1L,4181L,233L,6765L,1L,10946L,1L,17711L,610L,28657L,1L,46368L,13L,75025L,1597L,121393L,1L,196418L,89L,317811L,4181L,514229L,1L,832040L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105800Inst : IEnumerable<long>
{
public static readonly long[] Value=A105800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105800.Bytes);
public long this[int i]=>Value[i];

public static A105800Inst Instance=new A105800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105801
{
public static readonly long[] Value={ 1L,2L,10L,6L,8L,7L,46L,160L,103L,790L,2680L,1735L,13246L,44944L,29095L,222118L,753640L,487879L,3724558L,12637312L,8180935L,62454742L,211907032L,137180887L,1047263758L,3553333936L,2300298847L,17560898350L,59583591592L,38572244971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105801Inst : IEnumerable<long>
{
public static readonly long[] Value=A105801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105801.Bytes);
public long this[int i]=>Value[i];

public static A105801Inst Instance=new A105801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105802
{
public static readonly long[] Value={ 1L,3L,6L,15L,12L,45L,24L,36L,48L,405L,60L,315L,192L,144L,120L,945L,180L,1575L,240L,576L,3072L,295245L,360L,1296L,12288L,900L,960L,25515L,720L,14175L,840L,9216L,196608L,5184L,1260L,17325L,786432L,36864L,1680L,31185L,2880L,127575L,15360L,3600L,99225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105802Inst : IEnumerable<long>
{
public static readonly long[] Value=A105802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105802.Bytes);
public long this[int i]=>Value[i];

public static A105802Inst Instance=new A105802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105803
{
public static readonly long[] Value={ 4L,6L,8L,9L,11L,13L,17L,19L,23L,29L,30L,32L,33L,34L,35L,36L,38L,39L,41L,43L,47L,53L,59L,61L,67L,71L,73L,74L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105803Inst : IEnumerable<long>
{
public static readonly long[] Value=A105803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105803.Bytes);
public long this[int i]=>Value[i];

public static A105803Inst Instance=new A105803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105804
{
public static readonly BigInteger[] Value={ 0L,1L,1L,3L,9L,42L,282L,2802L,42348L,984576L,35804724L,2056887084L,188218830732L,27582766315980L,6497743050809304L,2466474617607855408L,BigInteger.Parse("1510962789131940581928"),BigInteger.Parse("1495259232837545099449512"),BigInteger.Parse("2391833322688676458284572616"),BigInteger.Parse("6186748984680033744268134049416") };
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
public class A105804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105804Inst Instance=new A105804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105805
{
public static readonly long[] Value={ 0L,1L,-1L,2L,0L,-2L,3L,1L,0L,-1L,-3L,4L,2L,1L,0L,-1L,-2L,-4L,5L,3L,2L,1L,1L,0L,-1L,-1L,-2L,-3L,-5L,6L,4L,3L,2L,2L,1L,0L,0L,0L,-1L,-2L,-2L,-3L,-4L,-6L,7L,5L,4L,3L,2L,3L,2L,1L,1L,0L,1L,0L,-1L,-1L,-2L,-1L,-2L,-3L,-3L,-4L,-5L,-7L,8L,6L,5L,4L,3L,4L,3L,2L,1L,2L,1L,0L,2L,1L,0L,0L,-1L,-1L,0L,-1L,-2L,-2L,-3L,-2L,-3L,-4L,-4L,-5L,-6L,-8L,9L,7L,6L,5L,4L,3L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105805Inst : IEnumerable<long>
{
public static readonly long[] Value=A105805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105805.Bytes);
public long this[int i]=>Value[i];

public static A105805Inst Instance=new A105805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105806
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,2L,1L,1L,0L,1L,3L,1L,2L,1L,1L,0L,1L,2L,3L,2L,2L,1L,1L,0L,1L,4L,3L,3L,2L,2L,1L,1L,0L,1L,4L,5L,3L,4L,2L,2L,1L,1L,0L,1L,6L,5L,6L,3L,4L,2L,2L,1L,1L,0L,1L,7L,8L,6L,6L,4L,4L,2L,2L,1L,1L,0L,1L,11L,8L,9L,7L,6L,4L,4L,2L,2L,1L,1L,0L,1L,11L,13L,10L,10L,7L,7L,4L,4L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105806Inst : IEnumerable<long>
{
public static readonly long[] Value=A105806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105806.Bytes);
public long this[int i]=>Value[i];

public static A105806Inst Instance=new A105806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105807
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,12L,18L,29L,42L,61L,87L,125L,172L,235L,320L,437L,580L,759L,1002L,1329L,1718L,2191L,2784L,3624L,4633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105807Inst : IEnumerable<long>
{
public static readonly long[] Value=A105807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105807.Bytes);
public long this[int i]=>Value[i];

public static A105807Inst Instance=new A105807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105808
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,22L,23L,44L,46L,48L,52L,53L,55L,57L,64L,72L,84L,222L,444L,452L,524L,644L,722L,723L,844L,852L,2222L,2244L,4442L,5444L,6422L,7444L,8422L,22444L,44222L,52224L,64444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105808Inst : IEnumerable<long>
{
public static readonly long[] Value=A105808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105808.Bytes);
public long this[int i]=>Value[i];

public static A105808Inst Instance=new A105808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105809
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,4L,3L,1L,5L,7L,7L,4L,1L,8L,12L,14L,11L,5L,1L,13L,20L,26L,25L,16L,6L,1L,21L,33L,46L,51L,41L,22L,7L,1L,34L,54L,79L,97L,92L,63L,29L,8L,1L,55L,88L,133L,176L,189L,155L,92L,37L,9L,1L,89L,143L,221L,309L,365L,344L,247L,129L,46L,10L,1L,144L,232L,364L,530L,674L,709L,591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105809Inst : IEnumerable<long>
{
public static readonly long[] Value=A105809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105809.Bytes);
public long this[int i]=>Value[i];

public static A105809Inst Instance=new A105809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105810
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-2L,1L,1L,2L,-3L,1L,-2L,-1L,5L,-4L,1L,3L,-1L,-6L,9L,-5L,1L,-4L,4L,5L,-15L,14L,-6L,1L,5L,-8L,-1L,20L,-29L,20L,-7L,1L,-6L,13L,-7L,-21L,49L,-49L,27L,-8L,1L,7L,-19L,20L,14L,-70L,98L,-76L,35L,-9L,1L,-8L,26L,-39L,6L,84L,-168L,174L,-111L,44L,-10L,1L,9L,-34L,65L,-45L,-78L,252L,-342L,285L,-155L,54L,-11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105810Inst : IEnumerable<long>
{
public static readonly long[] Value=A105810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105810.Bytes);
public long this[int i]=>Value[i];

public static A105810Inst Instance=new A105810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105811
{
public static readonly long[] Value={ 1L,-1L,0L,1L,-2L,3L,-4L,5L,-6L,7L,-8L,9L,-10L,11L,-12L,13L,-14L,15L,-16L,17L,-18L,19L,-20L,21L,-22L,23L,-24L,25L,-26L,27L,-28L,29L,-30L,31L,-32L,33L,-34L,35L,-36L,37L,-38L,39L,-40L,41L,-42L,43L,-44L,45L,-46L,47L,-48L,49L,-50L,51L,-52L,53L,-54L,55L,-56L,57L,-58L,59L,-60L,61L,-62L,63L,-64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105811Inst : IEnumerable<long>
{
public static readonly long[] Value=A105811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105811.Bytes);
public long this[int i]=>Value[i];

public static A105811Inst Instance=new A105811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105812
{
public static readonly long[] Value={ 1L,0L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105812Inst : IEnumerable<long>
{
public static readonly long[] Value=A105812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105812.Bytes);
public long this[int i]=>Value[i];

public static A105812Inst Instance=new A105812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105813
{
public static readonly long[] Value={ 2L,23L,24L,44L,52L,55L,552L,563L,666L,672L,683L,772L,834L,922L,2223L,2456L,3333L,3423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105813Inst : IEnumerable<long>
{
public static readonly long[] Value=A105813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105813.Bytes);
public long this[int i]=>Value[i];

public static A105813Inst Instance=new A105813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105814
{
public static readonly long[] Value={ 12L,26L,42L,60L,80L,102L,126L,152L,180L,1110L,1232L,1356L,1482L,1610L,1740L,1872L,2006L,2142L,2280L,2420L,2562L,2706L,2852L,3000L,3150L,3302L,3456L,3612L,3770L,3930L,4092L,4256L,4422L,4590L,4760L,4932L,5106L,5282L,5460L,5640L,5822L,6006L,6192L,6380L,6570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105814Inst : IEnumerable<long>
{
public static readonly long[] Value=A105814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105814.Bytes);
public long this[int i]=>Value[i];

public static A105814Inst Instance=new A105814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105815
{
public static readonly long[] Value={ 2L,6L,6L,3L,5L,2L,5L,6L,3L,4L,8L,0L,6L,8L,5L,6L,5L,4L,4L,9L,8L,9L,4L,4L,6L,7L,3L,2L,7L,2L,1L,9L,5L,5L,1L,4L,5L,9L,9L,9L,2L,2L,9L,8L,2L,6L,8L,9L,2L,7L,2L,9L,3L,2L,9L,1L,4L,8L,3L,3L,7L,0L,5L,8L,6L,8L,0L,2L,3L,8L,8L,4L,8L,7L,9L,0L,3L,9L,3L,2L,9L,9L,3L,5L,6L,4L,3L,9L,6L,0L,5L,6L,8L,6L,4L,2L,4L,5L,5L,9L,9L,1L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105815Inst : IEnumerable<long>
{
public static readonly long[] Value=A105815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105815.Bytes);
public long this[int i]=>Value[i];

public static A105815Inst Instance=new A105815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105816
{
public static readonly long[] Value={ 2L,1L,1L,1L,34L,1L,2L,2L,2L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,9L,7L,1L,9L,1L,5L,1L,5L,1L,2L,7L,2L,2L,3L,5L,2L,1L,10L,8L,2L,3L,1L,1L,1L,12L,1L,1L,5L,4L,4L,2L,1L,1L,2L,2L,4L,13L,2L,2L,12L,3L,11L,15L,2L,2L,2L,23L,8L,1L,1L,3L,1L,2L,8L,19L,1L,5L,2L,7L,4L,1L,82L,22L,1L,1L,1L,2L,1L,1L,9L,1L,1L,1L,15L,8L,12L,2L,11L,1L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105816Inst : IEnumerable<long>
{
public static readonly long[] Value=A105816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105816.Bytes);
public long this[int i]=>Value[i];

public static A105816Inst Instance=new A105816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105817
{
public static readonly long[] Value={ 1L,6L,6L,1L,9L,8L,2L,4L,6L,2L,3L,2L,7L,8L,1L,1L,5L,5L,7L,9L,6L,7L,6L,0L,6L,0L,8L,1L,8L,1L,5L,1L,3L,1L,2L,9L,5L,0L,5L,6L,1L,6L,7L,5L,6L,2L,4L,6L,5L,0L,3L,5L,0L,0L,8L,2L,9L,9L,0L,6L,8L,0L,6L,7L,4L,3L,0L,6L,2L,9L,7L,2L,3L,5L,9L,8L,9L,5L,7L,3L,8L,1L,0L,8L,1L,7L,1L,6L,7L,0L,4L,1L,1L,0L,8L,4L,9L,2L,6L,6L,6L,9L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105817Inst : IEnumerable<long>
{
public static readonly long[] Value=A105817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105817.Bytes);
public long this[int i]=>Value[i];

public static A105817Inst Instance=new A105817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105818
{
public static readonly long[] Value={ 1L,1L,1L,1L,23L,18L,1L,1L,1L,1L,1L,1L,2L,1L,22L,2L,1L,53L,1L,1L,10L,1L,1L,17L,2L,4L,1L,27L,1L,2L,422L,3L,3L,13L,12L,5L,28L,1L,3L,1L,2L,1L,3L,2L,4L,6L,6L,3L,5L,50L,1L,1L,6L,3L,2L,1L,118L,2L,1L,1L,2L,6L,1L,4L,1L,1L,5L,2L,3L,3L,16L,1L,4L,6L,2L,2L,22L,4L,3L,10L,1L,1L,49L,5L,1L,1L,12L,1L,1L,3L,13L,3L,10L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105818Inst : IEnumerable<long>
{
public static readonly long[] Value=A105818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105818.Bytes);
public long this[int i]=>Value[i];

public static A105818Inst Instance=new A105818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105819
{
public static readonly long[] Value={ 0L,2L,0L,9L,0L,0L,64L,12L,0L,0L,625L,180L,0L,0L,0L,7776L,2730L,120L,0L,0L,0L,117649L,46410L,3780L,0L,0L,0L,0L,2097152L,893816L,99120L,1680L,0L,0L,0L,0L,43046721L,19389384L,2600640L,90720L,0L,0L,0L,0L,0L,1000000000L,469532790L,71734320L,3654000L,30240L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105819Inst : IEnumerable<long>
{
public static readonly long[] Value=A105819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105819.Bytes);
public long this[int i]=>Value[i];

public static A105819Inst Instance=new A105819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105820
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,2L,1L,0L,0L,3L,1L,0L,0L,0L,6L,3L,1L,0L,0L,0L,11L,5L,1L,0L,0L,0L,0L,23L,12L,3L,1L,0L,0L,0L,0L,47L,23L,6L,1L,0L,0L,0L,0L,0L,106L,52L,14L,3L,1L,0L,0L,0L,0L,0L,235L,110L,29L,6L,1L,0L,0L,0L,0L,0L,0L,551L,253L,68L,15L,3L,1L,0L,0L,0L,0L,0L,0L,1301L,570L,148L,31L,6L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105820Inst : IEnumerable<long>
{
public static readonly long[] Value=A105820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105820.Bytes);
public long this[int i]=>Value[i];

public static A105820Inst Instance=new A105820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105821
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,2L,2L,1L,1L,0L,3L,3L,2L,1L,1L,0L,6L,6L,4L,2L,1L,1L,0L,11L,11L,7L,4L,2L,1L,1L,0L,23L,23L,14L,8L,4L,2L,1L,1L,0L,47L,46L,29L,15L,8L,4L,2L,1L,1L,0L,106L,99L,60L,32L,16L,8L,4L,2L,1L,1L,0L,235L,216L,128L,66L,33L,16L,8L,4L,2L,1L,1L,0L,551L,488L,284L,143L,69L,34L,16L,8L,4L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105821Inst : IEnumerable<long>
{
public static readonly long[] Value=A105821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105821.Bytes);
public long this[int i]=>Value[i];

public static A105821Inst Instance=new A105821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105822
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,4L,12L,7L,10L,17L,6L,11L,21L,32L,13L,19L,14L,33L,20L,28L,24L,27L,42L,40L,18L,9L,35L,44L,39L,54L,48L,22L,15L,37L,52L,89L,30L,59L,23L,36L,99L,70L,16L,86L,47L,45L,92L,65L,157L,34L,123L,135L,222L,56L,136L,82L,29L,53L,102L,155L,25L,130L,87L,43L,170L,213L,63L,150L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105822Inst : IEnumerable<long>
{
public static readonly long[] Value=A105822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105822.Bytes);
public long this[int i]=>Value[i];

public static A105822Inst Instance=new A105822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105823
{
public static readonly long[] Value={ 16L,49L,121L,144L,400L,256L,529L,576L,529L,784L,625L,1849L,2116L,2601L,1089L,2704L,2209L,4096L,2704L,3600L,4761L,6084L,4624L,1764L,2601L,2809L,7396L,11025L,10404L,7056L,3364L,3481L,4489L,15876L,14161L,21904L,6241L,9025L,10404L,19881L,11236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105823Inst : IEnumerable<long>
{
public static readonly long[] Value=A105823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105823.Bytes);
public long this[int i]=>Value[i];

public static A105823Inst Instance=new A105823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105824
{
public static readonly long[] Value={ 1L,3L,0L,3L,2L,0L,0L,3L,1L,2L,0L,0L,2L,0L,0L,3L,2L,3L,0L,2L,0L,0L,0L,0L,3L,2L,0L,0L,2L,0L,0L,3L,0L,2L,0L,3L,2L,0L,0L,2L,2L,0L,0L,0L,2L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,3L,0L,0L,0L,2L,0L,0L,0L,3L,2L,2L,0L,0L,0L,0L,0L,2L,1L,2L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,2L,3L,0L,1L,2L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105824Inst : IEnumerable<long>
{
public static readonly long[] Value=A105824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105824.Bytes);
public long this[int i]=>Value[i];

public static A105824Inst Instance=new A105824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105825
{
public static readonly long[] Value={ 1L,3L,4L,2L,1L,2L,3L,0L,3L,3L,2L,3L,4L,4L,4L,1L,3L,4L,0L,2L,2L,1L,4L,0L,1L,2L,0L,1L,0L,2L,2L,3L,3L,4L,3L,1L,3L,0L,1L,0L,2L,1L,4L,4L,3L,2L,3L,4L,2L,3L,2L,3L,4L,0L,2L,0L,0L,0L,0L,3L,2L,1L,4L,2L,4L,4L,3L,1L,1L,4L,2L,0L,4L,4L,4L,0L,1L,3L,0L,1L,1L,1L,4L,4L,3L,2L,0L,0L,0L,4L,2L,3L,3L,4L,0L,2L,3L,1L,1L,2L,2L,1L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105825Inst : IEnumerable<long>
{
public static readonly long[] Value=A105825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105825.Bytes);
public long this[int i]=>Value[i];

public static A105825Inst Instance=new A105825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105826
{
public static readonly long[] Value={ 1L,3L,4L,0L,6L,5L,1L,1L,6L,4L,5L,0L,0L,3L,3L,3L,4L,4L,6L,0L,4L,1L,3L,4L,3L,0L,5L,0L,2L,2L,4L,0L,6L,5L,6L,0L,3L,4L,0L,6L,0L,5L,2L,0L,1L,2L,6L,5L,1L,2L,2L,0L,5L,1L,2L,1L,3L,6L,4L,0L,6L,5L,6L,1L,0L,4L,5L,0L,5L,4L,2L,6L,4L,2L,5L,0L,5L,0L,3L,4L,2L,0L,0L,0L,3L,6L,1L,5L,6L,3L,0L,0L,2L,4L,1L,0L,0L,3L,2L,0L,4L,6L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105826Inst : IEnumerable<long>
{
public static readonly long[] Value=A105826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105826.Bytes);
public long this[int i]=>Value[i];

public static A105826Inst Instance=new A105826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105827
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,4L,0L,7L,5L,2L,4L,4L,6L,0L,0L,7L,2L,7L,4L,2L,0L,4L,0L,4L,7L,2L,0L,0L,6L,0L,0L,7L,0L,6L,0L,3L,6L,4L,0L,2L,2L,0L,4L,4L,6L,0L,0L,4L,1L,5L,0L,2L,6L,0L,0L,0L,0L,2L,4L,0L,6L,0L,0L,7L,4L,0L,4L,6L,0L,0L,0L,3L,2L,2L,4L,4L,0L,0L,0L,2L,1L,6L,4L,0L,4L,4L,0L,4L,2L,2L,0L,0L,0L,0L,0L,4L,2L,3L,4L,1L,6L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105827Inst : IEnumerable<long>
{
public static readonly long[] Value=A105827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105827.Bytes);
public long this[int i]=>Value[i];

public static A105827Inst Instance=new A105827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105828
{
public static readonly long[] Value={ 1L,3L,4L,7L,2L,5L,12L,9L,21L,8L,13L,6L,19L,11L,30L,41L,15L,26L,24L,50L,14L,36L,18L,10L,28L,38L,66L,20L,16L,48L,45L,93L,72L,165L,63L,102L,96L,198L,105L,23L,62L,85L,58L,27L,31L,46L,32L,78L,47L,43L,90L,117L,22L,95L,53L,42L,128L,40L,25L,65L,68L,124L,79L,129L,208L,100L,108L,184L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105828Inst : IEnumerable<long>
{
public static readonly long[] Value=A105828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105828.Bytes);
public long this[int i]=>Value[i];

public static A105828Inst Instance=new A105828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105829
{
public static readonly long[] Value={ 1L,4L,5L,6L,8L,14L,9L,18L,7L,11L,30L,41L,15L,26L,21L,17L,38L,39L,27L,12L,20L,13L,33L,46L,19L,2L,72L,74L,23L,51L,54L,96L,24L,36L,60L,56L,32L,78L,47L,10L,37L,65L,102L,167L,67L,100L,68L,59L,105L,164L,45L,119L,48L,71L,29L,42L,135L,132L,3L,129L,270L,351L,66L,40L,64L,90L,61L,53L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105829Inst : IEnumerable<long>
{
public static readonly long[] Value=A105829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105829.Bytes);
public long this[int i]=>Value[i];

public static A105829Inst Instance=new A105829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105830
{
public static readonly long[] Value={ 1L,5L,6L,8L,14L,4L,10L,24L,18L,15L,3L,12L,36L,21L,2L,19L,33L,52L,28L,27L,55L,78L,16L,62L,35L,87L,54L,141L,25L,46L,71L,42L,29L,13L,90L,7L,26L,45L,50L,80L,40L,75L,115L,58L,57L,43L,44L,84L,53L,22L,31L,60L,91L,37L,20L,17L,63L,110L,32L,96L,56L,132L,108L,135L,138L,61L,65L,114L,143L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105830Inst : IEnumerable<long>
{
public static readonly long[] Value=A105830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105830.Bytes);
public long this[int i]=>Value[i];

public static A105830Inst Instance=new A105830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105831
{
public static readonly long[] Value={ 1L,6L,7L,3L,4L,15L,19L,8L,11L,10L,21L,13L,18L,16L,2L,5L,12L,9L,30L,24L,54L,33L,17L,26L,43L,28L,71L,39L,32L,55L,87L,46L,25L,66L,27L,93L,22L,56L,78L,23L,31L,114L,40L,74L,36L,38L,68L,106L,60L,166L,42L,124L,110L,14L,48L,62L,85L,58L,143L,86L,57L,29L,140L,169L,51L,118L,45L,52L,76L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105831Inst : IEnumerable<long>
{
public static readonly long[] Value=A105831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105831.Bytes);
public long this[int i]=>Value[i];

public static A105831Inst Instance=new A105831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105832
{
public static readonly long[] Value={ 1L,7L,8L,12L,20L,13L,15L,22L,5L,3L,2L,16L,18L,9L,14L,23L,10L,33L,19L,52L,71L,21L,50L,39L,11L,28L,64L,60L,4L,17L,42L,27L,24L,35L,26L,48L,74L,30L,44L,32L,51L,83L,38L,45L,62L,56L,6L,36L,96L,57L,153L,54L,99L,63L,86L,80L,166L,85L,81L,46L,127L,75L,202L,69L,133L,136L,165L,91L,114L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105832Inst : IEnumerable<long>
{
public static readonly long[] Value=A105832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105832.Bytes);
public long this[int i]=>Value[i];

public static A105832Inst Instance=new A105832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105833
{
public static readonly long[] Value={ 1L,8L,9L,14L,23L,10L,13L,3L,16L,12L,4L,5L,6L,11L,2L,40L,42L,27L,15L,22L,37L,24L,61L,33L,28L,45L,7L,38L,77L,48L,20L,50L,30L,36L,66L,26L,92L,118L,82L,200L,138L,47L,31L,78L,109L,35L,74L,57L,17L,124L,96L,79L,135L,46L,21L,25L,34L,32L,72L,44L,116L,69L,95L,86L,153L,98L,55L,43L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105833Inst : IEnumerable<long>
{
public static readonly long[] Value=A105833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105833.Bytes);
public long this[int i]=>Value[i];

public static A105833Inst Instance=new A105833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105834
{
public static readonly long[] Value={ 1L,9L,10L,16L,8L,3L,5L,2L,7L,4L,11L,15L,14L,29L,18L,47L,21L,26L,32L,40L,12L,28L,17L,6L,23L,13L,36L,49L,46L,95L,50L,45L,35L,80L,75L,155L,22L,69L,76L,33L,43L,20L,63L,68L,91L,27L,64L,51L,115L,44L,71L,34L,37L,62L,24L,38L,25L,48L,73L,70L,143L,60L,83L,19L,102L,72L,30L,42L,144L,96L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105834Inst : IEnumerable<long>
{
public static readonly long[] Value=A105834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105834.Bytes);
public long this[int i]=>Value[i];

public static A105834Inst Instance=new A105834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105835
{
public static readonly long[] Value={ 1L,10L,11L,6L,5L,4L,9L,13L,22L,8L,14L,15L,26L,21L,17L,30L,47L,19L,28L,20L,33L,27L,60L,7L,2L,24L,56L,34L,12L,46L,36L,82L,50L,32L,18L,45L,38L,35L,3L,54L,57L,25L,42L,16L,58L,63L,106L,40L,66L,43L,23L,126L,72L,104L,70L,61L,39L,100L,51L,49L,156L,160L,31L,129L,130L,144L,162L,81L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105835Inst : IEnumerable<long>
{
public static readonly long[] Value=A105835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105835.Bytes);
public long this[int i]=>Value[i];

public static A105835Inst Instance=new A105835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105836
{
public static readonly long[] Value={ 2L,3L,5L,8L,4L,12L,7L,10L,17L,6L,11L,21L,32L,13L,19L,14L,33L,20L,28L,24L,27L,42L,40L,18L,1L,39L,82L,72L,154L,43L,35L,78L,56L,22L,9L,31L,70L,69L,52L,25L,48L,73L,46L,119L,57L,26L,15L,36L,51L,50L,101L,60L,41L,54L,95L,61L,16L,45L,76L,121L,62L,59L,130L,141L,81L,222L,63L,87L,30L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105836Inst : IEnumerable<long>
{
public static readonly long[] Value=A105836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105836.Bytes);
public long this[int i]=>Value[i];

public static A105836Inst Instance=new A105836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105837
{
public static readonly BigInteger[] Value={ 1L,131L,529L,52139L,210541L,20751191L,83794789L,8258921879L,33350115481L,3287030156651L,13273262166649L,1308229743425219L,5282724992210821L,520672150853080511L,2102511273637740109L,BigInteger.Parse("207226207809782618159"),BigInteger.Parse("836794204182828352561") };
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
public class A105837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105837.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105837Inst Instance=new A105837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105838
{
public static readonly BigInteger[] Value={ 0L,39L,159L,15720L,63480L,6256719L,25265079L,2490158640L,10055438160L,991076882199L,4002039122799L,394446108956760L,1592801515436040L,156988560287908479L,633931001104421319L,BigInteger.Parse("62481052548478618080"),BigInteger.Parse("252302945638044249120"),BigInteger.Parse("24867301925734202087559") };
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
public class A105838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105838Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105838.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105838.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105838Inst Instance=new A105838Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105839
{
public static readonly BigInteger[] Value={ 1L,37L,2927L,68171L,183769L,4280053L,338355383L,7880431259L,21243328861L,494765566657L,39113205561107L,910962092609711L,2455686329490109L,57193909970135833L,4521408336114491603L,BigInteger.Parse("105305395973616940919"),BigInteger.Parse("283872428295154291321"),BigInteger.Parse("6611501604232996456477") };
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
public class A105839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105839.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105839Inst Instance=new A105839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105840
{
public static readonly long[] Value={ 2L,11L,17L,23L,31L,37L,41L,47L,59L,67L,71L,73L,79L,83L,89L,97L,101L,103L,109L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,191L,197L,199L,211L,223L,227L,233L,239L,241L,257L,263L,269L,271L,277L,281L,283L,293L,307L,311L,313L,331L,347L,349L,353L,359L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105840Inst : IEnumerable<long>
{
public static readonly long[] Value=A105840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105840.Bytes);
public long this[int i]=>Value[i];

public static A105840Inst Instance=new A105840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105841
{
public static readonly BigInteger[] Value={ 1L,309L,50469L,8242961L,17484559L,2855704251L,466414209771L,76178131891679L,161585265485281L,26391270694632789L,4310412628191203589L,BigInteger.Parse("704007671333868620081"),BigInteger.Parse("1493306066338224434479"),BigInteger.Parse("243897514468974137852571"),BigInteger.Parse("39835100723866104291485451") };
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
public class A105841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105841Inst Instance=new A105841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105842
{
public static readonly BigInteger[] Value={ 0L,55L,9064L,1480479L,3140319L,512899624L,83770465015L,13681996386240L,29021570410560L,4740012143979895L,774172961946305704L,BigInteger.Parse("126443510439085951839"),BigInteger.Parse("268205687063091955359"),BigInteger.Parse("43805286749779801393384"),BigInteger.Parse("7154595296776971135630775"),BigInteger.Parse("1168540093186822172351633280") };
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
public class A105842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105842.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105842Inst Instance=new A105842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105843
{
public static readonly BigInteger[] Value={ 1L,149L,295L,21755L,43069L,3176081L,6287779L,463686071L,917972665L,67694990285L,134017721311L,9883004895539L,19565669338741L,1442851019758409L,2856453705734875L,210646365879832175L,417022675367953009L,BigInteger.Parse("30752926567435739141"),BigInteger.Parse("60882454150015404439") };
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
public class A105843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105843.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105843Inst Instance=new A105843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105844
{
public static readonly long[] Value={ 0L,24L,48L,3576L,7080L,522144L,1033704L,76229520L,150913776L,11128987848L,22032377664L,1624755996360L,3216576225240L,237203246480784L,469598096507448L,34630049230198176L,68558105513862240L,5055749984362452984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105844Inst : IEnumerable<long>
{
public static readonly long[] Value=A105844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105844.Bytes);
public long this[int i]=>Value[i];

public static A105844Inst Instance=new A105844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105845
{
public static readonly BigInteger[] Value={ 1L,4511L,8609L,18486079L,35279681L,75755947231L,144576124129L,310447853266559L,592472921400961L,1272215226930411551L,2427953887325014049L,BigInteger.Parse("5213537689512973269439"),BigInteger.Parse("9949754437784986171841"),BigInteger.Parse("21365076179408937527749471"),BigInteger.Parse("40774091258088986007190369") };
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
public class A105845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105845Inst Instance=new A105845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105846
{
public static readonly BigInteger[] Value={ 0L,704L,1344L,2887040L,5509760L,11831091264L,22578997184L,48483809114880L,92528724952320L,198686637921689024L,379182692275612224L,BigInteger.Parse("814217793719272507520"),BigInteger.Parse("1553890580416733943680"),BigInteger.Parse("3336664319974940814129984"),BigInteger.Parse("6367843219365083425590464"),BigInteger.Parse("13673649569039513737032168960") };
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
public class A105846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105846Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105846.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105846.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105846Inst Instance=new A105846Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105847
{
public static readonly long[] Value={ 1L,0L,1L,1L,-1L,1L,0L,3L,-2L,1L,2L,-3L,6L,-3L,1L,0L,9L,-10L,10L,-4L,1L,5L,-9L,26L,-22L,15L,-5L,1L,0L,29L,-42L,59L,-40L,21L,-6L,1L,14L,-29L,108L,-121L,115L,-65L,28L,-7L,1L,0L,99L,-174L,308L,-276L,202L,-98L,36L,-8L,1L,42L,-99L,450L,-620L,734L,-546L,329L,-140L,45L,-9L,1L,0L,351L,-726L,1547L,-1700L,1540L,-980L,506L,-192L,55L,-10L,1L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105847Inst : IEnumerable<long>
{
public static readonly long[] Value=A105847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105847.Bytes);
public long this[int i]=>Value[i];

public static A105847Inst Instance=new A105847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105848
{
public static readonly long[] Value={ 1L,2L,1L,5L,3L,1L,14L,9L,4L,1L,42L,29L,14L,5L,1L,132L,99L,50L,20L,6L,1L,429L,351L,186L,78L,27L,7L,1L,1430L,1275L,714L,311L,114L,35L,8L,1L,4862L,4707L,2796L,1271L,483L,159L,44L,9L,1L,16796L,17577L,11082L,5282L,2082L,712L,214L,54L,10L,1L,58786L,66197L,44250L,22160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105848Inst : IEnumerable<long>
{
public static readonly long[] Value=A105848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105848.Bytes);
public long this[int i]=>Value[i];

public static A105848Inst Instance=new A105848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105849
{
public static readonly long[] Value={ 1L,3L,9L,28L,91L,308L,1079L,3888L,14332L,53810L,205075L,791250L,3084504L,12129506L,48056095L,191633546L,768535768L,3097705378L,12541851048L,50983349848L,208003171266L,851412895348L,3495527318559L,14390543072502L,59393240482618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105849Inst : IEnumerable<long>
{
public static readonly long[] Value=A105849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105849.Bytes);
public long this[int i]=>Value[i];

public static A105849Inst Instance=new A105849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105850
{
public static readonly BigInteger[] Value={ 8L,56L,3104L,9634304L,92819813433344L,BigInteger.Parse("8615517765800787268541087744"),BigInteger.Parse("74227146372828989101844394431169040459931374583287906304") };
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
public class A105850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A105850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105850Inst Instance=new A105850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105851
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,1L,8L,8L,4L,1L,16L,20L,12L,5L,1L,32L,48L,32L,16L,6L,1L,64L,112L,80L,44L,20L,7L,1L,128L,256L,192L,112L,56L,24L,8L,1L,256L,576L,448L,272L,144L,68L,28L,9L,1L,512L,1280L,1024L,640L,352L,176L,80L,32L,10L,1L,1024L,2816L,2304L,1472L,832L,432L,208L,92L,36L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105851Inst : IEnumerable<long>
{
public static readonly long[] Value=A105851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105851.Bytes);
public long this[int i]=>Value[i];

public static A105851Inst Instance=new A105851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105852
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,3L,8L,6L,4L,0L,3L,1L,5L,6L,6L,4L,0L,3L,2L,6L,5L,0L,6L,6L,4L,6L,4L,2L,3L,0L,5L,0L,3L,0L,3L,1L,2L,6L,2L,0L,6L,6L,8L,3L,6L,0L,3L,7L,3L,3L,0L,8L,0L,3L,0L,3L,8L,0L,6L,6L,8L,6L,5L,1L,3L,0L,5L,0L,6L,0L,0L,6L,2L,6L,7L,5L,6L,6L,8L,6L,4L,0L,3L,8L,0L,6L,3L,0L,0L,0L,4L,6L,2L,0L,3L,0L,8L,0L,3L,1L,3L,0L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105852Inst : IEnumerable<long>
{
public static readonly long[] Value=A105852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105852.Bytes);
public long this[int i]=>Value[i];

public static A105852Inst Instance=new A105852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105853
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,2L,8L,5L,3L,8L,2L,8L,4L,4L,4L,1L,8L,9L,0L,2L,2L,6L,4L,0L,1L,2L,0L,6L,0L,2L,2L,3L,8L,4L,8L,1L,8L,0L,6L,0L,2L,6L,4L,4L,8L,2L,8L,4L,7L,3L,2L,8L,4L,0L,2L,0L,0L,0L,0L,8L,2L,6L,4L,7L,4L,4L,8L,6L,6L,4L,2L,5L,4L,4L,4L,0L,6L,8L,0L,6L,1L,6L,4L,4L,8L,2L,0L,0L,0L,4L,2L,8L,8L,4L,0L,2L,8L,1L,6L,7L,2L,6L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105853Inst : IEnumerable<long>
{
public static readonly long[] Value=A105853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105853.Bytes);
public long this[int i]=>Value[i];

public static A105853Inst Instance=new A105853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105854
{
public static readonly long[] Value={ 3L,23L,43L,83L,103L,163L,223L,263L,283L,383L,443L,463L,503L,523L,563L,643L,683L,743L,823L,863L,883L,983L,1063L,1103L,1123L,1163L,1223L,1283L,1303L,1423L,1483L,1523L,1543L,1583L,1663L,1723L,1783L,1823L,2003L,2063L,2083L,2143L,2203L,2243L,2383L,2423L,2503L,2543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105854Inst : IEnumerable<long>
{
public static readonly long[] Value=A105854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105854.Bytes);
public long this[int i]=>Value[i];

public static A105854Inst Instance=new A105854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105855
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,3L,-2L,0L,6L,-4L,1L,8L,-4L,3L,-2L,0L,14L,-4L,-10L,4L,14L,-4L,-14L,4L,14L,-8L,5L,-4L,0L,25L,-6L,-14L,11L,-4L,-29L,1L,8L,9L,17L,-14L,2L,29L,-12L,-28L,3L,20L,23L,-5L,-32L,11L,29L,-12L,-37L,3L,20L,23L,-14L,8L,-7L,0L,53L,-9L,-20L,-31L,12L,46L,-9L,-32L,26L,-7L,-53L,10L,29L,39L,-7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105855Inst : IEnumerable<long>
{
public static readonly long[] Value=A105855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105855.Bytes);
public long this[int i]=>Value[i];

public static A105855Inst Instance=new A105855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105856
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,12L,20L,26L,32L,44L,52L,61L,78L,91L,107L,121L,135L,163L,187L,201L,219L,251L,279L,293L,311L,343L,367L,396L,421L,446L,496L,540L,570L,611L,648L,656L,665L,682L,708L,751L,780L,811L,871L,919L,939L,962L,1005L,1071L,1132L,1161L,1201L,1270L,1327L,1347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105856Inst : IEnumerable<long>
{
public static readonly long[] Value=A105856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105856.Bytes);
public long this[int i]=>Value[i];

public static A105856Inst Instance=new A105856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105857
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,9L,12L,17L,21L,30L,42L,47L,51L,61L,74L,79L,102L,124L,136L,148L,195L,206L,218L,252L,279L,300L,314L,323L,346L,416L,475L,503L,532L,574L,589L,596L,711L,731L,744L,778L,785L,818L,850L,862L,873L,929L,950L,1015L,1088L,1117L,1141L,1152L,1230L,1245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105857Inst : IEnumerable<long>
{
public static readonly long[] Value=A105857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105857.Bytes);
public long this[int i]=>Value[i];

public static A105857Inst Instance=new A105857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105858
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,8L,12L,17L,28L,32L,50L,60L,66L,69L,106L,107L,133L,200L,221L,224L,254L,363L,369L,386L,448L,484L,491L,517L,620L,680L,723L,844L,865L,900L,918L,988L,1030L,1084L,1221L,1255L,1260L,1409L,1446L,1467L,1513L,1638L,1737L,1796L,1840L,1930L,1975L,2012L,2036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105858Inst : IEnumerable<long>
{
public static readonly long[] Value=A105858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105858.Bytes);
public long this[int i]=>Value[i];

public static A105858Inst Instance=new A105858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105859
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,12L,17L,21L,25L,30L,37L,38L,39L,42L,46L,47L,51L,55L,56L,61L,66L,73L,74L,79L,86L,89L,93L,94L,102L,110L,111L,117L,118L,120L,124L,130L,136L,141L,144L,148L,154L,155L,158L,162L,170L,171L,172L,173L,177L,185L,186L,187L,188L,189L,190L,195L,201L,206L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105859Inst : IEnumerable<long>
{
public static readonly long[] Value=A105859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105859.Bytes);
public long this[int i]=>Value[i];

public static A105859Inst Instance=new A105859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105860
{
public static readonly long[] Value={ 7L,8L,10L,11L,13L,14L,15L,16L,18L,19L,20L,22L,23L,24L,26L,27L,28L,29L,31L,32L,33L,34L,35L,36L,40L,41L,43L,44L,45L,48L,49L,50L,52L,53L,54L,57L,58L,59L,60L,62L,63L,64L,65L,67L,68L,69L,70L,71L,72L,75L,76L,77L,78L,80L,81L,82L,83L,84L,85L,87L,88L,90L,91L,92L,95L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105860Inst : IEnumerable<long>
{
public static readonly long[] Value=A105860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105860.Bytes);
public long this[int i]=>Value[i];

public static A105860Inst Instance=new A105860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105861
{
public static readonly long[] Value={ 1L,3L,10L,23L,76L,102L,442L,695L,1792L,2828L,11254L,13334L,53236L,65418L,155110L,347319L,1114096L,1259328L,4980718L,6223148L,15033700L,27548678L,96468970L,108761942L,352992576L,529504212L,1381165192L,2314603370L,7784628196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105861Inst : IEnumerable<long>
{
public static readonly long[] Value=A105861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105861.Bytes);
public long this[int i]=>Value[i];

public static A105861Inst Instance=new A105861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105862
{
public static readonly long[] Value={ 1L,5L,10L,29L,26L,122L,50L,317L,334L,830L,122L,4754L,170L,7698L,11510L,34237L,290L,159530L,362L,458054L,358592L,1413890L,530L,8236946L,266276L,20806102L,14087530L,85118762L,842L,404242022L,962L,1244530621L,580671266L,4667223134L,35896250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105862Inst : IEnumerable<long>
{
public static readonly long[] Value=A105862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105862.Bytes);
public long this[int i]=>Value[i];

public static A105862Inst Instance=new A105862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105863
{
public static readonly long[] Value={ 1L,6L,12L,44L,30L,252L,56L,856L,846L,3080L,132L,20616L,182L,49532L,52110L,237232L,306L,1227096L,380L,4106320L,2470272L,15525092L,552L,86092176L,1328900L,270424752L,126624006L,1157002616L,870L,5577100260L,992L,19572325728L,6386892930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105863Inst : IEnumerable<long>
{
public static readonly long[] Value=A105863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105863.Bytes);
public long this[int i]=>Value[i];

public static A105863Inst Instance=new A105863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105864
{
public static readonly long[] Value={ 1L,1L,3L,7L,21L,65L,215L,735L,2585L,9281L,33883L,125383L,469229L,1772801L,6752623L,25902975L,99978865L,388001025L,1513077235L,5926139207L,23301146501L,91942524481L,363957103303L,1444966207967L,5752187960841L,22955311342145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105864Inst : IEnumerable<long>
{
public static readonly long[] Value=A105864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105864.Bytes);
public long this[int i]=>Value[i];

public static A105864Inst Instance=new A105864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105865
{
public static readonly long[] Value={ 1L,1L,4L,9L,30L,94L,328L,1165L,4294L,16134L,61752L,239610L,940716L,3729324L,14908176L,60026109L,243211206L,990897478L,4057013080L,16683617326L,68879236036L,285388549188L,1186296731376L,4945790840338L,20675513743900L,86648395759516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105865Inst : IEnumerable<long>
{
public static readonly long[] Value=A105865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105865.Bytes);
public long this[int i]=>Value[i];

public static A105865Inst Instance=new A105865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105866
{
public static readonly long[] Value={ 0L,1L,1L,6L,9L,33L,62L,185L,393L,1062L,2409L,6193L,14542L,36441L,87129L,215478L,520073L,1277441L,3098334L,7583481L,18439977L,45050950L,109690537L,267731409L,652322286L,1591394457L,3878780921L,9460182998L,23062009545L,56239784865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105866Inst : IEnumerable<long>
{
public static readonly long[] Value=A105866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105866.Bytes);
public long this[int i]=>Value[i];

public static A105866Inst Instance=new A105866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105867
{
public static readonly long[] Value={ 0L,1L,1L,7L,11L,47L,95L,327L,759L,2343L,5863L,17095L,44551L,126023L,335687L,934343L,2518215L,6948807L,18846663L,51765703L,140875207L,385980871L,1052314055L,2879386055L,7857807815L,21485572551L,58664391111L,160344666567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105867Inst : IEnumerable<long>
{
public static readonly long[] Value=A105867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105867.Bytes);
public long this[int i]=>Value[i];

public static A105867Inst Instance=new A105867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105868
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,0L,6L,1L,0L,0L,6L,12L,1L,0L,0L,0L,30L,20L,1L,0L,0L,0L,20L,90L,30L,1L,0L,0L,0L,0L,140L,210L,42L,1L,0L,0L,0L,0L,70L,560L,420L,56L,1L,0L,0L,0L,0L,0L,630L,1680L,756L,72L,1L,0L,0L,0L,0L,0L,252L,3150L,4200L,1260L,90L,1L,0L,0L,0L,0L,0L,0L,2772L,11550L,9240L,1980L,110L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105868Inst : IEnumerable<long>
{
public static readonly long[] Value=A105868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105868.Bytes);
public long this[int i]=>Value[i];

public static A105868Inst Instance=new A105868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105869
{
public static readonly long[] Value={ 1L,14L,40L,1696L,518656L,34358296576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105869Inst : IEnumerable<long>
{
public static readonly long[] Value=A105869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105869.Bytes);
public long this[int i]=>Value[i];

public static A105869Inst Instance=new A105869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105870
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,1L,6L,0L,6L,6L,5L,4L,2L,6L,1L,0L,1L,1L,2L,3L,5L,1L,6L,0L,6L,6L,5L,4L,2L,6L,1L,0L,1L,1L,2L,3L,5L,1L,6L,0L,6L,6L,5L,4L,2L,6L,1L,0L,1L,1L,2L,3L,5L,1L,6L,0L,6L,6L,5L,4L,2L,6L,1L,0L,1L,1L,2L,3L,5L,1L,6L,0L,6L,6L,5L,4L,2L,6L,1L,0L,1L,1L,2L,3L,5L,1L,6L,0L,6L,6L,5L,4L,2L,6L,1L,0L,1L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105870Inst : IEnumerable<long>
{
public static readonly long[] Value=A105870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105870.Bytes);
public long this[int i]=>Value[i];

public static A105870Inst Instance=new A105870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105871
{
public static readonly long[] Value={ 1L,2L,6L,22L,85L,336L,1350L,5492L,22554L,93300L,388201L,1622868L,6811056L,28680356L,121111440L,512684484L,2174928031L,9243973062L,39354962345L,167799259130L,716414975613L,3062437147352L,13105366936465L,56139506687280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105871Inst : IEnumerable<long>
{
public static readonly long[] Value=A105871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105871.Bytes);
public long this[int i]=>Value[i];

public static A105871Inst Instance=new A105871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105872
{
public static readonly long[] Value={ 1L,2L,6L,21L,75L,273L,1009L,3770L,14202L,53846L,205216L,785460L,3017106L,11624580L,44905518L,173863965L,674506059L,2621371005L,10203609597L,39773263035L,155231706951L,606554343495L,2372544034143L,9289131196485L,36401388236461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105872Inst : IEnumerable<long>
{
public static readonly long[] Value=A105872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105872.Bytes);
public long this[int i]=>Value[i];

public static A105872Inst Instance=new A105872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105873
{
public static readonly long[] Value={ 1L,6L,0L,3L,4L,17L,14L,23L,24L,33L,34L,43L,44L,54L,74L,94L,144L,154L,174L,194L,244L,254L,274L,294L,394L,494L,1254L,1274L,1294L,1394L,1494L,2274L,2294L,2394L,2494L,3494L,4494L,14394L,14494L,23494L,24494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105873Inst : IEnumerable<long>
{
public static readonly long[] Value=A105873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105873.Bytes);
public long this[int i]=>Value[i];

public static A105873Inst Instance=new A105873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105874
{
public static readonly long[] Value={ 5L,7L,13L,23L,29L,37L,47L,53L,61L,71L,79L,101L,103L,149L,167L,173L,181L,191L,197L,199L,239L,263L,269L,271L,293L,311L,317L,349L,359L,367L,373L,383L,389L,421L,461L,463L,479L,487L,503L,509L,541L,557L,599L,607L,613L,647L,653L,661L,677L,701L,709L,719L,743L,751L,757L,773L,797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105874Inst : IEnumerable<long>
{
public static readonly long[] Value=A105874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105874.Bytes);
public long this[int i]=>Value[i];

public static A105874Inst Instance=new A105874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105875
{
public static readonly long[] Value={ 2L,5L,11L,17L,23L,29L,47L,53L,59L,71L,83L,89L,101L,107L,113L,131L,137L,149L,167L,173L,179L,191L,197L,227L,233L,239L,251L,257L,263L,269L,281L,293L,311L,317L,347L,353L,359L,383L,389L,401L,419L,443L,449L,461L,467L,479L,503L,509L,521L,557L,563L,569L,587L,593L,599L,617L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105875Inst : IEnumerable<long>
{
public static readonly long[] Value=A105875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105875.Bytes);
public long this[int i]=>Value[i];

public static A105875Inst Instance=new A105875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105876
{
public static readonly long[] Value={ 3L,7L,11L,19L,23L,47L,59L,67L,71L,79L,83L,103L,107L,131L,139L,163L,167L,179L,191L,199L,211L,227L,239L,263L,271L,311L,347L,359L,367L,379L,383L,419L,443L,463L,467L,479L,487L,491L,503L,523L,547L,563L,587L,599L,607L,619L,647L,659L,719L,743L,751L,787L,823L,827L,839L,859L,863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105876Inst : IEnumerable<long>
{
public static readonly long[] Value=A105876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105876.Bytes);
public long this[int i]=>Value[i];

public static A105876Inst Instance=new A105876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105877
{
public static readonly long[] Value={ 2L,11L,17L,19L,37L,53L,59L,73L,79L,97L,113L,131L,137L,139L,151L,157L,173L,179L,193L,197L,233L,239L,257L,277L,293L,311L,317L,331L,353L,359L,373L,397L,419L,431L,433L,439L,479L,491L,499L,557L,571L,577L,593L,599L,613L,617L,619L,653L,659L,673L,677L,719L,751L,757L,773L,797L,811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105877Inst : IEnumerable<long>
{
public static readonly long[] Value=A105877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105877.Bytes);
public long this[int i]=>Value[i];

public static A105877Inst Instance=new A105877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105878
{
public static readonly long[] Value={ 13L,17L,19L,23L,41L,47L,61L,67L,71L,89L,109L,113L,137L,157L,167L,211L,229L,233L,257L,263L,277L,283L,331L,359L,373L,383L,397L,401L,449L,479L,503L,521L,523L,547L,569L,593L,599L,613L,619L,641L,647L,661L,691L,709L,719L,733L,739L,743L,757L,761L,787L,809L,811L,829L,839L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105878Inst : IEnumerable<long>
{
public static readonly long[] Value=A105878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105878.Bytes);
public long this[int i]=>Value[i];

public static A105878Inst Instance=new A105878Inst();

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